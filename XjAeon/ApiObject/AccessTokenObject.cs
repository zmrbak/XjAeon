using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XjAeon.ApiObject
{
    /// <summary>
    /// 从网站上获取的AccessToken对象
    /// </summary>
    public class AccessTokenObject : IApiObject
    {
        public string Url => "/open_api/authentication/get_access_token";
        public int code { get; set; }
        public string message { get; set; }
        public string description { get; set; }
        public string uuid { get; set; }

        public Result result { get; set; }
        public long timeTicks { get; set; } = DateTime.Now.Ticks;

        public class Result
        {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public int expires_in { get; set; }
            public string scope { get; set; }
            public string license { get; set; }
        }
    }
}
