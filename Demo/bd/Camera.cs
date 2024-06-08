using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.bd
{
    // Модель для таблицы камера
    public class TCamera
    {
        [Key]
        public int id { get; set; }
        public DateTime PhotoDate { get; set; }
        public byte[] Photo { get; set; }
    }
}
