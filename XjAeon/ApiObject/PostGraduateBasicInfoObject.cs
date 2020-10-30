namespace XjAeon.ApiObject
{
    /*
     //接口调用请求说明子表
     API描述	接口地址	请求方法	部门	默认返回类型	调用建议	使用场景
    ---	/open_api/customization/vaosesschoolroll/full	GET	全体部门	json	---	---

     //请求参数说明表
    参数名称	别名	是否必填	模糊查询	描述	代码表
    xh	学号	否	否	None	无
    xm	姓名	否	否	None	无
    nj	年级	否	否	None	无
    xb	性别	否	否	None	无
    zydm	专业代码	否	否	None	无
    status	状态	否	否	None	无
    DWM	学院代码	否	否	None	无

    //返回参数说明
    参数名称	别名	类型	描述	默认值	代码表
    xh	学号	varchar	None	---	无
    xm	姓名	varchar	None	---	无
    nj	年级	varchar	None	---	无
    xb	性别	varchar	None	---	无
    zydm	专业代码	varchar	None	---	无
    status	状态	char	None	---	无
    DWM	学院代码	varchar	None	---	无
     */

    /// <summary>
    /// 研究生系统-	研究生基本信息
    /// </summary>
    class PostGraduateBasicInfoObject
    {
        public static string Url = "/open_api/customization/vaosesschoolroll/full";

        public int code { get; set; }
        public string message { get; set; }
        public string description { get; set; }
        public string uuid { get; set; }
        public Result result { get; set; }

        public class Result
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
            public string xh { get; set; }
            public string xm { get; set; }
            public string nj { get; set; }
            public string xb { get; set; }
            public string zydm { get; set; }
            public string status { get; set; }
            public string DWM { get; set; }
        }

        public class Datum
        {
            public int __row_number__ { get; set; }
            public string xh { get; set; }
            public string xm { get; set; }
            public string nj { get; set; }
            public string xb { get; set; }
            public string zydm { get; set; }
            public string status { get; set; }
            public string DWM { get; set; }
        }
    }
}
