using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morra_5._21
{
/// <summary>
/// 玩家类
/// </summary>
    class Player
    {
        //用来保存用户的出拳结果
        private string Fist;

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
        /// 假设 剪刀：1      石头：2    布：3
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int ShowFist(string name) {
            this.Fist = name;
            switch (name)
            {     
                case "剪刀":
                    return 1;
                case "石头":
                    return 2;
                case "布":
                    return 3;
                default:
                    throw new ArgumentException("参数异常");
            }
        }
    }
}
