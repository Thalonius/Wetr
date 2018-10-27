using DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dao
{
    public interface IStationDao
    {
        IEnumerable<Station> FindAll();
        IEnumerable<Station> FindByPostCode(string postCode);
        IEnumerable<Station> FindByCity(string city);
        IEnumerable<Station> FindByHeight(int height);

        Station FindById(int id);
        Station FindByName(string name);
        Station FindByCoordinate(float longitude, float latitude);

        bool Update(Station station);
    }
}
