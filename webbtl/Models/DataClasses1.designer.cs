﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace webbtl.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="vntripvn")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["vntripvnConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<KhachSan> KhachSans
		{
			get
			{
				return this.GetTable<KhachSan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.KhachSan")]
	public partial class KhachSan
	{
		
		private int _ID;
		
		private string _Anh;
		
		private string _TenKhachSan;
		
		private string _DiaChi;
		
		private System.Nullable<int> _Gia;
		
		private System.Nullable<int> _IDQuanHuyen;
		
		private System.Nullable<int> _IDTienNghi;
		
		private string _LoaiChoO;
		
		private System.Nullable<int> _IDTinh;
		
		public KhachSan()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this._ID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Anh", DbType="NVarChar(50)")]
		public string Anh
		{
			get
			{
				return this._Anh;
			}
			set
			{
				if ((this._Anh != value))
				{
					this._Anh = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKhachSan", DbType="NVarChar(100)")]
		public string TenKhachSan
		{
			get
			{
				return this._TenKhachSan;
			}
			set
			{
				if ((this._TenKhachSan != value))
				{
					this._TenKhachSan = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DiaChi", DbType="NVarChar(100)")]
		public string DiaChi
		{
			get
			{
				return this._DiaChi;
			}
			set
			{
				if ((this._DiaChi != value))
				{
					this._DiaChi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gia", DbType="Int")]
		public System.Nullable<int> Gia
		{
			get
			{
				return this._Gia;
			}
			set
			{
				if ((this._Gia != value))
				{
					this._Gia = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDQuanHuyen", DbType="Int")]
		public System.Nullable<int> IDQuanHuyen
		{
			get
			{
				return this._IDQuanHuyen;
			}
			set
			{
				if ((this._IDQuanHuyen != value))
				{
					this._IDQuanHuyen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDTienNghi", DbType="Int")]
		public System.Nullable<int> IDTienNghi
		{
			get
			{
				return this._IDTienNghi;
			}
			set
			{
				if ((this._IDTienNghi != value))
				{
					this._IDTienNghi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiChoO", DbType="NVarChar(50)")]
		public string LoaiChoO
		{
			get
			{
				return this._LoaiChoO;
			}
			set
			{
				if ((this._LoaiChoO != value))
				{
					this._LoaiChoO = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDTinh", DbType="Int")]
		public System.Nullable<int> IDTinh
		{
			get
			{
				return this._IDTinh;
			}
			set
			{
				if ((this._IDTinh != value))
				{
					this._IDTinh = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
