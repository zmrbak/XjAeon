namespace XjAeon.ApiObject.教务系统
{
    /*
    //接口调用请求说明子表
     API描述	接口地址	请求方法	部门	默认返回类型	调用建议	使用场景
    ---	/open_api/customization/viewstudent_alpha/full	GET	全体部门	json	---	---

    //请求参数说明表
    参数名称	别名	是否必填	模糊查询	描述	代码表
    STUDENTCODE	学号	否	否	学号	无
    STUSEX	性别	否	否	None	无
    MAJORNAME	专业名称	否	否	None	无
    COLLEGECODE	学院代码	否	否	None	无
    MAJORCODE	专业代码	否	否	None	无
    CLASSCODE	班级编号	否	否	None	无
    STUNAME	姓名	否	否	None	无
    GRADE	年级	否	否	None	无
    COLLEGENAME	学院名称	否	否	None	无
    XJZT	学籍状态	否	否	None	无

    //返回参数说明
    参数名称	别名	类型	描述	默认值	代码表
    STUDENTCODE	学号	VARCHAR2	学号	---	无
    STUSEX	性别	CHAR	None	---	无
    MAJORNAME	专业名称	VARCHAR2	None	---	无
    COLLEGECODE	学院代码	CHAR	None	---	无
    MAJORCODE	专业代码	CHAR	None	---	无
    CLASSCODE	班级编号	CHAR	None	---	无
    STUNAME	姓名	VARCHAR2	None	---	无
    GRADE	年级	NUMBER	None	---	无
    COLLEGENAME	学院名称	VARCHAR2	None	---	无
    XJZT	学籍状态	VARCHAR2	None	---	无
     */

    /// <summary>
    /// 教务系统-本科生基本信息
    /// </summary>
    public class 本科生基本信息 : IApiObject
    {
        public string Url => "/open_api/customization/viewstudent_alpha/full";
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
            /// 学号
            /// </summary>
            public string STUDENTCODE { get; set; }
            /// <summary>
            /// 性别
            /// </summary>
            public string STUSEX { get; set; }
            /// <summary>
            /// 专业名称
            /// </summary>
            public string MAJORNAME { get; set; }
            /// <summary>
            /// 学院代码
            /// </summary>
            public string COLLEGECODE { get; set; }
            /// <summary>
            /// 专业代码
            /// </summary>
            public string MAJORCODE { get; set; }
            /// <summary>
            /// 班级编号
            /// </summary>
            public string CLASSCODE { get; set; }
            /// <summary>
            /// 姓名
            /// </summary>
            public string STUNAME { get; set; }
            /// <summary>
            /// 年级
            /// </summary>
            public string GRADE { get; set; }
            /// <summary>
            /// 学院名称
            /// </summary>
            public string COLLEGENAME { get; set; }
            /// <summary>
            /// 学籍状态
            /// </summary>
            public string XJZT { get; set; }
        }

        public class Datum
        {
            /// <summary>
            /// 学号
            /// </summary>            
            public string STUDENTCODE { get; set; }
            /// <summary>
            /// 性别
            /// </summary>
            public string STUSEX { get; set; }
            /// <summary>
            /// 专业名称
            /// </summary>
            public object MAJORNAME { get; set; }
            /// <summary>
            /// 学院代码
            /// </summary>
            public object COLLEGECODE { get; set; }
            /// <summary>
            /// 专业代码
            /// </summary>
            public object MAJORCODE { get; set; }
            /// <summary>
            /// 班级编号
            /// </summary>
            public string CLASSCODE { get; set; }
            /// <summary>
            /// 姓名
            /// </summary>
            public string STUNAME { get; set; }
            /// <summary>
            /// 年级
            /// </summary>
            public int? GRADE { get; set; }
            /// <summary>
            /// 学院名称
            /// </summary>
            public object COLLEGENAME { get; set; }
            /// <summary>
            /// 学籍状态
            /// </summary>
            public string XJZT { get; set; }
        }
    }
}