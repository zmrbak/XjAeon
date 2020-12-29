using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using XjAeon.ApiObject;
using XjAeon.ApiObject.人事系统;
using XjAeon.ApiObject.学校概况数据集;
using XjAeon.ApiObject.教务系统;
using XjAeon.ApiObject.教学管理数据集;
using XjAeon.ApiObject.教职工管理数据集;
using XjAeon.ApiObject.研究生系统;
using XjAeon.Generic;

namespace XjAeon
{
    class Program
    {
        static void Main(string[] args)
        {
            //人事系统 - 人员基础信息
            //DownLoadData<人员基础信息>();

            //var xjAeonApiData = new XjAeonApiData<人员基础信息>();
            //var list = new List<KeyValuePair<string, string>> { new KeyValuePair<string, string>("UID", "10201401498") };
            //var a1 = xjAeonApiData.GetDataByPage(1, 1, list);

            //人事系统- 组织机构代码表
            //DownLoadData<组织机构代码表>();

            //教务系统-本科生基本信息
            //DownLoadData<本科生基本信息>();

            //研究生系统-	研究生基础信息
            //DownLoadData<研究生基础信息>();

            //研究生系统 - 研究生专业代码表 
            //DownLoadData<研究生专业代码表>();

            //教学管理数据集  - 研究生专业信息
            //DownLoadData<研究生专业信息>();

            //学校概况数据集 - 院系所单位信息
            //DownLoadData<院系所单位信息>();

            //教职工管理数据集 - 教职工基本信息
            //DownLoadData<教职工基本信息>();

        }

        private static void DownLoadData<T>() where T : IApiObject, new()
        {
            var fileName = typeof(T).Name + DateTime.Now.ToString("_yyyyMMdd") + ".csv";
            var xjAeonApiData = new XjAeonApiData<T>();
            var a1 = xjAeonApiData.GetAllData();

            StringBuilder stringBuilder = new StringBuilder();

            //获取标题
            List<string> list = new List<string>();
            foreach (PropertyInfo item in a1[0].GetType().GetProperties())
            {
                if (item.Name == "result")
                {
                    var result = item.GetValue(a1[0], null);
                    foreach (PropertyInfo item2 in result.GetType().GetProperties())
                    {
                        if (item2.Name == "data_struct")
                        {
                            var data_struct = item2.GetValue(result, null);
                            foreach (var item3 in data_struct.GetType().GetProperties())
                            {
                                string name = item3.Name;
                                var itemValue2 = item3.GetValue(data_struct, null);
                                string value = itemValue2 == null ? "null" : itemValue2.ToString();
                                stringBuilder.Append(name + "(" + value + ")").Append(",");
                                list.Add(name);
                            }
                            stringBuilder.Remove(stringBuilder.Length - 1, 1);
                            stringBuilder.AppendLine();
                            break;
                        }
                    }
                    break;
                }
            }

            //获取数据
            foreach (var a in a1)
            {
                foreach (PropertyInfo item in a.GetType().GetProperties())
                {
                    if (item.Name == "result")
                    {
                        var result = item.GetValue(a, null);
                        foreach (PropertyInfo item2 in result.GetType().GetProperties())
                        {
                            if (item2.Name == "data")
                            {
                                //data数组
                                dynamic data = item2.GetValue(result, null);

                                //解析数组
                                foreach (var item3 in data)
                                {
                                    //每一个数据
                                    foreach (var item4 in list)
                                    {
                                        var p = item3.GetType().GetProperty(item4);
                                        var itemValue2 = p.GetValue(item3, null);
                                        string value = itemValue2 == null ? "null" : itemValue2.ToString();
                                        stringBuilder.Append(value).Append(",");
                                    }
                                    stringBuilder.Remove(stringBuilder.Length - 1, 1);
                                    stringBuilder.AppendLine();
                                }
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            File.WriteAllText(fileName, stringBuilder.ToString(), Encoding.Default);
            Process.Start(fileName);
        }
    }
}
