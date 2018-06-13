using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Activity14_2.Model;

namespace Activity14_2.Controllers
{
    public class StockController : ApiController
    {
        
        // GET api/<controller>/5
        public IEnumerable<StockItem> Get()
        {
            var context = new WideWorldImportersEntities();
            var query = from s in context.StockItems select s;
            var stockItems = query.ToArray<StockItem>();

            return stockItems;
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