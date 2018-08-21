using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TinyFx.Net.Json;
using TinyFx.Net.Json.Linq;
using Zq.Zqdb;
using ZQManageBLL;
using ZQService.Utility;

namespace ZQService
{
    /// <summary>
    /// UserServices 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://10.1.1.188/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class UserServices : System.Web.Services.WebService
    {
        private UserInfoBLL userInfoBLL = new UserInfoBLL();
        private UserFavBLL userFavBLL = new UserFavBLL();
        private string appid = "wx9207024b30ecb829";
        private string appsecret = "f8e49e7f96895c75581b276d261c4d18";


        [WebMethod]
        public string HelloWorld()
        {
            return "{\"result\":\"success\"}";
        }


        [WebMethod(MessageName = "FirstRegister")]
        public string UserRegister(string userId,
                                string openId,
                                string nickName = null,
                                string realName = null,
                                string sex = null,
                                string country = null,
                                string province = null,
                                string city = null,
                                string headImgUrl = null,
                                string isParent = null,
                                string phone = null,
                                string career = null,
                                string height = null,
                                string birthday = null,
                                string girlOrBoyFriend = null,
                                string shape = null,
                                string education = null,
                                string dirnk = null,
                                string smoke = null,
                                string marriage = null,
                                string salary = null,
                                string car = null,
                                string house = null,
                                string children = null)
        {
            UserinfoEO userEo = new UserinfoEO();
            userEo.UserId = Convert.ToUInt32(userId);
            userEo.OpenId = openId;
            userEo.NickName = nickName;
            userEo.RealName = realName;
            userEo.Sex = string.IsNullOrEmpty(sex) ? 0 : Convert.ToInt32(sex);
            userEo.IdCard = "";
            userEo.Country = country;
            userEo.Province = province;
            userEo.City = city;
            userEo.HeadImgUrl = headImgUrl;
            userEo.IsParent = string.IsNullOrEmpty(isParent) ? 0 : Convert.ToInt32(isParent);
            userEo.Phone = phone;
            userEo.IsNew = 0;
            userEo.IsVip = 0;
            userEo.VipId = "-1";
            userEo.IsHighLevel = 0;
            userEo.CoverImg = "-1";
            userEo.Career = career;
            userEo.LoveCount = 0;
            userEo.Feature = "";
            userEo.AddTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            userEo.IsForbiden = 0;
            userEo.Height = height;
            userEo.Birthday = birthday;
            userEo.GirlOrBoyFriend = string.IsNullOrEmpty(girlOrBoyFriend) ? 0 : Convert.ToInt32(girlOrBoyFriend);
            userEo.Shape = string.IsNullOrEmpty(shape) ? 0 : Convert.ToInt32(shape);
            userEo.Education = string.IsNullOrEmpty(education) ? 0 : Convert.ToInt32(education);
            userEo.Dirnk = string.IsNullOrEmpty(dirnk) ? 0 : Convert.ToInt32(dirnk);
            userEo.Smoke = string.IsNullOrEmpty(smoke) ? 0 : Convert.ToInt32(smoke);
            userEo.Marriage = string.IsNullOrEmpty(marriage) ? 0 : Convert.ToInt32(marriage);
            userEo.Salary = salary;
            userEo.Car = car;
            userEo.House = house;
            userEo.Children = string.IsNullOrEmpty(children) ? 0 : Convert.ToInt32(children);
            userEo.Household = "";
            userEo.Settle = "";

            int res = -1;
            if (userEo != null)
            {
                res = userInfoBLL.RegisetUser(userEo);
            }
            string json = JsonConvert.SerializeObject(res);
            return json;
        }

        [WebMethod]
        public string TestStr(string userId, string openId)
        {
            string endStr = string.Format("{0}-{1}", userId, openId);
            return endStr;
        }


        [WebMethod(MessageName = "SecondRegister")]
        public string UserRegister(string userId,
                         string openId,
                         string nickName = null,
                         string realName = null,
                         string sex = null,
                         string country = null,
                         string province = null,
                         string city = null,
                         string headImgUrl = null,
                         string isParent = null,
                         string phone = null,
                         string coverImg = null,
                         string career = null,
                         string feature = null,
                         string height = null,
                         string birthday = null,
                         string girlOrBoyFriend = null,
                         string shape = null,
                         string education = null,
                         string dirnk = null,
                         string smoke = null,
                         string marriage = null,
                         string salary = null,
                         string car = null,
                         string house = null,
                         string children = null,
                         string household = null,
                         string settle = null)
        {
            UserinfoEO userEo = new UserinfoEO();
            userEo.UserId = Convert.ToUInt32(userId);
            userEo.OpenId = openId;
            userEo.NickName = string.IsNullOrEmpty(nickName) ? "" : nickName;
            userEo.RealName = string.IsNullOrEmpty(realName) ? "" : realName;
            userEo.Sex = string.IsNullOrEmpty(sex) ? 0 : Convert.ToInt32(sex);
            userEo.IdCard = "";
            userEo.Country = string.IsNullOrEmpty(country) ? "" : country;
            userEo.Province = string.IsNullOrEmpty(province) ? "" : province;
            userEo.City = string.IsNullOrEmpty(city) ? "" : city;
            userEo.HeadImgUrl = string.IsNullOrEmpty(headImgUrl) ? "" : headImgUrl;
            userEo.IsParent = string.IsNullOrEmpty(isParent) ? 0 : Convert.ToInt32(isParent);
            userEo.Phone = string.IsNullOrEmpty(phone) ? "" : phone;
            userEo.IsNew = 0;
            userEo.IsVip = 0;
            userEo.VipId = "";
            userEo.IsHighLevel = 0;
            userEo.CoverImg = string.IsNullOrEmpty(coverImg) ? "" : coverImg;
            userEo.Career = string.IsNullOrEmpty(career) ? "" : career;
            userEo.LoveCount = 0;
            userEo.Feature = string.IsNullOrEmpty(feature) ? "" : feature;
            userEo.AddTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            userEo.IsForbiden = 0;
            userEo.Height = string.IsNullOrEmpty(height) ? "" : height;
            userEo.Birthday = string.IsNullOrEmpty(birthday) ? "" : birthday;
            userEo.GirlOrBoyFriend = string.IsNullOrEmpty(girlOrBoyFriend) ? 0 : Convert.ToInt32(girlOrBoyFriend);
            userEo.Shape = string.IsNullOrEmpty(shape) ? 0 : Convert.ToInt32(shape);
            userEo.Education = string.IsNullOrEmpty(education) ? 0 : Convert.ToInt32(education);
            userEo.Dirnk = string.IsNullOrEmpty(dirnk) ? 0 : Convert.ToInt32(dirnk);
            userEo.Smoke = string.IsNullOrEmpty(smoke) ? 0 : Convert.ToInt32(smoke);
            userEo.Marriage = string.IsNullOrEmpty(marriage) ? 0 : Convert.ToInt32(marriage);
            userEo.Salary = string.IsNullOrEmpty(salary) ? "" : salary;
            userEo.Car = string.IsNullOrEmpty(car) ? "" : car;
            userEo.House = string.IsNullOrEmpty(house) ? "" : house;
            userEo.Children = string.IsNullOrEmpty(children) ? 0 : Convert.ToInt32(children);
            userEo.Household = string.IsNullOrEmpty(household) ? "" : household;
            userEo.Settle = string.IsNullOrEmpty(settle) ? "" : settle;

            int res = -1;
            if (userEo != null)
            {
                res = userInfoBLL.RegisetUser(userEo);
            }
            string json = JsonConvert.SerializeObject(res);
            return json;
        }


        [WebMethod(MessageName = "ThridRegister")]
        public string UserRegister(string dataStr)
        {
            //转为json对象
            JObject jo = (JObject)JsonConvert.DeserializeObject(dataStr);
            UserinfoEO userEo = new UserinfoEO();

            userEo.UserId = Convert.ToUInt32(jo["userId"].ToString());
            userEo.OpenId = jo["openId"].ToString();
            userEo.NickName = jo["nickName"].ToString();
            userEo.RealName = jo["realName"].ToString();
            userEo.Sex = string.IsNullOrEmpty(jo["sex"].ToString()) ? 0 : Convert.ToInt32(jo["sex"].ToString());
            userEo.IdCard = jo["idCard"].ToString();
            userEo.Country = jo["country"].ToString();
            userEo.Province = jo["province"].ToString();
            userEo.City = jo["city"].ToString();
            userEo.HeadImgUrl = jo["headImgUrl"].ToString();
            userEo.IsParent = string.IsNullOrEmpty(jo["isParent"].ToString()) ? 0 : Convert.ToInt32(jo["isParent"].ToString());
            userEo.Phone = jo["phone"].ToString();
            userEo.IsNew = string.IsNullOrEmpty(jo["isNew"].ToString()) ? 0 : Convert.ToInt32(jo["isNew"].ToString());
            userEo.IsVip = string.IsNullOrEmpty(jo["isVip"].ToString()) ? 0 : Convert.ToInt32(jo["isVip"].ToString()); ;
            userEo.VipId = jo["vipId"].ToString();
            userEo.IsHighLevel = string.IsNullOrEmpty(jo["isHighLevel"].ToString()) ? 0 : Convert.ToInt32(jo["isHighLevel"].ToString());
            userEo.CoverImg = jo["coverImg"].ToString();
            userEo.Career = jo["career"].ToString();
            userEo.LoveCount = string.IsNullOrEmpty(jo["loveCount"].ToString()) ? 0 : Convert.ToInt32(jo["loveCount"].ToString());
            userEo.Feature = jo["feature"].ToString();
            userEo.AddTime = jo["addTime"].ToString();
            userEo.IsForbiden = string.IsNullOrEmpty(jo["isForbiden"].ToString()) ? 0 : Convert.ToInt32(jo["isForbiden"].ToString());
            userEo.Height = jo["height"].ToString();
            userEo.Birthday = jo["birthday"].ToString();
            userEo.GirlOrBoyFriend = string.IsNullOrEmpty(jo["girlOrBoyFriend"].ToString()) ? 0 : Convert.ToInt32(jo["girlOrBoyFriend"].ToString());
            userEo.Shape = string.IsNullOrEmpty(jo["shape"].ToString()) ? 0 : Convert.ToInt32(jo["shape"].ToString());
            userEo.Education = string.IsNullOrEmpty(jo["education"].ToString()) ? 0 : Convert.ToInt32(jo["education"].ToString());
            userEo.Dirnk = string.IsNullOrEmpty(jo["dirnk"].ToString()) ? 0 : Convert.ToInt32(jo["dirnk"].ToString());
            userEo.Smoke = string.IsNullOrEmpty(jo["smoke"].ToString()) ? 0 : Convert.ToInt32(jo["smoke"].ToString());
            userEo.Marriage = string.IsNullOrEmpty(jo["marriage"].ToString()) ? 0 : Convert.ToInt32(jo["marriage"].ToString());
            userEo.Salary = jo["salary"].ToString();
            userEo.Car = jo["car"].ToString();
            userEo.House = jo["house"].ToString();
            userEo.Children = string.IsNullOrEmpty(jo["children"].ToString()) ? 0 : Convert.ToInt32(jo["children"].ToString());
            userEo.Household = string.IsNullOrEmpty(jo["household"].ToString()) ? "" : jo["household"].ToString();
            userEo.Settle = string.IsNullOrEmpty(jo["settle"].ToString()) ? "" : jo["settle"].ToString();

            int res = -1;
            if (userEo != null)
            {
                res = userInfoBLL.RegisetUser(userEo);
            }
            string json = JsonConvert.SerializeObject(res);
            return json;
        }

        [WebMethod]
        public void StartOauth(string userId)
        {
            //开始微信验证
        }
        #region 微信验证过程
        //生成OAuth2的URL
        private string oauth2_authorize(string redirect_url, string scope, string state = null)
        {
            //"https://open.weixin.qq.com/connect/oauth2/authorize?appid=".$this->appid."&redirect_uri=".$redirect_url."&response_type=code&scope=".$scope."&state=".$state."#wechat_redirect";
            string url = string.Format("https://open.weixin.qq.com/connect/oauth2/authorize?appid={0}&redirect_uri={1}&response_type=code&scope={2}&state={3}#wechat_redirect", appid, redirect_url, scope, state);
            return url;
        }

        //生成OAuth2的Access Token
        private string oauth2_access_token(string code)
        {
            //"https://api.weixin.qq.com/sns/oauth2/access_token?appid=".$this->appid."&secret=".$this->appsecret."&code=".$code."&grant_type=authorization_code";
            string url = string.Format("https://api.weixin.qq.com/sns/oauth2/access_token?appid={0}&secret={1}&code={2}&grant_type=authorization_code", appid, appsecret, code);
            string res = HttpClientUlity.Post(url, "");
            return res;
        }

        //获取用户基本信息（OAuth2 授权的 Access Token 获取 未关注用户，Access Token为临时获取）
        private string oauth2_get_user_info(string access_token, string openid)
        {
            //"https://api.weixin.qq.com/sns/userinfo?access_token=".$access_token."&openid=".$openid."&lang=zh_CN";
            string url = string.Format("https://api.weixin.qq.com/sns/userinfo?access_token={0}&openid={1}&lang=zh_CN", access_token, openid);
            string res = HttpClientUlity.Post(url, "");
            return res;
        }

        //获取用户基本信息
        private string get_user_info(string openid)
        {
            //"https://api.weixin.qq.com/cgi-bin/user/info?access_token=".$this->access_token."&openid=".$openid."&lang=zh_CN";
            string url = string.Format("https://api.weixin.qq.com/cgi-bin/user/info?access_token={0}&openid={1}", "", openid);
            string res = HttpClientUlity.Post(url, "");
            return res;
        }
        #endregion

        [WebMethod]
        public void UpdateUserSex(string userId, string userSex)
        {
            //更新玩家性别信息
            int res = -1;
            if (!string.IsNullOrEmpty(userId))
            {
                res = userInfoBLL.UpdateUserSex(userId, userSex);
            }
            string json = JsonConvert.SerializeObject(res);
            Context.Response.Write(json);
            Context.Response.End();
        }

        [WebMethod]
        public void UpdateUserPhone(string userId, string phone)
        {
            //更新玩家性别手机
            int res = -1;
            if (string.IsNullOrEmpty(userId))
            {
                res = userInfoBLL.UpdateUserPhone(userId, phone);
            }
            string json = JsonConvert.SerializeObject(res);
            Context.Response.Write(json);
            Context.Response.End();
        }

        [WebMethod]
        public void UpdateUserBirthDay(string userId, string userBirthday)
        {
            //更新玩家生日信息
            int res = -1;
            if (string.IsNullOrEmpty(userId))
            {
                res = userInfoBLL.UpdateUserBirthDay(userId, userBirthday);
            }
            string json = JsonConvert.SerializeObject(res);
            Context.Response.Write(json);
            Context.Response.End();
        }

        [WebMethod]
        public void GetLoveList(string userId, int pageIndex = 1, int pageSize = 10)
        {
            //获取我喜欢的玩家列表
            if (!string.IsNullOrEmpty(userId))
            {
                List<UserfavEO> userList = userFavBLL.GetLoveList(userId, pageIndex, pageSize);
                if (userList != null)
                {
                    string json = JsonConvert.SerializeObject(userList);
                    Context.Response.Write(json);
                    Context.Response.End();
                }
            }
        }

        [WebMethod]
        public void GetBeLoveList(string userId, int pageIndex = 1, int pageSize = 10)
        {
            //获取喜欢我的列表
            if (!string.IsNullOrEmpty(userId))
            {
                List<UserfavEO> userList = userFavBLL.GetBeLoveList(userId, pageIndex, pageSize);
                if (userList != null)
                {
                    string json = JsonConvert.SerializeObject(userList);
                    Context.Response.Write(json);
                    Context.Response.End();
                }
            }
        }

        [WebMethod]
        public void UpdateUserCount(string userId)
        {
            //更新用户免费次数
            if (!string.IsNullOrEmpty(userId))
            {

            }
        }


        [WebMethod]
        public void GetRecommandList(string userId, string userSex = null)
        {
            //查看每天推荐列表
            if (!string.IsNullOrEmpty(userId))
            {

            }
        }

        [WebMethod]
        public void GetUserInfoDetail(string userId)
        {
            //获取玩家详细信息
            if (!string.IsNullOrEmpty(userId))
            {
                UserinfoEO userInfoDetail = userInfoBLL.GetUserInfoDetail(userId);
                if (userInfoDetail != null)
                {
                    string json = JsonConvert.SerializeObject(userInfoDetail);
                    Context.Response.Write(json);
                    Context.Response.End();
                }
            }
        }


        [WebMethod]
        public void TestUrl()
        {
            Context.Response.Redirect("http://www.baidu.com");
        }

        [WebMethod]
        public void AddUserBlackList(string userId)
        {
            //添加用户黑名单
            if (!string.IsNullOrEmpty(userId))
            {

            }
        }

    }
}
