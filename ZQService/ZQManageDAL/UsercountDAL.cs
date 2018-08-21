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
	/// 【表 usercount 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class UsercountEO : DataEntityBase, IRowMapper<UsercountEO>
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
		public virtual int? LeftTimes { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? GiveTimes { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public UsercountEO() 
		{
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "openId"></param>
		/// <param name = "leftTimes"></param>
		/// <param name = "giveTimes"></param>
		public UsercountEO(int userId, string openId, int? leftTimes, int? giveTimes) 
		{
			UserId = userId;
			OpenId = openId;
			LeftTimes = leftTimes;
			GiveTimes = giveTimes;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public UsercountEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static UsercountEO GetItem(IDataReader reader)
		{
			UsercountEO ret = new UsercountEO();

			ret.UserId = int.Parse(reader["userId"].ToString());
			ret.OriginalUserId = ret.UserId;
			ret.OpenId = (reader["openId"] is DBNull) ? null : (string)reader["openId"];
			ret.LeftTimes = (reader["leftTimes"] is DBNull) ? (int?)null : int.Parse(reader["leftTimes"].ToString());
			ret.GiveTimes = (reader["giveTimes"] is DBNull) ? (int?)null : int.Parse(reader["giveTimes"].ToString());
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 usercount 的操作类】
	/// </summary>
	public class UsercountMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public UsercountMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public UsercountMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "userId"></param>
		/// <return></return>
		public virtual UsercountEO GetByPK(int userId, TransactionManager tm = null)
		{
			const string sql = @"SELECT userId, openId, leftTimes, giveTimes FROM usercount WHERE userId=@userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.Int32, 0)
							.ExecSingle<UsercountEO>(UsercountEO.GetItem, tm);
		}




		#region  按 OpenId（字段） 查询

		/// <summary>
		/// 按 OpenId（字段） 查询
		/// </summary>
		/// <param name = "openId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetByOpenId(string openId)
		{
			return GetByOpenId(openId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 OpenId（字段） 查询
		/// </summary>
		/// <param name = "openId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetByOpenId(string openId, TransactionManager tm)
		{
			return GetByOpenId(openId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 OpenId（字段） 查询
		/// </summary>
		/// <param name = "openId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetByOpenId(string openId, int top)
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
		public virtual IEnumerable<UsercountEO> GetByOpenId(string openId, int top, TransactionManager tm)
		{
			return GetByOpenId(openId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 OpenId（字段） 查询
		/// </summary>
		/// <param name = "openId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetByOpenId(string openId, string sort)
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
		public virtual IEnumerable<UsercountEO> GetByOpenId(string openId, string sort, TransactionManager tm)
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
		public virtual IEnumerable<UsercountEO> GetByOpenId(string openId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, leftTimes, giveTimes FROM usercount WHERE openId=@OpenId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@OpenId", openId, DbType.String, 300)
							.ExecList<UsercountEO>(UsercountEO.GetItem, tm);
		}

		#endregion

		#region  按 LeftTimes（字段） 查询

		/// <summary>
		/// 按 LeftTimes（字段） 查询
		/// </summary>
		/// <param name = "leftTimes"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetByLeftTimes(int? leftTimes)
		{
			return GetByLeftTimes(leftTimes, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 LeftTimes（字段） 查询
		/// </summary>
		/// <param name = "leftTimes"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetByLeftTimes(int? leftTimes, TransactionManager tm)
		{
			return GetByLeftTimes(leftTimes, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 LeftTimes（字段） 查询
		/// </summary>
		/// <param name = "leftTimes"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetByLeftTimes(int? leftTimes, int top)
		{
			return GetByLeftTimes(leftTimes, top, string.Empty, null);
		}

		/// <summary>
		/// 按 LeftTimes（字段） 查询
		/// </summary>
		/// <param name = "leftTimes"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetByLeftTimes(int? leftTimes, int top, TransactionManager tm)
		{
			return GetByLeftTimes(leftTimes, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 LeftTimes（字段） 查询
		/// </summary>
		/// <param name = "leftTimes"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetByLeftTimes(int? leftTimes, string sort)
		{
			return GetByLeftTimes(leftTimes, 0, sort, null);
		}

		/// <summary>
		/// 按 LeftTimes（字段） 查询
		/// </summary>
		/// <param name = "leftTimes"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetByLeftTimes(int? leftTimes, string sort, TransactionManager tm)
		{
			return GetByLeftTimes(leftTimes, 0, sort, tm);
		}

		/// <summary>
		/// 按 LeftTimes（字段） 查询
		/// </summary>
		/// <param name = "leftTimes"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetByLeftTimes(int? leftTimes, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, leftTimes, giveTimes FROM usercount WHERE leftTimes=@LeftTimes";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@LeftTimes", leftTimes, DbType.Int32, 0)
							.ExecList<UsercountEO>(UsercountEO.GetItem, tm);
		}

		#endregion

		#region  按 GiveTimes（字段） 查询

		/// <summary>
		/// 按 GiveTimes（字段） 查询
		/// </summary>
		/// <param name = "giveTimes"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetByGiveTimes(int? giveTimes)
		{
			return GetByGiveTimes(giveTimes, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 GiveTimes（字段） 查询
		/// </summary>
		/// <param name = "giveTimes"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetByGiveTimes(int? giveTimes, TransactionManager tm)
		{
			return GetByGiveTimes(giveTimes, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 GiveTimes（字段） 查询
		/// </summary>
		/// <param name = "giveTimes"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetByGiveTimes(int? giveTimes, int top)
		{
			return GetByGiveTimes(giveTimes, top, string.Empty, null);
		}

		/// <summary>
		/// 按 GiveTimes（字段） 查询
		/// </summary>
		/// <param name = "giveTimes"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetByGiveTimes(int? giveTimes, int top, TransactionManager tm)
		{
			return GetByGiveTimes(giveTimes, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 GiveTimes（字段） 查询
		/// </summary>
		/// <param name = "giveTimes"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetByGiveTimes(int? giveTimes, string sort)
		{
			return GetByGiveTimes(giveTimes, 0, sort, null);
		}

		/// <summary>
		/// 按 GiveTimes（字段） 查询
		/// </summary>
		/// <param name = "giveTimes"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetByGiveTimes(int? giveTimes, string sort, TransactionManager tm)
		{
			return GetByGiveTimes(giveTimes, 0, sort, tm);
		}

		/// <summary>
		/// 按 GiveTimes（字段） 查询
		/// </summary>
		/// <param name = "giveTimes"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetByGiveTimes(int? giveTimes, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, leftTimes, giveTimes FROM usercount WHERE giveTimes=@GiveTimes";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@GiveTimes", giveTimes, DbType.Int32, 0)
							.ExecList<UsercountEO>(UsercountEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<UsercountEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<UsercountEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetTop(string where, int top)
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
		public virtual IEnumerable<UsercountEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<UsercountEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<UsercountEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<UsercountEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<UsercountEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UsercountEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<UsercountEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<UsercountEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<UsercountEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<UsercountEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<UsercountEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<UsercountEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<UsercountEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<UsercountEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<UsercountEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<UsercountEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} userId, openId, leftTimes, giveTimes FROM usercount";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<UsercountEO>(UsercountEO.GetItem, tm);
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
		public virtual IEnumerable<UsercountEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, leftTimes, giveTimes FROM usercount";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<UsercountEO>(UsercountEO.GetItem, tm);
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
			const string format = @"SELECT userId, openId, leftTimes, giveTimes FROM usercount {0} {1}";
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
		public virtual List<UsercountEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<UsercountEO>(pageIndex);
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
		public virtual IEnumerable<UsercountEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<UsercountEO>(pageIndex);
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
		public virtual int Add(UsercountEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO usercount (userId, openId, leftTimes, giveTimes) VALUES (@userId, @openId, @leftTimes, @giveTimes) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", item.UserId, DbType.Int32, 0)
							.AddInParameter("@openId", item.OpenId != null ?  (object)item.OpenId : DBNull.Value, DbType.String, 300)
							.AddInParameter("@leftTimes", item.LeftTimes.HasValue ? (object)item.LeftTimes.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@giveTimes", item.GiveTimes.HasValue ? (object)item.GiveTimes.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<UsercountEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO usercount (userId, openId, leftTimes, giveTimes) VALUES (@userId, @openId, @leftTimes, @giveTimes) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@userId", DbType.Int32, 0)
									.AddParameter("@openId", DbType.String, 300)
									.AddParameter("@leftTimes", DbType.Int32, 0)
									.AddParameter("@giveTimes", DbType.Int32, 0);

			foreach (UsercountEO item in items)
			{
				sqlDao
					.SetParameterValue("@userId", item.UserId)
					.SetParameterValue("@openId", item.OpenId != null ?  (object)item.OpenId : DBNull.Value)
					.SetParameterValue("@leftTimes", item.LeftTimes.HasValue ? (object)item.LeftTimes.Value : DBNull.Value)
					.SetParameterValue("@giveTimes", item.GiveTimes.HasValue ? (object)item.GiveTimes.Value : DBNull.Value)
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
		public virtual int Put(UsercountEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE usercount SET userId=@userId, openId=@openId, leftTimes=@leftTimes, giveTimes=@giveTimes WHERE userId=@OriginalUserId";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalUserId", (item.HasOriginal) ? item.OriginalUserId : item.UserId, DbType.Int32, 0)
							.AddInParameter("@userId", item.UserId, DbType.Int32, 0)
							.AddInParameter("@openId", item.OpenId != null ?  (object)item.OpenId : DBNull.Value, DbType.String, 300)
							.AddInParameter("@leftTimes", item.LeftTimes.HasValue ? (object)item.LeftTimes.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@giveTimes", item.GiveTimes.HasValue ? (object)item.GiveTimes.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<UsercountEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE usercount SET userId=@userId, openId=@openId, leftTimes=@leftTimes, giveTimes=@giveTimes WHERE userId=@OriginalUserId";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalUserId", DbType.Int32, 0)
									.AddParameter("@userId", DbType.Int32, 0)
									.AddParameter("@openId", DbType.String, 300)
									.AddParameter("@leftTimes", DbType.Int32, 0)
									.AddParameter("@giveTimes", DbType.Int32, 0);

			foreach (UsercountEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalUserId", (item.HasOriginal) ? item.OriginalUserId : item.UserId)
							.SetParameterValue("@userId", item.UserId)
							.SetParameterValue("@openId", item.OpenId != null ?  (object)item.OpenId : DBNull.Value)
							.SetParameterValue("@leftTimes", item.LeftTimes.HasValue ? (object)item.LeftTimes.Value : DBNull.Value)
							.SetParameterValue("@giveTimes", item.GiveTimes.HasValue ? (object)item.GiveTimes.Value : DBNull.Value)
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
			const string sql = @"UPDATE usercount SET openId = @openId  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.Int32, 0)
							.AddInParameter("@openId", openId != null ?  (object)openId : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "leftTimes"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLeftTimesByPK(int userId, int? leftTimes, TransactionManager tm = null)
		{
			const string sql = @"UPDATE usercount SET leftTimes = @leftTimes  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.Int32, 0)
							.AddInParameter("@leftTimes", leftTimes.HasValue ? (object)leftTimes.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "giveTimes"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGiveTimesByPK(int userId, int? giveTimes, TransactionManager tm = null)
		{
			const string sql = @"UPDATE usercount SET giveTimes = @giveTimes  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.Int32, 0)
							.AddInParameter("@giveTimes", giveTimes.HasValue ? (object)giveTimes.Value : DBNull.Value, DbType.Int32, 0)
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
			const string sql = @"UPDATE usercount SET openId=@openId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@openId", openId != null ?  (object)openId : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "leftTimes"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutLeftTimes(int? leftTimes, TransactionManager tm = null)
		{
			const string sql = @"UPDATE usercount SET leftTimes=@leftTimes";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@leftTimes", leftTimes.HasValue ? (object)leftTimes.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "giveTimes"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutGiveTimes(int? giveTimes, TransactionManager tm = null)
		{
			const string sql = @"UPDATE usercount SET giveTimes=@giveTimes";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@giveTimes", giveTimes.HasValue ? (object)giveTimes.Value : DBNull.Value, DbType.Int32, 0)
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
			const string format = @"UPDATE usercount SET {0} {1}";
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
			const string format = @"UPDATE usercount SET {0} {1}";
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
			const string sql = @"DELETE FROM usercount WHERE userId=@userId";
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
		public virtual int Remove(UsercountEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.UserId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<UsercountEO> items, TransactionManager tm = null)
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
			const string sql = @"DELETE FROM usercount WHERE userId IN ({0})";
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
			const string sql = @"DELETE FROM usercount WHERE openId=@openId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@openId", openId != null ?  (object)openId : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "leftTimes"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByLeftTimes(int? leftTimes, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM usercount WHERE leftTimes=@leftTimes";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@leftTimes", leftTimes.HasValue ? (object)leftTimes.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "giveTimes"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByGiveTimes(int? giveTimes, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM usercount WHERE giveTimes=@giveTimes";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@giveTimes", giveTimes.HasValue ? (object)giveTimes.Value : DBNull.Value, DbType.Int32, 0)
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
			const string format = @"DELETE FROM usercount {0}";
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
			const string format = @"DELETE FROM usercount {0}";
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
