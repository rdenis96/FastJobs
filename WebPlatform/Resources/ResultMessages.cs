using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPlatform.Resources
{
    public static class ResultMessages
    {
        public const string NoUserByEmail = "No user was found with that Email!";
        public const string WrongCredentials = "The email or/and password are wrong or the email does not exist!";
        public const string PasswordLength = "The password must be at least 6 characters with at least 1 uppercase and 1 symbol. (Ex: Password70!2)!";
        public const string IncorrectEmailFormat = "The Email format is not correct!";
        public const string CorrectLoginCredentials = "Login was successful, you will be redirected!";
        public const string RegisterEmailExist = "The email is already used, please try a different email!";
        public const string RegisterSuccessful = "Your account was registered, will be redirected!";
    }
}