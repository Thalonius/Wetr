using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public class Station
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Address { get; set; }

        public string PostCode { get; set; }

        public string City { get; set; }

        public float Longitude { get; set; }

        public float Latitude { get; set; }

        public int Height { get; set; }
    }
}
