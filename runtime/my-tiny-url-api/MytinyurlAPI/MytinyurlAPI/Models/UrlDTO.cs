using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MytinyurlAPI.Models
{
    public class UrlDTO
    {
        public string url { get; set; }
        public string tinyurl { get; set; }
        public string tinyurlshow { get { return "http://localhost:8080/url/" + tinyurl; } }
    }
}