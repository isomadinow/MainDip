using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.bd
{
    // Модель для таблицы отчёт
    public class Report
    {
        [Key]
        public DateTime ReportDate { get; set; }
        public string FileName { get; set; }
        public string ReportResult { get; set; }
    }
}
