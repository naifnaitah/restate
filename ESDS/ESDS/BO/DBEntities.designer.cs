﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESDS.BO
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DataSource")]
	public partial class DBEntitiesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertUsers_Subscription(Users_Subscription instance);
    partial void UpdateUsers_Subscription(Users_Subscription instance);
    partial void DeleteUsers_Subscription(Users_Subscription instance);
    partial void InsertProperty(Property instance);
    partial void UpdateProperty(Property instance);
    partial void DeleteProperty(Property instance);
    #endregion
		
		public DBEntitiesDataContext() : 
				base(global::ESDS.Properties.Settings.Default.DataSourceConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBEntitiesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBEntitiesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBEntitiesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBEntitiesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Users_Subscription> Users_Subscriptions
		{
			get
			{
				return this.GetTable<Users_Subscription>();
			}
		}
		
		public System.Data.Linq.Table<Property> Properties
		{
			get
			{
				return this.GetTable<Property>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="RealEstate.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _Email;
		
		private string _Passwd;
		
		private string _Telephone;
		
		private string _Address1;
		
		private string _Address2;
		
		private string _Town_City;
		
		private string _PostCode;
		
		private string _County;
		
		private EntitySet<Users_Subscription> _Users_Subscriptions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswdChanging(string value);
    partial void OnPasswdChanged();
    partial void OnTelephoneChanging(string value);
    partial void OnTelephoneChanged();
    partial void OnAddress1Changing(string value);
    partial void OnAddress1Changed();
    partial void OnAddress2Changing(string value);
    partial void OnAddress2Changed();
    partial void OnTown_CityChanging(string value);
    partial void OnTown_CityChanged();
    partial void OnPostCodeChanging(string value);
    partial void OnPostCodeChanged();
    partial void OnCountyChanging(string value);
    partial void OnCountyChanged();
    #endregion
		
		public User()
		{
			this._Users_Subscriptions = new EntitySet<Users_Subscription>(new Action<Users_Subscription>(this.attach_Users_Subscriptions), new Action<Users_Subscription>(this.detach_Users_Subscriptions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Passwd", DbType="VarChar(50)")]
		public string Passwd
		{
			get
			{
				return this._Passwd;
			}
			set
			{
				if ((this._Passwd != value))
				{
					this.OnPasswdChanging(value);
					this.SendPropertyChanging();
					this._Passwd = value;
					this.SendPropertyChanged("Passwd");
					this.OnPasswdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telephone", DbType="VarChar(50)")]
		public string Telephone
		{
			get
			{
				return this._Telephone;
			}
			set
			{
				if ((this._Telephone != value))
				{
					this.OnTelephoneChanging(value);
					this.SendPropertyChanging();
					this._Telephone = value;
					this.SendPropertyChanged("Telephone");
					this.OnTelephoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address1", DbType="VarChar(50)")]
		public string Address1
		{
			get
			{
				return this._Address1;
			}
			set
			{
				if ((this._Address1 != value))
				{
					this.OnAddress1Changing(value);
					this.SendPropertyChanging();
					this._Address1 = value;
					this.SendPropertyChanged("Address1");
					this.OnAddress1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address2", DbType="VarChar(50)")]
		public string Address2
		{
			get
			{
				return this._Address2;
			}
			set
			{
				if ((this._Address2 != value))
				{
					this.OnAddress2Changing(value);
					this.SendPropertyChanging();
					this._Address2 = value;
					this.SendPropertyChanged("Address2");
					this.OnAddress2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Town/City]", Storage="_Town_City", DbType="VarChar(50)")]
		public string Town_City
		{
			get
			{
				return this._Town_City;
			}
			set
			{
				if ((this._Town_City != value))
				{
					this.OnTown_CityChanging(value);
					this.SendPropertyChanging();
					this._Town_City = value;
					this.SendPropertyChanged("Town_City");
					this.OnTown_CityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostCode", DbType="VarChar(50)")]
		public string PostCode
		{
			get
			{
				return this._PostCode;
			}
			set
			{
				if ((this._PostCode != value))
				{
					this.OnPostCodeChanging(value);
					this.SendPropertyChanging();
					this._PostCode = value;
					this.SendPropertyChanged("PostCode");
					this.OnPostCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_County", DbType="VarChar(50)")]
		public string County
		{
			get
			{
				return this._County;
			}
			set
			{
				if ((this._County != value))
				{
					this.OnCountyChanging(value);
					this.SendPropertyChanging();
					this._County = value;
					this.SendPropertyChanged("County");
					this.OnCountyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Users_Subscription", Storage="_Users_Subscriptions", ThisKey="UserID", OtherKey="UserID")]
		public EntitySet<Users_Subscription> Users_Subscriptions
		{
			get
			{
				return this._Users_Subscriptions;
			}
			set
			{
				this._Users_Subscriptions.Assign(value);
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
		
		private void attach_Users_Subscriptions(Users_Subscription entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Users_Subscriptions(Users_Subscription entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="RealEstate.Users_Subscriptions")]
	public partial class Users_Subscription : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SubscriptionID;
		
		private System.Nullable<short> _PropertyTypeID;
		
		private string _PropertyLocation;
		
		private string _PropertyRadius;
		
		private System.Nullable<decimal> _PropertyMinPrice;
		
		private System.Nullable<decimal> _PropertyMaxPrice;
		
		private System.Nullable<short> _PropertyRoomMin;
		
		private System.Nullable<short> _PropertyRoomMax;
		
		private System.Nullable<int> _UserID;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSubscriptionIDChanging(int value);
    partial void OnSubscriptionIDChanged();
    partial void OnPropertyTypeIDChanging(System.Nullable<short> value);
    partial void OnPropertyTypeIDChanged();
    partial void OnPropertyLocationChanging(string value);
    partial void OnPropertyLocationChanged();
    partial void OnPropertyRadiusChanging(string value);
    partial void OnPropertyRadiusChanged();
    partial void OnPropertyMinPriceChanging(System.Nullable<decimal> value);
    partial void OnPropertyMinPriceChanged();
    partial void OnPropertyMaxPriceChanging(System.Nullable<decimal> value);
    partial void OnPropertyMaxPriceChanged();
    partial void OnPropertyRoomMinChanging(System.Nullable<short> value);
    partial void OnPropertyRoomMinChanged();
    partial void OnPropertyRoomMaxChanging(System.Nullable<short> value);
    partial void OnPropertyRoomMaxChanged();
    partial void OnUserIDChanging(System.Nullable<int> value);
    partial void OnUserIDChanged();
    #endregion
		
		public Users_Subscription()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubscriptionID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SubscriptionID
		{
			get
			{
				return this._SubscriptionID;
			}
			set
			{
				if ((this._SubscriptionID != value))
				{
					this.OnSubscriptionIDChanging(value);
					this.SendPropertyChanging();
					this._SubscriptionID = value;
					this.SendPropertyChanged("SubscriptionID");
					this.OnSubscriptionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyTypeID", DbType="SmallInt")]
		public System.Nullable<short> PropertyTypeID
		{
			get
			{
				return this._PropertyTypeID;
			}
			set
			{
				if ((this._PropertyTypeID != value))
				{
					this.OnPropertyTypeIDChanging(value);
					this.SendPropertyChanging();
					this._PropertyTypeID = value;
					this.SendPropertyChanged("PropertyTypeID");
					this.OnPropertyTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyLocation", DbType="VarChar(50)")]
		public string PropertyLocation
		{
			get
			{
				return this._PropertyLocation;
			}
			set
			{
				if ((this._PropertyLocation != value))
				{
					this.OnPropertyLocationChanging(value);
					this.SendPropertyChanging();
					this._PropertyLocation = value;
					this.SendPropertyChanged("PropertyLocation");
					this.OnPropertyLocationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyRadius", DbType="VarChar(50)")]
		public string PropertyRadius
		{
			get
			{
				return this._PropertyRadius;
			}
			set
			{
				if ((this._PropertyRadius != value))
				{
					this.OnPropertyRadiusChanging(value);
					this.SendPropertyChanging();
					this._PropertyRadius = value;
					this.SendPropertyChanged("PropertyRadius");
					this.OnPropertyRadiusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyMinPrice", DbType="Money")]
		public System.Nullable<decimal> PropertyMinPrice
		{
			get
			{
				return this._PropertyMinPrice;
			}
			set
			{
				if ((this._PropertyMinPrice != value))
				{
					this.OnPropertyMinPriceChanging(value);
					this.SendPropertyChanging();
					this._PropertyMinPrice = value;
					this.SendPropertyChanged("PropertyMinPrice");
					this.OnPropertyMinPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyMaxPrice", DbType="Money")]
		public System.Nullable<decimal> PropertyMaxPrice
		{
			get
			{
				return this._PropertyMaxPrice;
			}
			set
			{
				if ((this._PropertyMaxPrice != value))
				{
					this.OnPropertyMaxPriceChanging(value);
					this.SendPropertyChanging();
					this._PropertyMaxPrice = value;
					this.SendPropertyChanged("PropertyMaxPrice");
					this.OnPropertyMaxPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyRoomMin", DbType="SmallInt")]
		public System.Nullable<short> PropertyRoomMin
		{
			get
			{
				return this._PropertyRoomMin;
			}
			set
			{
				if ((this._PropertyRoomMin != value))
				{
					this.OnPropertyRoomMinChanging(value);
					this.SendPropertyChanging();
					this._PropertyRoomMin = value;
					this.SendPropertyChanged("PropertyRoomMin");
					this.OnPropertyRoomMinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyRoomMax", DbType="SmallInt")]
		public System.Nullable<short> PropertyRoomMax
		{
			get
			{
				return this._PropertyRoomMax;
			}
			set
			{
				if ((this._PropertyRoomMax != value))
				{
					this.OnPropertyRoomMaxChanging(value);
					this.SendPropertyChanging();
					this._PropertyRoomMax = value;
					this.SendPropertyChanged("PropertyRoomMax");
					this.OnPropertyRoomMaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int")]
		public System.Nullable<int> UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Users_Subscription", Storage="_User", ThisKey="UserID", OtherKey="UserID", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Users_Subscriptions.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Users_Subscriptions.Add(this);
						this._UserID = value.UserID;
					}
					else
					{
						this._UserID = default(Nullable<int>);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="RealEstate.Properties")]
	public partial class Property : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PropertyID;
		
		private string _PropertyAddress1;
		
		private string _PropertyAddress2;
		
		private string _PropertyTown_City;
		
		private string _PropertyPostCode;
		
		private string _PropertyCounty;
		
		private string _PropertyDescription;
		
		private System.Nullable<decimal> _PropertyPrice;
		
		private System.Nullable<short> _PropertyTenureID;
		
		private System.Nullable<short> _PropertyTypeID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPropertyIDChanging(int value);
    partial void OnPropertyIDChanged();
    partial void OnPropertyAddress1Changing(string value);
    partial void OnPropertyAddress1Changed();
    partial void OnPropertyAddress2Changing(string value);
    partial void OnPropertyAddress2Changed();
    partial void OnPropertyTown_CityChanging(string value);
    partial void OnPropertyTown_CityChanged();
    partial void OnPropertyPostCodeChanging(string value);
    partial void OnPropertyPostCodeChanged();
    partial void OnPropertyCountyChanging(string value);
    partial void OnPropertyCountyChanged();
    partial void OnPropertyDescriptionChanging(string value);
    partial void OnPropertyDescriptionChanged();
    partial void OnPropertyPriceChanging(System.Nullable<decimal> value);
    partial void OnPropertyPriceChanged();
    partial void OnPropertyTenureIDChanging(System.Nullable<short> value);
    partial void OnPropertyTenureIDChanged();
    partial void OnPropertyTypeIDChanging(System.Nullable<short> value);
    partial void OnPropertyTypeIDChanged();
    #endregion
		
		public Property()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PropertyID
		{
			get
			{
				return this._PropertyID;
			}
			set
			{
				if ((this._PropertyID != value))
				{
					this.OnPropertyIDChanging(value);
					this.SendPropertyChanging();
					this._PropertyID = value;
					this.SendPropertyChanged("PropertyID");
					this.OnPropertyIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyAddress1", DbType="VarChar(50)")]
		public string PropertyAddress1
		{
			get
			{
				return this._PropertyAddress1;
			}
			set
			{
				if ((this._PropertyAddress1 != value))
				{
					this.OnPropertyAddress1Changing(value);
					this.SendPropertyChanging();
					this._PropertyAddress1 = value;
					this.SendPropertyChanged("PropertyAddress1");
					this.OnPropertyAddress1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyAddress2", DbType="VarChar(50)")]
		public string PropertyAddress2
		{
			get
			{
				return this._PropertyAddress2;
			}
			set
			{
				if ((this._PropertyAddress2 != value))
				{
					this.OnPropertyAddress2Changing(value);
					this.SendPropertyChanging();
					this._PropertyAddress2 = value;
					this.SendPropertyChanged("PropertyAddress2");
					this.OnPropertyAddress2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[PropertyTown/City]", Storage="_PropertyTown_City", DbType="VarChar(50)")]
		public string PropertyTown_City
		{
			get
			{
				return this._PropertyTown_City;
			}
			set
			{
				if ((this._PropertyTown_City != value))
				{
					this.OnPropertyTown_CityChanging(value);
					this.SendPropertyChanging();
					this._PropertyTown_City = value;
					this.SendPropertyChanged("PropertyTown_City");
					this.OnPropertyTown_CityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyPostCode", DbType="VarChar(50)")]
		public string PropertyPostCode
		{
			get
			{
				return this._PropertyPostCode;
			}
			set
			{
				if ((this._PropertyPostCode != value))
				{
					this.OnPropertyPostCodeChanging(value);
					this.SendPropertyChanging();
					this._PropertyPostCode = value;
					this.SendPropertyChanged("PropertyPostCode");
					this.OnPropertyPostCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyCounty", DbType="VarChar(50)")]
		public string PropertyCounty
		{
			get
			{
				return this._PropertyCounty;
			}
			set
			{
				if ((this._PropertyCounty != value))
				{
					this.OnPropertyCountyChanging(value);
					this.SendPropertyChanging();
					this._PropertyCounty = value;
					this.SendPropertyChanged("PropertyCounty");
					this.OnPropertyCountyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyDescription", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string PropertyDescription
		{
			get
			{
				return this._PropertyDescription;
			}
			set
			{
				if ((this._PropertyDescription != value))
				{
					this.OnPropertyDescriptionChanging(value);
					this.SendPropertyChanging();
					this._PropertyDescription = value;
					this.SendPropertyChanged("PropertyDescription");
					this.OnPropertyDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyPrice", DbType="Money")]
		public System.Nullable<decimal> PropertyPrice
		{
			get
			{
				return this._PropertyPrice;
			}
			set
			{
				if ((this._PropertyPrice != value))
				{
					this.OnPropertyPriceChanging(value);
					this.SendPropertyChanging();
					this._PropertyPrice = value;
					this.SendPropertyChanged("PropertyPrice");
					this.OnPropertyPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyTenureID", DbType="SmallInt")]
		public System.Nullable<short> PropertyTenureID
		{
			get
			{
				return this._PropertyTenureID;
			}
			set
			{
				if ((this._PropertyTenureID != value))
				{
					this.OnPropertyTenureIDChanging(value);
					this.SendPropertyChanging();
					this._PropertyTenureID = value;
					this.SendPropertyChanged("PropertyTenureID");
					this.OnPropertyTenureIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PropertyTypeID", DbType="SmallInt")]
		public System.Nullable<short> PropertyTypeID
		{
			get
			{
				return this._PropertyTypeID;
			}
			set
			{
				if ((this._PropertyTypeID != value))
				{
					this.OnPropertyTypeIDChanging(value);
					this.SendPropertyChanging();
					this._PropertyTypeID = value;
					this.SendPropertyChanged("PropertyTypeID");
					this.OnPropertyTypeIDChanged();
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
