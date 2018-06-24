using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebPlatform.DataLayer.Context;
using WebPlatform.DataLayer.Repository.Interfaces;
using WebPlatform.Models;

namespace WebPlatform.DataLayer.Repository.Implementations
{
    public class UserRepository : IUserRepository
    {
        public User Create(User obj)
        {
            using (Entities context = new Entities())
            {
                context.Users.Add(obj);
                context.SaveChanges();
                return obj;
            }
        }

        public ICollection<User> GetAll()
        {
            using (Entities context = new Entities())
            {
                return context.Users.ToList();
            }
        }

        public ICollection<User> GetAllOnlineBetweenDates(DateTime startDate, DateTime endDate)
        {
            using (Entities context = new Entities())
            {
                return context.Users.Where(c => c.Lastonline >= startDate && c.Lastonline <= endDate).ToList();
            }
        }

        public ICollection<User> GetAllRegisteredBetweenDates(DateTime startDate, DateTime endDate)
        {
            using (Entities context = new Entities())
            {
                return context.Users.Where(c => c.Registerdate >= startDate && c.Registerdate <= endDate).ToList();
            }
        }

        public User GetByEmail(string email)
        {
            using (Entities context = new Entities())
            {
                return context.Users.Where(c => c.Email == email).FirstOrDefault();
            }
        }

        public ICollection<User> GetByFirstname(string firstname)
        {
            using (Entities context = new Entities())
            {
                return context.Users.Where(c => c.FirstName == firstname).ToList();
            }
        }

        public User GetById(int id)
        {
            using (Entities context = new Entities())
            {
                return context.Users.Where(c => c.Id == id).FirstOrDefault();
            }
        }

        public ICollection<User> GetByIp(string ip)
        {
            using (Entities context = new Entities())
            {
                return context.Users.Where(c => c.Ip == ip).ToList();
            }
        }

        public ICollection<User> GetByLastname(string lastname)
        {
            using (Entities context = new Entities())
            {
                return context.Users.Where(c => c.LastName == lastname).ToList();
            }
        }

        public User GetByPhone(string phone)
        {
            using (Entities context = new Entities())
            {
                return context.Users.Where(c => c.Phone == phone).FirstOrDefault();
            }
        }

        public bool Delete(User obj)
        {
            if (obj == null)
                return false;
            using (Entities context = new Entities())
            {
                context.Users.Remove(obj);
                if (context.Users.Contains(obj))
                    return false;
                context.SaveChanges();
                return true;
            }
        }

        public User Update(User obj)
        {
            if (obj == null)
                return null;
            using (Entities context = new Entities())
            {
                User oldUser = context.Users.Find(obj.Id);
                if (oldUser != null)
                {
                    oldUser.LastName = obj.LastName;
                    oldUser.FirstName = obj.FirstName;
                    oldUser.Phone = obj.Phone;
                    oldUser.Email = obj.Email;
                    oldUser.Password = obj.Password;
                }
                context.SaveChanges();
                return context.Users.Find(obj.Id);
            }
        }
    }
}