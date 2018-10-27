using DAL.Domain;
using System.Collections.Generic;

namespace DAL.Dao
{
    public interface IUserDao
    {
        IEnumerable<User> FindAll();

        User FindById(int id);

        bool Update(User user);
    }
}
