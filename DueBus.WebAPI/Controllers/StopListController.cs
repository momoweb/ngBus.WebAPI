using DueBus.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DueBus.WebAPI.Controllers
{
    public class StopListController : ApiController
    {
        [EnableCorsAttribute("http://192.168.0.7:8888, http://localhost:8888", "*", "*")]
        // GET: api/StopList
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [EnableCorsAttribute("http://192.168.0.7:8888, http://localhost:8888", "*", "*")]
        // GET: api/StopList/{linename}?run=1
        // To be replace by Database calls
        public string[] Get(string lineName, int run)
        {
            var stopRepository = new StopRepository();
            string[][] stops = stopRepository.Retrieve();

            return stops[0];
        }

        // POST: api/StopList
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/StopList/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/StopList/5
        public void Delete(int id)
        {
        }
    }
}
