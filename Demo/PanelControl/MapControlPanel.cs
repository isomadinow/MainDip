using GMap.NET.WindowsForms;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using System.Data.Entity;
using Demo.bd;
using System.Drawing.Imaging;

namespace Demo.PanelControl
{
    public partial class MapControlPanel : UserControl
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        private GMapOverlay PolygonOverlay;
        //Ruta automatizada(dirección)
        bool drawRoute = false;
        int RouteIndecatorCounter = 0;
        PointLatLng start;
        PointLatLng end;

        int selectedRow = 0;
        double InitialLat = 55.3484258884202;
        double InitialLng = 86.0793399810791;


        private MyDbContext dbContext;
        public MapControlPanel()
        {
            InitializeComponent();
            dbContext = new MyDbContext(DemoForm.connectionString);
            PolygonOverlay = new GMapOverlay("PolygonOverlay");
        gMapControl1.Overlays.Add(PolygonOverlay);
            Directory.CreateDirectory("photoPolygon");
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            GMapOverlay RouteOverlay = new GMapOverlay("RouteOverlay");

            List<PointLatLng> points = new List<PointLatLng>();
            // variables to store data
            double lng, lat;
            // add data from the grid
            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                lat = Convert.ToDouble(dataGridView1.Rows[rows].Cells[1].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[rows].Cells[2].Value);
                points.Add(new PointLatLng(lat, lng));
            }

            GMapRoute routePoints = new GMapRoute(points, "Route");
            RouteOverlay.Routes.Add(routePoints);
            gMapControl1.Overlays.Add(RouteOverlay);
            
            // Update the map
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;
        }




        private void btnPolygon_Click(object sender, EventArgs e)
        {
           
            List<PointLatLng> points = new List<PointLatLng>();

            double lng, lat;

            for (int rows = 0; rows < dataGridView1.Rows.Count; rows++)
            {
                lat = Convert.ToDouble(dataGridView1.Rows[rows].Cells[1].Value);
                lng = Convert.ToDouble(dataGridView1.Rows[rows].Cells[2].Value);
                points.Add(new PointLatLng(lat, lng));
            }

            GMapPolygon polygonPoints = new GMapPolygon(points, "Polygon");
            PolygonOverlay.Polygons.Add(polygonPoints);
            gMapControl1.Overlays.Add(PolygonOverlay);

            PolygonOverlay.Polygons.Add(polygonPoints);
            dataGridViewPolygons.Rows.Add(polygonPoints.Name);
            gMapControl1.Zoom = gMapControl1.Zoom + 1;
            gMapControl1.Zoom = gMapControl1.Zoom - 1;


        }
        private string GetUniqueFileName(string baseFilename)
        {
            string directory = "photoPolygon";
            string filename = Path.Combine(directory, baseFilename + ".png");
            int count = 1;

            while (File.Exists(filename))
            {
                filename = Path.Combine(directory, baseFilename + "_" + count + ".png");
                count++;
            }

            return filename;
        }
        private void TakePolygonScreenshot(GMapPolygon polygon, string filename)
        {         // Получение границ многоугольника
            double minLat = polygon.Points.Min(p => p.Lat);
            double maxLat = polygon.Points.Max(p => p.Lat);
            double minLng = polygon.Points.Min(p => p.Lng);
            double maxLng = polygon.Points.Max(p => p.Lng);

            // Вычисление размерности скриншота
            RectLatLng area = new RectLatLng(maxLat, minLng, maxLng - minLng, maxLat - minLat);

            // Настройка размеров скриншота
            int width = gMapControl1.Size.Width;
            int height = gMapControl1.Size.Height;

            using (Bitmap bitmap = new Bitmap(width, height))
            {
                gMapControl1.DrawToBitmap(bitmap, new Rectangle(0, 0, width, height));
                bitmap.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtDescripcion.Text, txtlatitud.Text, txtlongitud.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(selectedRow);
        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleSatelliteMap;
        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
        }

        private void btnRelieve_Click(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleTerrainMap;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trackZoom.Value = Convert.ToInt32(gMapControl1.Zoom);
        }

        private void trackZoom_ValueChanged(object sender, EventArgs e)
        {
            gMapControl1.Zoom = trackZoom.Value;
        }

        private void MapControlPanel_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Descripción", typeof(string)));
            dt.Columns.Add(new DataColumn("Lat", typeof(double)));
            dt.Columns.Add(new DataColumn("Long", typeof(double)));

            //insertando datos al dt para mostrar en la lista
            dt.Rows.Add("Расположение", InitialLat, InitialLng);
            dataGridView1.DataSource = dt;
            dataGridViewPolygons.Columns.Add("PolygonName", "Polygon Name");
            //desactivar las columnas de lat y long
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            //Creando las dimensiones del GMAPCONTROL(herramienta)
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(InitialLat, InitialLng);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            //Marcador
            markerOverlay = new GMapOverlay("Табло");
            marker = new GMarkerGoogle(new PointLatLng(InitialLat, InitialLng), GMarkerGoogleType.blue);
            markerOverlay.Markers.Add(marker);//Agregamos al mapa

            //agregamos un tooltip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Местоположение:\n широта:{0}\n долгота :{1}", InitialLat, InitialLng);

            //ahora agregamos el mapa y el marcador al control map

            gMapControl1.Overlays.Add(markerOverlay);
        }

        private void SelecionarRegistro(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRow = e.RowIndex;
            txtDescripcion.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
            txtlatitud.Text = dataGridView1.Rows[selectedRow].Cells[1].Value.ToString();
            txtlongitud.Text = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
         
            marker.Position = new PointLatLng(Convert.ToDouble(txtlatitud.Text), Convert.ToDouble(txtlongitud.Text));
         
            gMapControl1.Position = marker.Position;
        }

       

        private void gMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //se obtiene los datos de lat y lng del mapa donde usuario presiono
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            //se posicionan en el txt de la latitud y longitud
            txtlatitud.Text = lat.ToString();
            txtlongitud.Text = lng.ToString();

            //crearemos el marcador para moverlo al lugar indicado por el usuario
            marker.Position = new PointLatLng(lat, lng);
            //tambien se agregara el mensaje al marcador es decir el ToolTip
            marker.ToolTipText = string.Format("Местоположение:\n широта:{0}\n долгота :{1}", lat, lng);

            CrearDireccionTrazarRuta(lat, lng);
        }
        public void CrearDireccionTrazarRuta(double lat, double lng)
        {
            if (drawRoute)
            {
                switch (RouteIndecatorCounter)
                {
                    case 0://primer marcador de inico
                        RouteIndecatorCounter++;
                        start = new PointLatLng(lat, lng);
                        break;
                    case 1://Segundo marcador o final
                        RouteIndecatorCounter++;
                        end = new PointLatLng(lat, lng);
                        GDirections direccion;
                        var RutasDireccion = GMapProviders.GoogleMap.GetDirections(out direccion, start, end, false, false, false, false, false);
                        GMapRoute RutaObtenida = new GMapRoute(direccion.Route, "Расположение маршрута");
                        GMapOverlay CapaRutas = new GMapOverlay("Уровень маршрутизации");
                        CapaRutas.Routes.Add(RutaObtenida);
                        gMapControl1.Overlays.Add(CapaRutas);
                        gMapControl1.Zoom = gMapControl1.Zoom + 1;
                        gMapControl1.Zoom = gMapControl1.Zoom - 1;
                        RouteIndecatorCounter = 0;
                        drawRoute = false;
                        break;
                }
            }
        }
        // Метод для преобразования изображения в массив байтов
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Bmp);
                return ms.ToArray();
            }
        }
        private void buttonImagePolygon_Click(object sender, EventArgs e)
        {
            if (dataGridViewPolygons.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewPolygons.SelectedRows[0].Index;
                GMapPolygon selectedPolygon = PolygonOverlay.Polygons[selectedIndex];
                string filename = GetUniqueFileName("screenshot");
                TakePolygonScreenshot(selectedPolygon, filename);

                try
                {
                    // Создаем экземпляр класса Polygon и заполняем его свойства
                    Polygon polygon = new Polygon
                    {
                        PolygonDate = DateTime.Now,
                        PolygonName = "Polygon_" + selectedIndex, // Пример для названия полигона
                        PolygonPhoto = ImageToByteArray(new Bitmap(filename))
                    };

                    // Добавляем объект polygon в контекст базы данных
                    dbContext.Polygons.Add(polygon);

                    // Сохраняем изменения в базе данных
                    dbContext.SaveChanges();

                    MessageBox.Show("Данные о полигоне успешно сохранены в базе данных.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при сохранении данных о полигоне: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                MessageBox.Show("Скриншот сохранен как " + filename, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите полигон из списка.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

        }
    }
}
