using APM.WebAPI.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DueBus.WebAPI.Controllers
{
    public class TowardsController : ApiController
    {
        [EnableCorsAttribute("http://192.168.0.7:8888, http://localhost:8888", "*", "*")]
        // GET: api/Towards
        public IEnumerable<Towards> Get()
        {
            var towardsRepository = new TowardsRepository();
            return towardsRepository.Retrieve();
        }

        [EnableCorsAttribute("http://192.168.0.7:8888, http://localhost:8888", "*", "*")]
        // GET: api/Towards/5
        public Towards Get(String lineName)
        {
            var towardsRepository = new TowardsRepository();
            var towards = towardsRepository.Retrieve();
            return towards.SingleOrDefault(p => p.LineName.Equals(lineName));
        }

        // POST: api/Towards
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Towards/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Towards/5
        public void Delete(int id)
        {
        }
    }
}
