using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebPlatform.DataLayer.Repository.Implementations;
using WebPlatform.DataLayer.Repository.Interfaces;
using WebPlatform.Models;

namespace WebPlatform.Workers
{
    public class UserWorker
    {
        private IUserRepository userRepository;

        public UserWorker()
        {
            userRepository = new UserRepository();
        }

        public User GetByEmail(string email)
        {
            return userRepository.GetByEmail(email);
        }

        public User GetByPhone(string phone)
        {
            return userRepository.GetByPhone(phone);
        }

        public ICollection<User> GetByFirstname(string firstname)
        {
            return userRepository.GetByFirstname(firstname);
        }

        public ICollection<User> GetByLastname(string lastname)
        {
            return userRepository.GetByLastname(lastname);
        }

        public ICollection<User> GetByIp(string ip)
        {
            return userRepository.GetByIp(ip);
        }

        public ICollection<User> GetAllOnlineBetweenDates(DateTime startDate, DateTime endDate)
        {
            return userRepository.GetAllOnlineBetweenDates(startDate, endDate);
        }

        public ICollection<User> GetAllRegisteredBetweenDates(DateTime startDate, DateTime endDate)
        {
            return userRepository.GetAllRegisteredBetweenDates(startDate, endDate);
        }

        public User Create(User obj)
        {
            return userRepository.Create(obj);
        }

        public User Update(User obj)
        {
            return userRepository.Update(obj);
        }

        public bool Delete(User obj)
        {
            return userRepository.Delete(obj);
        }

        public User GetById(int id)
        {
            return userRepository.GetById(id);
        }

        public ICollection<User> GetAll()
        {
            return userRepository.GetAll();
        }
    }
}