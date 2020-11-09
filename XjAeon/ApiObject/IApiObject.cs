using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XjAeon.ApiObject
{
    public interface IApiObject
    {
        string Url { get; }
        int code { get; set; }
        string message { get; set; }
        string description { get; set; }
        string uuid { get; set; }
    }
}
