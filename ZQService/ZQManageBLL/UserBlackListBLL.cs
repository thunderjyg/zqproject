using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zq.Zqdb;

namespace ZQManageBLL
{
    public class UserBlackListBLL
    {
        UserblacklistMO userBlackListMo = new UserblacklistMO("ZQBgAuthorityConn");

        /// <summary>
        /// 添加系统黑名单
        /// </summary>
        /// <param name="bleo"></param>
        /// <returns></returns>
        public int AddUserBlackList(UserblacklistEO ubeo)
        {
            return userBlackListMo.Add(ubeo);
        }

    }
}
