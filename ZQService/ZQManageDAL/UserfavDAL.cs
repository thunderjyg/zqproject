//==========================================================
// 此代码由代码生成器工具自动生成，请不要修改
// 代码生成器核心库版本号：2.0
// 创建时间：2018/7/26 15:43:00
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
	/// 【表 userfav 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class UserfavEO : DataEntityBase, IRowMapper<UserfavEO>
	{
		protected int _originalUserId;

		/// <summary>
		/// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
		/// </summary>
		public bool HasOriginal { get; protected set; }

		/// <summary>
		/// 【主键 int】
		/// </summary>
		public virtual int UserId { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual int OriginalUserId
		{
			get { return _originalUserId; }
			set { HasOriginal = true; _originalUserId = value; }
		}

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string OpenId { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? LuserId { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string LopenId { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? IsDel { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string AddTime { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public UserfavEO() 
		{
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "openId"></param>
		/// <param name = "luserId"></param>
		/// <param name = "lopenId"></param>
		/// <param name = "isDel"></param>
		/// <param name = "addTime"></param>
		public UserfavEO(int userId, string openId, int? luserId, string lopenId, int? isDel, string addTime) 
		{
			UserId = userId;
			OpenId = openId;
			LuserId = luserId;
			LopenId = lopenId;
			IsDel = isDel;
			AddTime = addTime;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public UserfavEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static UserfavEO GetItem(IDataReader reader)
		{
			UserfavEO ret = new UserfavEO();

			ret.UserId = int.Parse(reader["userId"].ToString());
			ret.OriginalUserId = ret.UserId;
			ret.OpenId = (reader["openId"] is DBNull) ? null : (string)reader["openId"];
			ret.LuserId = (reader["luserId"] is DBNull) ? (int?)null : int.Parse(reader["luserId"].ToString());
			ret.LopenId = (reader["lopenId"] is DBNull) ? null : (string)reader["lopenId"];
			ret.IsDel = (reader["isDel"] is DBNull) ? (int?)null : int.Parse(reader["isDel"].ToString());
			ret.AddTime = (reader["addTime"] is DBNull) ? null : (string)reader["addTime"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 userfav 的操作类】
	/// </summary>
	public class UserfavMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public UserfavMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public UserfavMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "userId"></param>
		/// <return></return>
		public virtual UserfavEO GetByPK(int userId, TransactionManager tm = null)
		{
			const string sql = @"SELECT userId, openId, luserId, lopenId, isDel, addTime FROM userfav WHERE userId=@userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.Int32, 0)
							.ExecSingle<UserfavEO>(UserfavEO.GetItem, tm);
		}




		#region  按 OpenId（字段） 查询

		/// <summary>
		/// 按 OpenId（字段） 查询
		/// </summary>
		/// <param name = "openId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByOpenId(string openId)
		{
			return GetByOpenId(openId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 OpenId（字段） 查询
		/// </summary>
		/// <param name = "openId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByOpenId(string openId, TransactionManager tm)
		{
			return GetByOpenId(openId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 OpenId（字段） 查询
		/// </summary>
		/// <param name = "openId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByOpenId(string openId, int top)
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
		public virtual IEnumerable<UserfavEO> GetByOpenId(string openId, int top, TransactionManager tm)
		{
			return GetByOpenId(openId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 OpenId（字段） 查询
		/// </summary>
		/// <param name = "openId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByOpenId(string openId, string sort)
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
		public virtual IEnumerable<UserfavEO> GetByOpenId(string openId, string sort, TransactionManager tm)
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
		public virtual IEnumerable<UserfavEO> GetByOpenId(string openId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, luserId, lopenId, isDel, addTime FROM userfav WHERE openId=@OpenId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@OpenId", openId, DbType.String, 300)
							.ExecList<UserfavEO>(UserfavEO.GetItem, tm);
		}

		#endregion

		#region  按 LuserId（字段） 查询

		/// <summary>
		/// 按 LuserId（字段） 查询
		/// </summary>
		/// <param name = "luserId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByLuserId(int? luserId)
		{
			return GetByLuserId(luserId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 LuserId（字段） 查询
		/// </summary>
		/// <param name = "luserId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByLuserId(int? luserId, TransactionManager tm)
		{
			return GetByLuserId(luserId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 LuserId（字段） 查询
		/// </summary>
		/// <param name = "luserId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByLuserId(int? luserId, int top)
		{
			return GetByLuserId(luserId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 LuserId（字段） 查询
		/// </summary>
		/// <param name = "luserId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByLuserId(int? luserId, int top, TransactionManager tm)
		{
			return GetByLuserId(luserId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 LuserId（字段） 查询
		/// </summary>
		/// <param name = "luserId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByLuserId(int? luserId, string sort)
		{
			return GetByLuserId(luserId, 0, sort, null);
		}

		/// <summary>
		/// 按 LuserId（字段） 查询
		/// </summary>
		/// <param name = "luserId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByLuserId(int? luserId, string sort, TransactionManager tm)
		{
			return GetByLuserId(luserId, 0, sort, tm);
		}

		/// <summary>
		/// 按 LuserId（字段） 查询
		/// </summary>
		/// <param name = "luserId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByLuserId(int? luserId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, luserId, lopenId, isDel, addTime FROM userfav WHERE luserId=@LuserId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@LuserId", luserId, DbType.Int32, 0)
							.ExecList<UserfavEO>(UserfavEO.GetItem, tm);
		}

		#endregion

		#region  按 LopenId（字段） 查询

		/// <summary>
		/// 按 LopenId（字段） 查询
		/// </summary>
		/// <param name = "lopenId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByLopenId(string lopenId)
		{
			return GetByLopenId(lopenId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 LopenId（字段） 查询
		/// </summary>
		/// <param name = "lopenId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByLopenId(string lopenId, TransactionManager tm)
		{
			return GetByLopenId(lopenId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 LopenId（字段） 查询
		/// </summary>
		/// <param name = "lopenId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByLopenId(string lopenId, int top)
		{
			return GetByLopenId(lopenId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 LopenId（字段） 查询
		/// </summary>
		/// <param name = "lopenId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByLopenId(string lopenId, int top, TransactionManager tm)
		{
			return GetByLopenId(lopenId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 LopenId（字段） 查询
		/// </summary>
		/// <param name = "lopenId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByLopenId(string lopenId, string sort)
		{
			return GetByLopenId(lopenId, 0, sort, null);
		}

		/// <summary>
		/// 按 LopenId（字段） 查询
		/// </summary>
		/// <param name = "lopenId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByLopenId(string lopenId, string sort, TransactionManager tm)
		{
			return GetByLopenId(lopenId, 0, sort, tm);
		}

		/// <summary>
		/// 按 LopenId（字段） 查询
		/// </summary>
		/// <param name = "lopenId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByLopenId(string lopenId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, luserId, lopenId, isDel, addTime FROM userfav WHERE lopenId=@LopenId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@LopenId", lopenId, DbType.String, 300)
							.ExecList<UserfavEO>(UserfavEO.GetItem, tm);
		}

		#endregion

		#region  按 IsDel（字段） 查询

		/// <summary>
		/// 按 IsDel（字段） 查询
		/// </summary>
		/// <param name = "isDel"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByIsDel(int? isDel)
		{
			return GetByIsDel(isDel, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 IsDel（字段） 查询
		/// </summary>
		/// <param name = "isDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByIsDel(int? isDel, TransactionManager tm)
		{
			return GetByIsDel(isDel, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 IsDel（字段） 查询
		/// </summary>
		/// <param name = "isDel"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByIsDel(int? isDel, int top)
		{
			return GetByIsDel(isDel, top, string.Empty, null);
		}

		/// <summary>
		/// 按 IsDel（字段） 查询
		/// </summary>
		/// <param name = "isDel"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByIsDel(int? isDel, int top, TransactionManager tm)
		{
			return GetByIsDel(isDel, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 IsDel（字段） 查询
		/// </summary>
		/// <param name = "isDel"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByIsDel(int? isDel, string sort)
		{
			return GetByIsDel(isDel, 0, sort, null);
		}

		/// <summary>
		/// 按 IsDel（字段） 查询
		/// </summary>
		/// <param name = "isDel"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByIsDel(int? isDel, string sort, TransactionManager tm)
		{
			return GetByIsDel(isDel, 0, sort, tm);
		}

		/// <summary>
		/// 按 IsDel（字段） 查询
		/// </summary>
		/// <param name = "isDel"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByIsDel(int? isDel, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, luserId, lopenId, isDel, addTime FROM userfav WHERE isDel=@IsDel";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@IsDel", isDel, DbType.Int32, 0)
							.ExecList<UserfavEO>(UserfavEO.GetItem, tm);
		}

		#endregion

		#region  按 AddTime（字段） 查询

		/// <summary>
		/// 按 AddTime（字段） 查询
		/// </summary>
		/// <param name = "addTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByAddTime(string addTime)
		{
			return GetByAddTime(addTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 AddTime（字段） 查询
		/// </summary>
		/// <param name = "addTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByAddTime(string addTime, TransactionManager tm)
		{
			return GetByAddTime(addTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 AddTime（字段） 查询
		/// </summary>
		/// <param name = "addTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByAddTime(string addTime, int top)
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
		public virtual IEnumerable<UserfavEO> GetByAddTime(string addTime, int top, TransactionManager tm)
		{
			return GetByAddTime(addTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 AddTime（字段） 查询
		/// </summary>
		/// <param name = "addTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetByAddTime(string addTime, string sort)
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
		public virtual IEnumerable<UserfavEO> GetByAddTime(string addTime, string sort, TransactionManager tm)
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
		public virtual IEnumerable<UserfavEO> GetByAddTime(string addTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, luserId, lopenId, isDel, addTime FROM userfav WHERE addTime=@AddTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@AddTime", addTime, DbType.String, 60)
							.ExecList<UserfavEO>(UserfavEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<UserfavEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<UserfavEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetTop(string where, int top)
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
		public virtual IEnumerable<UserfavEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<UserfavEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<UserfavEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<UserfavEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<UserfavEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserfavEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<UserfavEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<UserfavEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<UserfavEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<UserfavEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<UserfavEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<UserfavEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<UserfavEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<UserfavEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<UserfavEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<UserfavEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} userId, openId, luserId, lopenId, isDel, addTime FROM userfav";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<UserfavEO>(UserfavEO.GetItem, tm);
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
		public virtual IEnumerable<UserfavEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, luserId, lopenId, isDel, addTime FROM userfav";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<UserfavEO>(UserfavEO.GetItem, tm);
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
			const string format = @"SELECT userId, openId, luserId, lopenId, isDel, addTime FROM userfav {0} {1}";
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
		public virtual List<UserfavEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<UserfavEO>(pageIndex);
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
		public virtual IEnumerable<UserfavEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<UserfavEO>(pageIndex);
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
		public virtual int Add(UserfavEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO userfav (userId, openId, luserId, lopenId, isDel, addTime) VALUES (@userId, @openId, @luserId, @lopenId, @isDel, @addTime) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", item.UserId, DbType.Int32, 0)
							.AddInParameter("@openId", item.OpenId != null ?  (object)item.OpenId : DBNull.Value, DbType.String, 300)
							.AddInParameter("@luserId", item.LuserId.HasValue ? (object)item.LuserId.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@lopenId", item.LopenId != null ?  (object)item.LopenId : DBNull.Value, DbType.String, 300)
							.AddInParameter("@isDel", item.IsDel.HasValue ? (object)item.IsDel.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@addTime", item.AddTime != null ?  (object)item.AddTime : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<UserfavEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO userfav (userId, openId, luserId, lopenId, isDel, addTime) VALUES (@userId, @openId, @luserId, @lopenId, @isDel, @addTime) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@userId", DbType.Int32, 0)
									.AddParameter("@openId", DbType.String, 300)
									.AddParameter("@luserId", DbType.Int32, 0)
									.AddParameter("@lopenId", DbType.String, 300)
									.AddParameter("@isDel", DbType.Int32, 0)
									.AddParameter("@addTime", DbType.String, 60);

			foreach (UserfavEO item in items)
			{
				sqlDao
					.SetParameterValue("@userId", item.UserId)
					.SetParameterValue("@openId", item.OpenId != null ?  (object)item.OpenId : DBNull.Value)
					.SetParameterValue("@luserId", item.LuserId.HasValue ? (object)item.LuserId.Value : DBNull.Value)
					.SetParameterValue("@lopenId", item.LopenId != null ?  (object)item.LopenId : DBNull.Value)
					.SetParameterValue("@isDel", item.IsDel.HasValue ? (object)item.IsDel.Value : DBNull.Value)
					.SetParameterValue("@addTime", item.AddTime != null ?  (object)item.AddTime : DBNull.Value)
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
		public virtual int Put(UserfavEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userfav SET userId=@userId, openId=@openId, luserId=@luserId, lopenId=@lopenId, isDel=@isDel, addTime=@addTime WHERE userId=@OriginalUserId";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalUserId", (item.HasOriginal) ? item.OriginalUserId : item.UserId, DbType.Int32, 0)
							.AddInParameter("@userId", item.UserId, DbType.Int32, 0)
							.AddInParameter("@openId", item.OpenId != null ?  (object)item.OpenId : DBNull.Value, DbType.String, 300)
							.AddInParameter("@luserId", item.LuserId.HasValue ? (object)item.LuserId.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@lopenId", item.LopenId != null ?  (object)item.LopenId : DBNull.Value, DbType.String, 300)
							.AddInParameter("@isDel", item.IsDel.HasValue ? (object)item.IsDel.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@addTime", item.AddTime != null ?  (object)item.AddTime : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<UserfavEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE userfav SET userId=@userId, openId=@openId, luserId=@luserId, lopenId=@lopenId, isDel=@isDel, addTime=@addTime WHERE userId=@OriginalUserId";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalUserId", DbType.Int32, 0)
									.AddParameter("@userId", DbType.Int32, 0)
									.AddParameter("@openId", DbType.String, 300)
									.AddParameter("@luserId", DbType.Int32, 0)
									.AddParameter("@lopenId", DbType.String, 300)
									.AddParameter("@isDel", DbType.Int32, 0)
									.AddParameter("@addTime", DbType.String, 60);

			foreach (UserfavEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalUserId", (item.HasOriginal) ? item.OriginalUserId : item.UserId)
							.SetParameterValue("@userId", item.UserId)
							.SetParameterValue("@openId", item.OpenId != null ?  (object)item.OpenId : DBNull.Value)
							.SetParameterValue("@luserId", item.LuserId.HasValue ? (object)item.LuserId.Value : DBNull.Value)
							.SetParameterValue("@lopenId", item.LopenId != null ?  (object)item.LopenId : DBNull.Value)
							.SetParameterValue("@isDel", item.IsDel.HasValue ? (object)item.IsDel.Value : DBNull.Value)
							.SetParameterValue("@addTime", item.AddTime != null ?  (object)item.AddTime : DBNull.Value)
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
		public virtual int PutOpenIdByPK(int userId, string openId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userfav SET openId = @openId  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.Int32, 0)
							.AddInParameter("@openId", openId != null ?  (object)openId : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "luserId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLuserIdByPK(int userId, int? luserId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userfav SET luserId = @luserId  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.Int32, 0)
							.AddInParameter("@luserId", luserId.HasValue ? (object)luserId.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "lopenId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLopenIdByPK(int userId, string lopenId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userfav SET lopenId = @lopenId  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.Int32, 0)
							.AddInParameter("@lopenId", lopenId != null ?  (object)lopenId : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "isDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutIsDelByPK(int userId, int? isDel, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userfav SET isDel = @isDel  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.Int32, 0)
							.AddInParameter("@isDel", isDel.HasValue ? (object)isDel.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "addTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutAddTimeByPK(int userId, string addTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userfav SET addTime = @addTime  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.Int32, 0)
							.AddInParameter("@addTime", addTime != null ?  (object)addTime : DBNull.Value, DbType.String, 60)
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
			const string sql = @"UPDATE userfav SET openId=@openId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@openId", openId != null ?  (object)openId : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "luserId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLuserId(int? luserId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userfav SET luserId=@luserId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@luserId", luserId.HasValue ? (object)luserId.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "lopenId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLopenId(string lopenId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userfav SET lopenId=@lopenId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@lopenId", lopenId != null ?  (object)lopenId : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "isDel"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutIsDel(int? isDel, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userfav SET isDel=@isDel";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@isDel", isDel.HasValue ? (object)isDel.Value : DBNull.Value, DbType.Int32, 0)
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
			const string sql = @"UPDATE userfav SET addTime=@addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@addTime", addTime != null ?  (object)addTime : DBNull.Value, DbType.String, 60)
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
			const string format = @"UPDATE userfav SET {0} {1}";
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
			const string format = @"UPDATE userfav SET {0} {1}";
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
		public virtual int RemoveByPK(int userId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userfav WHERE userId=@userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(UserfavEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.UserId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<UserfavEO> items, TransactionManager tm = null)
		{
			return Remove(items.Select(w => w.UserId), tm);
		}

		/// <summary>
		/// 根据主键删除一组记录
		/// </summary>
		/// <param name = "userIds">主键编码集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<int> userIds, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userfav WHERE userId IN ({0})";
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
			const string sql = @"DELETE FROM userfav WHERE openId=@openId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@openId", openId != null ?  (object)openId : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "luserId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByLuserId(int? luserId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userfav WHERE luserId=@luserId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@luserId", luserId.HasValue ? (object)luserId.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "lopenId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByLopenId(string lopenId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userfav WHERE lopenId=@lopenId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@lopenId", lopenId != null ?  (object)lopenId : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "isDel"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByIsDel(int? isDel, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userfav WHERE isDel=@isDel";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@isDel", isDel.HasValue ? (object)isDel.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "addTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByAddTime(string addTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userfav WHERE addTime=@addTime";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@addTime", addTime != null ?  (object)addTime : DBNull.Value, DbType.String, 60)
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
			const string format = @"DELETE FROM userfav {0}";
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
			const string format = @"DELETE FROM userfav {0}";
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
