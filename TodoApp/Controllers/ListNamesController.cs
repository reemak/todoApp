using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodoApp.Database;

namespace TodoApp.Controllers
{
    public class ListNamesController : ApiController
    {
        // GET: api/ListName
        public IEnumerable<string> Get()
        {
            List<string> lists = new List<string>();
            return lists;
        }

        // GET: api/ListName/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ListName
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ListName/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ListName/5
        public void Delete(int id)
        {
        }
    }
}
