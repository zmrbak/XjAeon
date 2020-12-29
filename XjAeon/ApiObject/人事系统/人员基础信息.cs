namespace XjAeon.ApiObject.人事系统
{
    /*
    //接口调用请求说明子表
    API描述	接口地址	请求方法	部门	默认返回类型	调用建议	使用场景
    /open_api/customization/hrryxx/full	GET	全体部门	json	---	---

    //请求参数说明表
    参数名称	别名	是否必填	模糊查询	描述	代码表
    UID	人员标识码	否	否	None	无
    XM	姓名	否	否	None	无
    XBM	性别码	否	否	None	无
    MZM	民族码	否	否	None	无
    GJM	国籍码	否	否	None	无
    BZLBM	编制类别码{DMB_XB_BZLB}	否	否	None	无
    DQZTM	当前状态码{DMB_HB_JZGDQZT}	否	否	None	无
    SZDWH	教职工所在单位{HR_JGSZXX}	否	否	None	无

    //返回参数说明
    参数名称	别名	类型	描述	默认值	代码表
    UID	人员标识码	varchar	None	---	无
    XM	姓名	varchar	None	---	无
    XBM	性别码	varchar	None	---	无
    MZM	民族码	varchar	None	---	无
    GJM	国籍码	varchar	None	---	无
    BZLBM	编制类别码{DMB_XB_BZLB}	varchar	None	---	无
    DQZTM	当前状态码{DMB_HB_JZGDQZT}	varchar	None	---	无
    SZDWH	教职工所在单位{HR_JGSZXX}	varchar	None	---	无
   */

    /// <summary>
    /// 人事系统 - 人员基础信息
    /// </summary>
    public class 人员基础信息 : IApiObject
    {
        public string Url => "/open_api/customization/hrryxx/full";
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
            ///  人员标识码  
            /// </summary>
            public string UID { get; set; }
            /// <summary>
            /// 姓名
            /// </summary>
            public string XM { get; set; }
            /// <summary>
            ///  性别码  
            /// </summary>
            public string XBM { get; set; }
            /// <summary>
            /// 民族码
            /// </summary>
            public string MZM { get; set; }
            /// <summary>
            /// 国籍码
            /// </summary>
            public string GJM { get; set; }
            /// <summary>
            /// 编制类别码{DMB_XB_BZLB}
            /// </summary>
            public string BZLBM { get; set; }
            /// <summary>
            /// 当前状态码{DMB_HB_JZGDQZT}
            /// </summary>
            public string DQZTM { get; set; }
            /// <summary>
            /// 教职工所在单位{HR_JGSZXX}
            /// </summary>
            public string SZDWH { get; set; }
        }

        public class Datum
        {
            public int __row_number__ { get; set; }
            /// <summary>
            ///  人员标识码  
            /// </summary>
            public string UID { get; set; }
            /// <summary>
            /// 姓名
            /// </summary>
            public string XM { get; set; }
            /// <summary>
            ///  性别码  
            /// </summary>
            public string XBM { get; set; }
            /// <summary>
            /// 民族码
            /// </summary>
            public string MZM { get; set; }
            /// <summary>
            /// 国籍码
            /// </summary>
            public string GJM { get; set; }
            /// <summary>
            /// 编制类别码{DMB_XB_BZLB}
            /// </summary>
            public string BZLBM { get; set; }
            /// <summary>
            /// 当前状态码{DMB_HB_JZGDQZT}
            /// </summary>
            public string DQZTM { get; set; }
            /// <summary>
            /// 教职工所在单位{HR_JGSZXX}
            /// </summary>
            public string SZDWH { get; set; }
        }
    }



   

}
