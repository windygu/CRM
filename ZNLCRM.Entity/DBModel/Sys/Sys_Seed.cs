﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by CodeSmith Template.
//
//     Creater: Administrator
//     Date:    2014/9/5
//     Time:    15:55
//     Version: 4.0.0.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

/// <summary>
/// CodeSmith自动生成的实体
/// </summary>
namespace ZNLCRM.Entity.DBModel
{
    using System;
    using MySoft.Data;
    using ZNLCRM.Utility;
    using ZNLFrame.Entity;
    /// <summary>
    /// 表名：Sys_Seed 主键列：SeedID
    /// </summary>
    [SerializableAttribute()]
    public partial class Sys_Seed : BaseEntity
    {
        #region Private Properties

        private Int32 _SeedID;
        private Guid? _SeedGuID;
        private Guid? _GCompanyID;
        private String _TableName;
        private Int32? _Year;
        private Int32? _Month;
        private Int32? _Day;
        private Int32? _SeedValue;

        #endregion

        #region Public Properties

        /// <summary>
        /// .
        /// </summary>
        public Int32 SeedID
        {
            get
            {
                return _SeedID;
            }
            set
            {
                this.OnPropertyValueChange(_.SeedID, _SeedID, value);
                this._SeedID = value;
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public Guid? SeedGuID
        {
            get
            {
                return this._SeedGuID;
            }
            set
            {
                this.OnPropertyValueChange(_.SeedGuID, _SeedGuID, value);
                this._SeedGuID = value;
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public Guid? GCompanyID
        {
            get
            {
                return this._GCompanyID;
            }
            set
            {
                this.OnPropertyValueChange(_.GCompanyID, _GCompanyID, value);
                this._GCompanyID = value;
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public String TableName
        {
            get
            {
                return this._TableName;
            }
            set
            {
                this.OnPropertyValueChange(_.TableName, _TableName, value);
                this._TableName = value.SubStr(200);
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public Int32? Year
        {
            get
            {
                return this._Year;
            }
            set
            {
                this.OnPropertyValueChange(_.Year, _Year, value);
                this._Year = value;
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public Int32? Month
        {
            get
            {
                return this._Month;
            }
            set
            {
                this.OnPropertyValueChange(_.Month, _Month, value);
                this._Month = value;
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public Int32? Day
        {
            get
            {
                return this._Day;
            }
            set
            {
                this.OnPropertyValueChange(_.Day, _Day, value);
                this._Day = value;
            }
        }

        /// <summary>
        /// .
        /// </summary>
        public Int32? SeedValue
        {
            get
            {
                return this._SeedValue;
            }
            set
            {
                this.OnPropertyValueChange(_.SeedValue, _SeedValue, value);
                this._SeedValue = value;
            }
        }

        #endregion
        /// <summary>
        /// 获取实体对应的表名
        /// </summary>
        protected override Table GetTable()
        {
            return new Table<Sys_Seed>("Sys_Seed");
        }

        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        protected override Field GetIdentityField()
        {
            return _.SeedID;
        }

        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        protected override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.SeedID
			};
        }

        /// <summary>
        /// 获取列信息
        /// </summary>
        protected override Field[] GetFields()
        {
            return new Field[] {
				_.SeedID,		
				_.SeedGuID,		
				_.GCompanyID,		
				_.TableName,		
				_.Year,		
				_.Month,		
				_.Day,		
				_.SeedValue		
			};
        }

        /// <summary>
        /// 获取列数据
        /// </summary>
        protected override object[] GetValues()
        {
            return new object[] {
				this._SeedID,		
				this._SeedGuID,		
				this._GCompanyID,		
				this._TableName,		
				this._Year,		
				this._Month,		
				this._Day,		
				this._SeedValue		
			};
        }

        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        protected override void SetValues(IRowReader reader)
        {
            if ((false == reader.IsDBNull(_.SeedID)))
            {
                this._SeedID = reader.GetInt32(_.SeedID);
            }
            if ((false == reader.IsDBNull(_.SeedGuID)))
            {
                this._SeedGuID = reader.GetGuid(_.SeedGuID);
            }
            if ((false == reader.IsDBNull(_.GCompanyID)))
            {
                this._GCompanyID = reader.GetGuid(_.GCompanyID);
            }
            if ((false == reader.IsDBNull(_.TableName)))
            {
                this._TableName = reader.GetString(_.TableName);
            }
            if ((false == reader.IsDBNull(_.Year)))
            {
                this._Year = reader.GetInt32(_.Year);
            }
            if ((false == reader.IsDBNull(_.Month)))
            {
                this._Month = reader.GetInt32(_.Month);
            }
            if ((false == reader.IsDBNull(_.Day)))
            {
                this._Day = reader.GetInt32(_.Day);
            }
            if ((false == reader.IsDBNull(_.SeedValue)))
            {
                this._SeedValue = reader.GetInt32(_.SeedValue);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if ((obj == null))
            {
                return false;
            }
            if ((false == typeof(Sys_Seed).IsAssignableFrom(obj.GetType())))
            {
                return false;
            }
            if ((((object)(this)) == ((object)(obj))))
            {
                return true;
            }
            return false;
        }

        public class _
        {

            /// <summary>
            /// 表示选择所有列，与*等同
            /// </summary>
            public static AllField All = new AllField<Sys_Seed>();

            /// <summary>
            ///  - 字段名：SeedID - 数据类型：Int32?
            /// </summary>
            public static Field SeedID = new Field<Sys_Seed>("SeedID");
            /// <summary>
            ///  - 字段名：SeedGuID - 数据类型：Guid?
            /// </summary>
            public static Field SeedGuID = new Field<Sys_Seed>("SeedGuID");
            /// <summary>
            ///  - 字段名：GCompanyID - 数据类型：Guid?
            /// </summary>
            public static Field GCompanyID = new Field<Sys_Seed>("GCompanyID");
            /// <summary>
            ///  - 字段名：TableName - 数据类型：String
            /// </summary>
            public static Field TableName = new Field<Sys_Seed>("TableName");
            /// <summary>
            ///  - 字段名：Year - 数据类型：Int32?
            /// </summary>
            public static Field Year = new Field<Sys_Seed>("Year");
            /// <summary>
            ///  - 字段名：Month - 数据类型：Int32?
            /// </summary>
            public static Field Month = new Field<Sys_Seed>("Month");
            /// <summary>
            ///  - 字段名：Day - 数据类型：Int32?
            /// </summary>
            public static Field Day = new Field<Sys_Seed>("Day");
            /// <summary>
            ///  - 字段名：SeedValue - 数据类型：Int32?
            /// </summary>
            public static Field SeedValue = new Field<Sys_Seed>("SeedValue");
        }
    }
}
