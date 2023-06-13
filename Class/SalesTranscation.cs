using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleReportSystem.Class
{
    public class SalesTranscation
    {
        public string SaleId { get; set; }
        public string SalesItem { get; set; }
        public DateTime SalesDate { get; set; }
        public string UserId { get; set; }
        public double Amount { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int Status { get; set; }
    }
}
