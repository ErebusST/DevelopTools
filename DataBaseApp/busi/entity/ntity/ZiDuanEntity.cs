using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseApp.busi.entity
{
    public class ZiDuanEntity
    {
        public string ziDuan = "";
        public string leiXing = "";
        public string zhongWenMiaoShu = "";
        public ZiDuanEntity(string ziDuan, string leiXing, string zhongWenMiaoShu)
        {
            this.ziDuan = ziDuan;
            this.zhongWenMiaoShu = zhongWenMiaoShu;
            switch (leiXing.Substring(0, 3))
            {
                case "big":
                    this.leiXing = "Integer";
                    break;
                case "var":
                    this.leiXing = "String";
                    break;
                case "dec":
                    this.leiXing = "BigDecimal";
                    break;
                case "int":
                    this.leiXing = "Integer";
                    break;
                case "tex":
                    this.leiXing = "String";
                    break;
                case "bit":
                    this.leiXing = "boolean";
                    break;
                case "<Un":
                    this.leiXing = "String";
                    break;
                case "dat":
                    this.leiXing = "Timestamp";
                    break;
            }            
            if (String.IsNullOrEmpty(this.leiXing))
            {
                throw new Exception();
            }
        }
    }
}
