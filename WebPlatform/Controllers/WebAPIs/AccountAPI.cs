using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebPlatform.Models;
using WebPlatform.Resources.Helpers;
using WebPlatform.Workers;

namespace WebPlatform.Controllers.WebAPIs
{
    [RoutePrefix("api/account")]
    public class AccountAPI : ApiController
    {
        private UserWorker userWorker = new UserWorker();

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [Route(Name = "getAllUsers")]
        [HttpGet]
        public IHttpActionResult GetAll(int id)
        {
            ICollection<User> users = userWorker.GetAll();
            return Ok(users);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
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