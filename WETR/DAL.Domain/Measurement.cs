using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public class Measurement
    {
        public int StationId { get; set; }

        public string Type { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public decimal Value { get; set; }

        public string Unit { get; set; }

        public decimal AvgValuePerHour { get; set; }
    }
}
