﻿namespace XjAeon.ApiObject.研究生系统
{
    /*
    //接口调用请求说明子表
    API描述	接口地址	请求方法	部门	默认返回类型	调用建议	使用场景
    ---	/open_api/customization/vfosterprofessional/full	GET	全体部门	json	---	---

    //请求参数说明表
    参数名称	别名	是否必填	模糊查询	描述	代码表
    ZYDM	None	否	否	None	无
    MC	None	否	否	None	无

    //返回参数说明
    参数名称	别名	类型	描述	默认值	代码表
    ZYDM	None	varchar	None	---	无
    MC	None	varchar	None	---	无
     */

    /// <summary>
    /// 研究生系统 - 研究生专业代码表 
    /// </summary>
    class 研究生专业代码表 : IApiObject
    {
        public string Url => "/open_api/customization/vfosterprofessional/full";
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
            /// <summary>
            /// 专业代码
            /// </summary>
            public string ZYDM { get; set; }
            /// <summary>
            /// 专业名称
            /// </summary>
            public string MC { get; set; }
        }

        public class Datum
        {
            public int __row_number__ { get; set; }
            /// <summary>
            /// 专业代码
            /// </summary>
            public string ZYDM { get; set; }
            /// <summary>
            /// 专业名称
            /// </summary>
            public string MC { get; set; }
        }
    }
}
