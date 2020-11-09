namespace XjAeon.ApiObject
{
    /*
    //接口调用请求说明子表
    API描述	接口地址	请求方法	部门	默认返回类型	调用建议	使用场景
    ---	/open_api/customization/hrjgszxx/full	GET	全体部门	json	---	---

    //请求参数说明表
    参数名称	别名	是否必填	模糊查询	描述	代码表
    DWH	单位号	否	否	None	无
    DWMC	单位名称	否	否	None	无
    DWJC	单位简称	否	否	None	无
    LSDWH	隶属单位号	否	否	None	无
    DWLBM	单位类别码	否	否	None	无
    SFST	是否使用	否	否	None	无
    PX	排序	否	否	None	无

    //返回参数说明
    参数名称	别名	类型	描述	默认值	代码表
    DWH	单位号	varchar	None	---	无
    DWMC	单位名称	varchar	None	---	无
    DWJC	单位简称	varchar	None	---	无
    LSDWH	隶属单位号	varchar	None	---	无
    DWLBM	单位类别码	varchar	None	---	无
    SFST	是否使用	varchar	None	---	无
    PX	排序	varchar	None	---	无
    */

    /// <summary>
    /// 人事系统- 组织机构代码表
    /// </summary>
    public class OrganizationCodeObject : IApiObject
    {
        public string Url => "/open_api/customization/hrjgszxx/full";
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
            public string DWH { get; set; }
            public string DWMC { get; set; }
            public string DWJC { get; set; }
            public string LSDWH { get; set; }
            public string DWLBM { get; set; }
            public string SFST { get; set; }
            public string PX { get; set; }
        }

        public class Datum
        {
            public int __row_number__ { get; set; }
            public string DWH { get; set; }
            public string DWMC { get; set; }
            public string DWJC { get; set; }
            public string LSDWH { get; set; }
            public string DWLBM { get; set; }
            public string SFST { get; set; }
            public string PX { get; set; }
        }
    }   
}
