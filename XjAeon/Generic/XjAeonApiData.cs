using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Web.Script.Serialization;
using XjAeon.Common;

namespace XjAeon.Generic
{
    public class XjAeonApiData<TClass>
    {
        private string API_URL_FILE_NAME = "ApiUrl_" + typeof(TClass).Name + ".json";
        private ApiUrl apiUrl = null;

        private int totalRecords = 0;
        /// <summary>
        /// 记录总数
        /// </summary>
        public int TotalRecords
        {
            get { return totalRecords; }
        }

        private List<KeyValuePair<string, string>> dataStruct;
        /// <summary>
        /// 数据结构
        /// </summary>
        public List<KeyValuePair<string, string>> DataStruct
        {
            get { return dataStruct; }
        }

        /// <summary>
        /// 实例化时，初始化
        /// </summary>
        public XjAeonApiData()
        {
            string ApiUrlJsonFileName = Path.Combine(Utility.AppDataPath, API_URL_FILE_NAME);
            Utility.Log.Info("检查配置文件：" + ApiUrlJsonFileName);

            if (File.Exists(ApiUrlJsonFileName))
            {
                Utility.Log.Info("读取配置文件：" + ApiUrlJsonFileName);
                apiUrl = new JavaScriptSerializer().Deserialize<ApiUrl>(File.ReadAllText(ApiUrlJsonFileName));
            }
            else
            {
                apiUrl = new ApiUrl
                {
                    Url = typeof(TClass).GetField("Url").GetValue(typeof(TClass)).ToString()
                };
                Utility.Log.Info("写入配置文件：" + ApiUrlJsonFileName);
                File.WriteAllText(ApiUrlJsonFileName, new JavaScriptSerializer().Serialize(apiUrl));
            }

            //获取一条数据
            GetFirstRecord();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageId"></param>
        /// <param name="perPage"></param>
        /// <returns></returns>

        /// <summary>
        /// 获取第几页的数据
        /// </summary>
        /// <param name="pageId">第几页，默认从1开始</param>
        /// <param name="perPage">每页多少条数据，默认100条</param>
        /// <param name="filterList">查询条件，默认null</param>
        /// <returns></returns>
        public TClass GetDataByPage(int pageId = 1, int perPage = 100, List<KeyValuePair<string, string>> filterList = null)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{apiUrl.Url}?access_token={AccessToken.AccessTokenObject.result.access_token}&page={pageId}&per_page={perPage}");
            if (filterList != null)
            {
                foreach (var item in filterList)
                {
                    stringBuilder.Append($"&{item.Key.ToString()}={item.Value.ToString()}");
                }
            }
            string dataString = Utility.GetWebString(stringBuilder.ToString());
            return new JavaScriptSerializer().Deserialize<TClass>(dataString);
        }

        public List<TClass> GetAllData()
        {
            int perPage = 100;
            int pageCount = (int)Math.Ceiling(totalRecords * 1.0 / perPage);
            List<TClass> personnelBasicInfoObjects = new List<TClass>();

            for (int pageNumber = 0; pageNumber < pageCount; pageNumber++)
            {
                Utility.Log.Info("读取页码：" + (pageNumber + 1));
                personnelBasicInfoObjects.Add(GetDataByPage(pageNumber + 1, perPage));
            }
            return personnelBasicInfoObjects;
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        private void GetFirstRecord()
        {
            string dataString = Utility.GetWebString($"{apiUrl.Url}?access_token={AccessToken.AccessTokenObject.result.access_token}&page=1&per_page=1");
            TClass personnelBasicInfo = new JavaScriptSerializer().Deserialize<TClass>(dataString);

            //验证数据
            PropertyInfo[] PropertyList = personnelBasicInfo.GetType().GetProperties();
            foreach (var item in PropertyList)
            {
                if (item.Name == "code")
                {
                    int code = int.Parse(item.GetValue(personnelBasicInfo, null).ToString());
                    if (code != 10000)
                    {
                        Utility.Log.Error("获取的数据有误，请联系程序开发者！\n" + dataString);
                        return;
                    }
                }
            }

            //数据结构
            dataStruct = new List<KeyValuePair<string, string>>();
            foreach (var item in PropertyList)
            {
                if (item.Name == "result")
                {
                    var result = item.GetValue(personnelBasicInfo, null);
                    PropertyInfo[] PropertyList2 = result.GetType().GetProperties();
                    foreach (var item1 in PropertyList2)
                    {
                        if (item1.Name == "data_struct")
                        {
                            var data_struct = item1.GetValue(result, null);
                            foreach (PropertyInfo item2 in data_struct.GetType().GetProperties())
                            {
                                string name = item2.Name;
                                string value = item2.GetValue(data_struct, null).ToString();
                                dataStruct.Add(new KeyValuePair<string, string>(name, value));
                            }
                            continue;
                        }

                        if (item1.Name == "total")
                        {
                            totalRecords = int.Parse(item1.GetValue(result, null).ToString());
                        }
                    }
                }
            }
        }
    }
}
