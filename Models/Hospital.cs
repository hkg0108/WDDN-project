using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proj.Models
{
    public class Hospital
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ContactNo { get; set; }
        public string contactPerson { get; set; }
        public string Email { get; set; }
        public string address { get; set; }

        public int area { get; set; }
        public Area Area { get; set; }

    }
}
