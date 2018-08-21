using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ZQService
{
    /// <summary>
    /// UserPhotoServices 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class UserPhotoServices : System.Web.Services.WebService
    {

        [WebMethod]
        public void UploadUserPhoto(string userId,string fileName)
        {
            //return "Hello World";
            //用户上传一张照片
        }

        [WebMethod]
        public void DeleteUserPhoto(string userId, string fileName)
        {
            //return "Hello World";
            //用户删除一张照片
        }
    }
}
