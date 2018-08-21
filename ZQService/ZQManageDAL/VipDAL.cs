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
	/// 【表 vip 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class VipEO : DataEntityBase, IRowMapper<VipEO>
	{
		protected int _originalVipId;

		/// <summary>
		/// 主键是否有原始值（即数据库中保存的值），用于实体对象更新时
		/// </summary>
		public bool HasOriginal { get; protected set; }

		/// <summary>
		/// 【主键 int】
		/// </summary>
		public virtual int VipId { get; set; }

		/// <summary>
		/// 【数据库中的原始主键值副本】
		/// </summary>
		public virtual int OriginalVipId
		{
			get { return _originalVipId; }
			set { HasOriginal = true; _originalVipId = value; }
		}

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? VipTimes { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? VipMoney { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public VipEO() 
		{
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "vipId"></param>
		/// <param name = "vipTimes"></param>
		/// <param name = "vipMoney"></param>
		public VipEO(int vipId, int? vipTimes, int? vipMoney) 
		{
			VipId = vipId;
			VipTimes = vipTimes;
			VipMoney = vipMoney;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public VipEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static VipEO GetItem(IDataReader reader)
		{
			VipEO ret = new VipEO();

			ret.VipId = int.Parse(reader["vipId"].ToString());
			ret.OriginalVipId = ret.VipId;
			ret.VipTimes = (reader["vipTimes"] is DBNull) ? (int?)null : int.Parse(reader["vipTimes"].ToString());
			ret.VipMoney = (reader["vipMoney"] is DBNull) ? (int?)null : int.Parse(reader["vipMoney"].ToString());
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 vip 的操作类】
	/// </summary>
	public class VipMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public VipMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public VipMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "vipId"></param>
		/// <return></return>
		public virtual VipEO GetByPK(int vipId, TransactionManager tm = null)
		{
			const string sql = @"SELECT vipId, vipTimes, vipMoney FROM vip WHERE vipId=@vipId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@vipId", vipId, DbType.Int32, 0)
							.ExecSingle<VipEO>(VipEO.GetItem, tm);
		}




		#region  按 VipTimes（字段） 查询

		/// <summary>
		/// 按 VipTimes（字段） 查询
		/// </summary>
		/// <param name = "vipTimes"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> GetByVipTimes(int? vipTimes)
		{
			return GetByVipTimes(vipTimes, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 VipTimes（字段） 查询
		/// </summary>
		/// <param name = "vipTimes"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> GetByVipTimes(int? vipTimes, TransactionManager tm)
		{
			return GetByVipTimes(vipTimes, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 VipTimes（字段） 查询
		/// </summary>
		/// <param name = "vipTimes"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> GetByVipTimes(int? vipTimes, int top)
		{
			return GetByVipTimes(vipTimes, top, string.Empty, null);
		}

		/// <summary>
		/// 按 VipTimes（字段） 查询
		/// </summary>
		/// <param name = "vipTimes"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> GetByVipTimes(int? vipTimes, int top, TransactionManager tm)
		{
			return GetByVipTimes(vipTimes, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 VipTimes（字段） 查询
		/// </summary>
		/// <param name = "vipTimes"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> GetByVipTimes(int? vipTimes, string sort)
		{
			return GetByVipTimes(vipTimes, 0, sort, null);
		}

		/// <summary>
		/// 按 VipTimes（字段） 查询
		/// </summary>
		/// <param name = "vipTimes"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> GetByVipTimes(int? vipTimes, string sort, TransactionManager tm)
		{
			return GetByVipTimes(vipTimes, 0, sort, tm);
		}

		/// <summary>
		/// 按 VipTimes（字段） 查询
		/// </summary>
		/// <param name = "vipTimes"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> GetByVipTimes(int? vipTimes, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} vipId, vipTimes, vipMoney FROM vip WHERE vipTimes=@VipTimes";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@VipTimes", vipTimes, DbType.Int32, 0)
							.ExecList<VipEO>(VipEO.GetItem, tm);
		}

		#endregion

		#region  按 VipMoney（字段） 查询

		/// <summary>
		/// 按 VipMoney（字段） 查询
		/// </summary>
		/// <param name = "vipMoney"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> GetByVipMoney(int? vipMoney)
		{
			return GetByVipMoney(vipMoney, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 VipMoney（字段） 查询
		/// </summary>
		/// <param name = "vipMoney"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> GetByVipMoney(int? vipMoney, TransactionManager tm)
		{
			return GetByVipMoney(vipMoney, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 VipMoney（字段） 查询
		/// </summary>
		/// <param name = "vipMoney"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> GetByVipMoney(int? vipMoney, int top)
		{
			return GetByVipMoney(vipMoney, top, string.Empty, null);
		}

		/// <summary>
		/// 按 VipMoney（字段） 查询
		/// </summary>
		/// <param name = "vipMoney"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> GetByVipMoney(int? vipMoney, int top, TransactionManager tm)
		{
			return GetByVipMoney(vipMoney, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 VipMoney（字段） 查询
		/// </summary>
		/// <param name = "vipMoney"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> GetByVipMoney(int? vipMoney, string sort)
		{
			return GetByVipMoney(vipMoney, 0, sort, null);
		}

		/// <summary>
		/// 按 VipMoney（字段） 查询
		/// </summary>
		/// <param name = "vipMoney"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> GetByVipMoney(int? vipMoney, string sort, TransactionManager tm)
		{
			return GetByVipMoney(vipMoney, 0, sort, tm);
		}

		/// <summary>
		/// 按 VipMoney（字段） 查询
		/// </summary>
		/// <param name = "vipMoney"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> GetByVipMoney(int? vipMoney, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} vipId, vipTimes, vipMoney FROM vip WHERE vipMoney=@VipMoney";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@VipMoney", vipMoney, DbType.Int32, 0)
							.ExecList<VipEO>(VipEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<VipEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<VipEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> GetTop(string where, int top)
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
		public virtual IEnumerable<VipEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<VipEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<VipEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<VipEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<VipEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<VipEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<VipEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<VipEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<VipEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<VipEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<VipEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<VipEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<VipEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<VipEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<VipEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<VipEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} vipId, vipTimes, vipMoney FROM vip";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<VipEO>(VipEO.GetItem, tm);
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
		public virtual IEnumerable<VipEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} vipId, vipTimes, vipMoney FROM vip";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<VipEO>(VipEO.GetItem, tm);
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
			const string format = @"SELECT vipId, vipTimes, vipMoney FROM vip {0} {1}";
			 string sql = string.Format(format, string.IsNullOrEmpty(where) ? string.Empty : "WHERE " + where, string.IsNullOrEmpty(sort) ? string.Empty : "ORDER BY " + sort);

			return Database.CreatePager(sql, pageSize, "vipId");
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
		public virtual List<VipEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<VipEO>(pageIndex);
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
		public virtual IEnumerable<VipEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<VipEO>(pageIndex);
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
		public virtual int Add(VipEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO vip (vipId, vipTimes, vipMoney) VALUES (@vipId, @vipTimes, @vipMoney) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@vipId", item.VipId, DbType.Int32, 0)
							.AddInParameter("@vipTimes", item.VipTimes.HasValue ? (object)item.VipTimes.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@vipMoney", item.VipMoney.HasValue ? (object)item.VipMoney.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<VipEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO vip (vipId, vipTimes, vipMoney) VALUES (@vipId, @vipTimes, @vipMoney) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@vipId", DbType.Int32, 0)
									.AddParameter("@vipTimes", DbType.Int32, 0)
									.AddParameter("@vipMoney", DbType.Int32, 0);

			foreach (VipEO item in items)
			{
				sqlDao
					.SetParameterValue("@vipId", item.VipId)
					.SetParameterValue("@vipTimes", item.VipTimes.HasValue ? (object)item.VipTimes.Value : DBNull.Value)
					.SetParameterValue("@vipMoney", item.VipMoney.HasValue ? (object)item.VipMoney.Value : DBNull.Value)
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
		public virtual int Put(VipEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE vip SET vipId=@vipId, vipTimes=@vipTimes, vipMoney=@vipMoney WHERE vipId=@OriginalVipId";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalVipId", (item.HasOriginal) ? item.OriginalVipId : item.VipId, DbType.Int32, 0)
							.AddInParameter("@vipId", item.VipId, DbType.Int32, 0)
							.AddInParameter("@vipTimes", item.VipTimes.HasValue ? (object)item.VipTimes.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@vipMoney", item.VipMoney.HasValue ? (object)item.VipMoney.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<VipEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE vip SET vipId=@vipId, vipTimes=@vipTimes, vipMoney=@vipMoney WHERE vipId=@OriginalVipId";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalVipId", DbType.Int32, 0)
									.AddParameter("@vipId", DbType.Int32, 0)
									.AddParameter("@vipTimes", DbType.Int32, 0)
									.AddParameter("@vipMoney", DbType.Int32, 0);

			foreach (VipEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalVipId", (item.HasOriginal) ? item.OriginalVipId : item.VipId)
							.SetParameterValue("@vipId", item.VipId)
							.SetParameterValue("@vipTimes", item.VipTimes.HasValue ? (object)item.VipTimes.Value : DBNull.Value)
							.SetParameterValue("@vipMoney", item.VipMoney.HasValue ? (object)item.VipMoney.Value : DBNull.Value)
							.ExecNonQuery(tm);
			}
			return ret;
		}


		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "vipId"></param>
		/// <param name = "vipTimes"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutVipTimesByPK(int vipId, int? vipTimes, TransactionManager tm = null)
		{
			const string sql = @"UPDATE vip SET vipTimes = @vipTimes  WHERE vipId = @vipId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@vipId", vipId, DbType.Int32, 0)
							.AddInParameter("@vipTimes", vipTimes.HasValue ? (object)vipTimes.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "vipId"></param>
		/// <param name = "vipMoney"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutVipMoneyByPK(int vipId, int? vipMoney, TransactionManager tm = null)
		{
			const string sql = @"UPDATE vip SET vipMoney = @vipMoney  WHERE vipId = @vipId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@vipId", vipId, DbType.Int32, 0)
							.AddInParameter("@vipMoney", vipMoney.HasValue ? (object)vipMoney.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "vipTimes"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutVipTimes(int? vipTimes, TransactionManager tm = null)
		{
			const string sql = @"UPDATE vip SET vipTimes=@vipTimes";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@vipTimes", vipTimes.HasValue ? (object)vipTimes.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "vipMoney"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutVipMoney(int? vipMoney, TransactionManager tm = null)
		{
			const string sql = @"UPDATE vip SET vipMoney=@vipMoney";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@vipMoney", vipMoney.HasValue ? (object)vipMoney.Value : DBNull.Value, DbType.Int32, 0)
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
			const string format = @"UPDATE vip SET {0} {1}";
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
			const string format = @"UPDATE vip SET {0} {1}";
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
		/// <param name = "vipId"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPK(int vipId, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM vip WHERE vipId=@vipId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@vipId", vipId, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(VipEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.VipId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<VipEO> items, TransactionManager tm = null)
		{
			return Remove(items.Select(w => w.VipId), tm);
		}

		/// <summary>
		/// 根据主键删除一组记录
		/// </summary>
		/// <param name = "vipIds">主键编码集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<int> vipIds, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM vip WHERE vipId IN ({0})";
			return Database.CreateSqlDao(String.Format(sql, String.Join(",", vipIds)))
							.ExecNonQuery(tm);
		}




		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "vipTimes"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByVipTimes(int? vipTimes, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM vip WHERE vipTimes=@vipTimes";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@vipTimes", vipTimes.HasValue ? (object)vipTimes.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "vipMoney"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByVipMoney(int? vipMoney, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM vip WHERE vipMoney=@vipMoney";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@vipMoney", vipMoney.HasValue ? (object)vipMoney.Value : DBNull.Value, DbType.Int32, 0)
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
			const string format = @"DELETE FROM vip {0}";
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
			const string format = @"DELETE FROM vip {0}";
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
