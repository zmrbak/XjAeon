using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XjAeon.ApiObject
{
    public interface IResult
    {
        int page { get; set; }
        int per { get; set; }
        int total { get; set; }
        int max_page { get; set; }       
    }
}
