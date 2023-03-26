using DAO.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Service
{
    public interface BaseService<T>
    {

        List<T> getAll();

         T get(int id);

        void save(T model);

        void update(T model);

        void delete(T model);
  
    }
}
