using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Basler.Pylon;
using System.Drawing.Imaging;
using Demo.bd;
using System.IO;
namespace Demo.PanelControl
{
    public partial class CameraControlPanel : UserControl
    {
        private MyDbContext dbContext;
        private Basler.Pylon.Camera camera;
        private Bitmap grabbedImage;
        private string strVendor, strModel, strFirmware;
        private long intAOIWidth, intAOIHeight, intAOIOffsetX, intAOIOffsetY;
        private int intSuccessfulGrabs, intFailedGrabs;

        private void btnStopGrabbing_Click(object sender, EventArgs e)
        {
            camera.StreamGrabber.Stop();
            btnStartGrabbing.Enabled = true;
            btnStopGrabbing.Enabled = false;
            btnSnapShot.Enabled = false;
        }

        private void btnReleaseCamera_Click(object sender, EventArgs e)
        {
            if (camera.IsConnected)
            {
                if (camera.StreamGrabber.IsGrabbing)
                    camera.StreamGrabber.Stop();
                if (camera.IsOpen)
                    camera.Close();
                camera.Dispose();
            }
            tbMessages.AppendText("\r\nCamera Released.");

            btnOpenCamera.Enabled = true;
            btnStartGrabbing.Enabled = false;
            btnStopGrabbing.Enabled = false;
            btnSnapShot.Enabled = false;
            btnReleaseCamera.Enabled = false;
            tbSerialNumber.Focus();
        }

        private void btnStartGrabbing_Click(object sender, EventArgs e)
        {
            camera.StreamGrabber.Start(GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
            btnStartGrabbing.Enabled = false;
            btnStopGrabbing.Enabled = true;
            btnSnapShot.Enabled = true;
        }

        private double dblExposureTime = 0;
        private bool takeSnapshot = false;
        public CameraControlPanel()
        {
            InitializeComponent();
            dbContext = new MyDbContext(DemoForm.connectionString);
        }

        private void btnOpenCamera_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbSerialNumber.Text == "")
                {
                    tbMessages.AppendText("\r\nОткрытие первой найденной камеры...");
                    camera = new Camera();
                }
                else
                {
                    tbMessages.AppendText("\r\nКамера открытия: " + tbSerialNumber.Text + "...");
                    camera = new Camera(tbSerialNumber.Text);
                }

                // First add event handlers for various events
                camera.CameraOpened += OnCameraOpened;
                camera.ConnectionLost += OnConnectionLost;
                camera.StreamGrabber.GrabStarting += OnGrabStarting;
                camera.StreamGrabber.GrabStarted += OnGrabStarted;
                camera.StreamGrabber.ImageGrabbed += OnImageGrabbed;
                camera.StreamGrabber.GrabStopped += OnGrabStopped;

                camera.Open();

                // The OnCameraOpened event will now configure/initialize the camera.
            }
            catch (Exception ex)
            {
                tbMessages.AppendText("\r\n");
                tbMessages.AppendText(ex.Message.ToString());
                if (camera != null)
                {
                    if (camera.IsOpen)
                        camera.Close();
                    camera.Dispose();
                }

                btnOpenCamera.Enabled = true;
                btnStartGrabbing.Enabled = false;
                btnStopGrabbing.Enabled = false;
                btnReleaseCamera.Enabled = false;
            }
        }

        private void CameraControlPanel_Load(object sender, EventArgs e)
        {
            intSuccessfulGrabs = 0;
            intFailedGrabs = 0;
        }
        private void BtnReleaseCamera_Click(object sender, EventArgs e)
        {
            if (camera.IsConnected)
            {
                if (camera.StreamGrabber.IsGrabbing)
                    camera.StreamGrabber.Stop();
                if (camera.IsOpen)
                    camera.Close();
                camera.Dispose();
            }
            tbMessages.AppendText("\r\nКамера выпущена.");

            btnOpenCamera.Enabled = true;
            btnStartGrabbing.Enabled = false;
            btnStopGrabbing.Enabled = false;
            btnSnapShot.Enabled = false;
            btnReleaseCamera.Enabled = false;
            tbSerialNumber.Focus();
        }

        private void CbUseTestImage_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbUseTestImage.Checked == true)
                    camera.Parameters[PLCamera.TestImageSelector].SetValue(PLCamera.TestImageSelector.Testimage2);
                else
                    camera.Parameters[PLCamera.TestImageSelector].SetValue(PLCamera.TestImageSelector.Off);
            }
            catch (Exception ex)
            {
                tbMessages.AppendText("\r\n");
                tbMessages.AppendText(ex.Message.ToString());
            }
        }

     
    

        private void CameraBack_Click(object sender, EventArgs e)
        {
            new DemoForm().Show();
            this.Hide();
            
        }

        private void btnSnapShot_Click_1(object sender, EventArgs e)
        {
            try
            {
                btnSnapShot.Enabled = false;
                takeSnapshot = true;
            }
            catch (Exception ex)
            {
                tbMessages.AppendText("\r\n");
                tbMessages.AppendText(ex.Message.ToString());
            }

        }

        private void btnSaveSnapshot_Click_1(object sender, EventArgs e)
        {
            if (pbSnapShot.Image != null)
            {
                string fileName = Application.StartupPath.ToString() + "\\Snapshot_" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".bmp";

                // Сохраняем фото на диск
                pbSnapShot.Image.Save(fileName, ImageFormat.Bmp);
                tbMessages.AppendText("\r\nСнимок сохранен как: " + fileName);

                // Читаем сохраненное фото обратно в массив байтов
                byte[] photoBytes;
                using (var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = new BinaryReader(stream))
                    {
                        photoBytes = reader.ReadBytes((int)stream.Length);
                    }
                }

                // Создаем новый объект Camera и заполняем его данными
                var camera = new TCamera
                {
                    PhotoDate = DateTime.Now,
                    Photo = photoBytes
                };

                // Добавляем объект Camera в контекст базы данных и сохраняем изменения
                dbContext.Cameras.Add(camera);
                dbContext.SaveChanges();

                btnSaveSnapshot.Enabled = false;
            }
        }

        private void OnCameraOpened(Object sender, EventArgs e)
        {
            try
            {
                tbMessages.AppendText("\r\nКамера открыта.");

                // Configure the camera
                camera.Parameters[PLCamera.UserSetSelector].SetValue(PLCamera.UserSetSelector.Default);
                camera.Parameters[PLCamera.UserSetLoad].Execute();

                camera.Parameters[PLCamera.PixelFormat].SetValue(PLCamera.PixelFormat.Mono8);
                camera.Parameters[PLCamera.GainAuto].TrySetValue(PLCamera.GainAuto.Off);

                if (cbUseTestImage.Checked == true)
                    camera.Parameters[PLCamera.TestImageSelector].SetValue(PLCamera.TestImageSelector.Testimage2);
                else
                    camera.Parameters[PLCamera.TestImageSelector].SetValue(PLCamera.TestImageSelector.Off);

                camera.Parameters[PLCamera.ExposureMode].SetValue(PLCamera.ExposureMode.Timed);
                camera.Parameters[PLCamera.ExposureTime].SetValue(10000.0);

                // Display camera information
                strVendor = camera.Parameters[PLCamera.DeviceVendorName].GetValue();
                strModel = camera.Parameters[PLCamera.DeviceModelName].GetValue();
                strFirmware = camera.Parameters[PLCamera.DeviceFirmwareVersion].GetValue();
                intAOIOffsetX = camera.Parameters[PLCamera.OffsetX].GetValue();
                intAOIOffsetY = camera.Parameters[PLCamera.OffsetY].GetValue();
                intAOIWidth = camera.Parameters[PLCamera.Width].GetValue();
                intAOIHeight = camera.Parameters[PLCamera.Height].GetValue();
                dblExposureTime = camera.Parameters[PLCamera.ExposureTime].GetValue();

                tbSerialNumber.Text = camera.Parameters[PLCamera.DeviceSerialNumber].GetValue().ToString();
                tbCameraInfo.Text = strVendor + " " + strModel
                    + "\r\n"
                    + "Serial Number: " + tbSerialNumber.Text
                    + "\r\n"
                    + strFirmware
                    + "\r\n"
                    + "Width: " + intAOIWidth.ToString()
                    + "\r\n"
                    + "Height: " + intAOIHeight.ToString()
                    + "\r\n"
                    + "OffsetX: " + intAOIOffsetX.ToString()
                    + "\r\n"
                    + "OffsetY: " + intAOIOffsetY.ToString()
                    + "\r\n"
                    + "Exposure Time (us): " + dblExposureTime.ToString();

                btnOpenCamera.Enabled = false;
                btnStartGrabbing.Enabled = true;
                btnReleaseCamera.Enabled = true;

                tbMessages.AppendText("\r\nКамера инициализирована.");
            }
            catch (Exception ex)
            {
                tbMessages.AppendText("\r\n");
                tbMessages.AppendText(ex.Message.ToString());
                if (camera != null)
                {
                    if (camera.IsOpen)
                        camera.Close();
                    camera.Dispose();
                }

                btnOpenCamera.Enabled = true;
                btnStartGrabbing.Enabled = false;
                btnStopGrabbing.Enabled = false;
                btnReleaseCamera.Enabled = false;
            }
        }

        private void OnConnectionLost(Object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                // If called from a different thread, we must use the Invoke method to marshal the call to the proper thread.
                BeginInvoke(new EventHandler<EventArgs>(OnConnectionLost), sender, e);
            }

            tbMessages.AppendText("\r\nКамера была отключена. Подключитесь снова и нажмите Открыть камеру.");
            btnOpenCamera.Enabled = true;
            btnStartGrabbing.Enabled = false;
            btnStopGrabbing.Enabled = false;
            btnReleaseCamera.Enabled = false;
        }

        private void OnGrabStarting(Object sender, EventArgs e)
        {
            intSuccessfulGrabs = 0;
            intFailedGrabs = 0;
            tbSuccessfulGrabs.Text = intSuccessfulGrabs.ToString();
            tbFailedGrabs.Text = intFailedGrabs.ToString();
        }

        private void OnGrabStarted(Object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                // If called from a different thread, we must use the Invoke method to marshal the call to the proper thread.
                BeginInvoke(new EventHandler<EventArgs>(OnGrabStarted), sender, e);
                return;
            }

            tbMessages.AppendText("\r\nGrabbing Started.");
        }

        private void OnGrabStopped(Object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                // If called from a different thread, we must use the Invoke method to marshal the call to the proper thread.
                BeginInvoke(new EventHandler<EventArgs>(OnGrabStopped), sender, e);
                return;
            }

            tbMessages.AppendText("\r\nGrabbing Stopped");
            GC.Collect();
        }

        private void OnImageGrabbed(Object sender, ImageGrabbedEventArgs e)
        {
            if (InvokeRequired)
            {
                // If called from a different thread, we must use the Invoke method to marshal the call to the proper GUI thread.
                // The grab result will be disposed after the event call. Clone the event arguments for marshaling to the GUI thread.
                BeginInvoke(new EventHandler<ImageGrabbedEventArgs>(OnImageGrabbed), sender, e.Clone());
                return;
            }

            try
            {
                // Get the grab result.
                IGrabResult grabResult = e.GrabResult;

                // Process the result
                if (grabResult.GrabSucceeded)
                {
                    Basler.Pylon.PixelDataConverter converter = new PixelDataConverter();
                    grabbedImage = new Bitmap(grabResult.Width, grabResult.Height, PixelFormat.Format32bppRgb);
                    // Lock the bits of the bitmap.
                    BitmapData bmpData = grabbedImage.LockBits(new Rectangle(0, 0, grabbedImage.Width, grabbedImage.Height), ImageLockMode.ReadWrite, grabbedImage.PixelFormat);
                    // Place the pointer to the buffer of the bitmap.
                    converter.OutputPixelFormat = PixelType.BGRA8packed;
                    IntPtr ptrBmp = bmpData.Scan0;
                    converter.Convert(ptrBmp, bmpData.Stride * grabbedImage.Height, grabResult);
                    grabbedImage.UnlockBits(bmpData);

                    // Assign a temporary variable to dispose the bitmap after assigning the new bitmap to the display control.
                    Bitmap bitmapOld = pbImage.Image as Bitmap;
                    // Provide the display control with the new bitmap. This action automatically updates the display.
                    pbImage.Image = grabbedImage;

                    if (takeSnapshot == true)
                    {
                        Bitmap snapshot = (Bitmap)grabbedImage.Clone();
                        if (pbSnapShot.Image != null)
                            pbSnapShot.Image.Dispose();
                        // Provide the display control with the new bitmap. This action automatically updates the display.
                        pbSnapShot.Image = snapshot;
                        takeSnapshot = false;
                        btnSnapShot.Enabled = true;
                        btnSaveSnapshot.Enabled = true;
                    }

                    if (bitmapOld != null)
                    {
                        // Dispose the bitmap.
                        bitmapOld.Dispose();
                    }

                    grabResult.Dispose();

                    intSuccessfulGrabs += 1;
                    tbSuccessfulGrabs.Text = intSuccessfulGrabs.ToString();
                    tbSuccessfulGrabs.Refresh();
                }
                else
                {
                    intFailedGrabs += 1;
                    tbFailedGrabs.Text = intFailedGrabs.ToString();
                    tbFailedGrabs.Refresh();
                    tbMessages.AppendText("\r\n" + "Error: " + grabResult.ErrorCode.ToString() + "   " + grabResult.ErrorDescription.ToString());
                }
            }
            catch (Exception ex)
            {
                tbMessages.AppendText("\r\n");
                tbMessages.AppendText(ex.Message.ToString());
            }
            finally
            {
                // Dispose the grab result if needed for returning it to the grab loop.
                e.DisposeGrabResultIfClone();
            }
        }
    }
}
