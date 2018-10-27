using DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dao
{
    public interface IMeasurementDao
    {
        IEnumerable<Measurement> FindAll();
        IEnumerable<Measurement> FindByTime(DateTime StartTime, DateTime EndTime);
        IEnumerable<Measurement> FindByValue(decimal value);
        IEnumerable<Measurement> FindByType(string type);
        IEnumerable<Measurement> FindByStation(int station);

        Measurement FindById(int id);
       
        bool Update(Measurement measurement);
    }
}
