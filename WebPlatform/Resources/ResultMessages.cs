using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPlatform.Resources
{
    public static class ResultMessages
    {
        public static object NoUserByEmail()
        {
            return new
            {
                message = "No user was found with that Email!"
            };
        }

        public static object WrongCredentials()
        {
            return new
            {
                message = "The email or/and password are wrong or the email does not exist!"
            };
        }

        public static object PasswordLength()
        {
            return new
            {
                message = "The password must be at least 6 characters with at least 1 uppercase and 1 symbol. (Ex: Password70!2)!"
            };
        }

        public static object IncorrectEmailFormat()
        {
            return new
            {
                message = "The Email format is not correct!"
            };
        }

        public static object CorrectLoginCredentials()
        {
            return new
            {
                message = "Login was successful, you will be redirected!"
            };
        }
    }
}