using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DueBus.WebAPI.Models
{
    public class Stop
    {
        public string StopName { get; set; }
        public int StopCode { get; set; }
        public List<String> interchanges { get; set; }
    }
}