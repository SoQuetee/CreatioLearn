using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreatioIntegration.Models
{
    public class BaseCreatioResponse<T>
    {
        public string Context { get; set; }
        public List<T> Value { get; set; }
        public string ErrorText { get; set; }
    }
}
