﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kisiler
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="kisiler")]
	public partial class DataClasses2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertGOREVLER(GOREVLER instance);
    partial void UpdateGOREVLER(GOREVLER instance);
    partial void DeleteGOREVLER(GOREVLER instance);
    #endregion
		
		public DataClasses2DataContext() : 
				base(global::kisiler.Properties.Settings.Default.kisilerConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<GOREVLER> GOREVLER
		{
			get
			{
				return this.GetTable<GOREVLER>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GOREVLER")]
	public partial class GOREVLER : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _GOREVİD;
		
		private string _GOREVADI;
		
		private System.Nullable<int> _GOREVMAASI;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGOREVİDChanging(int value);
    partial void OnGOREVİDChanged();
    partial void OnGOREVADIChanging(string value);
    partial void OnGOREVADIChanged();
    partial void OnGOREVMAASIChanging(System.Nullable<int> value);
    partial void OnGOREVMAASIChanged();
    #endregion
		
		public GOREVLER()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GOREVİD", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int GOREVİD
		{
			get
			{
				return this._GOREVİD;
			}
			set
			{
				if ((this._GOREVİD != value))
				{
					this.OnGOREVİDChanging(value);
					this.SendPropertyChanging();
					this._GOREVİD = value;
					this.SendPropertyChanged("GOREVİD");
					this.OnGOREVİDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GOREVADI", DbType="VarChar(25)")]
		public string GOREVADI
		{
			get
			{
				return this._GOREVADI;
			}
			set
			{
				if ((this._GOREVADI != value))
				{
					this.OnGOREVADIChanging(value);
					this.SendPropertyChanging();
					this._GOREVADI = value;
					this.SendPropertyChanged("GOREVADI");
					this.OnGOREVADIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GOREVMAASI", DbType="Int")]
		public System.Nullable<int> GOREVMAASI
		{
			get
			{
				return this._GOREVMAASI;
			}
			set
			{
				if ((this._GOREVMAASI != value))
				{
					this.OnGOREVMAASIChanging(value);
					this.SendPropertyChanging();
					this._GOREVMAASI = value;
					this.SendPropertyChanged("GOREVMAASI");
					this.OnGOREVMAASIChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
