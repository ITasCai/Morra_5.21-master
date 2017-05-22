using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morra_5._21
{
    /// <summary>
    /// 裁判
    /// </summary>
    class CaiPan
    {
        /// <summary>
        /// 判断是否玩家赢了
        /// </summary>
        /// <param name="playerFist">玩家</param>
        /// <param name="pcFist">计算机</param>
        /// <returns>返回结果-1表示用户输了，0表示平局， 1表示用户赢了</returns>
        public static int IsPlayerWin(int playerFist,int pcFist) {
            if (playerFist==pcFist)
            {
                return 0;
            }
            else if (playerFist-pcFist==-2||playerFist-pcFist==1)
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }
    }
}
