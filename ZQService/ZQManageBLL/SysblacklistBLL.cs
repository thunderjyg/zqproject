using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zq.Zqdb;

namespace ZQManageBLL
{
    public class SysblacklistBLL
    {
        SysblacklistMO sysBlackListMo = new SysblacklistMO("ZQBgAuthorityConn");

        /// <summary>
        /// 添加系统黑名单
        /// </summary>
        /// <param name="bleo"></param>
        /// <returns></returns>
        public int AddSysBlackList(SysblacklistEO bleo)
        {
            return sysBlackListMo.Add(bleo);
        }

    }
}
