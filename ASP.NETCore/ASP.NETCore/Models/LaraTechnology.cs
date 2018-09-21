using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETCore.Models
{
    public class LaraTechnology
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Joining_Date { get; set; }
        public string Course_Taken { get; set; }
        public decimal Amount_Paid { get; set; }
    }
}
