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

namespace TezRota.VeriKatmani
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbTezRota")]
	public partial class dbTezRotaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttArac(tArac instance);
    partial void UpdatetArac(tArac instance);
    partial void DeletetArac(tArac instance);
    partial void InserttAracTipi(tAracTipi instance);
    partial void UpdatetAracTipi(tAracTipi instance);
    partial void DeletetAracTipi(tAracTipi instance);
    partial void InserttPlan(tPlan instance);
    partial void UpdatetPlan(tPlan instance);
    partial void DeletetPlan(tPlan instance);
    partial void InserttTasima(tTasima instance);
    partial void UpdatetTasima(tTasima instance);
    partial void DeletetTasima(tTasima instance);
    partial void InserttOptimizasyonSonuc(tOptimizasyonSonuc instance);
    partial void UpdatetOptimizasyonSonuc(tOptimizasyonSonuc instance);
    partial void DeletetOptimizasyonSonuc(tOptimizasyonSonuc instance);
    partial void InserttOptimizasyonEmir(tOptimizasyonEmir instance);
    partial void UpdatetOptimizasyonEmir(tOptimizasyonEmir instance);
    partial void DeletetOptimizasyonEmir(tOptimizasyonEmir instance);
    partial void InserttNoktaKaynak(tNoktaKaynak instance);
    partial void UpdatetNoktaKaynak(tNoktaKaynak instance);
    partial void DeletetNoktaKaynak(tNoktaKaynak instance);
    partial void InserttNokta(tNokta instance);
    partial void UpdatetNokta(tNokta instance);
    partial void DeletetNokta(tNokta instance);
    #endregion
		
		public dbTezRotaDataContext() : 
				base(global::TezRota.Properties.Settings.Default.dbTezRotaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public dbTezRotaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbTezRotaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbTezRotaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public dbTezRotaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tArac> tAracs
		{
			get
			{
				return this.GetTable<tArac>();
			}
		}
		
		public System.Data.Linq.Table<tAracTipi> tAracTipis
		{
			get
			{
				return this.GetTable<tAracTipi>();
			}
		}
		
		public System.Data.Linq.Table<tPlan> tPlans
		{
			get
			{
				return this.GetTable<tPlan>();
			}
		}
		
		public System.Data.Linq.Table<tTasima> tTasimas
		{
			get
			{
				return this.GetTable<tTasima>();
			}
		}
		
		public System.Data.Linq.Table<tOptimizasyonSonuc> tOptimizasyonSonucs
		{
			get
			{
				return this.GetTable<tOptimizasyonSonuc>();
			}
		}
		
		public System.Data.Linq.Table<tOptimizasyonEmir> tOptimizasyonEmirs
		{
			get
			{
				return this.GetTable<tOptimizasyonEmir>();
			}
		}
		
		public System.Data.Linq.Table<tNoktaKaynak> tNoktaKaynaks
		{
			get
			{
				return this.GetTable<tNoktaKaynak>();
			}
		}
		
		public System.Data.Linq.Table<tNokta> tNoktas
		{
			get
			{
				return this.GetTable<tNokta>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tArac")]
	public partial class tArac : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _DorsePlaka;
		
		private string _CekiciPlaka;
		
		private int _AracTipId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnDorsePlakaChanging(string value);
    partial void OnDorsePlakaChanged();
    partial void OnCekiciPlakaChanging(string value);
    partial void OnCekiciPlakaChanged();
    partial void OnAracTipIdChanging(int value);
    partial void OnAracTipIdChanged();
    #endregion
		
		public tArac()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DorsePlaka", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DorsePlaka
		{
			get
			{
				return this._DorsePlaka;
			}
			set
			{
				if ((this._DorsePlaka != value))
				{
					this.OnDorsePlakaChanging(value);
					this.SendPropertyChanging();
					this._DorsePlaka = value;
					this.SendPropertyChanged("DorsePlaka");
					this.OnDorsePlakaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CekiciPlaka", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CekiciPlaka
		{
			get
			{
				return this._CekiciPlaka;
			}
			set
			{
				if ((this._CekiciPlaka != value))
				{
					this.OnCekiciPlakaChanging(value);
					this.SendPropertyChanging();
					this._CekiciPlaka = value;
					this.SendPropertyChanged("CekiciPlaka");
					this.OnCekiciPlakaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AracTipId", DbType="Int NOT NULL")]
		public int AracTipId
		{
			get
			{
				return this._AracTipId;
			}
			set
			{
				if ((this._AracTipId != value))
				{
					this.OnAracTipIdChanging(value);
					this.SendPropertyChanging();
					this._AracTipId = value;
					this.SendPropertyChanged("AracTipId");
					this.OnAracTipIdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tAracTipi")]
	public partial class tAracTipi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Kod;
		
		private string _Ad;
		
		private string _AracTuru;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnKodChanging(string value);
    partial void OnKodChanged();
    partial void OnAdChanging(string value);
    partial void OnAdChanged();
    partial void OnAracTuruChanging(string value);
    partial void OnAracTuruChanged();
    #endregion
		
		public tAracTipi()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kod", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Kod
		{
			get
			{
				return this._Kod;
			}
			set
			{
				if ((this._Kod != value))
				{
					this.OnKodChanging(value);
					this.SendPropertyChanging();
					this._Kod = value;
					this.SendPropertyChanged("Kod");
					this.OnKodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ad", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Ad
		{
			get
			{
				return this._Ad;
			}
			set
			{
				if ((this._Ad != value))
				{
					this.OnAdChanging(value);
					this.SendPropertyChanging();
					this._Ad = value;
					this.SendPropertyChanged("Ad");
					this.OnAdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AracTuru", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string AracTuru
		{
			get
			{
				return this._AracTuru;
			}
			set
			{
				if ((this._AracTuru != value))
				{
					this.OnAracTuruChanging(value);
					this.SendPropertyChanging();
					this._AracTuru = value;
					this.SendPropertyChanged("AracTuru");
					this.OnAracTuruChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tPlan")]
	public partial class tPlan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _PlanIsmi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPlanIsmiChanging(string value);
    partial void OnPlanIsmiChanged();
    #endregion
		
		public tPlan()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlanIsmi", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string PlanIsmi
		{
			get
			{
				return this._PlanIsmi;
			}
			set
			{
				if ((this._PlanIsmi != value))
				{
					this.OnPlanIsmiChanging(value);
					this.SendPropertyChanging();
					this._PlanIsmi = value;
					this.SendPropertyChanged("PlanIsmi");
					this.OnPlanIsmiChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tTasima")]
	public partial class tTasima : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _PlanId;
		
		private int _TasimaTipi;
		
		private string _NakliyeNo;
		
		private int _SiraId;
		
		private int _KaynakId;
		
		private int _HedefId;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPlanIdChanging(int value);
    partial void OnPlanIdChanged();
    partial void OnTasimaTipiChanging(int value);
    partial void OnTasimaTipiChanged();
    partial void OnNakliyeNoChanging(string value);
    partial void OnNakliyeNoChanged();
    partial void OnSiraIdChanging(int value);
    partial void OnSiraIdChanged();
    partial void OnKaynakIdChanging(int value);
    partial void OnKaynakIdChanged();
    partial void OnHedefIdChanging(int value);
    partial void OnHedefIdChanged();
    #endregion
		
		public tTasima()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlanId", DbType="Int NOT NULL")]
		public int PlanId
		{
			get
			{
				return this._PlanId;
			}
			set
			{
				if ((this._PlanId != value))
				{
					this.OnPlanIdChanging(value);
					this.SendPropertyChanging();
					this._PlanId = value;
					this.SendPropertyChanged("PlanId");
					this.OnPlanIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TasimaTipi", DbType="Int NOT NULL")]
		public int TasimaTipi
		{
			get
			{
				return this._TasimaTipi;
			}
			set
			{
				if ((this._TasimaTipi != value))
				{
					this.OnTasimaTipiChanging(value);
					this.SendPropertyChanging();
					this._TasimaTipi = value;
					this.SendPropertyChanged("TasimaTipi");
					this.OnTasimaTipiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NakliyeNo", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string NakliyeNo
		{
			get
			{
				return this._NakliyeNo;
			}
			set
			{
				if ((this._NakliyeNo != value))
				{
					this.OnNakliyeNoChanging(value);
					this.SendPropertyChanging();
					this._NakliyeNo = value;
					this.SendPropertyChanged("NakliyeNo");
					this.OnNakliyeNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SiraId", DbType="Int NOT NULL")]
		public int SiraId
		{
			get
			{
				return this._SiraId;
			}
			set
			{
				if ((this._SiraId != value))
				{
					this.OnSiraIdChanging(value);
					this.SendPropertyChanging();
					this._SiraId = value;
					this.SendPropertyChanged("SiraId");
					this.OnSiraIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KaynakId", DbType="Int NOT NULL")]
		public int KaynakId
		{
			get
			{
				return this._KaynakId;
			}
			set
			{
				if ((this._KaynakId != value))
				{
					this.OnKaynakIdChanging(value);
					this.SendPropertyChanging();
					this._KaynakId = value;
					this.SendPropertyChanged("KaynakId");
					this.OnKaynakIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HedefId", DbType="Int NOT NULL")]
		public int HedefId
		{
			get
			{
				return this._HedefId;
			}
			set
			{
				if ((this._HedefId != value))
				{
					this.OnHedefIdChanging(value);
					this.SendPropertyChanging();
					this._HedefId = value;
					this.SendPropertyChanged("HedefId");
					this.OnHedefIdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tOptimizasyonSonuc")]
	public partial class tOptimizasyonSonuc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _EmirId;
		
		private int _TasimaId;
		
		private int _KaynakId;
		
		private int _HedefId;
		
		private string _NakliyeNo;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnEmirIdChanging(int value);
    partial void OnEmirIdChanged();
    partial void OnTasimaIdChanging(int value);
    partial void OnTasimaIdChanged();
    partial void OnKaynakIdChanging(int value);
    partial void OnKaynakIdChanged();
    partial void OnHedefIdChanging(int value);
    partial void OnHedefIdChanged();
    partial void OnNakliyeNoChanging(string value);
    partial void OnNakliyeNoChanged();
    #endregion
		
		public tOptimizasyonSonuc()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmirId", DbType="Int NOT NULL")]
		public int EmirId
		{
			get
			{
				return this._EmirId;
			}
			set
			{
				if ((this._EmirId != value))
				{
					this.OnEmirIdChanging(value);
					this.SendPropertyChanging();
					this._EmirId = value;
					this.SendPropertyChanged("EmirId");
					this.OnEmirIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TasimaId", DbType="Int NOT NULL")]
		public int TasimaId
		{
			get
			{
				return this._TasimaId;
			}
			set
			{
				if ((this._TasimaId != value))
				{
					this.OnTasimaIdChanging(value);
					this.SendPropertyChanging();
					this._TasimaId = value;
					this.SendPropertyChanged("TasimaId");
					this.OnTasimaIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KaynakId", DbType="Int NOT NULL")]
		public int KaynakId
		{
			get
			{
				return this._KaynakId;
			}
			set
			{
				if ((this._KaynakId != value))
				{
					this.OnKaynakIdChanging(value);
					this.SendPropertyChanging();
					this._KaynakId = value;
					this.SendPropertyChanged("KaynakId");
					this.OnKaynakIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HedefId", DbType="Int NOT NULL")]
		public int HedefId
		{
			get
			{
				return this._HedefId;
			}
			set
			{
				if ((this._HedefId != value))
				{
					this.OnHedefIdChanging(value);
					this.SendPropertyChanging();
					this._HedefId = value;
					this.SendPropertyChanged("HedefId");
					this.OnHedefIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NakliyeNo", DbType="NVarChar(50)")]
		public string NakliyeNo
		{
			get
			{
				return this._NakliyeNo;
			}
			set
			{
				if ((this._NakliyeNo != value))
				{
					this.OnNakliyeNoChanging(value);
					this.SendPropertyChanging();
					this._NakliyeNo = value;
					this.SendPropertyChanged("NakliyeNo");
					this.OnNakliyeNoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tOptimizasyonEmir")]
	public partial class tOptimizasyonEmir : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _PlanId;
		
		private System.DateTime _EmirZamani;
		
		private string _BaslangicSkor;
		
		private System.Nullable<double> _Sicaklik;
		
		private System.Nullable<int> _Dongu;
		
		private System.Nullable<double> _SicaklikAzaltmaOrani;
		
		private string _SonucSkor;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPlanIdChanging(int value);
    partial void OnPlanIdChanged();
    partial void OnEmirZamaniChanging(System.DateTime value);
    partial void OnEmirZamaniChanged();
    partial void OnBaslangicSkorChanging(string value);
    partial void OnBaslangicSkorChanged();
    partial void OnSicaklikChanging(System.Nullable<double> value);
    partial void OnSicaklikChanged();
    partial void OnDonguChanging(System.Nullable<int> value);
    partial void OnDonguChanged();
    partial void OnSicaklikAzaltmaOraniChanging(System.Nullable<double> value);
    partial void OnSicaklikAzaltmaOraniChanged();
    partial void OnSonucSkorChanging(string value);
    partial void OnSonucSkorChanged();
    #endregion
		
		public tOptimizasyonEmir()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlanId", DbType="Int NOT NULL")]
		public int PlanId
		{
			get
			{
				return this._PlanId;
			}
			set
			{
				if ((this._PlanId != value))
				{
					this.OnPlanIdChanging(value);
					this.SendPropertyChanging();
					this._PlanId = value;
					this.SendPropertyChanged("PlanId");
					this.OnPlanIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmirZamani", DbType="DateTime NOT NULL")]
		public System.DateTime EmirZamani
		{
			get
			{
				return this._EmirZamani;
			}
			set
			{
				if ((this._EmirZamani != value))
				{
					this.OnEmirZamaniChanging(value);
					this.SendPropertyChanging();
					this._EmirZamani = value;
					this.SendPropertyChanged("EmirZamani");
					this.OnEmirZamaniChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BaslangicSkor", DbType="NVarChar(MAX)")]
		public string BaslangicSkor
		{
			get
			{
				return this._BaslangicSkor;
			}
			set
			{
				if ((this._BaslangicSkor != value))
				{
					this.OnBaslangicSkorChanging(value);
					this.SendPropertyChanging();
					this._BaslangicSkor = value;
					this.SendPropertyChanged("BaslangicSkor");
					this.OnBaslangicSkorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sicaklik", DbType="Float")]
		public System.Nullable<double> Sicaklik
		{
			get
			{
				return this._Sicaklik;
			}
			set
			{
				if ((this._Sicaklik != value))
				{
					this.OnSicaklikChanging(value);
					this.SendPropertyChanging();
					this._Sicaklik = value;
					this.SendPropertyChanged("Sicaklik");
					this.OnSicaklikChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dongu", DbType="Int")]
		public System.Nullable<int> Dongu
		{
			get
			{
				return this._Dongu;
			}
			set
			{
				if ((this._Dongu != value))
				{
					this.OnDonguChanging(value);
					this.SendPropertyChanging();
					this._Dongu = value;
					this.SendPropertyChanged("Dongu");
					this.OnDonguChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SicaklikAzaltmaOrani", DbType="Float")]
		public System.Nullable<double> SicaklikAzaltmaOrani
		{
			get
			{
				return this._SicaklikAzaltmaOrani;
			}
			set
			{
				if ((this._SicaklikAzaltmaOrani != value))
				{
					this.OnSicaklikAzaltmaOraniChanging(value);
					this.SendPropertyChanging();
					this._SicaklikAzaltmaOrani = value;
					this.SendPropertyChanged("SicaklikAzaltmaOrani");
					this.OnSicaklikAzaltmaOraniChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SonucSkor", DbType="NVarChar(MAX)")]
		public string SonucSkor
		{
			get
			{
				return this._SonucSkor;
			}
			set
			{
				if ((this._SonucSkor != value))
				{
					this.OnSonucSkorChanging(value);
					this.SendPropertyChanging();
					this._SonucSkor = value;
					this.SendPropertyChanged("SonucSkor");
					this.OnSonucSkorChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tNoktaKaynak")]
	public partial class tNoktaKaynak : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _NoktaAdi;
		
		private string _Kodu1;
		
		private string _Kodu2;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNoktaAdiChanging(string value);
    partial void OnNoktaAdiChanged();
    partial void OnKodu1Changing(string value);
    partial void OnKodu1Changed();
    partial void OnKodu2Changing(string value);
    partial void OnKodu2Changed();
    #endregion
		
		public tNoktaKaynak()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NoktaAdi", DbType="NVarChar(MAX)")]
		public string NoktaAdi
		{
			get
			{
				return this._NoktaAdi;
			}
			set
			{
				if ((this._NoktaAdi != value))
				{
					this.OnNoktaAdiChanging(value);
					this.SendPropertyChanging();
					this._NoktaAdi = value;
					this.SendPropertyChanged("NoktaAdi");
					this.OnNoktaAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kodu1", DbType="NVarChar(MAX)")]
		public string Kodu1
		{
			get
			{
				return this._Kodu1;
			}
			set
			{
				if ((this._Kodu1 != value))
				{
					this.OnKodu1Changing(value);
					this.SendPropertyChanging();
					this._Kodu1 = value;
					this.SendPropertyChanged("Kodu1");
					this.OnKodu1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Kodu2", DbType="NVarChar(MAX)")]
		public string Kodu2
		{
			get
			{
				return this._Kodu2;
			}
			set
			{
				if ((this._Kodu2 != value))
				{
					this.OnKodu2Changing(value);
					this.SendPropertyChanging();
					this._Kodu2 = value;
					this.SendPropertyChanged("Kodu2");
					this.OnKodu2Changed();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tNokta")]
	public partial class tNokta : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _nokta_isim;
		
		private string _kordinat;
		
		private string _musteriKodu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void Onnokta_isimChanging(string value);
    partial void Onnokta_isimChanged();
    partial void OnkordinatChanging(string value);
    partial void OnkordinatChanged();
    partial void OnmusteriKoduChanging(string value);
    partial void OnmusteriKoduChanged();
    #endregion
		
		public tNokta()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nokta_isim", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string nokta_isim
		{
			get
			{
				return this._nokta_isim;
			}
			set
			{
				if ((this._nokta_isim != value))
				{
					this.Onnokta_isimChanging(value);
					this.SendPropertyChanging();
					this._nokta_isim = value;
					this.SendPropertyChanged("nokta_isim");
					this.Onnokta_isimChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_kordinat", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string kordinat
		{
			get
			{
				return this._kordinat;
			}
			set
			{
				if ((this._kordinat != value))
				{
					this.OnkordinatChanging(value);
					this.SendPropertyChanging();
					this._kordinat = value;
					this.SendPropertyChanged("kordinat");
					this.OnkordinatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_musteriKodu", DbType="NVarChar(MAX)")]
		public string musteriKodu
		{
			get
			{
				return this._musteriKodu;
			}
			set
			{
				if ((this._musteriKodu != value))
				{
					this.OnmusteriKoduChanging(value);
					this.SendPropertyChanging();
					this._musteriKodu = value;
					this.SendPropertyChanged("musteriKodu");
					this.OnmusteriKoduChanged();
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
