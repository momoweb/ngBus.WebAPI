using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Hosting;

namespace APM.WebAPI.Models
{
    /// <summary>
    /// Stores the data in a json file so that no database is required for this
    /// sample application
    /// </summary>
    public class TowardsRepository
    {
        /// <summary>
        /// Retrieves the list of products.
        /// </summary>
        /// <returns></returns>
        internal List<Towards> Retrieve()
        {
            var filePath = HostingEnvironment.MapPath(@"~/App_Data/destinations.json");

            var json = System.IO.File.ReadAllText(filePath);

            var products = JsonConvert.DeserializeObject<List<Towards>>(json);

            return products;
        }
    }
}