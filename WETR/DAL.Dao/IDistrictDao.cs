using DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dao
{
    public interface IDistrictDao
    {
        IEnumerable<District> FindAll();
        IEnumerable<District> FindByProvinceCode(string provinceCode);

        District FindByName(string name);
        District FindById(int id);

        bool Update(District district);
    }
}
