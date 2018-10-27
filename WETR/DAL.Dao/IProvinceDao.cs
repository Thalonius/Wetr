using DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dao
{
    public interface IProvinceDao
    {
        IEnumerable<Province> FindAll();

        Province FindByName(string name);
        Province FindById(int id);

        bool Update(Province province);
    }
}
