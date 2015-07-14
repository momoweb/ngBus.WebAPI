using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace DueBus.WebAPI.Models
{
    public class StopRepository
    {
        /// <summary>
        /// Retrieves the list of towards.
        /// </summary>
        /// <returns></returns>
        internal string[][] Retrieve()
        {
            var filePath = HostingEnvironment.MapPath(@"~/App_Data/test.json");

            var json = System.IO.File.ReadAllText(filePath);

            var stops = JsonConvert.DeserializeObject<string[][]>(json);

            return stops;
        }
    }
}