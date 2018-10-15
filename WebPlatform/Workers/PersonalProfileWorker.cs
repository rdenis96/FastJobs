using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebPlatform.DataLayer.Repository.Implementations;
using WebPlatform.DataLayer.Repository.Interfaces;
using WebPlatform.Models;

namespace WebPlatform.Workers
{
    public class PersonalProfileWorker
    {
        private IPersonalProfileRepository personalProfileRepository;

        public PersonalProfileWorker()
        {
            personalProfileRepository = new PersonalProfileRepository();
        }

        public PersonalProfile Create(PersonalProfile obj)
        {
            return personalProfileRepository.Create(obj);
        }

        public bool Delete(PersonalProfile obj)
        {
            return personalProfileRepository.Delete(obj);
        }

        public ICollection<PersonalProfile> GetAll()
        {
            return personalProfileRepository.GetAll();
        }

        public PersonalProfile GetById(int id)
        {
            return personalProfileRepository.GetById(id);
        }

        public PersonalProfile Update(PersonalProfile obj)
        {
            return personalProfileRepository.Update(obj);
        }
    }
}