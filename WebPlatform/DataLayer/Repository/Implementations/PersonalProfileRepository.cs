using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebPlatform.DataLayer.Context;
using WebPlatform.DataLayer.Repository.Interfaces;
using WebPlatform.Models;

namespace WebPlatform.DataLayer.Repository.Implementations
{
    public class PersonalProfileRepository : IPersonalProfileRepository
    {
        public PersonalProfile Create(PersonalProfile obj)
        {
            using (Entities context = new Entities())
            {
                context.PersonalProfiles.Add(obj);
                context.SaveChanges();
                return obj;
            }
        }

        public bool Delete(PersonalProfile obj)
        {
            if (obj == null)
                return false;
            using (Entities context = new Entities())
            {
                context.PersonalProfiles.Remove(obj);
                if (context.PersonalProfiles.Contains(obj))
                    return false;
                context.SaveChanges();
                return true;
            }
        }

        public ICollection<PersonalProfile> GetAll()
        {
            using (Entities context = new Entities())
            {
                return context.PersonalProfiles.ToList();
            }
        }

        public PersonalProfile GetById(int id)
        {
            using (Entities context = new Entities())
            {
                return context.PersonalProfiles.Where(c => c.Id == id).FirstOrDefault();
            }
        }

        public PersonalProfile Update(PersonalProfile obj)
        {
            if (obj == null)
                return null;
            using (Entities context = new Entities())
            {
                PersonalProfile oldProfile = context.PersonalProfiles.Find(obj.Id);
                if (oldProfile != null)
                {
                    oldProfile.About = obj.About;
                    oldProfile.Address = obj.Address;
                    oldProfile.Born = obj.Born;
                    oldProfile.BornCountry = obj.BornCountry;
                    oldProfile.Gender = obj.Gender;
                    oldProfile.Hobbies = obj.Hobbies;
                    oldProfile.Image = obj.Image;
                    oldProfile.MaritalStatus = obj.MaritalStatus;
                    oldProfile.Studies = obj.Studies;
                }
                context.SaveChanges();
                return context.PersonalProfiles.Find(obj.Id);
            }
        }
    }
}