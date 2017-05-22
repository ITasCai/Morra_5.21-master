using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morra_5._21
{
    /// <summary>
    /// 计算机
    /// </summary>
    class PC
    {
        //用来保存出拳结果
        private String Fist;
    public string Fist1
        {
            get
            {
                return Fist;
            }

            set
            {
                Fist = value;
            }
        }
        /// <summary>
        /// 剪刀：1      石头：2    布：
        /// </summary>
        /// <returns></returns>
        public int ShowFist() {
            Random rdn = new Random();
            int n = rdn.Next(1,4);
            switch (n)
            {
                case 1:
                    this.Fist = "剪刀";
                    break;
                case 2:
                    this.Fist = "石头";
                    break;
                case 3:
                    this.Fist = "布";
                    break;

            }
            return n;
        }
    }
}
