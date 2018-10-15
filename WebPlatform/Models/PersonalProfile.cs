using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebPlatform.Models
{
    public class PersonalProfile : IEquatable<PersonalProfile>
    {
        [ForeignKey("User")]
        public int Id { get; set; }

        public virtual User User { get; set; }

        public string Image { get; set; }
        public DateTime Born { get; set; }
        public int Gender { get; set; }
        public string BornCountry { get; set; }
        public string Address { get; set; }
        public string Studies { get; set; }
        public string Hobbies { get; set; }
        public string MaritalStatus { get; set; }
        public string About { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return Equals((PersonalProfile)obj);
        }

        public bool Equals(PersonalProfile obj)
        {
            if (obj == null)
                return false;

            var result = (Id == obj.Id) &&
                         (Image.Equals(obj.Image)) &&
                         (Born.Equals(obj.Born)) &&
                         (Gender.Equals(obj.Gender)) &&
                         (BornCountry.Equals(obj.BornCountry)) &&
                         (Address.Equals(obj.Address)) &&
                         (Studies.Equals(obj.Studies)) &&
                         (Hobbies.Equals(obj.Hobbies)) &&
                         (MaritalStatus.Equals(obj.MaritalStatus)) &&
                         (About.Equals(obj.About));
            return result;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}