//==========================================================
// 此代码由代码生成器工具自动生成，请不要修改
// 代码生成器核心库版本号：2.0
// 创建时间：2018/8/7 11:44:36
//==========================================================

using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Xml;
using TinyFx.Common;
using TinyFx.Data;

namespace Zq.Zqdb
{
	#region EO

	/// <summary>
	/// 【表 userinfo 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class UserinfoEO : DataEntityBase, IRowMapper<UserinfoEO>
	{
		protected uint _originalUserId;

		/// <summary>
		/// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
		/// </summary>
		public bool HasOriginal { get; protected set; }

		/// <summary>
		/// 【主键 int】
		/// </summary>
		public virtual uint UserId { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual uint OriginalUserId
		{
			get { return _originalUserId; }
			set { HasOriginal = true; _originalUserId = value; }
		}

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string OpenId { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string NickName { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string RealName { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? Sex { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string IdCard { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Country { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Province { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string City { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string HeadImgUrl { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? IsParent { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Phone { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? IsNew { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? IsVip { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string VipId { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? IsHighLevel { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string CoverImg { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Career { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? LoveCount { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Feature { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string AddTime { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? IsForbiden { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Height { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Birthday { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? GirlOrBoyFriend { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? Shape { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? Education { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? Dirnk { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? Smoke { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? Marriage { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Salary { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Car { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string House { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? Children { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Household { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string Settle { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public UserinfoEO() 
		{
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "openId"></param>
		/// <param name = "nickName"></param>
		/// <param name = "realName"></param>
		/// <param name = "sex"></param>
		/// <param name = "idCard"></param>
		/// <param name = "country"></param>
		/// <param name = "province"></param>
		/// <param name = "city"></param>
		/// <param name = "headImgUrl"></param>
		/// <param name = "isParent"></param>
		/// <param name = "phone"></param>
		/// <param name = "isNew"></param>
		/// <param name = "isVip"></param>
		/// <param name = "vipId"></param>
		/// <param name = "isHighLevel"></param>
		/// <param name = "coverImg"></param>
		/// <param name = "career"></param>
		/// <param name = "loveCount"></param>
		/// <param name = "feature"></param>
		/// <param name = "addTime"></param>
		/// <param name = "isForbiden"></param>
		/// <param name = "height"></param>
		/// <param name = "birthday"></param>
		/// <param name = "girlOrBoyFriend"></param>
		/// <param name = "shape"></param>
		/// <param name = "education"></param>
		/// <param name = "dirnk"></param>
		/// <param name = "smoke"></param>
		/// <param name = "marriage"></param>
		/// <param name = "salary"></param>
		/// <param name = "car"></param>
		/// <param name = "house"></param>
		/// <param name = "children"></param>
		/// <param name = "household"></param>
		/// <param name = "settle"></param>
		public UserinfoEO(uint userId, string openId, string nickName, string realName, int? sex, string idCard, string country, string province, string city, string headImgUrl, int? isParent, string phone, int? isNew, int? isVip, string vipId, int? isHighLevel, string coverImg, string career, int? loveCount, string feature, string addTime, int? isForbiden, string height, string birthday, int? girlOrBoyFriend, int? shape, int? education, int? dirnk, int? smoke, int? marriage, string salary, string car, string house, int? children, string household, string settle) 
		{
			UserId = userId;
			OpenId = openId;
			NickName = nickName;
			RealName = realName;
			Sex = sex;
			IdCard = idCard;
			Country = country;
			Province = province;
			City = city;
			HeadImgUrl = headImgUrl;
			IsParent = isParent;
			Phone = phone;
			IsNew = isNew;
			IsVip = isVip;
			VipId = vipId;
			IsHighLevel = isHighLevel;
			CoverImg = coverImg;
			Career = career;
			LoveCount = loveCount;
			Feature = feature;
			AddTime = addTime;
			IsForbiden = isForbiden;
			Height = height;
			Birthday = birthday;
			GirlOrBoyFriend = girlOrBoyFriend;
			Shape = shape;
			Education = education;
			Dirnk = dirnk;
			Smoke = smoke;
			Marriage = marriage;
			Salary = salary;
			Car = car;
			House = house;
			Children = children;
			Household = household;
			Settle = settle;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public UserinfoEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static UserinfoEO GetItem(IDataReader reader)
		{
			UserinfoEO ret = new UserinfoEO();

			ret.UserId = uint.Parse(reader["userId"].ToString());
			ret.OriginalUserId = ret.UserId;
			ret.OpenId = (reader["openId"] is DBNull) ? null : (string)reader["openId"];
			ret.NickName = (reader["nickName"] is DBNull) ? null : (string)reader["nickName"];
			ret.RealName = (reader["realName"] is DBNull) ? null : (string)reader["realName"];
			ret.Sex = (reader["sex"] is DBNull) ? (int?)null : int.Parse(reader["sex"].ToString());
			ret.IdCard = (reader["idCard"] is DBNull) ? null : (string)reader["idCard"];
			ret.Country = (reader["country"] is DBNull) ? null : (string)reader["country"];
			ret.Province = (reader["province"] is DBNull) ? null : (string)reader["province"];
			ret.City = (reader["city"] is DBNull) ? null : (string)reader["city"];
			ret.HeadImgUrl = (reader["headImgUrl"] is DBNull) ? null : (string)reader["headImgUrl"];
			ret.IsParent = (reader["isParent"] is DBNull) ? (int?)null : int.Parse(reader["isParent"].ToString());
			ret.Phone = (reader["phone"] is DBNull) ? null : (string)reader["phone"];
			ret.IsNew = (reader["isNew"] is DBNull) ? (int?)null : int.Parse(reader["isNew"].ToString());
			ret.IsVip = (reader["isVip"] is DBNull) ? (int?)null : int.Parse(reader["isVip"].ToString());
			ret.VipId = (reader["vipId"] is DBNull) ? null : (string)reader["vipId"];
			ret.IsHighLevel = (reader["isHighLevel"] is DBNull) ? (int?)null : int.Parse(reader["isHighLevel"].ToString());
			ret.CoverImg = (reader["coverImg"] is DBNull) ? null : (string)reader["coverImg"];
			ret.Career = (reader["career"] is DBNull) ? null : (string)reader["career"];
			ret.LoveCount = (reader["loveCount"] is DBNull) ? (int?)null : int.Parse(reader["loveCount"].ToString());
			ret.Feature = (reader["feature"] is DBNull) ? null : (string)reader["feature"];
			ret.AddTime = (reader["addTime"] is DBNull) ? null : (string)reader["addTime"];
			ret.IsForbiden = (reader["isForbiden"] is DBNull) ? (int?)null : int.Parse(reader["isForbiden"].ToString());
			ret.Height = (reader["height"] is DBNull) ? null : (string)reader["height"];
			ret.Birthday = (reader["birthday"] is DBNull) ? null : (string)reader["birthday"];
			ret.GirlOrBoyFriend = (reader["girlOrBoyFriend"] is DBNull) ? (int?)null : int.Parse(reader["girlOrBoyFriend"].ToString());
			ret.Shape = (reader["shape"] is DBNull) ? (int?)null : int.Parse(reader["shape"].ToString());
			ret.Education = (reader["education"] is DBNull) ? (int?)null : int.Parse(reader["education"].ToString());
			ret.Dirnk = (reader["dirnk"] is DBNull) ? (int?)null : int.Parse(reader["dirnk"].ToString());
			ret.Smoke = (reader["smoke"] is DBNull) ? (int?)null : int.Parse(reader["smoke"].ToString());
			ret.Marriage = (reader["marriage"] is DBNull) ? (int?)null : int.Parse(reader["marriage"].ToString());
			ret.Salary = (reader["salary"] is DBNull) ? null : (string)reader["salary"];
			ret.Car = (reader["car"] is DBNull) ? null : (string)reader["car"];
			ret.House = (reader["house"] is DBNull) ? null : (string)reader["house"];
			ret.Children = (reader["children"] is DBNull) ? (int?)null : int.Parse(reader["children"].ToString());
			ret.Household = (reader["household"] is DBNull) ? null : (string)reader["household"];
			ret.Settle = (reader["settle"] is DBNull) ? null : (string)reader["settle"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 userinfo 的操作类】
	/// </summary>
	public class UserinfoMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public UserinfoMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public UserinfoMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "userId"></param>
		/// <return></return>
		public virtual UserinfoEO GetByPK(uint userId, TransactionManager tm = null)
		{
			const string sql = @"SELECT userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE userId=@userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.ExecSingle<UserinfoEO>(UserinfoEO.GetItem, tm);
		}




		#region  按 OpenId（字段） 查询

		/// <summary>
		/// 按 OpenId（字段） 查询
		/// </summary>
		/// <param name = "openId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByOpenId(string openId)
		{
			return GetByOpenId(openId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 OpenId（字段） 查询
		/// </summary>
		/// <param name = "openId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByOpenId(string openId, TransactionManager tm)
		{
			return GetByOpenId(openId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 OpenId（字段） 查询
		/// </summary>
		/// <param name = "openId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByOpenId(string openId, int top)
		{
			return GetByOpenId(openId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 OpenId（字段） 查询
		/// </summary>
		/// <param name = "openId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByOpenId(string openId, int top, TransactionManager tm)
		{
			return GetByOpenId(openId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 OpenId（字段） 查询
		/// </summary>
		/// <param name = "openId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByOpenId(string openId, string sort)
		{
			return GetByOpenId(openId, 0, sort, null);
		}

		/// <summary>
		/// 按 OpenId（字段） 查询
		/// </summary>
		/// <param name = "openId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByOpenId(string openId, string sort, TransactionManager tm)
		{
			return GetByOpenId(openId, 0, sort, tm);
		}

		/// <summary>
		/// 按 OpenId（字段） 查询
		/// </summary>
		/// <param name = "openId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByOpenId(string openId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE openId=@OpenId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@OpenId", openId, DbType.String, 300)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 NickName（字段） 查询

		/// <summary>
		/// 按 NickName（字段） 查询
		/// </summary>
		/// <param name = "nickName"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByNickName(string nickName)
		{
			return GetByNickName(nickName, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 NickName（字段） 查询
		/// </summary>
		/// <param name = "nickName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByNickName(string nickName, TransactionManager tm)
		{
			return GetByNickName(nickName, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 NickName（字段） 查询
		/// </summary>
		/// <param name = "nickName"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByNickName(string nickName, int top)
		{
			return GetByNickName(nickName, top, string.Empty, null);
		}

		/// <summary>
		/// 按 NickName（字段） 查询
		/// </summary>
		/// <param name = "nickName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByNickName(string nickName, int top, TransactionManager tm)
		{
			return GetByNickName(nickName, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 NickName（字段） 查询
		/// </summary>
		/// <param name = "nickName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByNickName(string nickName, string sort)
		{
			return GetByNickName(nickName, 0, sort, null);
		}

		/// <summary>
		/// 按 NickName（字段） 查询
		/// </summary>
		/// <param name = "nickName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByNickName(string nickName, string sort, TransactionManager tm)
		{
			return GetByNickName(nickName, 0, sort, tm);
		}

		/// <summary>
		/// 按 NickName（字段） 查询
		/// </summary>
		/// <param name = "nickName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByNickName(string nickName, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE nickName=@NickName";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@NickName", nickName, DbType.String, 150)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 RealName（字段） 查询

		/// <summary>
		/// 按 RealName（字段） 查询
		/// </summary>
		/// <param name = "realName"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByRealName(string realName)
		{
			return GetByRealName(realName, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 RealName（字段） 查询
		/// </summary>
		/// <param name = "realName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByRealName(string realName, TransactionManager tm)
		{
			return GetByRealName(realName, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 RealName（字段） 查询
		/// </summary>
		/// <param name = "realName"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByRealName(string realName, int top)
		{
			return GetByRealName(realName, top, string.Empty, null);
		}

		/// <summary>
		/// 按 RealName（字段） 查询
		/// </summary>
		/// <param name = "realName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByRealName(string realName, int top, TransactionManager tm)
		{
			return GetByRealName(realName, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 RealName（字段） 查询
		/// </summary>
		/// <param name = "realName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByRealName(string realName, string sort)
		{
			return GetByRealName(realName, 0, sort, null);
		}

		/// <summary>
		/// 按 RealName（字段） 查询
		/// </summary>
		/// <param name = "realName"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByRealName(string realName, string sort, TransactionManager tm)
		{
			return GetByRealName(realName, 0, sort, tm);
		}

		/// <summary>
		/// 按 RealName（字段） 查询
		/// </summary>
		/// <param name = "realName"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByRealName(string realName, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE realName=@RealName";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@RealName", realName, DbType.String, 150)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 Sex（字段） 查询

		/// <summary>
		/// 按 Sex（字段） 查询
		/// </summary>
		/// <param name = "sex"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySex(int? sex)
		{
			return GetBySex(sex, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Sex（字段） 查询
		/// </summary>
		/// <param name = "sex"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySex(int? sex, TransactionManager tm)
		{
			return GetBySex(sex, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Sex（字段） 查询
		/// </summary>
		/// <param name = "sex"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySex(int? sex, int top)
		{
			return GetBySex(sex, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Sex（字段） 查询
		/// </summary>
		/// <param name = "sex"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySex(int? sex, int top, TransactionManager tm)
		{
			return GetBySex(sex, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Sex（字段） 查询
		/// </summary>
		/// <param name = "sex"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySex(int? sex, string sort)
		{
			return GetBySex(sex, 0, sort, null);
		}

		/// <summary>
		/// 按 Sex（字段） 查询
		/// </summary>
		/// <param name = "sex"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySex(int? sex, string sort, TransactionManager tm)
		{
			return GetBySex(sex, 0, sort, tm);
		}

		/// <summary>
		/// 按 Sex（字段） 查询
		/// </summary>
		/// <param name = "sex"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySex(int? sex, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE sex=@Sex";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Sex", sex, DbType.Int32, 0)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 IdCard（字段） 查询

		/// <summary>
		/// 按 IdCard（字段） 查询
		/// </summary>
		/// <param name = "idCard"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIdCard(string idCard)
		{
			return GetByIdCard(idCard, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 IdCard（字段） 查询
		/// </summary>
		/// <param name = "idCard"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIdCard(string idCard, TransactionManager tm)
		{
			return GetByIdCard(idCard, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 IdCard（字段） 查询
		/// </summary>
		/// <param name = "idCard"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIdCard(string idCard, int top)
		{
			return GetByIdCard(idCard, top, string.Empty, null);
		}

		/// <summary>
		/// 按 IdCard（字段） 查询
		/// </summary>
		/// <param name = "idCard"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIdCard(string idCard, int top, TransactionManager tm)
		{
			return GetByIdCard(idCard, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 IdCard（字段） 查询
		/// </summary>
		/// <param name = "idCard"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIdCard(string idCard, string sort)
		{
			return GetByIdCard(idCard, 0, sort, null);
		}

		/// <summary>
		/// 按 IdCard（字段） 查询
		/// </summary>
		/// <param name = "idCard"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIdCard(string idCard, string sort, TransactionManager tm)
		{
			return GetByIdCard(idCard, 0, sort, tm);
		}

		/// <summary>
		/// 按 IdCard（字段） 查询
		/// </summary>
		/// <param name = "idCard"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIdCard(string idCard, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE idCard=@IdCard";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@IdCard", idCard, DbType.String, 60)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 Country（字段） 查询

		/// <summary>
		/// 按 Country（字段） 查询
		/// </summary>
		/// <param name = "country"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCountry(string country)
		{
			return GetByCountry(country, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Country（字段） 查询
		/// </summary>
		/// <param name = "country"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCountry(string country, TransactionManager tm)
		{
			return GetByCountry(country, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Country（字段） 查询
		/// </summary>
		/// <param name = "country"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCountry(string country, int top)
		{
			return GetByCountry(country, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Country（字段） 查询
		/// </summary>
		/// <param name = "country"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCountry(string country, int top, TransactionManager tm)
		{
			return GetByCountry(country, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Country（字段） 查询
		/// </summary>
		/// <param name = "country"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCountry(string country, string sort)
		{
			return GetByCountry(country, 0, sort, null);
		}

		/// <summary>
		/// 按 Country（字段） 查询
		/// </summary>
		/// <param name = "country"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCountry(string country, string sort, TransactionManager tm)
		{
			return GetByCountry(country, 0, sort, tm);
		}

		/// <summary>
		/// 按 Country（字段） 查询
		/// </summary>
		/// <param name = "country"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCountry(string country, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE country=@Country";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Country", country, DbType.String, 60)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 Province（字段） 查询

		/// <summary>
		/// 按 Province（字段） 查询
		/// </summary>
		/// <param name = "province"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByProvince(string province)
		{
			return GetByProvince(province, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Province（字段） 查询
		/// </summary>
		/// <param name = "province"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByProvince(string province, TransactionManager tm)
		{
			return GetByProvince(province, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Province（字段） 查询
		/// </summary>
		/// <param name = "province"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByProvince(string province, int top)
		{
			return GetByProvince(province, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Province（字段） 查询
		/// </summary>
		/// <param name = "province"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByProvince(string province, int top, TransactionManager tm)
		{
			return GetByProvince(province, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Province（字段） 查询
		/// </summary>
		/// <param name = "province"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByProvince(string province, string sort)
		{
			return GetByProvince(province, 0, sort, null);
		}

		/// <summary>
		/// 按 Province（字段） 查询
		/// </summary>
		/// <param name = "province"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByProvince(string province, string sort, TransactionManager tm)
		{
			return GetByProvince(province, 0, sort, tm);
		}

		/// <summary>
		/// 按 Province（字段） 查询
		/// </summary>
		/// <param name = "province"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByProvince(string province, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE province=@Province";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Province", province, DbType.String, 60)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 City（字段） 查询

		/// <summary>
		/// 按 City（字段） 查询
		/// </summary>
		/// <param name = "city"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCity(string city)
		{
			return GetByCity(city, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 City（字段） 查询
		/// </summary>
		/// <param name = "city"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCity(string city, TransactionManager tm)
		{
			return GetByCity(city, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 City（字段） 查询
		/// </summary>
		/// <param name = "city"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCity(string city, int top)
		{
			return GetByCity(city, top, string.Empty, null);
		}

		/// <summary>
		/// 按 City（字段） 查询
		/// </summary>
		/// <param name = "city"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCity(string city, int top, TransactionManager tm)
		{
			return GetByCity(city, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 City（字段） 查询
		/// </summary>
		/// <param name = "city"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCity(string city, string sort)
		{
			return GetByCity(city, 0, sort, null);
		}

		/// <summary>
		/// 按 City（字段） 查询
		/// </summary>
		/// <param name = "city"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCity(string city, string sort, TransactionManager tm)
		{
			return GetByCity(city, 0, sort, tm);
		}

		/// <summary>
		/// 按 City（字段） 查询
		/// </summary>
		/// <param name = "city"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCity(string city, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE city=@City";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@City", city, DbType.String, 60)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 HeadImgUrl（字段） 查询

		/// <summary>
		/// 按 HeadImgUrl（字段） 查询
		/// </summary>
		/// <param name = "headImgUrl"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHeadImgUrl(string headImgUrl)
		{
			return GetByHeadImgUrl(headImgUrl, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 HeadImgUrl（字段） 查询
		/// </summary>
		/// <param name = "headImgUrl"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHeadImgUrl(string headImgUrl, TransactionManager tm)
		{
			return GetByHeadImgUrl(headImgUrl, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 HeadImgUrl（字段） 查询
		/// </summary>
		/// <param name = "headImgUrl"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHeadImgUrl(string headImgUrl, int top)
		{
			return GetByHeadImgUrl(headImgUrl, top, string.Empty, null);
		}

		/// <summary>
		/// 按 HeadImgUrl（字段） 查询
		/// </summary>
		/// <param name = "headImgUrl"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHeadImgUrl(string headImgUrl, int top, TransactionManager tm)
		{
			return GetByHeadImgUrl(headImgUrl, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 HeadImgUrl（字段） 查询
		/// </summary>
		/// <param name = "headImgUrl"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHeadImgUrl(string headImgUrl, string sort)
		{
			return GetByHeadImgUrl(headImgUrl, 0, sort, null);
		}

		/// <summary>
		/// 按 HeadImgUrl（字段） 查询
		/// </summary>
		/// <param name = "headImgUrl"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHeadImgUrl(string headImgUrl, string sort, TransactionManager tm)
		{
			return GetByHeadImgUrl(headImgUrl, 0, sort, tm);
		}

		/// <summary>
		/// 按 HeadImgUrl（字段） 查询
		/// </summary>
		/// <param name = "headImgUrl"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHeadImgUrl(string headImgUrl, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE headImgUrl=@HeadImgUrl";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@HeadImgUrl", headImgUrl, DbType.String, 1500)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 IsParent（字段） 查询

		/// <summary>
		/// 按 IsParent（字段） 查询
		/// </summary>
		/// <param name = "isParent"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsParent(int? isParent)
		{
			return GetByIsParent(isParent, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 IsParent（字段） 查询
		/// </summary>
		/// <param name = "isParent"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsParent(int? isParent, TransactionManager tm)
		{
			return GetByIsParent(isParent, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 IsParent（字段） 查询
		/// </summary>
		/// <param name = "isParent"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsParent(int? isParent, int top)
		{
			return GetByIsParent(isParent, top, string.Empty, null);
		}

		/// <summary>
		/// 按 IsParent（字段） 查询
		/// </summary>
		/// <param name = "isParent"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsParent(int? isParent, int top, TransactionManager tm)
		{
			return GetByIsParent(isParent, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 IsParent（字段） 查询
		/// </summary>
		/// <param name = "isParent"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsParent(int? isParent, string sort)
		{
			return GetByIsParent(isParent, 0, sort, null);
		}

		/// <summary>
		/// 按 IsParent（字段） 查询
		/// </summary>
		/// <param name = "isParent"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsParent(int? isParent, string sort, TransactionManager tm)
		{
			return GetByIsParent(isParent, 0, sort, tm);
		}

		/// <summary>
		/// 按 IsParent（字段） 查询
		/// </summary>
		/// <param name = "isParent"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsParent(int? isParent, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE isParent=@IsParent";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@IsParent", isParent, DbType.Int32, 0)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 Phone（字段） 查询

		/// <summary>
		/// 按 Phone（字段） 查询
		/// </summary>
		/// <param name = "phone"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByPhone(string phone)
		{
			return GetByPhone(phone, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Phone（字段） 查询
		/// </summary>
		/// <param name = "phone"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByPhone(string phone, TransactionManager tm)
		{
			return GetByPhone(phone, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Phone（字段） 查询
		/// </summary>
		/// <param name = "phone"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByPhone(string phone, int top)
		{
			return GetByPhone(phone, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Phone（字段） 查询
		/// </summary>
		/// <param name = "phone"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByPhone(string phone, int top, TransactionManager tm)
		{
			return GetByPhone(phone, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Phone（字段） 查询
		/// </summary>
		/// <param name = "phone"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByPhone(string phone, string sort)
		{
			return GetByPhone(phone, 0, sort, null);
		}

		/// <summary>
		/// 按 Phone（字段） 查询
		/// </summary>
		/// <param name = "phone"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByPhone(string phone, string sort, TransactionManager tm)
		{
			return GetByPhone(phone, 0, sort, tm);
		}

		/// <summary>
		/// 按 Phone（字段） 查询
		/// </summary>
		/// <param name = "phone"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByPhone(string phone, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE phone=@Phone";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Phone", phone, DbType.String, 36)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 IsNew（字段） 查询

		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// <param name = "isNew"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsNew(int? isNew)
		{
			return GetByIsNew(isNew, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// <param name = "isNew"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsNew(int? isNew, TransactionManager tm)
		{
			return GetByIsNew(isNew, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// <param name = "isNew"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsNew(int? isNew, int top)
		{
			return GetByIsNew(isNew, top, string.Empty, null);
		}

		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// <param name = "isNew"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsNew(int? isNew, int top, TransactionManager tm)
		{
			return GetByIsNew(isNew, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// <param name = "isNew"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsNew(int? isNew, string sort)
		{
			return GetByIsNew(isNew, 0, sort, null);
		}

		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// <param name = "isNew"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsNew(int? isNew, string sort, TransactionManager tm)
		{
			return GetByIsNew(isNew, 0, sort, tm);
		}

		/// <summary>
		/// 按 IsNew（字段） 查询
		/// </summary>
		/// <param name = "isNew"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsNew(int? isNew, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE isNew=@IsNew";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@IsNew", isNew, DbType.Int32, 0)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 IsVip（字段） 查询

		/// <summary>
		/// 按 IsVip（字段） 查询
		/// </summary>
		/// <param name = "isVip"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsVip(int? isVip)
		{
			return GetByIsVip(isVip, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 IsVip（字段） 查询
		/// </summary>
		/// <param name = "isVip"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsVip(int? isVip, TransactionManager tm)
		{
			return GetByIsVip(isVip, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 IsVip（字段） 查询
		/// </summary>
		/// <param name = "isVip"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsVip(int? isVip, int top)
		{
			return GetByIsVip(isVip, top, string.Empty, null);
		}

		/// <summary>
		/// 按 IsVip（字段） 查询
		/// </summary>
		/// <param name = "isVip"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsVip(int? isVip, int top, TransactionManager tm)
		{
			return GetByIsVip(isVip, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 IsVip（字段） 查询
		/// </summary>
		/// <param name = "isVip"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsVip(int? isVip, string sort)
		{
			return GetByIsVip(isVip, 0, sort, null);
		}

		/// <summary>
		/// 按 IsVip（字段） 查询
		/// </summary>
		/// <param name = "isVip"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsVip(int? isVip, string sort, TransactionManager tm)
		{
			return GetByIsVip(isVip, 0, sort, tm);
		}

		/// <summary>
		/// 按 IsVip（字段） 查询
		/// </summary>
		/// <param name = "isVip"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsVip(int? isVip, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE isVip=@IsVip";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@IsVip", isVip, DbType.Int32, 0)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 VipId（字段） 查询

		/// <summary>
		/// 按 VipId（字段） 查询
		/// </summary>
		/// <param name = "vipId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByVipId(string vipId)
		{
			return GetByVipId(vipId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 VipId（字段） 查询
		/// </summary>
		/// <param name = "vipId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByVipId(string vipId, TransactionManager tm)
		{
			return GetByVipId(vipId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 VipId（字段） 查询
		/// </summary>
		/// <param name = "vipId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByVipId(string vipId, int top)
		{
			return GetByVipId(vipId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 VipId（字段） 查询
		/// </summary>
		/// <param name = "vipId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByVipId(string vipId, int top, TransactionManager tm)
		{
			return GetByVipId(vipId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 VipId（字段） 查询
		/// </summary>
		/// <param name = "vipId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByVipId(string vipId, string sort)
		{
			return GetByVipId(vipId, 0, sort, null);
		}

		/// <summary>
		/// 按 VipId（字段） 查询
		/// </summary>
		/// <param name = "vipId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByVipId(string vipId, string sort, TransactionManager tm)
		{
			return GetByVipId(vipId, 0, sort, tm);
		}

		/// <summary>
		/// 按 VipId（字段） 查询
		/// </summary>
		/// <param name = "vipId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByVipId(string vipId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE vipId=@VipId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@VipId", vipId, DbType.String, 33)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 IsHighLevel（字段） 查询

		/// <summary>
		/// 按 IsHighLevel（字段） 查询
		/// </summary>
		/// <param name = "isHighLevel"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsHighLevel(int? isHighLevel)
		{
			return GetByIsHighLevel(isHighLevel, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 IsHighLevel（字段） 查询
		/// </summary>
		/// <param name = "isHighLevel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsHighLevel(int? isHighLevel, TransactionManager tm)
		{
			return GetByIsHighLevel(isHighLevel, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 IsHighLevel（字段） 查询
		/// </summary>
		/// <param name = "isHighLevel"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsHighLevel(int? isHighLevel, int top)
		{
			return GetByIsHighLevel(isHighLevel, top, string.Empty, null);
		}

		/// <summary>
		/// 按 IsHighLevel（字段） 查询
		/// </summary>
		/// <param name = "isHighLevel"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsHighLevel(int? isHighLevel, int top, TransactionManager tm)
		{
			return GetByIsHighLevel(isHighLevel, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 IsHighLevel（字段） 查询
		/// </summary>
		/// <param name = "isHighLevel"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsHighLevel(int? isHighLevel, string sort)
		{
			return GetByIsHighLevel(isHighLevel, 0, sort, null);
		}

		/// <summary>
		/// 按 IsHighLevel（字段） 查询
		/// </summary>
		/// <param name = "isHighLevel"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsHighLevel(int? isHighLevel, string sort, TransactionManager tm)
		{
			return GetByIsHighLevel(isHighLevel, 0, sort, tm);
		}

		/// <summary>
		/// 按 IsHighLevel（字段） 查询
		/// </summary>
		/// <param name = "isHighLevel"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsHighLevel(int? isHighLevel, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE isHighLevel=@IsHighLevel";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@IsHighLevel", isHighLevel, DbType.Int32, 0)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 CoverImg（字段） 查询

		/// <summary>
		/// 按 CoverImg（字段） 查询
		/// </summary>
		/// <param name = "coverImg"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCoverImg(string coverImg)
		{
			return GetByCoverImg(coverImg, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 CoverImg（字段） 查询
		/// </summary>
		/// <param name = "coverImg"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCoverImg(string coverImg, TransactionManager tm)
		{
			return GetByCoverImg(coverImg, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 CoverImg（字段） 查询
		/// </summary>
		/// <param name = "coverImg"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCoverImg(string coverImg, int top)
		{
			return GetByCoverImg(coverImg, top, string.Empty, null);
		}

		/// <summary>
		/// 按 CoverImg（字段） 查询
		/// </summary>
		/// <param name = "coverImg"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCoverImg(string coverImg, int top, TransactionManager tm)
		{
			return GetByCoverImg(coverImg, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 CoverImg（字段） 查询
		/// </summary>
		/// <param name = "coverImg"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCoverImg(string coverImg, string sort)
		{
			return GetByCoverImg(coverImg, 0, sort, null);
		}

		/// <summary>
		/// 按 CoverImg（字段） 查询
		/// </summary>
		/// <param name = "coverImg"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCoverImg(string coverImg, string sort, TransactionManager tm)
		{
			return GetByCoverImg(coverImg, 0, sort, tm);
		}

		/// <summary>
		/// 按 CoverImg（字段） 查询
		/// </summary>
		/// <param name = "coverImg"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCoverImg(string coverImg, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE coverImg=@CoverImg";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@CoverImg", coverImg, DbType.String, 60)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 Career（字段） 查询

		/// <summary>
		/// 按 Career（字段） 查询
		/// </summary>
		/// <param name = "career"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCareer(string career)
		{
			return GetByCareer(career, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Career（字段） 查询
		/// </summary>
		/// <param name = "career"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCareer(string career, TransactionManager tm)
		{
			return GetByCareer(career, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Career（字段） 查询
		/// </summary>
		/// <param name = "career"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCareer(string career, int top)
		{
			return GetByCareer(career, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Career（字段） 查询
		/// </summary>
		/// <param name = "career"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCareer(string career, int top, TransactionManager tm)
		{
			return GetByCareer(career, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Career（字段） 查询
		/// </summary>
		/// <param name = "career"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCareer(string career, string sort)
		{
			return GetByCareer(career, 0, sort, null);
		}

		/// <summary>
		/// 按 Career（字段） 查询
		/// </summary>
		/// <param name = "career"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCareer(string career, string sort, TransactionManager tm)
		{
			return GetByCareer(career, 0, sort, tm);
		}

		/// <summary>
		/// 按 Career（字段） 查询
		/// </summary>
		/// <param name = "career"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCareer(string career, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE career=@Career";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Career", career, DbType.String, 60)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 LoveCount（字段） 查询

		/// <summary>
		/// 按 LoveCount（字段） 查询
		/// </summary>
		/// <param name = "loveCount"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByLoveCount(int? loveCount)
		{
			return GetByLoveCount(loveCount, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 LoveCount（字段） 查询
		/// </summary>
		/// <param name = "loveCount"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByLoveCount(int? loveCount, TransactionManager tm)
		{
			return GetByLoveCount(loveCount, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 LoveCount（字段） 查询
		/// </summary>
		/// <param name = "loveCount"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByLoveCount(int? loveCount, int top)
		{
			return GetByLoveCount(loveCount, top, string.Empty, null);
		}

		/// <summary>
		/// 按 LoveCount（字段） 查询
		/// </summary>
		/// <param name = "loveCount"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByLoveCount(int? loveCount, int top, TransactionManager tm)
		{
			return GetByLoveCount(loveCount, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 LoveCount（字段） 查询
		/// </summary>
		/// <param name = "loveCount"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByLoveCount(int? loveCount, string sort)
		{
			return GetByLoveCount(loveCount, 0, sort, null);
		}

		/// <summary>
		/// 按 LoveCount（字段） 查询
		/// </summary>
		/// <param name = "loveCount"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByLoveCount(int? loveCount, string sort, TransactionManager tm)
		{
			return GetByLoveCount(loveCount, 0, sort, tm);
		}

		/// <summary>
		/// 按 LoveCount（字段） 查询
		/// </summary>
		/// <param name = "loveCount"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByLoveCount(int? loveCount, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE loveCount=@LoveCount";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@LoveCount", loveCount, DbType.Int32, 0)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 Feature（字段） 查询

		/// <summary>
		/// 按 Feature（字段） 查询
		/// </summary>
		/// <param name = "feature"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByFeature(string feature)
		{
			return GetByFeature(feature, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Feature（字段） 查询
		/// </summary>
		/// <param name = "feature"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByFeature(string feature, TransactionManager tm)
		{
			return GetByFeature(feature, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Feature（字段） 查询
		/// </summary>
		/// <param name = "feature"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByFeature(string feature, int top)
		{
			return GetByFeature(feature, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Feature（字段） 查询
		/// </summary>
		/// <param name = "feature"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByFeature(string feature, int top, TransactionManager tm)
		{
			return GetByFeature(feature, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Feature（字段） 查询
		/// </summary>
		/// <param name = "feature"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByFeature(string feature, string sort)
		{
			return GetByFeature(feature, 0, sort, null);
		}

		/// <summary>
		/// 按 Feature（字段） 查询
		/// </summary>
		/// <param name = "feature"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByFeature(string feature, string sort, TransactionManager tm)
		{
			return GetByFeature(feature, 0, sort, tm);
		}

		/// <summary>
		/// 按 Feature（字段） 查询
		/// </summary>
		/// <param name = "feature"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByFeature(string feature, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE feature=@Feature";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Feature", feature, DbType.String, 150)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 AddTime（字段） 查询

		/// <summary>
		/// 按 AddTime（字段） 查询
		/// </summary>
		/// <param name = "addTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByAddTime(string addTime)
		{
			return GetByAddTime(addTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 AddTime（字段） 查询
		/// </summary>
		/// <param name = "addTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByAddTime(string addTime, TransactionManager tm)
		{
			return GetByAddTime(addTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 AddTime（字段） 查询
		/// </summary>
		/// <param name = "addTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByAddTime(string addTime, int top)
		{
			return GetByAddTime(addTime, top, string.Empty, null);
		}

		/// <summary>
		/// 按 AddTime（字段） 查询
		/// </summary>
		/// <param name = "addTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByAddTime(string addTime, int top, TransactionManager tm)
		{
			return GetByAddTime(addTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 AddTime（字段） 查询
		/// </summary>
		/// <param name = "addTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByAddTime(string addTime, string sort)
		{
			return GetByAddTime(addTime, 0, sort, null);
		}

		/// <summary>
		/// 按 AddTime（字段） 查询
		/// </summary>
		/// <param name = "addTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByAddTime(string addTime, string sort, TransactionManager tm)
		{
			return GetByAddTime(addTime, 0, sort, tm);
		}

		/// <summary>
		/// 按 AddTime（字段） 查询
		/// </summary>
		/// <param name = "addTime"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByAddTime(string addTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE addTime=@AddTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@AddTime", addTime, DbType.String, 60)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 IsForbiden（字段） 查询

		/// <summary>
		/// 按 IsForbiden（字段） 查询
		/// </summary>
		/// <param name = "isForbiden"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsForbiden(int? isForbiden)
		{
			return GetByIsForbiden(isForbiden, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 IsForbiden（字段） 查询
		/// </summary>
		/// <param name = "isForbiden"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsForbiden(int? isForbiden, TransactionManager tm)
		{
			return GetByIsForbiden(isForbiden, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 IsForbiden（字段） 查询
		/// </summary>
		/// <param name = "isForbiden"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsForbiden(int? isForbiden, int top)
		{
			return GetByIsForbiden(isForbiden, top, string.Empty, null);
		}

		/// <summary>
		/// 按 IsForbiden（字段） 查询
		/// </summary>
		/// <param name = "isForbiden"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsForbiden(int? isForbiden, int top, TransactionManager tm)
		{
			return GetByIsForbiden(isForbiden, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 IsForbiden（字段） 查询
		/// </summary>
		/// <param name = "isForbiden"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsForbiden(int? isForbiden, string sort)
		{
			return GetByIsForbiden(isForbiden, 0, sort, null);
		}

		/// <summary>
		/// 按 IsForbiden（字段） 查询
		/// </summary>
		/// <param name = "isForbiden"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsForbiden(int? isForbiden, string sort, TransactionManager tm)
		{
			return GetByIsForbiden(isForbiden, 0, sort, tm);
		}

		/// <summary>
		/// 按 IsForbiden（字段） 查询
		/// </summary>
		/// <param name = "isForbiden"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByIsForbiden(int? isForbiden, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE isForbiden=@IsForbiden";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@IsForbiden", isForbiden, DbType.Int32, 0)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 Height（字段） 查询

		/// <summary>
		/// 按 Height（字段） 查询
		/// </summary>
		/// <param name = "height"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHeight(string height)
		{
			return GetByHeight(height, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Height（字段） 查询
		/// </summary>
		/// <param name = "height"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHeight(string height, TransactionManager tm)
		{
			return GetByHeight(height, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Height（字段） 查询
		/// </summary>
		/// <param name = "height"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHeight(string height, int top)
		{
			return GetByHeight(height, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Height（字段） 查询
		/// </summary>
		/// <param name = "height"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHeight(string height, int top, TransactionManager tm)
		{
			return GetByHeight(height, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Height（字段） 查询
		/// </summary>
		/// <param name = "height"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHeight(string height, string sort)
		{
			return GetByHeight(height, 0, sort, null);
		}

		/// <summary>
		/// 按 Height（字段） 查询
		/// </summary>
		/// <param name = "height"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHeight(string height, string sort, TransactionManager tm)
		{
			return GetByHeight(height, 0, sort, tm);
		}

		/// <summary>
		/// 按 Height（字段） 查询
		/// </summary>
		/// <param name = "height"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHeight(string height, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE height=@Height";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Height", height, DbType.String, 30)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 Birthday（字段） 查询

		/// <summary>
		/// 按 Birthday（字段） 查询
		/// </summary>
		/// <param name = "birthday"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByBirthday(string birthday)
		{
			return GetByBirthday(birthday, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Birthday（字段） 查询
		/// </summary>
		/// <param name = "birthday"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByBirthday(string birthday, TransactionManager tm)
		{
			return GetByBirthday(birthday, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Birthday（字段） 查询
		/// </summary>
		/// <param name = "birthday"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByBirthday(string birthday, int top)
		{
			return GetByBirthday(birthday, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Birthday（字段） 查询
		/// </summary>
		/// <param name = "birthday"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByBirthday(string birthday, int top, TransactionManager tm)
		{
			return GetByBirthday(birthday, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Birthday（字段） 查询
		/// </summary>
		/// <param name = "birthday"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByBirthday(string birthday, string sort)
		{
			return GetByBirthday(birthday, 0, sort, null);
		}

		/// <summary>
		/// 按 Birthday（字段） 查询
		/// </summary>
		/// <param name = "birthday"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByBirthday(string birthday, string sort, TransactionManager tm)
		{
			return GetByBirthday(birthday, 0, sort, tm);
		}

		/// <summary>
		/// 按 Birthday（字段） 查询
		/// </summary>
		/// <param name = "birthday"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByBirthday(string birthday, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE birthday=@Birthday";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Birthday", birthday, DbType.String, 60)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 GirlOrBoyFriend（字段） 查询

		/// <summary>
		/// 按 GirlOrBoyFriend（字段） 查询
		/// </summary>
		/// <param name = "girlOrBoyFriend"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByGirlOrBoyFriend(int? girlOrBoyFriend)
		{
			return GetByGirlOrBoyFriend(girlOrBoyFriend, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 GirlOrBoyFriend（字段） 查询
		/// </summary>
		/// <param name = "girlOrBoyFriend"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByGirlOrBoyFriend(int? girlOrBoyFriend, TransactionManager tm)
		{
			return GetByGirlOrBoyFriend(girlOrBoyFriend, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 GirlOrBoyFriend（字段） 查询
		/// </summary>
		/// <param name = "girlOrBoyFriend"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByGirlOrBoyFriend(int? girlOrBoyFriend, int top)
		{
			return GetByGirlOrBoyFriend(girlOrBoyFriend, top, string.Empty, null);
		}

		/// <summary>
		/// 按 GirlOrBoyFriend（字段） 查询
		/// </summary>
		/// <param name = "girlOrBoyFriend"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByGirlOrBoyFriend(int? girlOrBoyFriend, int top, TransactionManager tm)
		{
			return GetByGirlOrBoyFriend(girlOrBoyFriend, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 GirlOrBoyFriend（字段） 查询
		/// </summary>
		/// <param name = "girlOrBoyFriend"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByGirlOrBoyFriend(int? girlOrBoyFriend, string sort)
		{
			return GetByGirlOrBoyFriend(girlOrBoyFriend, 0, sort, null);
		}

		/// <summary>
		/// 按 GirlOrBoyFriend（字段） 查询
		/// </summary>
		/// <param name = "girlOrBoyFriend"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByGirlOrBoyFriend(int? girlOrBoyFriend, string sort, TransactionManager tm)
		{
			return GetByGirlOrBoyFriend(girlOrBoyFriend, 0, sort, tm);
		}

		/// <summary>
		/// 按 GirlOrBoyFriend（字段） 查询
		/// </summary>
		/// <param name = "girlOrBoyFriend"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByGirlOrBoyFriend(int? girlOrBoyFriend, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE girlOrBoyFriend=@GirlOrBoyFriend";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@GirlOrBoyFriend", girlOrBoyFriend, DbType.Int32, 0)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 Shape（字段） 查询

		/// <summary>
		/// 按 Shape（字段） 查询
		/// </summary>
		/// <param name = "shape"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByShape(int? shape)
		{
			return GetByShape(shape, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Shape（字段） 查询
		/// </summary>
		/// <param name = "shape"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByShape(int? shape, TransactionManager tm)
		{
			return GetByShape(shape, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Shape（字段） 查询
		/// </summary>
		/// <param name = "shape"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByShape(int? shape, int top)
		{
			return GetByShape(shape, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Shape（字段） 查询
		/// </summary>
		/// <param name = "shape"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByShape(int? shape, int top, TransactionManager tm)
		{
			return GetByShape(shape, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Shape（字段） 查询
		/// </summary>
		/// <param name = "shape"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByShape(int? shape, string sort)
		{
			return GetByShape(shape, 0, sort, null);
		}

		/// <summary>
		/// 按 Shape（字段） 查询
		/// </summary>
		/// <param name = "shape"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByShape(int? shape, string sort, TransactionManager tm)
		{
			return GetByShape(shape, 0, sort, tm);
		}

		/// <summary>
		/// 按 Shape（字段） 查询
		/// </summary>
		/// <param name = "shape"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByShape(int? shape, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE shape=@Shape";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Shape", shape, DbType.Int32, 0)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 Education（字段） 查询

		/// <summary>
		/// 按 Education（字段） 查询
		/// </summary>
		/// <param name = "education"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByEducation(int? education)
		{
			return GetByEducation(education, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Education（字段） 查询
		/// </summary>
		/// <param name = "education"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByEducation(int? education, TransactionManager tm)
		{
			return GetByEducation(education, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Education（字段） 查询
		/// </summary>
		/// <param name = "education"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByEducation(int? education, int top)
		{
			return GetByEducation(education, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Education（字段） 查询
		/// </summary>
		/// <param name = "education"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByEducation(int? education, int top, TransactionManager tm)
		{
			return GetByEducation(education, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Education（字段） 查询
		/// </summary>
		/// <param name = "education"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByEducation(int? education, string sort)
		{
			return GetByEducation(education, 0, sort, null);
		}

		/// <summary>
		/// 按 Education（字段） 查询
		/// </summary>
		/// <param name = "education"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByEducation(int? education, string sort, TransactionManager tm)
		{
			return GetByEducation(education, 0, sort, tm);
		}

		/// <summary>
		/// 按 Education（字段） 查询
		/// </summary>
		/// <param name = "education"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByEducation(int? education, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE education=@Education";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Education", education, DbType.Int32, 0)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 Dirnk（字段） 查询

		/// <summary>
		/// 按 Dirnk（字段） 查询
		/// </summary>
		/// <param name = "dirnk"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByDirnk(int? dirnk)
		{
			return GetByDirnk(dirnk, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Dirnk（字段） 查询
		/// </summary>
		/// <param name = "dirnk"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByDirnk(int? dirnk, TransactionManager tm)
		{
			return GetByDirnk(dirnk, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Dirnk（字段） 查询
		/// </summary>
		/// <param name = "dirnk"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByDirnk(int? dirnk, int top)
		{
			return GetByDirnk(dirnk, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Dirnk（字段） 查询
		/// </summary>
		/// <param name = "dirnk"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByDirnk(int? dirnk, int top, TransactionManager tm)
		{
			return GetByDirnk(dirnk, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Dirnk（字段） 查询
		/// </summary>
		/// <param name = "dirnk"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByDirnk(int? dirnk, string sort)
		{
			return GetByDirnk(dirnk, 0, sort, null);
		}

		/// <summary>
		/// 按 Dirnk（字段） 查询
		/// </summary>
		/// <param name = "dirnk"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByDirnk(int? dirnk, string sort, TransactionManager tm)
		{
			return GetByDirnk(dirnk, 0, sort, tm);
		}

		/// <summary>
		/// 按 Dirnk（字段） 查询
		/// </summary>
		/// <param name = "dirnk"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByDirnk(int? dirnk, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE dirnk=@Dirnk";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Dirnk", dirnk, DbType.Int32, 0)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 Smoke（字段） 查询

		/// <summary>
		/// 按 Smoke（字段） 查询
		/// </summary>
		/// <param name = "smoke"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySmoke(int? smoke)
		{
			return GetBySmoke(smoke, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Smoke（字段） 查询
		/// </summary>
		/// <param name = "smoke"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySmoke(int? smoke, TransactionManager tm)
		{
			return GetBySmoke(smoke, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Smoke（字段） 查询
		/// </summary>
		/// <param name = "smoke"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySmoke(int? smoke, int top)
		{
			return GetBySmoke(smoke, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Smoke（字段） 查询
		/// </summary>
		/// <param name = "smoke"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySmoke(int? smoke, int top, TransactionManager tm)
		{
			return GetBySmoke(smoke, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Smoke（字段） 查询
		/// </summary>
		/// <param name = "smoke"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySmoke(int? smoke, string sort)
		{
			return GetBySmoke(smoke, 0, sort, null);
		}

		/// <summary>
		/// 按 Smoke（字段） 查询
		/// </summary>
		/// <param name = "smoke"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySmoke(int? smoke, string sort, TransactionManager tm)
		{
			return GetBySmoke(smoke, 0, sort, tm);
		}

		/// <summary>
		/// 按 Smoke（字段） 查询
		/// </summary>
		/// <param name = "smoke"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySmoke(int? smoke, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE smoke=@Smoke";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Smoke", smoke, DbType.Int32, 0)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 Marriage（字段） 查询

		/// <summary>
		/// 按 Marriage（字段） 查询
		/// </summary>
		/// <param name = "marriage"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByMarriage(int? marriage)
		{
			return GetByMarriage(marriage, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Marriage（字段） 查询
		/// </summary>
		/// <param name = "marriage"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByMarriage(int? marriage, TransactionManager tm)
		{
			return GetByMarriage(marriage, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Marriage（字段） 查询
		/// </summary>
		/// <param name = "marriage"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByMarriage(int? marriage, int top)
		{
			return GetByMarriage(marriage, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Marriage（字段） 查询
		/// </summary>
		/// <param name = "marriage"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByMarriage(int? marriage, int top, TransactionManager tm)
		{
			return GetByMarriage(marriage, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Marriage（字段） 查询
		/// </summary>
		/// <param name = "marriage"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByMarriage(int? marriage, string sort)
		{
			return GetByMarriage(marriage, 0, sort, null);
		}

		/// <summary>
		/// 按 Marriage（字段） 查询
		/// </summary>
		/// <param name = "marriage"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByMarriage(int? marriage, string sort, TransactionManager tm)
		{
			return GetByMarriage(marriage, 0, sort, tm);
		}

		/// <summary>
		/// 按 Marriage（字段） 查询
		/// </summary>
		/// <param name = "marriage"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByMarriage(int? marriage, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE marriage=@Marriage";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Marriage", marriage, DbType.Int32, 0)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 Salary（字段） 查询

		/// <summary>
		/// 按 Salary（字段） 查询
		/// </summary>
		/// <param name = "salary"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySalary(string salary)
		{
			return GetBySalary(salary, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Salary（字段） 查询
		/// </summary>
		/// <param name = "salary"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySalary(string salary, TransactionManager tm)
		{
			return GetBySalary(salary, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Salary（字段） 查询
		/// </summary>
		/// <param name = "salary"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySalary(string salary, int top)
		{
			return GetBySalary(salary, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Salary（字段） 查询
		/// </summary>
		/// <param name = "salary"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySalary(string salary, int top, TransactionManager tm)
		{
			return GetBySalary(salary, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Salary（字段） 查询
		/// </summary>
		/// <param name = "salary"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySalary(string salary, string sort)
		{
			return GetBySalary(salary, 0, sort, null);
		}

		/// <summary>
		/// 按 Salary（字段） 查询
		/// </summary>
		/// <param name = "salary"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySalary(string salary, string sort, TransactionManager tm)
		{
			return GetBySalary(salary, 0, sort, tm);
		}

		/// <summary>
		/// 按 Salary（字段） 查询
		/// </summary>
		/// <param name = "salary"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySalary(string salary, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE salary=@Salary";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Salary", salary, DbType.String, 60)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 Car（字段） 查询

		/// <summary>
		/// 按 Car（字段） 查询
		/// </summary>
		/// <param name = "car"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCar(string car)
		{
			return GetByCar(car, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Car（字段） 查询
		/// </summary>
		/// <param name = "car"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCar(string car, TransactionManager tm)
		{
			return GetByCar(car, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Car（字段） 查询
		/// </summary>
		/// <param name = "car"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCar(string car, int top)
		{
			return GetByCar(car, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Car（字段） 查询
		/// </summary>
		/// <param name = "car"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCar(string car, int top, TransactionManager tm)
		{
			return GetByCar(car, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Car（字段） 查询
		/// </summary>
		/// <param name = "car"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCar(string car, string sort)
		{
			return GetByCar(car, 0, sort, null);
		}

		/// <summary>
		/// 按 Car（字段） 查询
		/// </summary>
		/// <param name = "car"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCar(string car, string sort, TransactionManager tm)
		{
			return GetByCar(car, 0, sort, tm);
		}

		/// <summary>
		/// 按 Car（字段） 查询
		/// </summary>
		/// <param name = "car"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByCar(string car, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE car=@Car";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Car", car, DbType.String, 12)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 House（字段） 查询

		/// <summary>
		/// 按 House（字段） 查询
		/// </summary>
		/// <param name = "house"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHouse(string house)
		{
			return GetByHouse(house, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 House（字段） 查询
		/// </summary>
		/// <param name = "house"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHouse(string house, TransactionManager tm)
		{
			return GetByHouse(house, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 House（字段） 查询
		/// </summary>
		/// <param name = "house"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHouse(string house, int top)
		{
			return GetByHouse(house, top, string.Empty, null);
		}

		/// <summary>
		/// 按 House（字段） 查询
		/// </summary>
		/// <param name = "house"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHouse(string house, int top, TransactionManager tm)
		{
			return GetByHouse(house, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 House（字段） 查询
		/// </summary>
		/// <param name = "house"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHouse(string house, string sort)
		{
			return GetByHouse(house, 0, sort, null);
		}

		/// <summary>
		/// 按 House（字段） 查询
		/// </summary>
		/// <param name = "house"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHouse(string house, string sort, TransactionManager tm)
		{
			return GetByHouse(house, 0, sort, tm);
		}

		/// <summary>
		/// 按 House（字段） 查询
		/// </summary>
		/// <param name = "house"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHouse(string house, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE house=@House";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@House", house, DbType.String, 60)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 Children（字段） 查询

		/// <summary>
		/// 按 Children（字段） 查询
		/// </summary>
		/// <param name = "children"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByChildren(int? children)
		{
			return GetByChildren(children, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Children（字段） 查询
		/// </summary>
		/// <param name = "children"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByChildren(int? children, TransactionManager tm)
		{
			return GetByChildren(children, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Children（字段） 查询
		/// </summary>
		/// <param name = "children"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByChildren(int? children, int top)
		{
			return GetByChildren(children, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Children（字段） 查询
		/// </summary>
		/// <param name = "children"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByChildren(int? children, int top, TransactionManager tm)
		{
			return GetByChildren(children, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Children（字段） 查询
		/// </summary>
		/// <param name = "children"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByChildren(int? children, string sort)
		{
			return GetByChildren(children, 0, sort, null);
		}

		/// <summary>
		/// 按 Children（字段） 查询
		/// </summary>
		/// <param name = "children"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByChildren(int? children, string sort, TransactionManager tm)
		{
			return GetByChildren(children, 0, sort, tm);
		}

		/// <summary>
		/// 按 Children（字段） 查询
		/// </summary>
		/// <param name = "children"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByChildren(int? children, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE children=@Children";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Children", children, DbType.Int32, 0)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 Household（字段） 查询

		/// <summary>
		/// 按 Household（字段） 查询
		/// </summary>
		/// <param name = "household"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHousehold(string household)
		{
			return GetByHousehold(household, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Household（字段） 查询
		/// </summary>
		/// <param name = "household"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHousehold(string household, TransactionManager tm)
		{
			return GetByHousehold(household, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Household（字段） 查询
		/// </summary>
		/// <param name = "household"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHousehold(string household, int top)
		{
			return GetByHousehold(household, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Household（字段） 查询
		/// </summary>
		/// <param name = "household"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHousehold(string household, int top, TransactionManager tm)
		{
			return GetByHousehold(household, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Household（字段） 查询
		/// </summary>
		/// <param name = "household"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHousehold(string household, string sort)
		{
			return GetByHousehold(household, 0, sort, null);
		}

		/// <summary>
		/// 按 Household（字段） 查询
		/// </summary>
		/// <param name = "household"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHousehold(string household, string sort, TransactionManager tm)
		{
			return GetByHousehold(household, 0, sort, tm);
		}

		/// <summary>
		/// 按 Household（字段） 查询
		/// </summary>
		/// <param name = "household"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetByHousehold(string household, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE household=@Household";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Household", household, DbType.String, 150)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  按 Settle（字段） 查询

		/// <summary>
		/// 按 Settle（字段） 查询
		/// </summary>
		/// <param name = "settle"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySettle(string settle)
		{
			return GetBySettle(settle, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Settle（字段） 查询
		/// </summary>
		/// <param name = "settle"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySettle(string settle, TransactionManager tm)
		{
			return GetBySettle(settle, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Settle（字段） 查询
		/// </summary>
		/// <param name = "settle"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySettle(string settle, int top)
		{
			return GetBySettle(settle, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Settle（字段） 查询
		/// </summary>
		/// <param name = "settle"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySettle(string settle, int top, TransactionManager tm)
		{
			return GetBySettle(settle, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Settle（字段） 查询
		/// </summary>
		/// <param name = "settle"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySettle(string settle, string sort)
		{
			return GetBySettle(settle, 0, sort, null);
		}

		/// <summary>
		/// 按 Settle（字段） 查询
		/// </summary>
		/// <param name = "settle"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySettle(string settle, string sort, TransactionManager tm)
		{
			return GetBySettle(settle, 0, sort, tm);
		}

		/// <summary>
		/// 按 Settle（字段） 查询
		/// </summary>
		/// <param name = "settle"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetBySettle(string settle, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo WHERE settle=@Settle";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Settle", settle, DbType.String, 150)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> Get(string where, TransactionManager tm)
		{
			return GetTopSort(where, null , -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> Get(string where, TransactionManager tm, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, tm, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetTop(string where, int top)
		{
			return GetTopSort(where, null, top, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetTop(string where, int top, params object[] values)
		{
			return GetTopSort(where, top, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
		{
			return GetTopSort(where, paras, top, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetTop(string where, int top, TransactionManager tm)
		{
			return GetTopSort(where, null, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
		{
			return GetTopSort(where, top, string.Empty, tm, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetSort(string where, string sort)
		{
			return GetTopSort(where, null, -1, sort, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetSort(string where, string sort, params object[] values)
		{
			return GetTopSort(where, -1, sort, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
		{
			return GetTopSort(where, paras, -1, sort, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetSort(string where, string sort, TransactionManager tm)
		{
			return GetTopSort(where, null, -1, sort, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
		{
			return GetTopSort(where, -1, sort, tm, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, sort, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetTopSort(string where, int top, string sort)
		{
			return GetTopSort(where, null, top, sort, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetTopSort(string where, int top, string sort, params object[] values)
		{
			return GetTopSort(where, top, sort, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
		{
			return GetTopSort(where, paras, top, sort, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
		{
			return GetTopSort(where, null, top, sort, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserinfoEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<UserinfoEO>(UserinfoEO.GetItem, tm);
		}

		#endregion

		#region  分页

		/// <summary>
		/// 获取分页操作对象
		/// </summary>
		/// <param name = "pageSize">页大小</param>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>分页操作对象</return>
		public virtual IDataPager GetPager(int pageSize, string where = null, string sort = null)
		{
			const string format = @"SELECT userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle FROM userinfo {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "userId");
		}

		/// <summary>
		/// 获取分页数据
		/// </summary>
		/// <param name = "pageIndex">页索引，从1开始</param>
		/// <param name = "pageSize">页大小</param>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>查询到的数据集合</return>
		public virtual List<UserinfoEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<UserinfoEO>(pageIndex);
		}

		/// <summary>
		/// 获取分页数据
		/// </summary>
		/// <param name = "pageIndex">页索引，从1开始</param>
		/// <param name = "pageSize">页大小</param>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>查询到的数据集合</return>
		public virtual IEnumerable<UserinfoEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<UserinfoEO>(pageIndex);
		}

		/// <summary>
		/// 获取分页信息
		/// </summary>
		/// <param name = "pageSize">页大小</param>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>
		/// Tuple类型：
		/// 	Item1:数据个数(RecordCount)
		/// 	Item2:总页数(PageCount)
		/// </return>
		public virtual Tuple<long, long> GetPageInfo(int pageSize, string where = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where);

			pager.AddParameters(paras);
			return Tuple.Create(pager.GetRecordCount(), pager.PageCount);
		}

		#endregion

		#endregion

		#region  Add方法集合

		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(UserinfoEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO userinfo (userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle) VALUES (@userId, @openId, @nickName, @realName, @sex, @idCard, @country, @province, @city, @headImgUrl, @isParent, @phone, @isNew, @isVip, @vipId, @isHighLevel, @coverImg, @career, @loveCount, @feature, @addTime, @isForbiden, @height, @birthday, @girlOrBoyFriend, @shape, @education, @dirnk, @smoke, @marriage, @salary, @car, @house, @children, @household, @settle) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", item.UserId, DbType.UInt32, 0)
							.AddInParameter("@openId", item.OpenId != null ?  (object)item.OpenId : DBNull.Value, DbType.String, 300)
							.AddInParameter("@nickName", item.NickName != null ?  (object)item.NickName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@realName", item.RealName != null ?  (object)item.RealName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@sex", item.Sex.HasValue ? (object)item.Sex.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@idCard", item.IdCard != null ?  (object)item.IdCard : DBNull.Value, DbType.String, 60)
							.AddInParameter("@country", item.Country != null ?  (object)item.Country : DBNull.Value, DbType.String, 60)
							.AddInParameter("@province", item.Province != null ?  (object)item.Province : DBNull.Value, DbType.String, 60)
							.AddInParameter("@city", item.City != null ?  (object)item.City : DBNull.Value, DbType.String, 60)
							.AddInParameter("@headImgUrl", item.HeadImgUrl != null ?  (object)item.HeadImgUrl : DBNull.Value, DbType.String, 1500)
							.AddInParameter("@isParent", item.IsParent.HasValue ? (object)item.IsParent.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@phone", item.Phone != null ?  (object)item.Phone : DBNull.Value, DbType.String, 36)
							.AddInParameter("@isNew", item.IsNew.HasValue ? (object)item.IsNew.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@isVip", item.IsVip.HasValue ? (object)item.IsVip.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@vipId", item.VipId != null ?  (object)item.VipId : DBNull.Value, DbType.String, 33)
							.AddInParameter("@isHighLevel", item.IsHighLevel.HasValue ? (object)item.IsHighLevel.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@coverImg", item.CoverImg != null ?  (object)item.CoverImg : DBNull.Value, DbType.String, 60)
							.AddInParameter("@career", item.Career != null ?  (object)item.Career : DBNull.Value, DbType.String, 60)
							.AddInParameter("@loveCount", item.LoveCount.HasValue ? (object)item.LoveCount.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@feature", item.Feature != null ?  (object)item.Feature : DBNull.Value, DbType.String, 150)
							.AddInParameter("@addTime", item.AddTime != null ?  (object)item.AddTime : DBNull.Value, DbType.String, 60)
							.AddInParameter("@isForbiden", item.IsForbiden.HasValue ? (object)item.IsForbiden.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@height", item.Height != null ?  (object)item.Height : DBNull.Value, DbType.String, 30)
							.AddInParameter("@birthday", item.Birthday != null ?  (object)item.Birthday : DBNull.Value, DbType.String, 60)
							.AddInParameter("@girlOrBoyFriend", item.GirlOrBoyFriend.HasValue ? (object)item.GirlOrBoyFriend.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@shape", item.Shape.HasValue ? (object)item.Shape.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@education", item.Education.HasValue ? (object)item.Education.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@dirnk", item.Dirnk.HasValue ? (object)item.Dirnk.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@smoke", item.Smoke.HasValue ? (object)item.Smoke.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@marriage", item.Marriage.HasValue ? (object)item.Marriage.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@salary", item.Salary != null ?  (object)item.Salary : DBNull.Value, DbType.String, 60)
							.AddInParameter("@car", item.Car != null ?  (object)item.Car : DBNull.Value, DbType.String, 12)
							.AddInParameter("@house", item.House != null ?  (object)item.House : DBNull.Value, DbType.String, 60)
							.AddInParameter("@children", item.Children.HasValue ? (object)item.Children.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@household", item.Household != null ?  (object)item.Household : DBNull.Value, DbType.String, 150)
							.AddInParameter("@settle", item.Settle != null ?  (object)item.Settle : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<UserinfoEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO userinfo (userId, openId, nickName, realName, sex, idCard, country, province, city, headImgUrl, isParent, phone, isNew, isVip, vipId, isHighLevel, coverImg, career, loveCount, feature, addTime, isForbiden, height, birthday, girlOrBoyFriend, shape, education, dirnk, smoke, marriage, salary, car, house, children, household, settle) VALUES (@userId, @openId, @nickName, @realName, @sex, @idCard, @country, @province, @city, @headImgUrl, @isParent, @phone, @isNew, @isVip, @vipId, @isHighLevel, @coverImg, @career, @loveCount, @feature, @addTime, @isForbiden, @height, @birthday, @girlOrBoyFriend, @shape, @education, @dirnk, @smoke, @marriage, @salary, @car, @house, @children, @household, @settle) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@userId", DbType.UInt32, 0)
									.AddParameter("@openId", DbType.String, 300)
									.AddParameter("@nickName", DbType.String, 150)
									.AddParameter("@realName", DbType.String, 150)
									.AddParameter("@sex", DbType.Int32, 0)
									.AddParameter("@idCard", DbType.String, 60)
									.AddParameter("@country", DbType.String, 60)
									.AddParameter("@province", DbType.String, 60)
									.AddParameter("@city", DbType.String, 60)
									.AddParameter("@headImgUrl", DbType.String, 1500)
									.AddParameter("@isParent", DbType.Int32, 0)
									.AddParameter("@phone", DbType.String, 36)
									.AddParameter("@isNew", DbType.Int32, 0)
									.AddParameter("@isVip", DbType.Int32, 0)
									.AddParameter("@vipId", DbType.String, 33)
									.AddParameter("@isHighLevel", DbType.Int32, 0)
									.AddParameter("@coverImg", DbType.String, 60)
									.AddParameter("@career", DbType.String, 60)
									.AddParameter("@loveCount", DbType.Int32, 0)
									.AddParameter("@feature", DbType.String, 150)
									.AddParameter("@addTime", DbType.String, 60)
									.AddParameter("@isForbiden", DbType.Int32, 0)
									.AddParameter("@height", DbType.String, 30)
									.AddParameter("@birthday", DbType.String, 60)
									.AddParameter("@girlOrBoyFriend", DbType.Int32, 0)
									.AddParameter("@shape", DbType.Int32, 0)
									.AddParameter("@education", DbType.Int32, 0)
									.AddParameter("@dirnk", DbType.Int32, 0)
									.AddParameter("@smoke", DbType.Int32, 0)
									.AddParameter("@marriage", DbType.Int32, 0)
									.AddParameter("@salary", DbType.String, 60)
									.AddParameter("@car", DbType.String, 12)
									.AddParameter("@house", DbType.String, 60)
									.AddParameter("@children", DbType.Int32, 0)
									.AddParameter("@household", DbType.String, 150)
									.AddParameter("@settle", DbType.String, 150);

			foreach (UserinfoEO item in items)
			{
				sqlDao
					.SetParameterValue("@userId", item.UserId)
					.SetParameterValue("@openId", item.OpenId != null ?  (object)item.OpenId : DBNull.Value)
					.SetParameterValue("@nickName", item.NickName != null ?  (object)item.NickName : DBNull.Value)
					.SetParameterValue("@realName", item.RealName != null ?  (object)item.RealName : DBNull.Value)
					.SetParameterValue("@sex", item.Sex.HasValue ? (object)item.Sex.Value : DBNull.Value)
					.SetParameterValue("@idCard", item.IdCard != null ?  (object)item.IdCard : DBNull.Value)
					.SetParameterValue("@country", item.Country != null ?  (object)item.Country : DBNull.Value)
					.SetParameterValue("@province", item.Province != null ?  (object)item.Province : DBNull.Value)
					.SetParameterValue("@city", item.City != null ?  (object)item.City : DBNull.Value)
					.SetParameterValue("@headImgUrl", item.HeadImgUrl != null ?  (object)item.HeadImgUrl : DBNull.Value)
					.SetParameterValue("@isParent", item.IsParent.HasValue ? (object)item.IsParent.Value : DBNull.Value)
					.SetParameterValue("@phone", item.Phone != null ?  (object)item.Phone : DBNull.Value)
					.SetParameterValue("@isNew", item.IsNew.HasValue ? (object)item.IsNew.Value : DBNull.Value)
					.SetParameterValue("@isVip", item.IsVip.HasValue ? (object)item.IsVip.Value : DBNull.Value)
					.SetParameterValue("@vipId", item.VipId != null ?  (object)item.VipId : DBNull.Value)
					.SetParameterValue("@isHighLevel", item.IsHighLevel.HasValue ? (object)item.IsHighLevel.Value : DBNull.Value)
					.SetParameterValue("@coverImg", item.CoverImg != null ?  (object)item.CoverImg : DBNull.Value)
					.SetParameterValue("@career", item.Career != null ?  (object)item.Career : DBNull.Value)
					.SetParameterValue("@loveCount", item.LoveCount.HasValue ? (object)item.LoveCount.Value : DBNull.Value)
					.SetParameterValue("@feature", item.Feature != null ?  (object)item.Feature : DBNull.Value)
					.SetParameterValue("@addTime", item.AddTime != null ?  (object)item.AddTime : DBNull.Value)
					.SetParameterValue("@isForbiden", item.IsForbiden.HasValue ? (object)item.IsForbiden.Value : DBNull.Value)
					.SetParameterValue("@height", item.Height != null ?  (object)item.Height : DBNull.Value)
					.SetParameterValue("@birthday", item.Birthday != null ?  (object)item.Birthday : DBNull.Value)
					.SetParameterValue("@girlOrBoyFriend", item.GirlOrBoyFriend.HasValue ? (object)item.GirlOrBoyFriend.Value : DBNull.Value)
					.SetParameterValue("@shape", item.Shape.HasValue ? (object)item.Shape.Value : DBNull.Value)
					.SetParameterValue("@education", item.Education.HasValue ? (object)item.Education.Value : DBNull.Value)
					.SetParameterValue("@dirnk", item.Dirnk.HasValue ? (object)item.Dirnk.Value : DBNull.Value)
					.SetParameterValue("@smoke", item.Smoke.HasValue ? (object)item.Smoke.Value : DBNull.Value)
					.SetParameterValue("@marriage", item.Marriage.HasValue ? (object)item.Marriage.Value : DBNull.Value)
					.SetParameterValue("@salary", item.Salary != null ?  (object)item.Salary : DBNull.Value)
					.SetParameterValue("@car", item.Car != null ?  (object)item.Car : DBNull.Value)
					.SetParameterValue("@house", item.House != null ?  (object)item.House : DBNull.Value)
					.SetParameterValue("@children", item.Children.HasValue ? (object)item.Children.Value : DBNull.Value)
					.SetParameterValue("@household", item.Household != null ?  (object)item.Household : DBNull.Value)
					.SetParameterValue("@settle", item.Settle != null ?  (object)item.Settle : DBNull.Value)
					.ExecNonQuery(tm);
				++ret;
			}
			return ret;
		}
		#endregion

		#region  Put方法集合

		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(UserinfoEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET userId=@userId, openId=@openId, nickName=@nickName, realName=@realName, sex=@sex, idCard=@idCard, country=@country, province=@province, city=@city, headImgUrl=@headImgUrl, isParent=@isParent, phone=@phone, isNew=@isNew, isVip=@isVip, vipId=@vipId, isHighLevel=@isHighLevel, coverImg=@coverImg, career=@career, loveCount=@loveCount, feature=@feature, addTime=@addTime, isForbiden=@isForbiden, height=@height, birthday=@birthday, girlOrBoyFriend=@girlOrBoyFriend, shape=@shape, education=@education, dirnk=@dirnk, smoke=@smoke, marriage=@marriage, salary=@salary, car=@car, house=@house, children=@children, household=@household, settle=@settle WHERE userId=@OriginalUserId";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalUserId", (item.HasOriginal) ? item.OriginalUserId : item.UserId, DbType.UInt32, 0)
							.AddInParameter("@userId", item.UserId, DbType.UInt32, 0)
							.AddInParameter("@openId", item.OpenId != null ?  (object)item.OpenId : DBNull.Value, DbType.String, 300)
							.AddInParameter("@nickName", item.NickName != null ?  (object)item.NickName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@realName", item.RealName != null ?  (object)item.RealName : DBNull.Value, DbType.String, 150)
							.AddInParameter("@sex", item.Sex.HasValue ? (object)item.Sex.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@idCard", item.IdCard != null ?  (object)item.IdCard : DBNull.Value, DbType.String, 60)
							.AddInParameter("@country", item.Country != null ?  (object)item.Country : DBNull.Value, DbType.String, 60)
							.AddInParameter("@province", item.Province != null ?  (object)item.Province : DBNull.Value, DbType.String, 60)
							.AddInParameter("@city", item.City != null ?  (object)item.City : DBNull.Value, DbType.String, 60)
							.AddInParameter("@headImgUrl", item.HeadImgUrl != null ?  (object)item.HeadImgUrl : DBNull.Value, DbType.String, 1500)
							.AddInParameter("@isParent", item.IsParent.HasValue ? (object)item.IsParent.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@phone", item.Phone != null ?  (object)item.Phone : DBNull.Value, DbType.String, 36)
							.AddInParameter("@isNew", item.IsNew.HasValue ? (object)item.IsNew.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@isVip", item.IsVip.HasValue ? (object)item.IsVip.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@vipId", item.VipId != null ?  (object)item.VipId : DBNull.Value, DbType.String, 33)
							.AddInParameter("@isHighLevel", item.IsHighLevel.HasValue ? (object)item.IsHighLevel.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@coverImg", item.CoverImg != null ?  (object)item.CoverImg : DBNull.Value, DbType.String, 60)
							.AddInParameter("@career", item.Career != null ?  (object)item.Career : DBNull.Value, DbType.String, 60)
							.AddInParameter("@loveCount", item.LoveCount.HasValue ? (object)item.LoveCount.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@feature", item.Feature != null ?  (object)item.Feature : DBNull.Value, DbType.String, 150)
							.AddInParameter("@addTime", item.AddTime != null ?  (object)item.AddTime : DBNull.Value, DbType.String, 60)
							.AddInParameter("@isForbiden", item.IsForbiden.HasValue ? (object)item.IsForbiden.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@height", item.Height != null ?  (object)item.Height : DBNull.Value, DbType.String, 30)
							.AddInParameter("@birthday", item.Birthday != null ?  (object)item.Birthday : DBNull.Value, DbType.String, 60)
							.AddInParameter("@girlOrBoyFriend", item.GirlOrBoyFriend.HasValue ? (object)item.GirlOrBoyFriend.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@shape", item.Shape.HasValue ? (object)item.Shape.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@education", item.Education.HasValue ? (object)item.Education.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@dirnk", item.Dirnk.HasValue ? (object)item.Dirnk.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@smoke", item.Smoke.HasValue ? (object)item.Smoke.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@marriage", item.Marriage.HasValue ? (object)item.Marriage.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@salary", item.Salary != null ?  (object)item.Salary : DBNull.Value, DbType.String, 60)
							.AddInParameter("@car", item.Car != null ?  (object)item.Car : DBNull.Value, DbType.String, 12)
							.AddInParameter("@house", item.House != null ?  (object)item.House : DBNull.Value, DbType.String, 60)
							.AddInParameter("@children", item.Children.HasValue ? (object)item.Children.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@household", item.Household != null ?  (object)item.Household : DBNull.Value, DbType.String, 150)
							.AddInParameter("@settle", item.Settle != null ?  (object)item.Settle : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<UserinfoEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE userinfo SET userId=@userId, openId=@openId, nickName=@nickName, realName=@realName, sex=@sex, idCard=@idCard, country=@country, province=@province, city=@city, headImgUrl=@headImgUrl, isParent=@isParent, phone=@phone, isNew=@isNew, isVip=@isVip, vipId=@vipId, isHighLevel=@isHighLevel, coverImg=@coverImg, career=@career, loveCount=@loveCount, feature=@feature, addTime=@addTime, isForbiden=@isForbiden, height=@height, birthday=@birthday, girlOrBoyFriend=@girlOrBoyFriend, shape=@shape, education=@education, dirnk=@dirnk, smoke=@smoke, marriage=@marriage, salary=@salary, car=@car, house=@house, children=@children, household=@household, settle=@settle WHERE userId=@OriginalUserId";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalUserId", DbType.UInt32, 0)
									.AddParameter("@userId", DbType.UInt32, 0)
									.AddParameter("@openId", DbType.String, 300)
									.AddParameter("@nickName", DbType.String, 150)
									.AddParameter("@realName", DbType.String, 150)
									.AddParameter("@sex", DbType.Int32, 0)
									.AddParameter("@idCard", DbType.String, 60)
									.AddParameter("@country", DbType.String, 60)
									.AddParameter("@province", DbType.String, 60)
									.AddParameter("@city", DbType.String, 60)
									.AddParameter("@headImgUrl", DbType.String, 1500)
									.AddParameter("@isParent", DbType.Int32, 0)
									.AddParameter("@phone", DbType.String, 36)
									.AddParameter("@isNew", DbType.Int32, 0)
									.AddParameter("@isVip", DbType.Int32, 0)
									.AddParameter("@vipId", DbType.String, 33)
									.AddParameter("@isHighLevel", DbType.Int32, 0)
									.AddParameter("@coverImg", DbType.String, 60)
									.AddParameter("@career", DbType.String, 60)
									.AddParameter("@loveCount", DbType.Int32, 0)
									.AddParameter("@feature", DbType.String, 150)
									.AddParameter("@addTime", DbType.String, 60)
									.AddParameter("@isForbiden", DbType.Int32, 0)
									.AddParameter("@height", DbType.String, 30)
									.AddParameter("@birthday", DbType.String, 60)
									.AddParameter("@girlOrBoyFriend", DbType.Int32, 0)
									.AddParameter("@shape", DbType.Int32, 0)
									.AddParameter("@education", DbType.Int32, 0)
									.AddParameter("@dirnk", DbType.Int32, 0)
									.AddParameter("@smoke", DbType.Int32, 0)
									.AddParameter("@marriage", DbType.Int32, 0)
									.AddParameter("@salary", DbType.String, 60)
									.AddParameter("@car", DbType.String, 12)
									.AddParameter("@house", DbType.String, 60)
									.AddParameter("@children", DbType.Int32, 0)
									.AddParameter("@household", DbType.String, 150)
									.AddParameter("@settle", DbType.String, 150);

			foreach (UserinfoEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalUserId", (item.HasOriginal) ? item.OriginalUserId : item.UserId)
							.SetParameterValue("@userId", item.UserId)
							.SetParameterValue("@openId", item.OpenId != null ?  (object)item.OpenId : DBNull.Value)
							.SetParameterValue("@nickName", item.NickName != null ?  (object)item.NickName : DBNull.Value)
							.SetParameterValue("@realName", item.RealName != null ?  (object)item.RealName : DBNull.Value)
							.SetParameterValue("@sex", item.Sex.HasValue ? (object)item.Sex.Value : DBNull.Value)
							.SetParameterValue("@idCard", item.IdCard != null ?  (object)item.IdCard : DBNull.Value)
							.SetParameterValue("@country", item.Country != null ?  (object)item.Country : DBNull.Value)
							.SetParameterValue("@province", item.Province != null ?  (object)item.Province : DBNull.Value)
							.SetParameterValue("@city", item.City != null ?  (object)item.City : DBNull.Value)
							.SetParameterValue("@headImgUrl", item.HeadImgUrl != null ?  (object)item.HeadImgUrl : DBNull.Value)
							.SetParameterValue("@isParent", item.IsParent.HasValue ? (object)item.IsParent.Value : DBNull.Value)
							.SetParameterValue("@phone", item.Phone != null ?  (object)item.Phone : DBNull.Value)
							.SetParameterValue("@isNew", item.IsNew.HasValue ? (object)item.IsNew.Value : DBNull.Value)
							.SetParameterValue("@isVip", item.IsVip.HasValue ? (object)item.IsVip.Value : DBNull.Value)
							.SetParameterValue("@vipId", item.VipId != null ?  (object)item.VipId : DBNull.Value)
							.SetParameterValue("@isHighLevel", item.IsHighLevel.HasValue ? (object)item.IsHighLevel.Value : DBNull.Value)
							.SetParameterValue("@coverImg", item.CoverImg != null ?  (object)item.CoverImg : DBNull.Value)
							.SetParameterValue("@career", item.Career != null ?  (object)item.Career : DBNull.Value)
							.SetParameterValue("@loveCount", item.LoveCount.HasValue ? (object)item.LoveCount.Value : DBNull.Value)
							.SetParameterValue("@feature", item.Feature != null ?  (object)item.Feature : DBNull.Value)
							.SetParameterValue("@addTime", item.AddTime != null ?  (object)item.AddTime : DBNull.Value)
							.SetParameterValue("@isForbiden", item.IsForbiden.HasValue ? (object)item.IsForbiden.Value : DBNull.Value)
							.SetParameterValue("@height", item.Height != null ?  (object)item.Height : DBNull.Value)
							.SetParameterValue("@birthday", item.Birthday != null ?  (object)item.Birthday : DBNull.Value)
							.SetParameterValue("@girlOrBoyFriend", item.GirlOrBoyFriend.HasValue ? (object)item.GirlOrBoyFriend.Value : DBNull.Value)
							.SetParameterValue("@shape", item.Shape.HasValue ? (object)item.Shape.Value : DBNull.Value)
							.SetParameterValue("@education", item.Education.HasValue ? (object)item.Education.Value : DBNull.Value)
							.SetParameterValue("@dirnk", item.Dirnk.HasValue ? (object)item.Dirnk.Value : DBNull.Value)
							.SetParameterValue("@smoke", item.Smoke.HasValue ? (object)item.Smoke.Value : DBNull.Value)
							.SetParameterValue("@marriage", item.Marriage.HasValue ? (object)item.Marriage.Value : DBNull.Value)
							.SetParameterValue("@salary", item.Salary != null ?  (object)item.Salary : DBNull.Value)
							.SetParameterValue("@car", item.Car != null ?  (object)item.Car : DBNull.Value)
							.SetParameterValue("@house", item.House != null ?  (object)item.House : DBNull.Value)
							.SetParameterValue("@children", item.Children.HasValue ? (object)item.Children.Value : DBNull.Value)
							.SetParameterValue("@household", item.Household != null ?  (object)item.Household : DBNull.Value)
							.SetParameterValue("@settle", item.Settle != null ?  (object)item.Settle : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "openId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutOpenIdByPK(uint userId, string openId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET openId = @openId  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@openId", openId != null ?  (object)openId : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "nickName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutNickNameByPK(uint userId, string nickName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET nickName = @nickName  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@nickName", nickName != null ?  (object)nickName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "realName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRealNameByPK(uint userId, string realName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET realName = @realName  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@realName", realName != null ?  (object)realName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "sex"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutSexByPK(uint userId, int? sex, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET sex = @sex  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@sex", sex.HasValue ? (object)sex.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "idCard"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutIdCardByPK(uint userId, string idCard, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET idCard = @idCard  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@idCard", idCard != null ?  (object)idCard : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "country"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCountryByPK(uint userId, string country, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET country = @country  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@country", country != null ?  (object)country : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "province"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutProvinceByPK(uint userId, string province, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET province = @province  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@province", province != null ?  (object)province : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "city"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCityByPK(uint userId, string city, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET city = @city  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@city", city != null ?  (object)city : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "headImgUrl"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutHeadImgUrlByPK(uint userId, string headImgUrl, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET headImgUrl = @headImgUrl  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@headImgUrl", headImgUrl != null ?  (object)headImgUrl : DBNull.Value, DbType.String, 1500)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "isParent"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutIsParentByPK(uint userId, int? isParent, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET isParent = @isParent  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@isParent", isParent.HasValue ? (object)isParent.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "phone"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPhoneByPK(uint userId, string phone, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET phone = @phone  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@phone", phone != null ?  (object)phone : DBNull.Value, DbType.String, 36)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "isNew"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutIsNewByPK(uint userId, int? isNew, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET isNew = @isNew  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@isNew", isNew.HasValue ? (object)isNew.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "isVip"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutIsVipByPK(uint userId, int? isVip, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET isVip = @isVip  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@isVip", isVip.HasValue ? (object)isVip.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "vipId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutVipIdByPK(uint userId, string vipId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET vipId = @vipId  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@vipId", vipId != null ?  (object)vipId : DBNull.Value, DbType.String, 33)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "isHighLevel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutIsHighLevelByPK(uint userId, int? isHighLevel, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET isHighLevel = @isHighLevel  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@isHighLevel", isHighLevel.HasValue ? (object)isHighLevel.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "coverImg"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCoverImgByPK(uint userId, string coverImg, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET coverImg = @coverImg  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@coverImg", coverImg != null ?  (object)coverImg : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "career"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCareerByPK(uint userId, string career, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET career = @career  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@career", career != null ?  (object)career : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "loveCount"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLoveCountByPK(uint userId, int? loveCount, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET loveCount = @loveCount  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@loveCount", loveCount.HasValue ? (object)loveCount.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "feature"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFeatureByPK(uint userId, string feature, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET feature = @feature  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@feature", feature != null ?  (object)feature : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "addTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutAddTimeByPK(uint userId, string addTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET addTime = @addTime  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@addTime", addTime != null ?  (object)addTime : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "isForbiden"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutIsForbidenByPK(uint userId, int? isForbiden, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET isForbiden = @isForbiden  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@isForbiden", isForbiden.HasValue ? (object)isForbiden.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "height"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutHeightByPK(uint userId, string height, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET height = @height  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@height", height != null ?  (object)height : DBNull.Value, DbType.String, 30)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "birthday"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutBirthdayByPK(uint userId, string birthday, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET birthday = @birthday  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@birthday", birthday != null ?  (object)birthday : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "girlOrBoyFriend"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGirlOrBoyFriendByPK(uint userId, int? girlOrBoyFriend, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET girlOrBoyFriend = @girlOrBoyFriend  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@girlOrBoyFriend", girlOrBoyFriend.HasValue ? (object)girlOrBoyFriend.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "shape"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutShapeByPK(uint userId, int? shape, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET shape = @shape  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@shape", shape.HasValue ? (object)shape.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "education"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutEducationByPK(uint userId, int? education, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET education = @education  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@education", education.HasValue ? (object)education.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "dirnk"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutDirnkByPK(uint userId, int? dirnk, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET dirnk = @dirnk  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@dirnk", dirnk.HasValue ? (object)dirnk.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "smoke"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutSmokeByPK(uint userId, int? smoke, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET smoke = @smoke  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@smoke", smoke.HasValue ? (object)smoke.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "marriage"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMarriageByPK(uint userId, int? marriage, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET marriage = @marriage  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@marriage", marriage.HasValue ? (object)marriage.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "salary"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutSalaryByPK(uint userId, string salary, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET salary = @salary  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@salary", salary != null ?  (object)salary : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "car"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCarByPK(uint userId, string car, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET car = @car  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@car", car != null ?  (object)car : DBNull.Value, DbType.String, 12)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "house"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutHouseByPK(uint userId, string house, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET house = @house  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@house", house != null ?  (object)house : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "children"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutChildrenByPK(uint userId, int? children, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET children = @children  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@children", children.HasValue ? (object)children.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "household"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutHouseholdByPK(uint userId, string household, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET household = @household  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@household", household != null ?  (object)household : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "settle"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutSettleByPK(uint userId, string settle, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET settle = @settle  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.AddInParameter("@settle", settle != null ?  (object)settle : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "openId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutOpenId(string openId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET openId=@openId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@openId", openId != null ?  (object)openId : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "nickName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutNickName(string nickName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET nickName=@nickName";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@nickName", nickName != null ?  (object)nickName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "realName"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutRealName(string realName, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET realName=@realName";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@realName", realName != null ?  (object)realName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "sex"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutSex(int? sex, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET sex=@sex";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@sex", sex.HasValue ? (object)sex.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "idCard"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutIdCard(string idCard, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET idCard=@idCard";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@idCard", idCard != null ?  (object)idCard : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "country"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCountry(string country, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET country=@country";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@country", country != null ?  (object)country : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "province"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutProvince(string province, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET province=@province";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@province", province != null ?  (object)province : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "city"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCity(string city, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET city=@city";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@city", city != null ?  (object)city : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "headImgUrl"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutHeadImgUrl(string headImgUrl, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET headImgUrl=@headImgUrl";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@headImgUrl", headImgUrl != null ?  (object)headImgUrl : DBNull.Value, DbType.String, 1500)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "isParent"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutIsParent(int? isParent, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET isParent=@isParent";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@isParent", isParent.HasValue ? (object)isParent.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "phone"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPhone(string phone, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET phone=@phone";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@phone", phone != null ?  (object)phone : DBNull.Value, DbType.String, 36)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "isNew"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutIsNew(int? isNew, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET isNew=@isNew";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@isNew", isNew.HasValue ? (object)isNew.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "isVip"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutIsVip(int? isVip, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET isVip=@isVip";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@isVip", isVip.HasValue ? (object)isVip.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "vipId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutVipId(string vipId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET vipId=@vipId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@vipId", vipId != null ?  (object)vipId : DBNull.Value, DbType.String, 33)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "isHighLevel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutIsHighLevel(int? isHighLevel, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET isHighLevel=@isHighLevel";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@isHighLevel", isHighLevel.HasValue ? (object)isHighLevel.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "coverImg"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCoverImg(string coverImg, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET coverImg=@coverImg";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@coverImg", coverImg != null ?  (object)coverImg : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "career"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCareer(string career, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET career=@career";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@career", career != null ?  (object)career : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "loveCount"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLoveCount(int? loveCount, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET loveCount=@loveCount";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@loveCount", loveCount.HasValue ? (object)loveCount.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "feature"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutFeature(string feature, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET feature=@feature";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@feature", feature != null ?  (object)feature : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "addTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutAddTime(string addTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET addTime=@addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@addTime", addTime != null ?  (object)addTime : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "isForbiden"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutIsForbiden(int? isForbiden, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET isForbiden=@isForbiden";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@isForbiden", isForbiden.HasValue ? (object)isForbiden.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "height"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutHeight(string height, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET height=@height";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@height", height != null ?  (object)height : DBNull.Value, DbType.String, 30)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "birthday"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutBirthday(string birthday, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET birthday=@birthday";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@birthday", birthday != null ?  (object)birthday : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "girlOrBoyFriend"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGirlOrBoyFriend(int? girlOrBoyFriend, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET girlOrBoyFriend=@girlOrBoyFriend";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@girlOrBoyFriend", girlOrBoyFriend.HasValue ? (object)girlOrBoyFriend.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "shape"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutShape(int? shape, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET shape=@shape";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@shape", shape.HasValue ? (object)shape.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "education"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutEducation(int? education, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET education=@education";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@education", education.HasValue ? (object)education.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "dirnk"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutDirnk(int? dirnk, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET dirnk=@dirnk";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@dirnk", dirnk.HasValue ? (object)dirnk.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "smoke"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutSmoke(int? smoke, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET smoke=@smoke";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@smoke", smoke.HasValue ? (object)smoke.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "marriage"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutMarriage(int? marriage, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET marriage=@marriage";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@marriage", marriage.HasValue ? (object)marriage.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "salary"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutSalary(string salary, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET salary=@salary";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@salary", salary != null ?  (object)salary : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "car"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutCar(string car, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET car=@car";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@car", car != null ?  (object)car : DBNull.Value, DbType.String, 12)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "house"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutHouse(string house, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET house=@house";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@house", house != null ?  (object)house : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "children"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutChildren(int? children, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET children=@children";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@children", children.HasValue ? (object)children.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "household"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutHousehold(string household, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET household=@household";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@household", household != null ?  (object)household : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "settle"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutSettle(string settle, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userinfo SET settle=@settle";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@settle", settle != null ?  (object)settle : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按自定义语句更新数据
		/// </summary>
		/// <param name = "set">自定义更新的列，对应update中的set子句</param>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">update语句中定义的参数值集合</param>
		/// <return>受影响的行数</return>
		public int Put(string set, string where, params object[] values)
		{
			return Put(set, where, null, values);
		}

		/// <summary>
		/// 按自定义语句更新数据
		/// </summary>
		/// <param name = "set">自定义更新的列，对应update中的set子句</param>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">update语句中定义的参数集合</param>
		/// <return>受影响的行数</return>
		public int Put(string set, string where, IEnumerable<DbParameter> paras)
		{
			return Put(set, where, paras, null);
		}

		/// <summary>
		/// 按自定义语句更新数据
		/// </summary>
		/// <param name = "set">自定义更新的列，对应update中的set子句</param>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(string set, string where, TransactionManager tm)
		{
			return Put(set, where, null, tm);
		}

		/// <summary>
		/// 按自定义语句更新数据
		/// </summary>
		/// <param name = "set">自定义更新的列，对应update中的set子句</param>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "values">update语句中定义的参数值集合</param>
		/// <return>受影响的行数</return>
		public virtual int Put(string set, string where, TransactionManager tm, params object[] values)
		{
			if (string.IsNullOrEmpty(set)) throw new ArgumentNullException("set");
			const string format = @"UPDATE userinfo SET {0} {1}";
			string sql = string.Format(format, set, (string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where));

			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按自定义语句更新数据
		/// </summary>
		/// <param name = "set">自定义更新的列，对应update中的set子句</param>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">update语句中定义的参数集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(string set, string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			if (string.IsNullOrEmpty(set)) throw new ArgumentNullException("set");
			const string format = @"UPDATE userinfo SET {0} {1}";
			string sql = string.Format(format, set, (string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where));


			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecNonQuery(tm);
		}

		#endregion

		#region  Remove方法集合
		/// <summary>
		/// 按主键删除
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(uint userId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE userId=@userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.UInt32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(UserinfoEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.UserId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<UserinfoEO> items, TransactionManager tm = null)
		{
			return Remove(items.Select(w => w.UserId), tm);
		}

		/// <summary>
		/// 根据主键删除一组记录
		/// </summary>
		/// <param name = "userIds">主键编码集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<uint> userIds, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE userId IN ({0})";
			return Database.CreateSqlDao(String.Format(sql, String.Join(",", userIds)))
							.ExecNonQuery(tm);
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "openId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByOpenId(string openId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE openId=@openId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@openId", openId != null ?  (object)openId : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "nickName"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByNickName(string nickName, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE nickName=@nickName";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@nickName", nickName != null ?  (object)nickName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "realName"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByRealName(string realName, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE realName=@realName";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@realName", realName != null ?  (object)realName : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "sex"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveBySex(int? sex, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE sex=@sex";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@sex", sex.HasValue ? (object)sex.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "idCard"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByIdCard(string idCard, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE idCard=@idCard";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@idCard", idCard != null ?  (object)idCard : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "country"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByCountry(string country, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE country=@country";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@country", country != null ?  (object)country : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "province"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByProvince(string province, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE province=@province";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@province", province != null ?  (object)province : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "city"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByCity(string city, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE city=@city";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@city", city != null ?  (object)city : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "headImgUrl"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByHeadImgUrl(string headImgUrl, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE headImgUrl=@headImgUrl";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@headImgUrl", headImgUrl != null ?  (object)headImgUrl : DBNull.Value, DbType.String, 1500)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "isParent"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByIsParent(int? isParent, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE isParent=@isParent";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@isParent", isParent.HasValue ? (object)isParent.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "phone"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPhone(string phone, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE phone=@phone";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@phone", phone != null ?  (object)phone : DBNull.Value, DbType.String, 36)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "isNew"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByIsNew(int? isNew, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE isNew=@isNew";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@isNew", isNew.HasValue ? (object)isNew.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "isVip"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByIsVip(int? isVip, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE isVip=@isVip";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@isVip", isVip.HasValue ? (object)isVip.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "vipId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByVipId(string vipId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE vipId=@vipId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@vipId", vipId != null ?  (object)vipId : DBNull.Value, DbType.String, 33)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "isHighLevel"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByIsHighLevel(int? isHighLevel, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE isHighLevel=@isHighLevel";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@isHighLevel", isHighLevel.HasValue ? (object)isHighLevel.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "coverImg"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByCoverImg(string coverImg, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE coverImg=@coverImg";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@coverImg", coverImg != null ?  (object)coverImg : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "career"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByCareer(string career, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE career=@career";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@career", career != null ?  (object)career : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "loveCount"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByLoveCount(int? loveCount, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE loveCount=@loveCount";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@loveCount", loveCount.HasValue ? (object)loveCount.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "feature"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByFeature(string feature, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE feature=@feature";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@feature", feature != null ?  (object)feature : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "addTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByAddTime(string addTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE addTime=@addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@addTime", addTime != null ?  (object)addTime : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "isForbiden"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByIsForbiden(int? isForbiden, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE isForbiden=@isForbiden";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@isForbiden", isForbiden.HasValue ? (object)isForbiden.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "height"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByHeight(string height, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE height=@height";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@height", height != null ?  (object)height : DBNull.Value, DbType.String, 30)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "birthday"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByBirthday(string birthday, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE birthday=@birthday";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@birthday", birthday != null ?  (object)birthday : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "girlOrBoyFriend"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByGirlOrBoyFriend(int? girlOrBoyFriend, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE girlOrBoyFriend=@girlOrBoyFriend";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@girlOrBoyFriend", girlOrBoyFriend.HasValue ? (object)girlOrBoyFriend.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "shape"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByShape(int? shape, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE shape=@shape";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@shape", shape.HasValue ? (object)shape.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "education"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByEducation(int? education, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE education=@education";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@education", education.HasValue ? (object)education.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "dirnk"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByDirnk(int? dirnk, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE dirnk=@dirnk";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@dirnk", dirnk.HasValue ? (object)dirnk.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "smoke"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveBySmoke(int? smoke, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE smoke=@smoke";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@smoke", smoke.HasValue ? (object)smoke.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "marriage"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByMarriage(int? marriage, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE marriage=@marriage";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@marriage", marriage.HasValue ? (object)marriage.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "salary"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveBySalary(string salary, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE salary=@salary";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@salary", salary != null ?  (object)salary : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "car"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByCar(string car, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE car=@car";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@car", car != null ?  (object)car : DBNull.Value, DbType.String, 12)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "house"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByHouse(string house, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE house=@house";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@house", house != null ?  (object)house : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "children"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByChildren(int? children, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE children=@children";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@children", children.HasValue ? (object)children.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "household"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByHousehold(string household, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE household=@household";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@household", household != null ?  (object)household : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "settle"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveBySettle(string settle, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userinfo WHERE settle=@settle";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@settle", settle != null ?  (object)settle : DBNull.Value, DbType.String, 150)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 删除全部数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int RemoveAll(TransactionManager tm = null)
		{
			return Remove(string.Empty, tm);
		}

		/// <summary>
		/// 删除指定条件的数据
		/// </summary>
		/// <param name = "where">自定义删除条件，where子句。如：id=1 and name='aaa'</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(string where, params object[] values)
		{
			return Remove(where, null, values);
		}

		/// <summary>
		/// 删除指定条件的数据
		/// </summary>
		/// <param name = "where">自定义删除条件，where子句。如：id=1 and name='aaa'</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(string where, IEnumerable<DbParameter> paras)
		{
			return Remove(where, paras, null);
		}

		/// <summary>
		/// 删除指定条件的数据
		/// </summary>
		/// <param name = "where">自定义删除条件，where子句。如：id=1 and name='aaa'</param>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(string where, TransactionManager tm, params object[] values)
		{
			const string format = @"DELETE FROM userinfo {0}";
			string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecNonQuery(tm);
		}
		/// <summary>
		/// 删除指定条件的数据
		/// </summary>
		/// <param name = "where">自定义删除条件，where子句。如：id=1 and name='aaa'</param>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			const string format = @"DELETE FROM userinfo {0}";
			string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : " WHERE " + where);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecNonQuery(tm);
		}
		#endregion

		#region  自定义方法集合

		#endregion
	}


	#endregion
}
