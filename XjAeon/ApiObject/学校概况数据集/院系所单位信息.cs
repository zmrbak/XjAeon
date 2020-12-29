using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XjAeon.ApiObject.学校概况数据集
{
    class 院系所单位信息 : IApiObject
    {
        public string Url => "/open_api/customization/tgxxxyxsdwxx/full";
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
            public Datum[] data { get; set; }
        }

        public class Data_Struct
        {
            public string DWMC { get; set; }
            public string DWJP { get; set; }
            public string DWYWMC { get; set; }
            public string DWDM { get; set; }
            public string SXRQ { get; set; }
            public string DWBBM { get; set; }
            public string XZFZRJGH { get; set; }
            public string DZZFZRJGH { get; set; }
            public string DWYWJC { get; set; }
            public string DWJC { get; set; }
            public string DWFZRH { get; set; }
            public string DWLBM { get; set; }
            public string DWYXBS { get; set; }
            public string TSTAMP { get; set; }
            public string JLNY { get; set; }
            public string DWDZ { get; set; }
            public string SFST { get; set; }
            public string LSDWH { get; set; }
            public string DWLB { get; set; }
        }

        public class Datum
        {
            public string DWMC { get; set; }
            public object DWJP { get; set; }
            public object DWYWMC { get; set; }
            public string DWDM { get; set; }
            public string SXRQ { get; set; }
            public object DWBBM { get; set; }
            public object XZFZRJGH { get; set; }
            public object DZZFZRJGH { get; set; }
            public object DWYWJC { get; set; }
            public string DWJC { get; set; }
            public object DWFZRH { get; set; }
            public string DWLBM { get; set; }
            public string DWYXBS { get; set; }
            public string TSTAMP { get; set; }
            public string JLNY { get; set; }
            public object DWDZ { get; set; }
            public string SFST { get; set; }
            public string LSDWH { get; set; }
            public string DWLB { get; set; }
        }

    }
}
