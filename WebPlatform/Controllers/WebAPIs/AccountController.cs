using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebPlatform.Models;
using WebPlatform.Resources;
using WebPlatform.Resources.Helpers;
using WebPlatform.Workers;

namespace WebPlatform.Controllers.WebAPIs
{
    public class AccountController : ApiController
    {
        private UserWorker userWorker = new UserWorker();
        private PersonalProfileWorker personalProfileWorker = new PersonalProfileWorker();

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet]
        public IHttpActionResult GetAll(int id)
        {
            ICollection<User> users = userWorker.GetAll();
            return Ok(users);
        }

        [HttpPost]
        public IHttpActionResult Register([FromBody]User userCredentials)
        {
            userCredentials.Ip = IpHelper.GetIpAddress();
            var user = userWorker.GetByEmail(userCredentials.Email);
            if (user != null)
            {
                return Ok(ResultMessages.RegisterEmailExist);
            }

            var encryptedPassword = PasswordEncryptor.MD5Hash(userCredentials.Password);
            userCredentials.Password = encryptedPassword;
            user = userWorker.Create(userCredentials);

            if (user == null)
            {
                return Ok(ResultMessages.RegisterFailed);
            }
            PersonalProfile personalProfile = new PersonalProfile
            {
                Id = user.Id,
                Born = DateTime.UtcNow.AddYears(-18),
                Image = DefaultConstants.RegisterImage
            };
            personalProfile = personalProfileWorker.Create(personalProfile);

            return Ok(ResultMessages.RegisterSuccessful);
        }

        [HttpPost]
        public IHttpActionResult Login([FromBody]User userCredentials)
        {
            User user = userWorker.GetByEmail(userCredentials.Email);
            var result = new { message = "", userId = -1 };
            if (user == null)
            {
                result = new
                {
                    message = ResultMessages.WrongCredentials,
                    userId = -1
                };
                return Ok(result);
            }
            var encryptedPassword = PasswordEncryptor.MD5Hash(userCredentials.Password);
            if (user.Password.Equals(encryptedPassword))
            {
                result = new
                {
                    message = ResultMessages.CorrectLoginCredentials,
                    userId = user.Id
                };
                return Ok(result);
            }
            result = new
            {
                message = ResultMessages.WrongCredentials,
                userId = -1
            };
            return Ok(result);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}