using System;
using System.IO;
using System.Threading;
using System.Web.Script.Serialization;

namespace XjAeon.Common
{
    public static class AccessToken
    {
        private static string APP_SECRET_FILENAME = "AppKeySecret.json";

        private static AccessTokenObject accessTokenObject = null;
        public static AccessTokenObject AccessTokenObject
        {
            get
            {
                if (accessTokenObject == null)
                {
                    Utility.Log.Info("首次运行，获取AccessToken");
                    RefreshAccessToken();

                    return accessTokenObject;
                }

                if (DateTime.Now > new DateTime(accessTokenObject.timeTicks).AddSeconds(accessTokenObject.result.expires_in))
                {
                    Utility.Log.Info("AccessToken已过期，刷新AccessToken");
                    RefreshAccessToken();
                }

                return accessTokenObject;
            }
        }


        private static void RefreshAccessToken()
        {
            AppKeySecret appKeySecret = null;

            //检查保存了AppKey 与 AppSecret的文件
            string appKeySecretFile = Path.Combine(Utility.AppDataPath, APP_SECRET_FILENAME);
            Utility.Log.Info("检查配置文件：" + appKeySecretFile);

            if (File.Exists(appKeySecretFile))
            {
                Utility.Log.Info("读取配置文件：" + appKeySecretFile);
                appKeySecret = new JavaScriptSerializer().Deserialize<AppKeySecret>(File.ReadAllText(appKeySecretFile));
            }

            //读取的配置不正确，重写配置文件
            if (appKeySecret == null)
            {
                appKeySecret = new AppKeySecret
                {
                    AppUrl = "/open_api/authentication/get_access_token",
                    AppKey = "20200930230363715",
                    AppSecret = "0f8a8a47bf9f2390f02134696892903b223da361"
                };

                //写入配置文件
                File.WriteAllText(appKeySecretFile, new JavaScriptSerializer().Serialize(appKeySecret));
                Utility.Log.Info("写入配置文件：" + appKeySecretFile);
            }

            //经测试，远程服务器经常在这里出问题，那就多试几次
            string accessTokenString;
            int i = 0;
            while (true)
            {
                accessTokenString = Utility.GetWebString($"{appKeySecret.AppUrl}?key={appKeySecret.AppKey}&secret={appKeySecret.AppSecret}");
                if (accessTokenString != null) break;

                i++;
                if (i > 4)
                {
                    Utility.Log.Error("远程服务器故障，超过" + i + "次尝试。。。");
                    return;
                }

                Utility.Log.Error("远程服务器故障，第“" + i + "”次等待3秒钟...");
                Thread.Sleep(3000);
                continue;
            }

            //成功获取AccessToken
            Utility.Log.Info("成功获取AccessToken:" + accessTokenString);

            //解析AccessToken
            accessTokenObject = new JavaScriptSerializer().Deserialize<AccessTokenObject>(accessTokenString);
        }

        class AppKeySecret
        {
            public string AppUrl { get; set; }
            public string AppKey { get; set; }
            public string AppSecret { get; set; }
        }
    }

    /// <summary>
    /// 从网站上获取的AccessToken对象
    /// </summary>
    public class AccessTokenObject
    {
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
