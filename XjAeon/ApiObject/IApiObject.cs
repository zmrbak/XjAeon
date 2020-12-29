using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XjAeon.ApiObject
{
    public interface IApiObject
    {
        string  Url { get; }
        public int code { get; set; }
        //public IResult result { get; set; }
    }
}
