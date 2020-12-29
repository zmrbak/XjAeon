using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XjAeon.ApiObject.教学管理数据集
{
    class 研究生专业信息 : IApiObject
    {
        public string Url => "/open_api/customization/tgxjxyjszyxx/full";
        public int code { get; set; }
        public string message { get; set; }
        public string description { get; set; }
        public string uuid { get; set; }
        public Result result { get; set; }

        public class Result : IResult
        {
            public int page { get; set; }
            public int per { get; set; }
            public int total { get; set; }
            public int max_page { get; set; }
            public Data_Struct data_struct { get; set; }
            public Data_Struct[] data { get; set; }
        }

        public class Data_Struct
        {
            /// <summary>
            /// 专业代码
            /// </summary>
            public string ZYDM { get; set; }
            /// <summary>
            /// 起始学期
            /// </summary>
            public string QSXQ { get; set; }
            /// <summary>
            /// 专业英文名称
            /// </summary>
            public string ZYYWMC { get; set; }
            /// <summary>
            /// 学科门类码
            /// </summary>
            public string XKMLM { get; set; }
            /// <summary>
            /// 专业方向号
            /// </summary>
            public string ZYFXH { get; set; }
            /// <summary>
            /// 启用标志
            /// </summary>
            public string QYBZ { get; set; }
            /// <summary>
            /// 学制
            /// </summary>
            public string XZ { get; set; }
            /// <summary>
            /// 专业名称
            /// </summary>
            public string ZYDMMC { get; set; }
            /// <summary>
            /// 专业简称
            /// </summary>
            public string ZYJC { get; set; }
            /// <summary>
            /// 时间戳
            /// </summary>
            public string TSTAMP { get; set; }
            /// <summary>
            /// 单位号
            /// </summary>
            public string DWH { get; set; }
            /// <summary>
            /// 建立年月
            /// </summary>
            public string JLNY { get; set; }
        }
    }
}
