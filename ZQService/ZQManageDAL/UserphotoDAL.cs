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
	/// 【表 userphoto 的实体类】
	/// </summary>
	[SerializableAttribute]
	public class UserphotoEO : DataEntityBase, IRowMapper<UserphotoEO>
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
		/// 【字段 varchar】
		/// </summary>
		public virtual string Photos { get; set; }

		/// <summary>
		/// 【字段 int】
		/// </summary>
		public virtual int? PhotosIndex { get; set; }

		/// <summary>
		/// 【字段 varchar】
		/// </summary>
		public virtual string IdCardImg { get; set; }

		/// <summary>
		/// 默认构造函数
		/// </summary>
		public UserphotoEO() 
		{
		}

		/// <summary>
		/// 自定义构造函数
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "openId"></param>
		/// <param name = "photos"></param>
		/// <param name = "photosIndex"></param>
		/// <param name = "idCardImg"></param>
		public UserphotoEO(int userId, string openId, string photos, int? photosIndex, string idCardImg) 
		{
			UserId = userId;
			OpenId = openId;
			Photos = photos;
			PhotosIndex = photosIndex;
			IdCardImg = idCardImg;
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public UserphotoEO MapRow(IDataReader reader)
		{
			return GetItem(reader);
		}

		/// <summary>
		/// 将结果集映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static UserphotoEO GetItem(IDataReader reader)
		{
			UserphotoEO ret = new UserphotoEO();

			ret.UserId = int.Parse(reader["userId"].ToString());
			ret.OriginalUserId = ret.UserId;
			ret.OpenId = (reader["openId"] is DBNull) ? null : (string)reader["openId"];
			ret.Photos = (reader["photos"] is DBNull) ? null : (string)reader["photos"];
			ret.PhotosIndex = (reader["photosIndex"] is DBNull) ? (int?)null : int.Parse(reader["photosIndex"].ToString());
			ret.IdCardImg = (reader["idCardImg"] is DBNull) ? null : (string)reader["idCardImg"];
			return ret;
		}
	}


	#endregion

	#region  MO

	/// <summary>
	/// 【表 userphoto 的操作类】
	/// </summary>
	public class UserphotoMO : DataManagerBase
	{

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "routeData">路由数据</param>
		public UserphotoMO(object routeData = null) : base(routeData) { }

		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">连接字符串名称</param>
		public UserphotoMO(string connectionStringName) : base(connectionStringName) { }

		#region  Get方法集合

		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <param name = "userId"></param>
		/// <return></return>
		public virtual UserphotoEO GetByPK(int userId, TransactionManager tm = null)
		{
			const string sql = @"SELECT userId, openId, photos, photosIndex, idCardImg FROM userphoto WHERE userId=@userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.Int32, 0)
							.ExecSingle<UserphotoEO>(UserphotoEO.GetItem, tm);
		}




		#region  按 OpenId（字段） 查询

		/// <summary>
		/// 按 OpenId（字段） 查询
		/// </summary>
		/// <param name = "openId"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByOpenId(string openId)
		{
			return GetByOpenId(openId, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 OpenId（字段） 查询
		/// </summary>
		/// <param name = "openId"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByOpenId(string openId, TransactionManager tm)
		{
			return GetByOpenId(openId, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 OpenId（字段） 查询
		/// </summary>
		/// <param name = "openId"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByOpenId(string openId, int top)
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
		public virtual IEnumerable<UserphotoEO> GetByOpenId(string openId, int top, TransactionManager tm)
		{
			return GetByOpenId(openId, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 OpenId（字段） 查询
		/// </summary>
		/// <param name = "openId"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByOpenId(string openId, string sort)
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
		public virtual IEnumerable<UserphotoEO> GetByOpenId(string openId, string sort, TransactionManager tm)
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
		public virtual IEnumerable<UserphotoEO> GetByOpenId(string openId, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, photos, photosIndex, idCardImg FROM userphoto WHERE openId=@OpenId";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@OpenId", openId, DbType.String, 300)
							.ExecList<UserphotoEO>(UserphotoEO.GetItem, tm);
		}

		#endregion

		#region  按 Photos（字段） 查询

		/// <summary>
		/// 按 Photos（字段） 查询
		/// </summary>
		/// <param name = "photos"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByPhotos(string photos)
		{
			return GetByPhotos(photos, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 Photos（字段） 查询
		/// </summary>
		/// <param name = "photos"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByPhotos(string photos, TransactionManager tm)
		{
			return GetByPhotos(photos, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 Photos（字段） 查询
		/// </summary>
		/// <param name = "photos"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByPhotos(string photos, int top)
		{
			return GetByPhotos(photos, top, string.Empty, null);
		}

		/// <summary>
		/// 按 Photos（字段） 查询
		/// </summary>
		/// <param name = "photos"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByPhotos(string photos, int top, TransactionManager tm)
		{
			return GetByPhotos(photos, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 Photos（字段） 查询
		/// </summary>
		/// <param name = "photos"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByPhotos(string photos, string sort)
		{
			return GetByPhotos(photos, 0, sort, null);
		}

		/// <summary>
		/// 按 Photos（字段） 查询
		/// </summary>
		/// <param name = "photos"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByPhotos(string photos, string sort, TransactionManager tm)
		{
			return GetByPhotos(photos, 0, sort, tm);
		}

		/// <summary>
		/// 按 Photos（字段） 查询
		/// </summary>
		/// <param name = "photos"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByPhotos(string photos, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, photos, photosIndex, idCardImg FROM userphoto WHERE photos=@Photos";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@Photos", photos, DbType.String, 600)
							.ExecList<UserphotoEO>(UserphotoEO.GetItem, tm);
		}

		#endregion

		#region  按 PhotosIndex（字段） 查询

		/// <summary>
		/// 按 PhotosIndex（字段） 查询
		/// </summary>
		/// <param name = "photosIndex"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByPhotosIndex(int? photosIndex)
		{
			return GetByPhotosIndex(photosIndex, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 PhotosIndex（字段） 查询
		/// </summary>
		/// <param name = "photosIndex"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByPhotosIndex(int? photosIndex, TransactionManager tm)
		{
			return GetByPhotosIndex(photosIndex, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 PhotosIndex（字段） 查询
		/// </summary>
		/// <param name = "photosIndex"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByPhotosIndex(int? photosIndex, int top)
		{
			return GetByPhotosIndex(photosIndex, top, string.Empty, null);
		}

		/// <summary>
		/// 按 PhotosIndex（字段） 查询
		/// </summary>
		/// <param name = "photosIndex"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByPhotosIndex(int? photosIndex, int top, TransactionManager tm)
		{
			return GetByPhotosIndex(photosIndex, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 PhotosIndex（字段） 查询
		/// </summary>
		/// <param name = "photosIndex"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByPhotosIndex(int? photosIndex, string sort)
		{
			return GetByPhotosIndex(photosIndex, 0, sort, null);
		}

		/// <summary>
		/// 按 PhotosIndex（字段） 查询
		/// </summary>
		/// <param name = "photosIndex"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByPhotosIndex(int? photosIndex, string sort, TransactionManager tm)
		{
			return GetByPhotosIndex(photosIndex, 0, sort, tm);
		}

		/// <summary>
		/// 按 PhotosIndex（字段） 查询
		/// </summary>
		/// <param name = "photosIndex"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByPhotosIndex(int? photosIndex, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, photos, photosIndex, idCardImg FROM userphoto WHERE photosIndex=@PhotosIndex";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@PhotosIndex", photosIndex, DbType.Int32, 0)
							.ExecList<UserphotoEO>(UserphotoEO.GetItem, tm);
		}

		#endregion

		#region  按 IdCardImg（字段） 查询

		/// <summary>
		/// 按 IdCardImg（字段） 查询
		/// </summary>
		/// <param name = "idCardImg"></param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByIdCardImg(string idCardImg)
		{
			return GetByIdCardImg(idCardImg, 0, string.Empty, null);
		}

		/// <summary>
		/// 按 IdCardImg（字段） 查询
		/// </summary>
		/// <param name = "idCardImg"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByIdCardImg(string idCardImg, TransactionManager tm)
		{
			return GetByIdCardImg(idCardImg, 0, string.Empty, tm);
		}

		/// <summary>
		/// 按 IdCardImg（字段） 查询
		/// </summary>
		/// <param name = "idCardImg"></param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByIdCardImg(string idCardImg, int top)
		{
			return GetByIdCardImg(idCardImg, top, string.Empty, null);
		}

		/// <summary>
		/// 按 IdCardImg（字段） 查询
		/// </summary>
		/// <param name = "idCardImg"></param>
		/// <param name = "top">获取行数</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByIdCardImg(string idCardImg, int top, TransactionManager tm)
		{
			return GetByIdCardImg(idCardImg, top, string.Empty, tm);
		}

		/// <summary>
		/// 按 IdCardImg（字段） 查询
		/// </summary>
		/// <param name = "idCardImg"></param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByIdCardImg(string idCardImg, string sort)
		{
			return GetByIdCardImg(idCardImg, 0, sort, null);
		}

		/// <summary>
		/// 按 IdCardImg（字段） 查询
		/// </summary>
		/// <param name = "idCardImg"></param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByIdCardImg(string idCardImg, string sort, TransactionManager tm)
		{
			return GetByIdCardImg(idCardImg, 0, sort, tm);
		}

		/// <summary>
		/// 按 IdCardImg（字段） 查询
		/// </summary>
		/// <param name = "idCardImg"></param>
		/// <param name = "top">获取行数</param>
		/// <param name = "sort">排序表达式</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetByIdCardImg(string idCardImg, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, photos, photosIndex, idCardImg FROM userphoto WHERE idCardImg=@IdCardImg";
			string sql = format;

			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameter("@IdCardImg", idCardImg, DbType.String, 300)
							.ExecList<UserphotoEO>(UserphotoEO.GetItem, tm);
		}

		#endregion

		#region  自定义条件查询

		/// <summary>
		/// 获取所有数据
		/// </summary>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetAll(TransactionManager tm = null)
		{
			return GetTopSort(string.Empty, null, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "values">where子句中定义的参数值集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> Get(string where, params object[] values)
		{
			return GetTopSort(where, -1, string.Empty, null, values);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "paras">where子句中定义的参数集合</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> Get(string where, IEnumerable<DbParameter> paras)
		{
			return GetTopSort(where, paras, -1, string.Empty, null);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> Get(string where, TransactionManager tm)
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
		public virtual IEnumerable<UserphotoEO> Get(string where, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<UserphotoEO> Get(string where, IEnumerable<DbParameter> paras, TransactionManager tm)
		{
			return GetTopSort(where, paras, -1, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "top">获取行数</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetTop(string where, int top)
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
		public virtual IEnumerable<UserphotoEO> GetTop(string where, int top, params object[] values)
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
		public virtual IEnumerable<UserphotoEO> GetTop(string where, IEnumerable<DbParameter> paras, int top)
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
		public virtual IEnumerable<UserphotoEO> GetTop(string where, int top, TransactionManager tm)
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
		public virtual IEnumerable<UserphotoEO> GetTop(string where, int top, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<UserphotoEO> GetTop(string where, IEnumerable<DbParameter> paras, int top, TransactionManager tm)
		{
			return GetTopSort(where, paras, top, string.Empty, tm);
		}

		/// <summary>
		/// 按自定义条件查询
		/// </summary>
		/// <param name = "where">自定义条件,where子句</param>
		/// <param name = "sort">排序表达式</param>
		/// <return>实体对象集合</return>
		public virtual IEnumerable<UserphotoEO> GetSort(string where, string sort)
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
		public virtual IEnumerable<UserphotoEO> GetSort(string where, string sort, params object[] values)
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
		public virtual IEnumerable<UserphotoEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort)
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
		public virtual IEnumerable<UserphotoEO> GetSort(string where, string sort, TransactionManager tm)
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
		public virtual IEnumerable<UserphotoEO> GetSort(string where, string sort, TransactionManager tm, params object[] values)
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
		public virtual IEnumerable<UserphotoEO> GetSort(string where, IEnumerable<DbParameter> paras, string sort, TransactionManager tm)
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
		public virtual IEnumerable<UserphotoEO> GetTopSort(string where, int top, string sort)
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
		public virtual IEnumerable<UserphotoEO> GetTopSort(string where, int top, string sort, params object[] values)
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
		public virtual IEnumerable<UserphotoEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort)
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
		public virtual IEnumerable<UserphotoEO> GetTopSort(string where, int top, string sort, TransactionManager tm)
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
		public virtual IEnumerable<UserphotoEO> GetTopSort(string where, int top, string sort, TransactionManager tm, params object[] values)
		{
			const string format = @"SELECT {0} userId, openId, photos, photosIndex, idCardImg FROM userphoto";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddInParameters(values)
							.ExecList<UserphotoEO>(UserphotoEO.GetItem, tm);
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
		public virtual IEnumerable<UserphotoEO> GetTopSort(string where, IEnumerable<DbParameter> paras, int top, string sort, TransactionManager tm)
		{
			const string format = @"SELECT {0} userId, openId, photos, photosIndex, idCardImg FROM userphoto";
			string sql = format;

			if (!string.IsNullOrEmpty(where)) sql += " WHERE " + where;
			if (!string.IsNullOrEmpty(sort)) sql += " ORDER BY " + sort;
			sql = string.Format(sql, string.Empty);
			sql = sql + ((top > 0) ? string.Format(" LIMIT {0} ", top) : string.Empty);
			return Database.CreateSqlDao(sql)
							.AddParameters(paras)
							.ExecList<UserphotoEO>(UserphotoEO.GetItem, tm);
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
			const string format = @"SELECT userId, openId, photos, photosIndex, idCardImg FROM userphoto {0} {1}";
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
		public virtual List<UserphotoEO> GetPageList(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageList<UserphotoEO>(pageIndex);
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
		public virtual IEnumerable<UserphotoEO> GetPageMutil(int pageIndex , int pageSize, string where = null, string sort = null, IEnumerable<DbParameter> paras = null)
		{
			var pager = GetPager(pageSize, where, sort);

			pager.AddParameters(paras);
			return pager.GetPageMutil<UserphotoEO>(pageIndex);
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
		public virtual int Add(UserphotoEO item, TransactionManager tm = null)
		{
			const string sql = @"INSERT INTO userphoto (userId, openId, photos, photosIndex, idCardImg) VALUES (@userId, @openId, @photos, @photosIndex, @idCardImg) ";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", item.UserId, DbType.Int32, 0)
							.AddInParameter("@openId", item.OpenId != null ?  (object)item.OpenId : DBNull.Value, DbType.String, 300)
							.AddInParameter("@photos", item.Photos != null ?  (object)item.Photos : DBNull.Value, DbType.String, 600)
							.AddInParameter("@photosIndex", item.PhotosIndex.HasValue ? (object)item.PhotosIndex.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@idCardImg", item.IdCardImg != null ?  (object)item.IdCardImg : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 插入一组数据
		/// </summary>
		/// <param name = "items">要插入的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Add(IEnumerable<UserphotoEO> items, TransactionManager tm = null)
		{
			int ret = 0;
			const string sql = @"INSERT INTO userphoto (userId, openId, photos, photosIndex, idCardImg) VALUES (@userId, @openId, @photos, @photosIndex, @idCardImg) ";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@userId", DbType.Int32, 0)
									.AddParameter("@openId", DbType.String, 300)
									.AddParameter("@photos", DbType.String, 600)
									.AddParameter("@photosIndex", DbType.Int32, 0)
									.AddParameter("@idCardImg", DbType.String, 300);

			foreach (UserphotoEO item in items)
			{
				sqlDao
					.SetParameterValue("@userId", item.UserId)
					.SetParameterValue("@openId", item.OpenId != null ?  (object)item.OpenId : DBNull.Value)
					.SetParameterValue("@photos", item.Photos != null ?  (object)item.Photos : DBNull.Value)
					.SetParameterValue("@photosIndex", item.PhotosIndex.HasValue ? (object)item.PhotosIndex.Value : DBNull.Value)
					.SetParameterValue("@idCardImg", item.IdCardImg != null ?  (object)item.IdCardImg : DBNull.Value)
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
		public virtual int Put(UserphotoEO item, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userphoto SET userId=@userId, openId=@openId, photos=@photos, photosIndex=@photosIndex, idCardImg=@idCardImg WHERE userId=@OriginalUserId";
			return Database.CreateSqlDao (sql)
							.AddInParameter("@OriginalUserId", (item.HasOriginal) ? item.OriginalUserId : item.UserId, DbType.Int32, 0)
							.AddInParameter("@userId", item.UserId, DbType.Int32, 0)
							.AddInParameter("@openId", item.OpenId != null ?  (object)item.OpenId : DBNull.Value, DbType.String, 300)
							.AddInParameter("@photos", item.Photos != null ?  (object)item.Photos : DBNull.Value, DbType.String, 600)
							.AddInParameter("@photosIndex", item.PhotosIndex.HasValue ? (object)item.PhotosIndex.Value : DBNull.Value, DbType.Int32, 0)
							.AddInParameter("@idCardImg", item.IdCardImg != null ?  (object)item.IdCardImg : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}


		/// <summary>
		/// 更新数据
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Put(IEnumerable<UserphotoEO> items, TransactionManager tm = null)
		{

			int ret = 0;
			const string sql = @"UPDATE userphoto SET userId=@userId, openId=@openId, photos=@photos, photosIndex=@photosIndex, idCardImg=@idCardImg WHERE userId=@OriginalUserId";
			var sqlDao = Database.CreateSqlDao(sql)
									.AddParameter("@OriginalUserId", DbType.Int32, 0)
									.AddParameter("@userId", DbType.Int32, 0)
									.AddParameter("@openId", DbType.String, 300)
									.AddParameter("@photos", DbType.String, 600)
									.AddParameter("@photosIndex", DbType.Int32, 0)
									.AddParameter("@idCardImg", DbType.String, 300);

			foreach (UserphotoEO item in items)
			{
				ret += sqlDao
							.SetParameterValue("@OriginalUserId", (item.HasOriginal) ? item.OriginalUserId : item.UserId)
							.SetParameterValue("@userId", item.UserId)
							.SetParameterValue("@openId", item.OpenId != null ?  (object)item.OpenId : DBNull.Value)
							.SetParameterValue("@photos", item.Photos != null ?  (object)item.Photos : DBNull.Value)
							.SetParameterValue("@photosIndex", item.PhotosIndex.HasValue ? (object)item.PhotosIndex.Value : DBNull.Value)
							.SetParameterValue("@idCardImg", item.IdCardImg != null ?  (object)item.IdCardImg : DBNull.Value)
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
			const string sql = @"UPDATE userphoto SET openId = @openId  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.Int32, 0)
							.AddInParameter("@openId", openId != null ?  (object)openId : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "photos"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPhotosByPK(int userId, string photos, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userphoto SET photos = @photos  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.Int32, 0)
							.AddInParameter("@photos", photos != null ?  (object)photos : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "photosIndex"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPhotosIndexByPK(int userId, int? photosIndex, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userphoto SET photosIndex = @photosIndex  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.Int32, 0)
							.AddInParameter("@photosIndex", photosIndex.HasValue ? (object)photosIndex.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// <param name = "userId"></param>
		/// <param name = "idCardImg"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutIdCardImgByPK(int userId, string idCardImg, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userphoto SET idCardImg = @idCardImg  WHERE userId = @userId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@userId", userId, DbType.Int32, 0)
							.AddInParameter("@idCardImg", idCardImg != null ?  (object)idCardImg : DBNull.Value, DbType.String, 300)
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
			const string sql = @"UPDATE userphoto SET openId=@openId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@openId", openId != null ?  (object)openId : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "photos"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPhotos(string photos, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userphoto SET photos=@photos";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@photos", photos != null ?  (object)photos : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "photosIndex"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutPhotosIndex(int? photosIndex, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userphoto SET photosIndex=@photosIndex";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@photosIndex", photosIndex.HasValue ? (object)photosIndex.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// <param name = "idCardImg"></param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int PutIdCardImg(string idCardImg, TransactionManager tm = null)
		{
			const string sql = @"UPDATE userphoto SET idCardImg=@idCardImg";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@idCardImg", idCardImg != null ?  (object)idCardImg : DBNull.Value, DbType.String, 300)
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
			const string format = @"UPDATE userphoto SET {0} {1}";
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
			const string format = @"UPDATE userphoto SET {0} {1}";
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
			const string sql = @"DELETE FROM userphoto WHERE userId=@userId";
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
		public virtual int Remove(UserphotoEO item, TransactionManager tm = null)
		{
			return RemoveByPK(item.UserId, tm);
		}

		/// <summary>
		/// 删除指定实体集合对应的记录集
		/// </summary>
		/// <param name = "items">要删除的实体集合</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>受影响的行数</return>
		public virtual int Remove(IEnumerable<UserphotoEO> items, TransactionManager tm = null)
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
			const string sql = @"DELETE FROM userphoto WHERE userId IN ({0})";
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
			const string sql = @"DELETE FROM userphoto WHERE openId=@openId";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@openId", openId != null ?  (object)openId : DBNull.Value, DbType.String, 300)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "photos"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPhotos(string photos, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userphoto WHERE photos=@photos";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@photos", photos != null ?  (object)photos : DBNull.Value, DbType.String, 600)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "photosIndex"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByPhotosIndex(int? photosIndex, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userphoto WHERE photosIndex=@photosIndex";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@photosIndex", photosIndex.HasValue ? (object)photosIndex.Value : DBNull.Value, DbType.Int32, 0)
							.ExecNonQuery(tm);
		}

		/// <summary>
		/// 按字段删除
		/// </summary>
		/// <param name = "idCardImg"></param>
		/// <param name="tm">事务管理对象</param>
		public virtual int RemoveByIdCardImg(string idCardImg, TransactionManager tm = null)
		{
			const string sql = @"DELETE FROM userphoto WHERE idCardImg=@idCardImg";
			return Database.CreateSqlDao(sql)
							.AddInParameter("@idCardImg", idCardImg != null ?  (object)idCardImg : DBNull.Value, DbType.String, 300)
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
			const string format = @"DELETE FROM userphoto {0}";
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
			const string format = @"DELETE FROM userphoto {0}";
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
