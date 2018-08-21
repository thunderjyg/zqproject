using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Zq.Zqdb;
using ZQManageBLL;

namespace ZQService
{
    /// <summary>
    /// SysService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://10.1.1.188/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class SysService : System.Web.Services.WebService
    {

        private SysblacklistBLL sysBlackList = new SysblacklistBLL();

        [WebMethod]
        public void AddSysBlackList(string userId)
        {
            //添加系统黑名单
            if (!string.IsNullOrEmpty(userId))
            {
                SysblacklistEO sbEo = new SysblacklistEO();
                sbEo.UserId = userId;
                sbEo.AddTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                int res = sysBlackList.AddSysBlackList(sbEo);
            }
        }
    }
}
