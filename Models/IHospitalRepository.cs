using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proj.Models
{
    public interface IHospitalRepository
    {
        Hospital GetHospital(int id);
    }
}
