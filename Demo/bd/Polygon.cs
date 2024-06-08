using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.bd
{
    // Модель для таблицы полигон
    public class Polygon
    {
        [Key]
 
        public DateTime PolygonDate { get; set; }
        public string PolygonName { get; set; }
        public byte[] PolygonPhoto { get; set; }
    }
}
