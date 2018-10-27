using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Domain
{
    public class User
    {
        public int EMail { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{this.Firstname} {this.Surname} ({this.EMail})"; ; ToString();
        }
    }
}
