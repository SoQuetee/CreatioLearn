using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreatioIntegration.Models
{
    public class BaseCreatioRequest
    {
        public string Url { get; set; }
        public string Method { get; set; } = "GET";
        public bool KeepAlive { get; set; } = true;
        public string ContentType { get; set; } = "application/json";
        public string Data { get; set; }

    }
}
