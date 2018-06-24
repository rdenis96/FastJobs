using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPlatform.Models
{
    public class User : IEquatable<User>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public DateTime Lastonline { get; set; }
        public DateTime Registerdate { get; set; }
        public string Ip { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return Equals((User)obj);
        }

        public bool Equals(User obj)
        {
            if (obj == null)
                return false;

            var result = (Id == obj.Id) &&
                         (FirstName.Equals(obj.FirstName)) &&
                         (LastName.Equals(obj.LastName)) &&
                         (Email.Equals(obj.Email)) &&
                         (Password.Equals(obj.Password)) &&
                         (Phone.Equals(obj.Phone)) &&
                         Lastonline == obj.Lastonline &&
                         Registerdate == obj.Registerdate;
            return result;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}