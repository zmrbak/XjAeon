using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Web.Script.Serialization;

namespace XjAeon.Common
{
    public static class Utility
    {
        public static string AppDataPath { set; get; } = null;
        private static log4net.ILog log = null;
        public static log4net.ILog Log
        {
            get
            {
                if (log == null)
                {
                    XmlConfigurator.Configure(new FileInfo(Utility.GetLog4netConfigFileName()));
                    log = LogManager.GetLogger("LogRoot");
                }
                return log;
            }
        }

        private static IpWithPort ipWithPort = null;
        public static IpWithPort IpWithPort
        {
            get
            {
                if (ipWithPort == null)
                {
                    string log4netConfigFile = Path.Combine(AppDataPath, "IpIpWithPort.Json");
                    if (File.Exists(log4netConfigFile) == true)
                    {
                        ipWithPort = new JavaScriptSerializer().Deserialize<IpWithPort>(File.ReadAllText(log4netConfigFile));
                    }
                    else
                    {
                        ipWithPort = new IpWithPort
                        {
                            Protocal = "http",
                            Ip = "127.0.0.1",
                            Port = 80
                        };
                        File.WriteAllText(log4netConfigFile, new JavaScriptSerializer().Serialize(ipWithPort));
                    }
                }
                return ipWithPort;
            }
        }

        static Utility()
        {
            if (AppDataPath == null)
            {
                //应用程序的数据保存路径
                Assembly assembly = Assembly.GetExecutingAssembly();
                AssemblyProductAttribute product = assembly.GetCustomAttribute<AssemblyProductAttribute>();
                AppDataPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "Zmrbak",
                    product.Product);

                //如果路径不存在，则创建路径，获取AccessToken
                if (Directory.Exists(AppDataPath) == false)
                {
                    Directory.CreateDirectory(AppDataPath);
                }
            }
        }

        private static string GetLog4netConfigFileName()
        {
            string log4netConfigFile = Path.Combine(AppDataPath, "log4net.config");
            if (File.Exists(log4netConfigFile) == false)
            {
                string configString = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
<configuration>
  <configSections>
    <section name=""log4net"" type=""log4net.Config.Log4NetConfigurationSectionHandler, log4net"" />
  </configSections>
  <log4net debug=""false"" update=""Merge"" threshold=""ALL"">
    <root>
      <level value=""DEBUG"" />
      <appender-ref ref=""LogConsoleAppender"" />
    </root>
    <logger name=""LogConsoleAppender"">
      <level value=""DEBUG""/>
      <appender-ref ref=""LogConsoleAppender"" />
    </logger>
    <appender name=""LogConsoleAppender""  type=""log4net.Appender.ConsoleAppender,log4net"" >
      <layout type=""log4net.Layout.PatternLayout,log4net"">
        <param name=""ConversionPattern"" value=""%date: %message%n"" />
      </layout>
    </appender>
  </log4net>
</configuration>";
                File.WriteAllText(log4netConfigFile, configString);
            }
            return log4netConfigFile;
        }

        /// <summary>
        /// 从网站上获取数据
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string GetWebString(String url)
        {
            try
            {
                var web = $"{Utility.IpWithPort.Protocal}://{Utility.IpWithPort.Ip}:{Utility.IpWithPort.Port}" + url;
                //以二进制下载数据
                byte[] byteData = new WebClient().DownloadData($"{Utility.IpWithPort.Protocal}://{Utility.IpWithPort.Ip}:{Utility.IpWithPort.Port}" + url);

                //将二进制的UTF8转换成Unicode，返回
                return Encoding.UTF8.GetString(byteData);
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return null;
            }
        }
    }

    public class IpWithPort
    {
        public string Protocal { set; get; } = "http";
        public string Ip { set; get; }
        public int Port { set; get; }
    }
}
