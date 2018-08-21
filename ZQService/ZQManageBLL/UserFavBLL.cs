using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zq.Zqdb;

namespace ZQManageBLL
{
    public class UserFavBLL
    {
        UserfavMO userFavMo = new UserfavMO("ZQBgAuthorityConn");


        public int AddUserFavInfo(string userId, string bUsrId)
        {
            //return "Hello World";
            //添加用户喜欢
            int res = -1;
            UserfavEO userFav = new UserfavEO();
            userFav.UserId = Convert.ToInt32(userId);
            userFav.OpenId = "";
            userFav.LuserId = Convert.ToInt32(bUsrId);
            userFav.LopenId = "";
            userFav.IsDel = 1;
            userFav.AddTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            res = userFavMo.Add(userFav);
            return res;
        }

        public int DelUserFavInfo(string userId, string bUsrId)
        {
            //return "Hello World";
            //取消用户喜欢
            //UPDATE userfav SET userId = @userId, openId = @openId, luserId = @luserId, lopenId = @lopenId, isDel = @isDel, addTime = @addTime WHERE userId = @OriginalUserId
            int res = -1;
            if (!string.IsNullOrEmpty(userId) && !string.IsNullOrEmpty(bUsrId))
            {
                res = userFavMo.Put(" isDel = 0 ", string.Format("userId = {0} and luserId = {1}", Convert.ToInt32(userId), Convert.ToInt32(bUsrId)));
            }
            return res;
        }

        /// <summary>
        /// 获取我喜欢的玩家列表
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<UserfavEO> GetLoveList(string userId, int pageIndex, int pageSize)
        {
            //获取我喜欢的玩家列表
            List<UserfavEO> userList = new List<UserfavEO>();
            userList = userFavMo.GetPageList(pageIndex, pageSize, string.Format("luserId = {0} and isDel = 1 ", userId), " addTime Desc");
            return userList;
        }

        /// <summary>
        /// 获取喜欢我的列表
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<UserfavEO> GetBeLoveList(string userId, int pageIndex, int pageSize)
        {
            //获取喜欢我的列表
            List<UserfavEO> userList = new List<UserfavEO>();
            userList = userFavMo.GetPageList(pageIndex, pageSize, string.Format("userId = {0} and isDel = 1", userId), " addTime Desc");
            return userList;
        }

    }
}
