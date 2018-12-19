using Messenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Messenger.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        public ApplicationDbContext _ctx = new ApplicationDbContext();
        // GET api/valuesPOST
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5o
        public void Delete(int id)
        {
        }

        [HttpPost, Route("api/Send")]
        public void Send([FromBody]Message msg)
        {
            _ctx.Messages.Add(msg);
            _ctx.SaveChanges();
        }
    }
}
