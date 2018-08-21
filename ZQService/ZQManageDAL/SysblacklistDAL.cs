//==========================================================
// 此代码由代码生成器工具自动生成，请不要修改
// 代码生成器核心库版本号：2.0
// 创建时间：2018/8/15 17:11:51
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
	/// 【表 sysblacklist 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class SysblacklistEO : DataEntityBase, IRowMapper<SysblacklistEO>
	{
		protected int _originalId;

		/// <summary>
		/// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
		/// </summary>
		public bool HasOriginal { get; protected set; }

		/// <summary>
		/// 【主键 int 自增字段】
		/// </summary>
		public virtual int Id { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual int OriginalId
		{
			get { return _originalId; }
			set { HasOriginal = true; _originalId = value; }
		}

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string UserId { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string AddTime { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SysblacklistEO() 
		{
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "id"></param>
		/// <param name = "userId"></param>
		/// <param name = "addTime"></param>
		public SysblacklistEO(int id, string userId, string addTime) 
		{
			Id = id;
			UserId = userId;
			AddTime = addTime;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public SysblacklistEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static SysblacklistEO GetItem(IDataReader reader)
		{
			SysblacklistEO ret = new SysblacklistEO();

			ret.Id = int.Parse(reader["id"].ToString());
			ret.OriginalId = ret.Id;
			ret.UserId = (reader["userId"] is DBNull) ? null : (string)reader["userId"];
			ret.AddTime = (reader["addTime"] is DBNull) ? null : (string)reader["addTime"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 sysblacklist 的操作类】
	/// </summary>
	public class SysblacklistMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public SysblacklistMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public SysblacklistMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "id"></param>
		/// <return></return>
		public virtual SysblacklistEO GetByPK(int id, TransactionManager tm = null)
		{
			const string sql = @"SELECT id, userId, addTime FROM sysblacklist WHERE id=@id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@id", id, DbType.Int32, 0)
							.ExecSingle<SysblacklistEO>(SysblacklistEO.GetItem, tm);
		}




		#region  按 UserId（字段） 查询

		/// <summary>
		/// 按 UserId（字段） 查询
		/// </summary>
		/// <param name = "userId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<SysblacklistEO> GetByUserId(string userId)
		{
			return GetByUserId(userId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 UserId（字段） 查询
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<SysblacklistEO> GetByUserId(string userId, TransactionManager tm)
		{
			return GetByUserId(userId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 UserId（字段） 查询
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<SysblacklistEO> GetByUserId(string userId, int top)
		{
			return GetByUserId(userId, top, string.Empty, null);
		}

		/// <summary>
		/// 按 UserId（字段） 查询
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<SysblacklistEO> GetByUserId(string userId, int top, TransactionManager tm)
		{
			return GetByUserId(userId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 UserId（字段） 查询
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<SysblacklistEO> GetByUserId(string userId, string sort)
		{
			return GetByUserId(userId, 0, sort, null);
		}

		/// <summary>
		/// 按 UserId（字段） 查询
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<SysblacklistEO> GetByUserId(string userId, string sort, TransactionManager tm)
		{
			return GetByUserId(userId, 0, sort, tm);
		}

		/// <summary>
		/// 按 UserId（字段） 查询
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<SysblacklistEO> GetByUserId(string userId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} id, userId, addTime FROM sysblacklist WHERE userId=@UserId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@UserId", userId, DbType.String, 60)
							.ExecList<SysblacklistEO>(SysblacklistEO.GetItem, tm);
		}

		#endregion

		#region  按 AddTime（字段） 查询

		/// <summary>
		/// 按 AddTime（字段） 查询
		/// </summary>
		/// <param name = "addTime"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<SysblacklistEO> GetByAddTime(string addTime)
		{
			return GetByAddTime(addTime, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 AddTime（字段） 查询
		/// </summary>
		/// <param name = "addTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<SysblacklistEO> GetByAddTime(string addTime, TransactionManager tm)
		{
			return GetByAddTime(addTime, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 AddTime（字段） 查询
		/// </summary>
		/// <param name = "addTime"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<SysblacklistEO> GetByAddTime(string addTime, int top)
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
		public virtual IEnumerable<SysblacklistEO> GetByAddTime(string addTime, int top, TransactionManager tm)
		{
			return GetByAddTime(addTime, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 AddTime（字段） 查询
		/// </summary>
		/// <param name = "addTime"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<SysblacklistEO> GetByAddTime(string addTime, string sort)
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
		public virtual IEnumerable<SysblacklistEO> GetByAddTime(string addTime, string sort, TransactionManager tm)
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
		public virtual IEnumerable<SysblacklistEO> GetByAddTime(string addTime, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} id, userId, addTime FROM sysblacklist WHERE addTime=@AddTime";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@AddTime", addTime, DbType.String, 60)
							.ExecList<SysblacklistEO>(SysblacklistEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<SysblacklistEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<SysblacklistEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<SysblacklistEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<SysblacklistEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<SysblacklistEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<SysblacklistEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<SysblacklistEO> GetTop(string where, int top)
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
		public virtual IEnumerable<SysblacklistEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<SysblacklistEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<SysblacklistEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<SysblacklistEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<SysblacklistEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<SysblacklistEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<SysblacklistEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<SysblacklistEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<SysblacklistEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<SysblacklistEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<SysblacklistEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<SysblacklistEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<SysblacklistEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<SysblacklistEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<SysblacklistEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<SysblacklistEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} id, userId, addTime FROM sysblacklist";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<SysblacklistEO>(SysblacklistEO.GetItem, tm);
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
		public virtual IEnumerable<SysblacklistEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} id, userId, addTime FROM sysblacklist";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<SysblacklistEO>(SysblacklistEO.GetItem, tm);
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
			const string format = @"SELECT id, userId, addTime FROM sysblacklist {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "id");
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
		public virtual List<SysblacklistEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<SysblacklistEO>(pageIndex);
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
		public virtual IEnumerable<SysblacklistEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<SysblacklistEO>(pageIndex);
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
		public virtual int Add(SysblacklistEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO sysblacklist (userId, addTime) VALUES (@userId, @addTime)";
			item.Id = int.Parse(Database.CreateSqlDao(sql)
												.AddInParameter("@userId", item.UserId != null ?  (object)item.UserId : DBNull.Value, DbType.String, 60)
												.AddInParameter("@addTime", item.AddTime != null ?  (object)item.AddTime : DBNull.Value, DbType.String, 60)
												.ExecScalar(tm).ToString());
			return 1;
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<SysblacklistEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO sysblacklist (userId, addTime) VALUES (@userId, @addTime)";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@userId", DbType.String, 60)
									.AddParameter("@addTime", DbType.String, 60);

			foreach (SysblacklistEO item in items)
			{
				item.Id = int.Parse(sqlDao
												.SetParameterValue("@userId", item.UserId != null ?  (object)item.UserId : DBNull.Value)
												.SetParameterValue("@addTime", item.AddTime != null ?  (object)item.AddTime : DBNull.Value)
												.ExecScalar(tm).ToString());
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
		public virtual int Put(SysblacklistEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE sysblacklist SET userId=@userId, addTime=@addTime WHERE id=@OriginalId";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalId", (item.HasOriginal) ? item.OriginalId : item.Id, DbType.Int32, 0)
							.AddInParameter("@userId", item.UserId != null ?  (object)item.UserId : DBNull.Value, DbType.String, 60)
							.AddInParameter("@addTime", item.AddTime != null ?  (object)item.AddTime : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<SysblacklistEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE sysblacklist SET userId=@userId, addTime=@addTime WHERE id=@OriginalId";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalId", DbType.Int32, 0)
									.AddParameter("@userId", DbType.String, 60)
									.AddParameter("@addTime", DbType.String, 60);

			foreach (SysblacklistEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalId", (item.HasOriginal) ? item.OriginalId : item.Id)
							.SetParameterValue("@userId", item.UserId != null ?  (object)item.UserId : DBNull.Value)
							.SetParameterValue("@addTime", item.AddTime != null ?  (object)item.AddTime : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "id"></param>
		/// <param name = "userId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUserIdByPK(int id, string userId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE sysblacklist SET userId = @userId  WHERE id = @id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@id", id, DbType.Int32, 0)
							.AddInParameter("@userId", userId != null ?  (object)userId : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "id"></param>
		/// <param name = "addTime"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutAddTimeByPK(int id, string addTime, TransactionManager tm = null)
		{
			const string sql = @"UPDATE sysblacklist SET addTime = @addTime  WHERE id = @id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@id", id, DbType.Int32, 0)
							.AddInParameter("@addTime", addTime != null ?  (object)addTime : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutUserId(string userId, TransactionManager tm = null)
		{
			const string sql = @"UPDATE sysblacklist SET userId=@userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId != null ?  (object)userId : DBNull.Value, DbType.String, 60)
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
			const string sql = @"UPDATE sysblacklist SET addTime=@addTime";
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
			const string format = @"UPDATE sysblacklist SET {0} {1}";
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
			const string format = @"UPDATE sysblacklist SET {0} {1}";
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
		/// <param name = "id"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(int id, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM sysblacklist WHERE id=@id";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@id", id, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(SysblacklistEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.Id, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<SysblacklistEO> items, TransactionManager tm = null)
		{
			return Remove(items.Select(w => w.Id), tm);
		}

		/// <summary>
		/// 根据主键删除一组记录
		/// </summary>
		/// <param name = "ids">主键编码集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<int> ids, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM sysblacklist WHERE id IN ({0})";
			return Database.CreateSqlDao(String.Format(sql, String.Join(",", ids)))
							.ExecNonQuery(tm);
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByUserId(string userId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM sysblacklist WHERE userId=@userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId != null ?  (object)userId : DBNull.Value, DbType.String, 60)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "addTime"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByAddTime(string addTime, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM sysblacklist WHERE addTime=@addTime";
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
			const string format = @"DELETE FROM sysblacklist {0}";
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
			const string format = @"DELETE FROM sysblacklist {0}";
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
