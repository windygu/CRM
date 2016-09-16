//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by CodeSmith Template.
//
//     Creater: David
//     Date:    2015/1/8
//     Time:    14:43
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
    /// 表名：STK_Out 主键列：StkOutID
    /// </summary>
    [SerializableAttribute()]
	public partial class STK_Out : BaseEntity
	{
		#region Private Properties
		
		private Int32 _StkOutID;
		private Guid? _StkOutGuid;
		private Guid? _GCompanyID;
		private String _BillNo;
		private String _BillType;
		private DateTime? _OutDate;
		private Int32? _OperOrgID;
		private Int32? _OperDeptID;
		private Int32? _OperEmpID;
		private String _OperEmpName;
		private Guid? _SourceBillGuid;
		private String _SourceBillNo;
		private String _TransportCompany;
		private String _ShippingNo;
		private String _Currency;
		private Decimal? _TaxRate;
		private Decimal? _Amount;
		private Decimal? _SCAmount;
		private Decimal? _TaxAmount;
		private Decimal? _ExchangeRate;
		private String _Remark;
		private Decimal? _ReceivedAmount;
		private DateTime? _ReceivedDate;
		private Boolean? _IsCut;
		private Boolean? _IsRaiseTaxes;
		private String _ApproveStatus;
		private String _Status;
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
		/// 出库单ID.
		/// </summary>
		public Int32 StkOutID
		{
			get 
			{
				return _StkOutID;
			}
			set 
			{
				this.OnPropertyValueChange(_.StkOutID, _StkOutID , value);
				this._StkOutID = value;
			}
		}
		
		/// <summary>
		/// 出库GUID.
		/// </summary>
		public Guid? StkOutGuid
		{
			get 
			{
				return this._StkOutGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.StkOutGuid, _StkOutGuid , value);
				this._StkOutGuid = value;
			}
		}

		/// <summary>
		/// 公司GUID.
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
		/// 出库单编号.
		/// </summary>
		public String BillNo
		{
			get 
			{
				return this._BillNo;
			}
			set 
			{
				this.OnPropertyValueChange(_.BillNo, _BillNo , value);
				this._BillNo = value.SubStr(50);
			}
		}

		/// <summary>
		/// 销售出货，采购退货出库，杂项出库.
		/// </summary>
		public String BillType
		{
			get 
			{
				return this._BillType;
			}
			set 
			{
				this.OnPropertyValueChange(_.BillType, _BillType , value);
				this._BillType = value.SubStr(20);
			}
		}

		/// <summary>
		/// 出库日期.
		/// </summary>
		public DateTime? OutDate
		{
			get 
			{
				return this._OutDate;
			}
			set 
			{
				this.OnPropertyValueChange(_.OutDate, _OutDate , value);
				this._OutDate = value;
			}
		}

		/// <summary>
		/// 操作人机构ID.
		/// </summary>
		public Int32? OperOrgID
		{
			get 
			{
				return this._OperOrgID;
			}
			set 
			{
				this.OnPropertyValueChange(_.OperOrgID, _OperOrgID , value);
				this._OperOrgID = value;
			}
		}

		/// <summary>
		/// 操作部门ID.
		/// </summary>
		public Int32? OperDeptID
		{
			get 
			{
				return this._OperDeptID;
			}
			set 
			{
				this.OnPropertyValueChange(_.OperDeptID, _OperDeptID , value);
				this._OperDeptID = value;
			}
		}

		/// <summary>
		/// 操作人ID.
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
		/// 操作员.
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
		/// 内部单据GuID.
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
		/// 内部单据编号.
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
		/// 运输公司.
		/// </summary>
		public String TransportCompany
		{
			get 
			{
				return this._TransportCompany;
			}
			set 
			{
				this.OnPropertyValueChange(_.TransportCompany, _TransportCompany , value);
				this._TransportCompany = value.SubStr(50);
			}
		}

		/// <summary>
		/// 货运单号.
		/// </summary>
		public String ShippingNo
		{
			get 
			{
				return this._ShippingNo;
			}
			set 
			{
				this.OnPropertyValueChange(_.ShippingNo, _ShippingNo , value);
				this._ShippingNo = value.SubStr(50);
			}
		}

		/// <summary>
		/// 币种.
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
		/// 税率.
		/// </summary>
		public Decimal? TaxRate
		{
			get 
			{
				return this._TaxRate;
			}
			set 
			{
				this.OnPropertyValueChange(_.TaxRate, _TaxRate , value);
				this._TaxRate = value;
			}
		}

		/// <summary>
		/// 记帐金额.
		/// </summary>
		public Decimal? Amount
		{
			get 
			{
				return this._Amount;
			}
			set 
			{
				this.OnPropertyValueChange(_.Amount, _Amount , value);
				this._Amount = value;
			}
		}

		/// <summary>
		/// 本币金额.
		/// </summary>
		public Decimal? SCAmount
		{
			get 
			{
				return this._SCAmount;
			}
			set 
			{
				this.OnPropertyValueChange(_.SCAmount, _SCAmount , value);
				this._SCAmount = value;
			}
		}

		/// <summary>
		/// 税额.
		/// </summary>
		public Decimal? TaxAmount
		{
			get 
			{
				return this._TaxAmount;
			}
			set 
			{
				this.OnPropertyValueChange(_.TaxAmount, _TaxAmount , value);
				this._TaxAmount = value;
			}
		}

		/// <summary>
		/// 汇率.
		/// </summary>
		public Decimal? ExchangeRate
		{
			get 
			{
				return this._ExchangeRate;
			}
			set 
			{
				this.OnPropertyValueChange(_.ExchangeRate, _ExchangeRate , value);
				this._ExchangeRate = value;
			}
		}

		/// <summary>
		/// 备注.
		/// </summary>
		public String Remark
		{
			get 
			{
				return this._Remark;
			}
			set 
			{
				this.OnPropertyValueChange(_.Remark, _Remark , value);
				this._Remark = value.SubStr(100);
			}
		}

		/// <summary>
		/// 已收金额.
		/// </summary>
		public Decimal? ReceivedAmount
		{
			get 
			{
				return this._ReceivedAmount;
			}
			set 
			{
				this.OnPropertyValueChange(_.ReceivedAmount, _ReceivedAmount , value);
				this._ReceivedAmount = value;
			}
		}

		/// <summary>
		/// 收款时间.
		/// </summary>
		public DateTime? ReceivedDate
		{
			get 
			{
				return this._ReceivedDate;
			}
			set 
			{
				this.OnPropertyValueChange(_.ReceivedDate, _ReceivedDate , value);
				this._ReceivedDate = value;
			}
		}

		/// <summary>
		/// 是否已计提成.
		/// </summary>
		public Boolean? IsCut
		{
			get 
			{
				return this._IsCut;
			}
			set 
			{
				this.OnPropertyValueChange(_.IsCut, _IsCut , value);
				this._IsCut = value;
			}
		}

		/// <summary>
		/// 是否已提税金.
		/// </summary>
		public Boolean? IsRaiseTaxes
		{
			get 
			{
				return this._IsRaiseTaxes;
			}
			set 
			{
				this.OnPropertyValueChange(_.IsRaiseTaxes, _IsRaiseTaxes , value);
				this._IsRaiseTaxes = value;
			}
		}

		/// <summary>
		/// 流程审批状态.
		/// </summary>
		public String ApproveStatus
		{
			get 
			{
				return this._ApproveStatus;
			}
			set 
			{
				this.OnPropertyValueChange(_.ApproveStatus, _ApproveStatus , value);
				this._ApproveStatus = value.SubStr(20);
			}
		}

		/// <summary>
		/// 业务处理状态.
		/// </summary>
		public String Status
		{
			get 
			{
				return this._Status;
			}
			set 
			{
				this.OnPropertyValueChange(_.Status, _Status , value);
				this._Status = value.SubStr(10);
			}
		}

		/// <summary>
		/// 创建人员工ID.
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
		/// 创建人员工姓名.
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
		/// 创建时间.
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
		/// 最后更新人员工ID.
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
		/// 更新人.
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
		/// 最后更新时间.
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
		/// 删除标记.
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
            return new Table< STK_Out >("STK_Out");
        }
		
        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        protected override Field GetIdentityField() {
            return _.StkOutID;
        }  			
		
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        protected override Field[] GetPrimaryKeyFields() {
            return new Field[] {
				_.StkOutID
			};
        }
			
	    /// <summary>
        /// 获取列信息
        /// </summary>
        protected override Field[] GetFields() {
            return new Field[] {
				_.StkOutID,		
				_.StkOutGuid,		
				_.GCompanyID,		
				_.BillNo,		
				_.BillType,		
				_.OutDate,		
				_.OperOrgID,		
				_.OperDeptID,		
				_.OperEmpID,		
				_.OperEmpName,		
				_.SourceBillGuid,		
				_.SourceBillNo,		
				_.TransportCompany,		
				_.ShippingNo,		
				_.Currency,		
				_.TaxRate,		
				_.Amount,		
				_.SCAmount,		
				_.TaxAmount,		
				_.ExchangeRate,		
				_.Remark,		
				_.ReceivedAmount,		
				_.ReceivedDate,		
				_.IsCut,		
				_.IsRaiseTaxes,		
				_.ApproveStatus,		
				_.Status,		
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
				this._StkOutID,		
				this._StkOutGuid,		
				this._GCompanyID,		
				this._BillNo,		
				this._BillType,		
				this._OutDate,		
				this._OperOrgID,		
				this._OperDeptID,		
				this._OperEmpID,		
				this._OperEmpName,		
				this._SourceBillGuid,		
				this._SourceBillNo,		
				this._TransportCompany,		
				this._ShippingNo,		
				this._Currency,		
				this._TaxRate,		
				this._Amount,		
				this._SCAmount,		
				this._TaxAmount,		
				this._ExchangeRate,		
				this._Remark,		
				this._ReceivedAmount,		
				this._ReceivedDate,		
				this._IsCut,		
				this._IsRaiseTaxes,		
				this._ApproveStatus,		
				this._Status,		
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
            if ((false == reader.IsDBNull(_.StkOutID))) {
                this._StkOutID = reader.GetInt32(_.StkOutID);
            }
            if ((false == reader.IsDBNull(_.StkOutGuid))) {
                this._StkOutGuid = reader.GetGuid(_.StkOutGuid);
            }
            if ((false == reader.IsDBNull(_.GCompanyID))) {
                this._GCompanyID = reader.GetGuid(_.GCompanyID);
            }
            if ((false == reader.IsDBNull(_.BillNo))) {
                this._BillNo = reader.GetString(_.BillNo);
            }
            if ((false == reader.IsDBNull(_.BillType))) {
                this._BillType = reader.GetString(_.BillType);
            }
            if ((false == reader.IsDBNull(_.OutDate))) {
                this._OutDate = reader.GetDateTime(_.OutDate);
            }
            if ((false == reader.IsDBNull(_.OperOrgID))) {
                this._OperOrgID = reader.GetInt32(_.OperOrgID);
            }
            if ((false == reader.IsDBNull(_.OperDeptID))) {
                this._OperDeptID = reader.GetInt32(_.OperDeptID);
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
            if ((false == reader.IsDBNull(_.TransportCompany))) {
                this._TransportCompany = reader.GetString(_.TransportCompany);
            }
            if ((false == reader.IsDBNull(_.ShippingNo))) {
                this._ShippingNo = reader.GetString(_.ShippingNo);
            }
            if ((false == reader.IsDBNull(_.Currency))) {
                this._Currency = reader.GetString(_.Currency);
            }
            if ((false == reader.IsDBNull(_.TaxRate))) {
                this._TaxRate = reader.GetDecimal(_.TaxRate);
            }
            if ((false == reader.IsDBNull(_.Amount))) {
                this._Amount = reader.GetDecimal(_.Amount);
            }
            if ((false == reader.IsDBNull(_.SCAmount))) {
                this._SCAmount = reader.GetDecimal(_.SCAmount);
            }
            if ((false == reader.IsDBNull(_.TaxAmount))) {
                this._TaxAmount = reader.GetDecimal(_.TaxAmount);
            }
            if ((false == reader.IsDBNull(_.ExchangeRate))) {
                this._ExchangeRate = reader.GetDecimal(_.ExchangeRate);
            }
            if ((false == reader.IsDBNull(_.Remark))) {
                this._Remark = reader.GetString(_.Remark);
            }
            if ((false == reader.IsDBNull(_.ReceivedAmount))) {
                this._ReceivedAmount = reader.GetDecimal(_.ReceivedAmount);
            }
            if ((false == reader.IsDBNull(_.ReceivedDate))) {
                this._ReceivedDate = reader.GetDateTime(_.ReceivedDate);
            }
            if ((false == reader.IsDBNull(_.IsCut))) {
                this._IsCut = reader.GetBoolean(_.IsCut);
            }
            if ((false == reader.IsDBNull(_.IsRaiseTaxes))) {
                this._IsRaiseTaxes = reader.GetBoolean(_.IsRaiseTaxes);
            }
            if ((false == reader.IsDBNull(_.ApproveStatus))) {
                this._ApproveStatus = reader.GetString(_.ApproveStatus);
            }
            if ((false == reader.IsDBNull(_.Status))) {
                this._Status = reader.GetString(_.Status);
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
            if ((false == typeof(STK_Out).IsAssignableFrom(obj.GetType()))) {
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
            public static AllField All = new AllField< STK_Out >();
			
		    /// <summary>
            /// 出库单ID - 字段名：StkOutID - 数据类型：Int32?
            /// </summary>
            public static Field StkOutID = new Field< STK_Out >("StkOutID");
		    /// <summary>
            /// 出库GUID - 字段名：StkOutGuid - 数据类型：Guid?
            /// </summary>
            public static Field StkOutGuid = new Field< STK_Out >("StkOutGuid");
		    /// <summary>
            /// 公司GUID - 字段名：GCompanyID - 数据类型：Guid?
            /// </summary>
            public static Field GCompanyID = new Field< STK_Out >("GCompanyID");
		    /// <summary>
            /// 出库单编号 - 字段名：BillNo - 数据类型：String
            /// </summary>
            public static Field BillNo = new Field< STK_Out >("BillNo");
		    /// <summary>
            /// 销售出货，采购退货出库，杂项出库 - 字段名：BillType - 数据类型：String
            /// </summary>
            public static Field BillType = new Field< STK_Out >("BillType");
		    /// <summary>
            /// 出库日期 - 字段名：OutDate - 数据类型：DateTime?
            /// </summary>
            public static Field OutDate = new Field< STK_Out >("OutDate");
		    /// <summary>
            /// 操作人机构ID - 字段名：OperOrgID - 数据类型：Int32?
            /// </summary>
            public static Field OperOrgID = new Field< STK_Out >("OperOrgID");
		    /// <summary>
            /// 操作部门ID - 字段名：OperDeptID - 数据类型：Int32?
            /// </summary>
            public static Field OperDeptID = new Field< STK_Out >("OperDeptID");
		    /// <summary>
            /// 操作人ID - 字段名：OperEmpID - 数据类型：Int32?
            /// </summary>
            public static Field OperEmpID = new Field< STK_Out >("OperEmpID");
		    /// <summary>
            /// 操作员 - 字段名：OperEmpName - 数据类型：String
            /// </summary>
            public static Field OperEmpName = new Field< STK_Out >("OperEmpName");
		    /// <summary>
            /// 内部单据GuID - 字段名：SourceBillGuid - 数据类型：Guid?
            /// </summary>
            public static Field SourceBillGuid = new Field< STK_Out >("SourceBillGuid");
		    /// <summary>
            /// 内部单据编号 - 字段名：SourceBillNo - 数据类型：String
            /// </summary>
            public static Field SourceBillNo = new Field< STK_Out >("SourceBillNo");
		    /// <summary>
            /// 运输公司 - 字段名：TransportCompany - 数据类型：String
            /// </summary>
            public static Field TransportCompany = new Field< STK_Out >("TransportCompany");
		    /// <summary>
            /// 货运单号 - 字段名：ShippingNo - 数据类型：String
            /// </summary>
            public static Field ShippingNo = new Field< STK_Out >("ShippingNo");
		    /// <summary>
            /// 币种 - 字段名：Currency - 数据类型：String
            /// </summary>
            public static Field Currency = new Field< STK_Out >("Currency");
		    /// <summary>
            /// 税率 - 字段名：TaxRate - 数据类型：Decimal?
            /// </summary>
            public static Field TaxRate = new Field< STK_Out >("TaxRate");
		    /// <summary>
            /// 记帐金额 - 字段名：Amount - 数据类型：Decimal?
            /// </summary>
            public static Field Amount = new Field< STK_Out >("Amount");
		    /// <summary>
            /// 本币金额 - 字段名：SCAmount - 数据类型：Decimal?
            /// </summary>
            public static Field SCAmount = new Field< STK_Out >("SCAmount");
		    /// <summary>
            /// 税额 - 字段名：TaxAmount - 数据类型：Decimal?
            /// </summary>
            public static Field TaxAmount = new Field< STK_Out >("TaxAmount");
		    /// <summary>
            /// 汇率 - 字段名：ExchangeRate - 数据类型：Decimal?
            /// </summary>
            public static Field ExchangeRate = new Field< STK_Out >("ExchangeRate");
		    /// <summary>
            /// 备注 - 字段名：Remark - 数据类型：String
            /// </summary>
            public static Field Remark = new Field< STK_Out >("Remark");
		    /// <summary>
            /// 已收金额 - 字段名：ReceivedAmount - 数据类型：Decimal?
            /// </summary>
            public static Field ReceivedAmount = new Field< STK_Out >("ReceivedAmount");
		    /// <summary>
            /// 收款时间 - 字段名：ReceivedDate - 数据类型：DateTime?
            /// </summary>
            public static Field ReceivedDate = new Field< STK_Out >("ReceivedDate");
		    /// <summary>
            /// 是否已计提成 - 字段名：IsCut - 数据类型：Boolean?
            /// </summary>
            public static Field IsCut = new Field< STK_Out >("IsCut");
		    /// <summary>
            /// 是否已提税金 - 字段名：IsRaiseTaxes - 数据类型：Boolean?
            /// </summary>
            public static Field IsRaiseTaxes = new Field< STK_Out >("IsRaiseTaxes");
		    /// <summary>
            /// 流程审批状态 - 字段名：ApproveStatus - 数据类型：String
            /// </summary>
            public static Field ApproveStatus = new Field< STK_Out >("ApproveStatus");
		    /// <summary>
            /// 业务处理状态 - 字段名：Status - 数据类型：String
            /// </summary>
            public static Field Status = new Field< STK_Out >("Status");
		    /// <summary>
            /// 创建人员工ID - 字段名：CreatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field CreatedEmpID = new Field< STK_Out >("CreatedEmpID");
		    /// <summary>
            /// 创建人员工姓名 - 字段名：CreatedEmpName - 数据类型：String
            /// </summary>
            public static Field CreatedEmpName = new Field< STK_Out >("CreatedEmpName");
		    /// <summary>
            /// 创建时间 - 字段名：CreatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field CreatedTime = new Field< STK_Out >("CreatedTime");
		    /// <summary>
            /// 最后更新人员工ID - 字段名：UpdatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field UpdatedEmpID = new Field< STK_Out >("UpdatedEmpID");
		    /// <summary>
            /// 更新人 - 字段名：UpdatedEmpName - 数据类型：String
            /// </summary>
            public static Field UpdatedEmpName = new Field< STK_Out >("UpdatedEmpName");
		    /// <summary>
            /// 最后更新时间 - 字段名：UpdatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field UpdatedTime = new Field< STK_Out >("UpdatedTime");
		    /// <summary>
            /// 删除标记 - 字段名：IsDeleted - 数据类型：Boolean?
            /// </summary>
            public static Field IsDeleted = new Field< STK_Out >("IsDeleted");
		}
	}
}