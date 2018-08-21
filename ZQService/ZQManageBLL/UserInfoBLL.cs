using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Data;
using Zq.Zqdb;

namespace ZQManageBLL
{
    public class UserInfoBLL
    {
        UserinfoMO userInfoMo = new UserinfoMO("ZQBgAuthorityConn");

        /// <summary>
        /// 用户信息注册
        /// </summary>
        /// <param name="userEo"></param>
        /// <returns></returns>
        public int RegisetUser(UserinfoEO userEo)
        {
            if (userEo != null)
            {
                return userInfoMo.Add(userEo);
            }
            return -1;
        }

        /// <summary>
        /// 用户信息注册
        /// </summary>
        /// <param name="userEo"></param>
        /// <returns></returns>
        public int UpdateUserSex(string userId, string userSex)
        {
            if (!string.IsNullOrEmpty(userId))
            {
                return userInfoMo.PutSexByPK(Convert.ToUInt32(userId), Convert.ToInt32(userSex));
            }
            return -1;
        }

        /// <summary>
        /// 更新玩家性别手机
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        public int UpdateUserPhone(string userId, string phone)
        {
            //更新玩家性别手机
            if (!string.IsNullOrEmpty(userId))
            {
                return userInfoMo.PutPhoneByPK(Convert.ToUInt32(userId), phone);
            }
            return -1;
        }

        /// <summary>
        /// 更新玩家生日信息
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userBirthday"></param>
        /// <returns></returns>
        public int UpdateUserBirthDay(string userId, string userBirthday)
        {
            //更新玩家生日信息
            if (!string.IsNullOrEmpty(userId))
            {
                return userInfoMo.PutBirthdayByPK(Convert.ToUInt32(userId), userBirthday);
            }
            return -1;
        }

        /// <summary>
        /// 更新用户免费次数
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public int UpdateUserCount(string userId,string userCount)
        {
            //更新用户免费次数
            if (!string.IsNullOrEmpty(userId))
            {
                //return userInfoMo.(Convert.ToUInt32(userId), userBirthday);
            }
            return -1;
        }

        /// <summary>
        /// 查看每天推荐列表
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="userSex"></param>
        /// <returns></returns>
        public int GetRecommandList(string userId, string userSex = null)
        {
            //查看每天推荐列表
            return -1;
        }

        /// <summary>
        /// 获取玩家详细信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UserinfoEO GetUserInfoDetail(string userId)
        {
            //获取玩家详细信息
            IEnumerable<UserinfoEO> userInfoList = userInfoMo.Get(string.Format("userId={0}", userId));
            return userInfoList.First();
        }

    }
}
