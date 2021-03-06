//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by CodeSmith Template.
//
//     Creater: David
//     Date:    2015/3/12
//     Time:    13:52
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
    /// 表名：STK_StockSheet 主键列：SSGuid
    /// </summary>
    [SerializableAttribute()]
	public partial class STK_StockSheet : BaseEntity
	{
		#region Private Properties
		
		private Int32? _SheetID;
		private Guid? _SSGuid;
		private Int32? _SSType;
		private Guid? _GCompanyID;
		private Int32? _OperEmpID;
		private String _OperEmpName;
		private Guid? _SourceBillGuid;
		private String _SourceBillNo;
		private Guid? _SourceBillLineGuid;
		private Guid? _ItemCode;
		private String _Model;
		private String _Brand;
		private String _Batch;
		private String _Package;
		private String _Quality;
		private String _MPQ;
		private String _MarkCode;
		private Int32? _FlowQty;
		private String _Currency;
		private Decimal? _FlowPrice;
		private Decimal? _FlowAmount;
		private Int32? _CreatedEmpID;
		private String _CreatedEmpName;
		private DateTime? _CreatedTime;
		private Int32? _UpdatedEmpID;
		private String _UpdatedEmpName;
		private DateTime? _UpdatedTime;
		private Boolean? _IsDeleted;
		
		#endregion
		
		#region Public Properties
		
		/// <summary>
		/// .
		/// </summary>
		public Guid? SSGuid
		{
			get 
			{
				return _SSGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.SSGuid, _SSGuid , value);
				this._SSGuid = value;
			}
		}
		
		/// <summary>
		/// 流水自增ID（用于排序）.
		/// </summary>
		public Int32? SheetID
		{
			get 
			{
				return this._SheetID;
			}
			set 
			{
				this.OnPropertyValueChange(_.SheetID, _SheetID , value);
				this._SheetID = value;
			}
		}

		/// <summary>
		/// 流水类型(1.增加，2.减少).
		/// </summary>
		public Int32? SSType
		{
			get 
			{
				return this._SSType;
			}
			set 
			{
				this.OnPropertyValueChange(_.SSType, _SSType , value);
				this._SSType = value;
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
				this.OnPropertyValueChange(_.GCompanyID, _GCompanyID , value);
				this._GCompanyID = value;
			}
		}

		/// <summary>
		/// 归属人员ID.
		/// </summary>
		public Int32? OperEmpID
		{
			get 
			{
				return this._OperEmpID;
			}
			set 
			{
				this.OnPropertyValueChange(_.OperEmpID, _OperEmpID , value);
				this._OperEmpID = value;
			}
		}

		/// <summary>
		/// 归属人员.
		/// </summary>
		public String OperEmpName
		{
			get 
			{
				return this._OperEmpName;
			}
			set 
			{
				this.OnPropertyValueChange(_.OperEmpName, _OperEmpName , value);
				this._OperEmpName = value.SubStr(50);
			}
		}

		/// <summary>
		/// 关联单据guid(入库单，出库）.
		/// </summary>
		public Guid? SourceBillGuid
		{
			get 
			{
				return this._SourceBillGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.SourceBillGuid, _SourceBillGuid , value);
				this._SourceBillGuid = value;
			}
		}

		/// <summary>
		/// 关联单据编号（入库单或者出库单编号.
		/// </summary>
		public String SourceBillNo
		{
			get 
			{
				return this._SourceBillNo;
			}
			set 
			{
				this.OnPropertyValueChange(_.SourceBillNo, _SourceBillNo , value);
				this._SourceBillNo = value.SubStr(20);
			}
		}

		/// <summary>
		/// 关联明细guid (入库单明细，出库单明细guid).
		/// </summary>
		public Guid? SourceBillLineGuid
		{
			get 
			{
				return this._SourceBillLineGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.SourceBillLineGuid, _SourceBillLineGuid , value);
				this._SourceBillLineGuid = value;
			}
		}

		/// <summary>
		/// 存库ID.
		/// </summary>
		public Guid? ItemCode
		{
			get 
			{
				return this._ItemCode;
			}
			set 
			{
				this.OnPropertyValueChange(_.ItemCode, _ItemCode , value);
				this._ItemCode = value;
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public String Model
		{
			get 
			{
				return this._Model;
			}
			set 
			{
				this.OnPropertyValueChange(_.Model, _Model , value);
				this._Model = value.SubStr(50);
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public String Brand
		{
			get 
			{
				return this._Brand;
			}
			set 
			{
				this.OnPropertyValueChange(_.Brand, _Brand , value);
				this._Brand = value.SubStr(50);
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public String Batch
		{
			get 
			{
				return this._Batch;
			}
			set 
			{
				this.OnPropertyValueChange(_.Batch, _Batch , value);
				this._Batch = value.SubStr(50);
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public String Package
		{
			get 
			{
				return this._Package;
			}
			set 
			{
				this.OnPropertyValueChange(_.Package, _Package , value);
				this._Package = value.SubStr(50);
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public String Quality
		{
			get 
			{
				return this._Quality;
			}
			set 
			{
				this.OnPropertyValueChange(_.Quality, _Quality , value);
				this._Quality = value.SubStr(50);
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public String MPQ
		{
			get 
			{
				return this._MPQ;
			}
			set 
			{
				this.OnPropertyValueChange(_.MPQ, _MPQ , value);
				this._MPQ = value.SubStr(50);
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public String MarkCode
		{
			get 
			{
				return this._MarkCode;
			}
			set 
			{
				this.OnPropertyValueChange(_.MarkCode, _MarkCode , value);
				this._MarkCode = value.SubStr(50);
			}
		}

		/// <summary>
		/// 流水数量（减少用负数）.
		/// </summary>
		public Int32? FlowQty
		{
			get 
			{
				return this._FlowQty;
			}
			set 
			{
				this.OnPropertyValueChange(_.FlowQty, _FlowQty , value);
				this._FlowQty = value;
			}
		}

		/// <summary>
		/// 流水币种.
		/// </summary>
		public String Currency
		{
			get 
			{
				return this._Currency;
			}
			set 
			{
				this.OnPropertyValueChange(_.Currency, _Currency , value);
				this._Currency = value.SubStr(10);
			}
		}

		/// <summary>
		/// 流水单价.
		/// </summary>
		public Decimal? FlowPrice
		{
			get 
			{
				return this._FlowPrice;
			}
			set 
			{
				this.OnPropertyValueChange(_.FlowPrice, _FlowPrice , value);
				this._FlowPrice = value;
			}
		}

		/// <summary>
		/// 流水金额（减少用负数）.
		/// </summary>
		public Decimal? FlowAmount
		{
			get 
			{
				return this._FlowAmount;
			}
			set 
			{
				this.OnPropertyValueChange(_.FlowAmount, _FlowAmount , value);
				this._FlowAmount = value;
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public Int32? CreatedEmpID
		{
			get 
			{
				return this._CreatedEmpID;
			}
			set 
			{
				this.OnPropertyValueChange(_.CreatedEmpID, _CreatedEmpID , value);
				this._CreatedEmpID = value;
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public String CreatedEmpName
		{
			get 
			{
				return this._CreatedEmpName;
			}
			set 
			{
				this.OnPropertyValueChange(_.CreatedEmpName, _CreatedEmpName , value);
				this._CreatedEmpName = value.SubStr(50);
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public DateTime? CreatedTime
		{
			get 
			{
				return this._CreatedTime;
			}
			set 
			{
				this.OnPropertyValueChange(_.CreatedTime, _CreatedTime , value);
				this._CreatedTime = value;
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public Int32? UpdatedEmpID
		{
			get 
			{
				return this._UpdatedEmpID;
			}
			set 
			{
				this.OnPropertyValueChange(_.UpdatedEmpID, _UpdatedEmpID , value);
				this._UpdatedEmpID = value;
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public String UpdatedEmpName
		{
			get 
			{
				return this._UpdatedEmpName;
			}
			set 
			{
				this.OnPropertyValueChange(_.UpdatedEmpName, _UpdatedEmpName , value);
				this._UpdatedEmpName = value.SubStr(50);
			}
		}

		/// <summary>
		/// .
		/// </summary>
		public DateTime? UpdatedTime
		{
			get 
			{
				return this._UpdatedTime;
			}
			set 
			{
				this.OnPropertyValueChange(_.UpdatedTime, _UpdatedTime , value);
				this._UpdatedTime = value;
			}
		}

		/// <summary>
		/// 是否删除.
		/// </summary>
		public Boolean? IsDeleted
		{
			get 
			{
				return this._IsDeleted;
			}
			set 
			{
				this.OnPropertyValueChange(_.IsDeleted, _IsDeleted , value);
				this._IsDeleted = value;
			}
		}
		
		#endregion
	    /// <summary>
        /// 获取实体对应的表名
        /// </summary>
        protected override Table GetTable() {
            return new Table< STK_StockSheet >("STK_StockSheet");
        }
		
		
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        protected override Field[] GetPrimaryKeyFields() {
            return new Field[] {
				_.SSGuid
			};
        }
			
	    /// <summary>
        /// 获取列信息
        /// </summary>
        protected override Field[] GetFields() {
            return new Field[] {
				_.SheetID,		
				_.SSGuid,		
				_.SSType,		
				_.GCompanyID,		
				_.OperEmpID,		
				_.OperEmpName,		
				_.SourceBillGuid,		
				_.SourceBillNo,		
				_.SourceBillLineGuid,		
				_.ItemCode,		
				_.Model,		
				_.Brand,		
				_.Batch,		
				_.Package,		
				_.Quality,		
				_.MPQ,		
				_.MarkCode,		
				_.FlowQty,		
				_.Currency,		
				_.FlowPrice,		
				_.FlowAmount,		
				_.CreatedEmpID,		
				_.CreatedEmpName,		
				_.CreatedTime,		
				_.UpdatedEmpID,		
				_.UpdatedEmpName,		
				_.UpdatedTime,		
				_.IsDeleted		
			};
		}
		
	    /// <summary>
        /// 获取列数据
        /// </summary>
        protected override object[] GetValues() {
            return new object[] {
				this._SheetID,		
				this._SSGuid,		
				this._SSType,		
				this._GCompanyID,		
				this._OperEmpID,		
				this._OperEmpName,		
				this._SourceBillGuid,		
				this._SourceBillNo,		
				this._SourceBillLineGuid,		
				this._ItemCode,		
				this._Model,		
				this._Brand,		
				this._Batch,		
				this._Package,		
				this._Quality,		
				this._MPQ,		
				this._MarkCode,		
				this._FlowQty,		
				this._Currency,		
				this._FlowPrice,		
				this._FlowAmount,		
				this._CreatedEmpID,		
				this._CreatedEmpName,		
				this._CreatedTime,		
				this._UpdatedEmpID,		
				this._UpdatedEmpName,		
				this._UpdatedTime,		
				this._IsDeleted		
			};
		}
		
	    /// <summary>
        /// 给当前实体赋值
        /// </summary>
        protected override void SetValues(IRowReader reader) {
            if ((false == reader.IsDBNull(_.SheetID))) {
                this._SheetID = reader.GetInt32(_.SheetID);
            }
            if ((false == reader.IsDBNull(_.SSGuid))) {
                this._SSGuid = reader.GetGuid(_.SSGuid);
            }
            if ((false == reader.IsDBNull(_.SSType))) {
                this._SSType = reader.GetInt32(_.SSType);
            }
            if ((false == reader.IsDBNull(_.GCompanyID))) {
                this._GCompanyID = reader.GetGuid(_.GCompanyID);
            }
            if ((false == reader.IsDBNull(_.OperEmpID))) {
                this._OperEmpID = reader.GetInt32(_.OperEmpID);
            }
            if ((false == reader.IsDBNull(_.OperEmpName))) {
                this._OperEmpName = reader.GetString(_.OperEmpName);
            }
            if ((false == reader.IsDBNull(_.SourceBillGuid))) {
                this._SourceBillGuid = reader.GetGuid(_.SourceBillGuid);
            }
            if ((false == reader.IsDBNull(_.SourceBillNo))) {
                this._SourceBillNo = reader.GetString(_.SourceBillNo);
            }
            if ((false == reader.IsDBNull(_.SourceBillLineGuid))) {
                this._SourceBillLineGuid = reader.GetGuid(_.SourceBillLineGuid);
            }
            if ((false == reader.IsDBNull(_.ItemCode))) {
                this._ItemCode = reader.GetGuid(_.ItemCode);
            }
            if ((false == reader.IsDBNull(_.Model))) {
                this._Model = reader.GetString(_.Model);
            }
            if ((false == reader.IsDBNull(_.Brand))) {
                this._Brand = reader.GetString(_.Brand);
            }
            if ((false == reader.IsDBNull(_.Batch))) {
                this._Batch = reader.GetString(_.Batch);
            }
            if ((false == reader.IsDBNull(_.Package))) {
                this._Package = reader.GetString(_.Package);
            }
            if ((false == reader.IsDBNull(_.Quality))) {
                this._Quality = reader.GetString(_.Quality);
            }
            if ((false == reader.IsDBNull(_.MPQ))) {
                this._MPQ = reader.GetString(_.MPQ);
            }
            if ((false == reader.IsDBNull(_.MarkCode))) {
                this._MarkCode = reader.GetString(_.MarkCode);
            }
            if ((false == reader.IsDBNull(_.FlowQty))) {
                this._FlowQty = reader.GetInt32(_.FlowQty);
            }
            if ((false == reader.IsDBNull(_.Currency))) {
                this._Currency = reader.GetString(_.Currency);
            }
            if ((false == reader.IsDBNull(_.FlowPrice))) {
                this._FlowPrice = reader.GetDecimal(_.FlowPrice);
            }
            if ((false == reader.IsDBNull(_.FlowAmount))) {
                this._FlowAmount = reader.GetDecimal(_.FlowAmount);
            }
            if ((false == reader.IsDBNull(_.CreatedEmpID))) {
                this._CreatedEmpID = reader.GetInt32(_.CreatedEmpID);
            }
            if ((false == reader.IsDBNull(_.CreatedEmpName))) {
                this._CreatedEmpName = reader.GetString(_.CreatedEmpName);
            }
            if ((false == reader.IsDBNull(_.CreatedTime))) {
                this._CreatedTime = reader.GetDateTime(_.CreatedTime);
            }
            if ((false == reader.IsDBNull(_.UpdatedEmpID))) {
                this._UpdatedEmpID = reader.GetInt32(_.UpdatedEmpID);
            }
            if ((false == reader.IsDBNull(_.UpdatedEmpName))) {
                this._UpdatedEmpName = reader.GetString(_.UpdatedEmpName);
            }
            if ((false == reader.IsDBNull(_.UpdatedTime))) {
                this._UpdatedTime = reader.GetDateTime(_.UpdatedTime);
            }
            if ((false == reader.IsDBNull(_.IsDeleted))) {
                this._IsDeleted = reader.GetBoolean(_.IsDeleted);
            }
		}
		
	    public override int GetHashCode() {
            return base.GetHashCode();
        }
        
        public override bool Equals(object obj) {
            if ((obj == null)) {
                return false;
            }
            if ((false == typeof(STK_StockSheet).IsAssignableFrom(obj.GetType()))) {
                return false;
            }
            if ((((object)(this)) == ((object)(obj)))) {
                return true;
            }
            return false;
        }
		
        public class _ {
                
            /// <summary>
            /// 表示选择所有列，与*等同
            /// </summary>
            public static AllField All = new AllField< STK_StockSheet >();
			
		    /// <summary>
            /// 流水自增ID（用于排序） - 字段名：SheetID - 数据类型：Int32?
            /// </summary>
            public static Field SheetID = new Field< STK_StockSheet >("SheetID");
		    /// <summary>
            ///  - 字段名：SSGuid - 数据类型：Guid?
            /// </summary>
            public static Field SSGuid = new Field< STK_StockSheet >("SSGuid");
		    /// <summary>
            /// 流水类型(1.增加，2.减少) - 字段名：SSType - 数据类型：Int32?
            /// </summary>
            public static Field SSType = new Field< STK_StockSheet >("SSType");
		    /// <summary>
            ///  - 字段名：GCompanyID - 数据类型：Guid?
            /// </summary>
            public static Field GCompanyID = new Field< STK_StockSheet >("GCompanyID");
		    /// <summary>
            /// 归属人员ID - 字段名：OperEmpID - 数据类型：Int32?
            /// </summary>
            public static Field OperEmpID = new Field< STK_StockSheet >("OperEmpID");
		    /// <summary>
            /// 归属人员 - 字段名：OperEmpName - 数据类型：String
            /// </summary>
            public static Field OperEmpName = new Field< STK_StockSheet >("OperEmpName");
		    /// <summary>
            /// 关联单据guid(入库单，出库） - 字段名：SourceBillGuid - 数据类型：Guid?
            /// </summary>
            public static Field SourceBillGuid = new Field< STK_StockSheet >("SourceBillGuid");
		    /// <summary>
            /// 关联单据编号（入库单或者出库单编号 - 字段名：SourceBillNo - 数据类型：String
            /// </summary>
            public static Field SourceBillNo = new Field< STK_StockSheet >("SourceBillNo");
		    /// <summary>
            /// 关联明细guid (入库单明细，出库单明细guid) - 字段名：SourceBillLineGuid - 数据类型：Guid?
            /// </summary>
            public static Field SourceBillLineGuid = new Field< STK_StockSheet >("SourceBillLineGuid");
		    /// <summary>
            /// 存库ID - 字段名：ItemCode - 数据类型：Guid?
            /// </summary>
            public static Field ItemCode = new Field< STK_StockSheet >("ItemCode");
		    /// <summary>
            ///  - 字段名：Model - 数据类型：String
            /// </summary>
            public static Field Model = new Field< STK_StockSheet >("Model");
		    /// <summary>
            ///  - 字段名：Brand - 数据类型：String
            /// </summary>
            public static Field Brand = new Field< STK_StockSheet >("Brand");
		    /// <summary>
            ///  - 字段名：Batch - 数据类型：String
            /// </summary>
            public static Field Batch = new Field< STK_StockSheet >("Batch");
		    /// <summary>
            ///  - 字段名：Package - 数据类型：String
            /// </summary>
            public static Field Package = new Field< STK_StockSheet >("Package");
		    /// <summary>
            ///  - 字段名：Quality - 数据类型：String
            /// </summary>
            public static Field Quality = new Field< STK_StockSheet >("Quality");
		    /// <summary>
            ///  - 字段名：MPQ - 数据类型：String
            /// </summary>
            public static Field MPQ = new Field< STK_StockSheet >("MPQ");
		    /// <summary>
            ///  - 字段名：MarkCode - 数据类型：String
            /// </summary>
            public static Field MarkCode = new Field< STK_StockSheet >("MarkCode");
		    /// <summary>
            /// 流水数量（减少用负数） - 字段名：FlowQty - 数据类型：Int32?
            /// </summary>
            public static Field FlowQty = new Field< STK_StockSheet >("FlowQty");
		    /// <summary>
            /// 流水币种 - 字段名：Currency - 数据类型：String
            /// </summary>
            public static Field Currency = new Field< STK_StockSheet >("Currency");
		    /// <summary>
            /// 流水单价 - 字段名：FlowPrice - 数据类型：Decimal?
            /// </summary>
            public static Field FlowPrice = new Field< STK_StockSheet >("FlowPrice");
		    /// <summary>
            /// 流水金额（减少用负数） - 字段名：FlowAmount - 数据类型：Decimal?
            /// </summary>
            public static Field FlowAmount = new Field< STK_StockSheet >("FlowAmount");
		    /// <summary>
            ///  - 字段名：CreatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field CreatedEmpID = new Field< STK_StockSheet >("CreatedEmpID");
		    /// <summary>
            ///  - 字段名：CreatedEmpName - 数据类型：String
            /// </summary>
            public static Field CreatedEmpName = new Field< STK_StockSheet >("CreatedEmpName");
		    /// <summary>
            ///  - 字段名：CreatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field CreatedTime = new Field< STK_StockSheet >("CreatedTime");
		    /// <summary>
            ///  - 字段名：UpdatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field UpdatedEmpID = new Field< STK_StockSheet >("UpdatedEmpID");
		    /// <summary>
            ///  - 字段名：UpdatedEmpName - 数据类型：String
            /// </summary>
            public static Field UpdatedEmpName = new Field< STK_StockSheet >("UpdatedEmpName");
		    /// <summary>
            ///  - 字段名：UpdatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field UpdatedTime = new Field< STK_StockSheet >("UpdatedTime");
		    /// <summary>
            /// 是否删除 - 字段名：IsDeleted - 数据类型：Boolean?
            /// </summary>
            public static Field IsDeleted = new Field< STK_StockSheet >("IsDeleted");
		}
	}
}
