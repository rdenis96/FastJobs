using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPlatform.Models;

namespace WebPlatform.DataLayer.Repository.Interfaces
{
    public interface IUserRepository : IBasicRepository<User>
    {
        User GetByEmail(string email);

        User GetByPhone(string phone);

        ICollection<User> GetByFirstname(string firstname);

        ICollection<User> GetByLastname(string lastname);

        ICollection<User> GetByIp(string ip);

        ICollection<User> GetAllOnlineBetweenDates(DateTime startDate, DateTime endDate);

        ICollection<User> GetAllRegisteredBetweenDates(DateTime startDate, DateTime endDate);
    }
}