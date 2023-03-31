using DAO;
using DAO.Entity;
using DAO.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Service
{
    public class UserService : BaseService<User>
    {
        TienThachContext db ;

        public UserService()
        {
            db = new TienThachContext();
        }

        public void delete(User model)
        {
            throw new NotImplementedException();
        }

        public User get(int id)
        {

            return null;
        }


        public User getByUserName(string userName)
        {
           User user = db.Users.FirstOrDefault(p => p.UserName!.Equals(userName))!;
           return user;
        }

        public List<User> getAll()
        {
            throw new NotImplementedException();
        }

        public void save(User model)
        {
         db.Users.Add(model);
         db.SaveChanges();

        }

        public void update(User model)
        {
            throw new NotImplementedException();
        }
    }
}
