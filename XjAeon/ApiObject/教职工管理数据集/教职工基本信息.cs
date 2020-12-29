using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XjAeon.ApiObject.教职工管理数据集
{
    class 教职工基本信息 : IApiObject
    {
        public string Url => "/open_api/customization/tgxjgjzgjbxx/full";
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
            public string ID { get; set; }
            public string TC { get; set; }
            public string TXJJH { get; set; }
            public string LTXRYLXGL { get; set; }
            public string XQH { get; set; }
            public string YJXKM { get; set; }
            public string ZP { get; set; }
            public string JGH { get; set; }
            public string SFZJYXQ { get; set; }
            public string LKBXRQ { get; set; }
            public string TSTAMP { get; set; }
            public string TXRQ { get; set; }
            public string DQZTM { get; set; }
            public string XBM { get; set; }
            public string JSGLSC { get; set; }
            public string GRSF { get; set; }
            public string GZDH { get; set; }
            public string SFZJLXM { get; set; }
            public string JG { get; set; }
            public string XTBZ { get; set; }
            public string XKLBM { get; set; }
            public string SJBZ { get; set; }
            public string ZRJSTJ { get; set; }
            public string CZDH { get; set; }
            public string LKBXYY { get; set; }
            public string LXRQ { get; set; }
            public string DABH { get; set; }
            public string EJXKM { get; set; }
            public string JSTXH { get; set; }
            public string JRSYBZRQ { get; set; }
            public string CYM { get; set; }
            public string GJDQM { get; set; }
            public string JKZKM { get; set; }
            public string SZDWDM { get; set; }
            public string TXDZ { get; set; }
            public string LXDH { get; set; }
            public string SFZJH { get; set; }
            public string CSDM { get; set; }
            public string SHBXH { get; set; }
            public string RKZKM { get; set; }
            public string DAWB { get; set; }
            public string CSRQ { get; set; }
            public string XM { get; set; }
            public string ZZMMM { get; set; }
            public string ZGXLM { get; set; }
            public string LTXNY { get; set; }
            public string GATQWM { get; set; }
            public string BZLBM { get; set; }
            public string XYZJM { get; set; }
            public string LKBXQX { get; set; }
            public string CJNY { get; set; }
            public string CJGZNY { get; set; }
            public string GZJJH { get; set; }
            public string PQNY { get; set; }
            public string XCSZYH { get; set; }
            public string RYLYSM { get; set; }
            public string QXRQ { get; set; }
            public string DZXX { get; set; }
            public string WLDZ { get; set; }
            public string WHCDM { get; set; }
            public string RYLYM { get; set; }
            public string HYZKM { get; set; }
            public string ZGH { get; set; }
            public string JZGLBM { get; set; }
            public string HKXZ { get; set; }
            public string YJFX { get; set; }
            public string LKBXSM { get; set; }
            public string ZJGLSC { get; set; }
            public string MZM { get; set; }
            public string XXM { get; set; }
            public string YWXM { get; set; }
            public string XMPY { get; set; }
            public string SZDAMC { get; set; }
            public string XB { get; set; }
            public string MZ { get; set; }
            public string GJDQ { get; set; }
            public string SFZJLX { get; set; }
            public string ZZMM { get; set; }
            public string RYLY { get; set; }
            public string BZLB { get; set; }
            public string LKBXDYY { get; set; }
            public string JZGLB { get; set; }
            public string DQZT { get; set; }
        }

        public class Datum
        {
            public string ID { get; set; }
            public object TC { get; set; }
            public object TXJJH { get; set; }
            public object LTXRYLXGL { get; set; }
            public object XQH { get; set; }
            public object YJXKM { get; set; }
            public object ZP { get; set; }
            public string JGH { get; set; }
            public object SFZJYXQ { get; set; }
            public string LKBXRQ { get; set; }
            public string TSTAMP { get; set; }
            public object TXRQ { get; set; }
            public string DQZTM { get; set; }
            public string XBM { get; set; }
            public object JSGLSC { get; set; }
            public object GRSF { get; set; }
            public object GZDH { get; set; }
            public string SFZJLXM { get; set; }
            public object JG { get; set; }
            public object XTBZ { get; set; }
            public object XKLBM { get; set; }
            public object SJBZ { get; set; }
            public object ZRJSTJ { get; set; }
            public object CZDH { get; set; }
            public string LKBXYY { get; set; }
            public string LXRQ { get; set; }
            public object DABH { get; set; }
            public object EJXKM { get; set; }
            public object JSTXH { get; set; }
            public string JRSYBZRQ { get; set; }
            public object CYM { get; set; }
            public string GJDQM { get; set; }
            public object JKZKM { get; set; }
            public string SZDWDM { get; set; }
            public object TXDZ { get; set; }
            public string LXDH { get; set; }
            public string SFZJH { get; set; }
            public object CSDM { get; set; }
            public object SHBXH { get; set; }
            public object RKZKM { get; set; }
            public object DAWB { get; set; }
            public string CSRQ { get; set; }
            public string XM { get; set; }
            public string ZZMMM { get; set; }
            public object ZGXLM { get; set; }
            public string LTXNY { get; set; }
            public object GATQWM { get; set; }
            public string BZLBM { get; set; }
            public object XYZJM { get; set; }
            public string LKBXQX { get; set; }
            public object CJNY { get; set; }
            public string CJGZNY { get; set; }
            public string GZJJH { get; set; }
            public string PQNY { get; set; }
            public object XCSZYH { get; set; }
            public string RYLYSM { get; set; }
            public object QXRQ { get; set; }
            public object DZXX { get; set; }
            public object WLDZ { get; set; }
            public object WHCDM { get; set; }
            public object RYLYM { get; set; }
            public object HYZKM { get; set; }
            public string ZGH { get; set; }
            public string JZGLBM { get; set; }
            public object HKXZ { get; set; }
            public object YJFX { get; set; }
            public string LKBXSM { get; set; }
            public object ZJGLSC { get; set; }
            public string MZM { get; set; }
            public object XXM { get; set; }
            public object YWXM { get; set; }
            public object XMPY { get; set; }
            public string SZDAMC { get; set; }
            public string XB { get; set; }
            public string MZ { get; set; }
            public string GJDQ { get; set; }
            public string SFZJLX { get; set; }
            public string ZZMM { get; set; }
            public object RYLY { get; set; }
            public object BZLB { get; set; }
            public string LKBXDYY { get; set; }
            public string JZGLB { get; set; }
            public string DQZT { get; set; }
        }

    }
}
