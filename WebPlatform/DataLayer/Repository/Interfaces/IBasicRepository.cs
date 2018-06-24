using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPlatform.DataLayer.Repository.Interfaces
{
    public interface IBasicRepository<T>
    {
        T Create(T obj);

        T Update(T obj);

        bool Delete(T obj);

        T GetById(int id);

        ICollection<T> GetAll();
    }
}