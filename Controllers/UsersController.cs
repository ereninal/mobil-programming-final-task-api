using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelApi.Models;
using Microsoft.AspNetCore.Mvc;



namespace HotelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public UsersController()
        {
        }

        // GET api/users
        [HttpGet]
        public IEnumerable<User> Get()
        {
            using (var db = new HotelContext())
            {
                var u = db.Users.ToList();
                return u;
            }
        }
        /*
        // GET api/users/5
        [HttpGet("{id}")]
        public ActionResult<string> GetstringById(int id)
        {
            return null;
        }

        // POST api/users
        [HttpPost("")]
        public void Poststring(string value)
        {
        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public void Putstring(int id, string value)
        {
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public void DeletestringById(int id)
        {
        }
        */
    }
}
