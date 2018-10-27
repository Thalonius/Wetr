using DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dao
{
    public interface ICommunityDao
    {
        IEnumerable<Community> FindAll();
        IEnumerable<Community> FindByPostCode(string postCode);
        IEnumerable<Community> FindByDistrictCode(string districtCode);

        Community FindByName(string name);
        Community FindById(int id);

        bool Update(Community community);
    }
}
