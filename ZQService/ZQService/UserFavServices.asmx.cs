using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TinyFx.Net.Json;
using ZQManageBLL;

namespace ZQService
{
    /// <summary>
    /// UserFavServices 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class UserFavServices : System.Web.Services.WebService
    {

        private UserFavBLL userFavBLL = new UserFavBLL();

        [WebMethod]
        public void AddUserFavInfo(string userId, string bUsrId)
        {
            //return "Hello World";
            //添加用户喜欢
            int res = userFavBLL.AddUserFavInfo(userId, bUsrId);
            string json = JsonConvert.SerializeObject(res);
            Context.Response.Write(json);
            Context.Response.End();
        }

        [WebMethod]
        public void DelUserFavInfo(string userId, string bUsrId)
        {
            //return "Hello World";
            //取消用户喜欢
            int res = userFavBLL.DelUserFavInfo(userId, bUsrId);
            string json = JsonConvert.SerializeObject(res);
            Context.Response.Write(json);
            Context.Response.End();
        }
    }
}
