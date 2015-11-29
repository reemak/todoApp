using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TodoApp.Database;

namespace TodoApp.Controllers
{
    public class ListsController : ApiController
    {
        // GET: api/Lists
        public IEnumerable<string> Get()
        {
           using(var ctx=new TodoAppEntities())
            {
                List<string> li = ctx.getLists().ToList<string>();
                return li;

            }
        }

        // GET: api/Lists/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Lists
        public void Post([FromBody]string[] value)
        {
            using (var ctx = new TodoAppEntities())
            {
                ctx.addNames(value[0]);
               

            }

        }

        // PUT: api/Lists/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Lists/5
        public void Delete(int id)
        {
        }
    }
}
