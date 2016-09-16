//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by CodeSmith Template.
//
//     Creater: David
//     Date:    2015/3/12
//     Time:    18:25
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
    /// 表名：ORD_SalesOrderLine 主键列：SOLineGuid
    /// </summary>
    [SerializableAttribute()]
	public partial class ORD_SalesOrderLine : BaseEntity
	{
		#region Private Properties
		
		private Int32? _SOLineID;
		private Guid? _SOLineGuid;
		private String _SOLineCode;
		private Guid? _ItemCode;
		private Guid? _GCompanyID;
		private Guid? _SOGuid;
		private String _CItemCode;
		private String _Model;
		private String _Brand;
		private String _Package;
		private String _Batch;
		private String _Quality;
		private String _MPQ;
		private String _MarkCode;
		private String _InvType;
		private String _Warehouse;
		private String _Location;
		private Int32? _Qty;
		private Int32? _SpotQty;
		private Int32? _NotifyQty;
		private Int32? _PurchaseQty;
		private Int32? _StkInQty;
		private Int32? _ReserveQty;
		private Int32? _StkOutOccQty;
		private Int32? _StkOutQty;
		private Int32? _ShipmentQty;
		private Int32? _ReturnOccQty;
		private Int32? _ReturnQty;
		private String _Unit;
		private Decimal? _NTaxPrice;
		private Decimal? _UnitPrice;
		private Decimal? _Amount;
		private Decimal? _CommissionPrice;
		private Decimal? _CommissionAmount;
		private String _Demands;
		private String _Remark;
		private Int32? _BDLineID;
		private DateTime? _NeedDeliveryDate;
		private DateTime? _FactDeliveryDate;
		private DateTime? _NeedRecAmtDate;
		private DateTime? _FactRecAmtDate;
		private Decimal? _ReceivedAmount;
		private Decimal? _DepositAmount;
		private Int32? _CreatedEmpID;
		private String _CreatedEmpName;
		private DateTime? _CreatedTime;
		private Int32? _UpdatedEmpID;
		private String _UpdatedEmpName;
		private DateTime? _UpdatedTime;
		private Boolean? _IsCancel;
		private Boolean? _IsDeleted;
		
		#endregion
		
		#region Public Properties
		
		/// <summary>
		/// SOLineGuid.
		/// </summary>
		public Guid? SOLineGuid
		{
			get 
			{
				return _SOLineGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.SOLineGuid, _SOLineGuid , value);
				this._SOLineGuid = value;
			}
		}
		
		/// <summary>
		/// 销售单明细ID.
		/// </summary>
		public Int32? SOLineID
		{
			get 
			{
				return this._SOLineID;
			}
			set 
			{
				this.OnPropertyValueChange(_.SOLineID, _SOLineID , value);
				this._SOLineID = value;
			}
		}

		/// <summary>
		/// 销售料号（yyMMdd+四位随机数）.
		/// </summary>
		public String SOLineCode
		{
			get 
			{
				return this._SOLineCode;
			}
			set 
			{
				this.OnPropertyValueChange(_.SOLineCode, _SOLineCode , value);
				this._SOLineCode = value.SubStr(20);
			}
		}

		/// <summary>
		/// 库存guid(选择库存作为销售明细时带过来).
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
		/// 所属公司GUID.
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
		/// SOGuid.
		/// </summary>
		public Guid? SOGuid
		{
			get 
			{
				return this._SOGuid;
			}
			set 
			{
				this.OnPropertyValueChange(_.SOGuid, _SOGuid , value);
				this._SOGuid = value;
			}
		}

		/// <summary>
		/// 客户料号.
		/// </summary>
		public String CItemCode
		{
			get 
			{
				return this._CItemCode;
			}
			set 
			{
				this.OnPropertyValueChange(_.CItemCode, _CItemCode , value);
				this._CItemCode = value.SubStr(50);
			}
		}

		/// <summary>
		/// 型号.
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
		/// 品牌.
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
		/// 封装.
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
		/// 批号.
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
				this._Batch = value.SubStr(20);
			}
		}

		/// <summary>
		/// 品质.
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
		/// 包装.
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
		/// 标记码.
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
		/// 库存类型.
		/// </summary>
		public String InvType
		{
			get 
			{
				return this._InvType;
			}
			set 
			{
				this.OnPropertyValueChange(_.InvType, _InvType , value);
				this._InvType = value.SubStr(50);
			}
		}

		/// <summary>
		/// 仓库.
		/// </summary>
		public String Warehouse
		{
			get 
			{
				return this._Warehouse;
			}
			set 
			{
				this.OnPropertyValueChange(_.Warehouse, _Warehouse , value);
				this._Warehouse = value.SubStr(30);
			}
		}

		/// <summary>
		/// 位置.
		/// </summary>
		public String Location
		{
			get 
			{
				return this._Location;
			}
			set 
			{
				this.OnPropertyValueChange(_.Location, _Location , value);
				this._Location = value.SubStr(10);
			}
		}

		/// <summary>
		/// 数量.
		/// </summary>
		public Int32? Qty
		{
			get 
			{
				return this._Qty;
			}
			set 
			{
				this.OnPropertyValueChange(_.Qty, _Qty , value);
				this._Qty = value;
			}
		}

		/// <summary>
		/// 现货预留数.
		/// </summary>
		public Int32? SpotQty
		{
			get 
			{
				return this._SpotQty;
			}
			set 
			{
				this.OnPropertyValueChange(_.SpotQty, _SpotQty , value);
				this._SpotQty = value;
			}
		}

		/// <summary>
		/// 通知数量.
		/// </summary>
		public Int32? NotifyQty
		{
			get 
			{
				return this._NotifyQty;
			}
			set 
			{
				this.OnPropertyValueChange(_.NotifyQty, _NotifyQty , value);
				this._NotifyQty = value;
			}
		}

		/// <summary>
		/// 采购数量.
		/// </summary>
		public Int32? PurchaseQty
		{
			get 
			{
				return this._PurchaseQty;
			}
			set 
			{
				this.OnPropertyValueChange(_.PurchaseQty, _PurchaseQty , value);
				this._PurchaseQty = value;
			}
		}

		/// <summary>
		/// 入库数量.
		/// </summary>
		public Int32? StkInQty
		{
			get 
			{
				return this._StkInQty;
			}
			set 
			{
				this.OnPropertyValueChange(_.StkInQty, _StkInQty , value);
				this._StkInQty = value;
			}
		}

		/// <summary>
		/// 采购预留数.
		/// </summary>
		public Int32? ReserveQty
		{
			get 
			{
				return this._ReserveQty;
			}
			set 
			{
				this.OnPropertyValueChange(_.ReserveQty, _ReserveQty , value);
				this._ReserveQty = value;
			}
		}

		/// <summary>
		/// 出库占有数量.
		/// </summary>
		public Int32? StkOutOccQty
		{
			get 
			{
				return this._StkOutOccQty;
			}
			set 
			{
				this.OnPropertyValueChange(_.StkOutOccQty, _StkOutOccQty , value);
				this._StkOutOccQty = value;
			}
		}

		/// <summary>
		/// 出库数量.
		/// </summary>
		public Int32? StkOutQty
		{
			get 
			{
				return this._StkOutQty;
			}
			set 
			{
				this.OnPropertyValueChange(_.StkOutQty, _StkOutQty , value);
				this._StkOutQty = value;
			}
		}

		/// <summary>
		/// 发运数量.
		/// </summary>
		public Int32? ShipmentQty
		{
			get 
			{
				return this._ShipmentQty;
			}
			set 
			{
				this.OnPropertyValueChange(_.ShipmentQty, _ShipmentQty , value);
				this._ShipmentQty = value;
			}
		}

		/// <summary>
		/// 退货占有数量.
		/// </summary>
		public Int32? ReturnOccQty
		{
			get 
			{
				return this._ReturnOccQty;
			}
			set 
			{
				this.OnPropertyValueChange(_.ReturnOccQty, _ReturnOccQty , value);
				this._ReturnOccQty = value;
			}
		}

		/// <summary>
		/// 退货数量.
		/// </summary>
		public Int32? ReturnQty
		{
			get 
			{
				return this._ReturnQty;
			}
			set 
			{
				this.OnPropertyValueChange(_.ReturnQty, _ReturnQty , value);
				this._ReturnQty = value;
			}
		}

		/// <summary>
		/// 单位.
		/// </summary>
		public String Unit
		{
			get 
			{
				return this._Unit;
			}
			set 
			{
				this.OnPropertyValueChange(_.Unit, _Unit , value);
				this._Unit = value.SubStr(10);
			}
		}

		/// <summary>
		/// 未含税单价.
		/// </summary>
		public Decimal? NTaxPrice
		{
			get 
			{
				return this._NTaxPrice;
			}
			set 
			{
				this.OnPropertyValueChange(_.NTaxPrice, _NTaxPrice , value);
				this._NTaxPrice = value;
			}
		}

		/// <summary>
		/// 含税单价.
		/// </summary>
		public Decimal? UnitPrice
		{
			get 
			{
				return this._UnitPrice;
			}
			set 
			{
				this.OnPropertyValueChange(_.UnitPrice, _UnitPrice , value);
				this._UnitPrice = value;
			}
		}

		/// <summary>
		/// 小计金额.
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
		/// 佣金单价.
		/// </summary>
		public Decimal? CommissionPrice
		{
			get 
			{
				return this._CommissionPrice;
			}
			set 
			{
				this.OnPropertyValueChange(_.CommissionPrice, _CommissionPrice , value);
				this._CommissionPrice = value;
			}
		}

		/// <summary>
		/// 佣金金额.
		/// </summary>
		public Decimal? CommissionAmount
		{
			get 
			{
				return this._CommissionAmount;
			}
			set 
			{
				this.OnPropertyValueChange(_.CommissionAmount, _CommissionAmount , value);
				this._CommissionAmount = value;
			}
		}

		/// <summary>
		/// 采购要求.
		/// </summary>
		public String Demands
		{
			get 
			{
				return this._Demands;
			}
			set 
			{
				this.OnPropertyValueChange(_.Demands, _Demands , value);
				this._Demands = value.SubStr(50);
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
		/// 需求明细ID.
		/// </summary>
		public Int32? BDLineID
		{
			get 
			{
				return this._BDLineID;
			}
			set 
			{
				this.OnPropertyValueChange(_.BDLineID, _BDLineID , value);
				this._BDLineID = value;
			}
		}

		/// <summary>
		/// 需发货日期.
		/// </summary>
		public DateTime? NeedDeliveryDate
		{
			get 
			{
				return this._NeedDeliveryDate;
			}
			set 
			{
				this.OnPropertyValueChange(_.NeedDeliveryDate, _NeedDeliveryDate , value);
				this._NeedDeliveryDate = value;
			}
		}

		/// <summary>
		/// 实发货日期.
		/// </summary>
		public DateTime? FactDeliveryDate
		{
			get 
			{
				return this._FactDeliveryDate;
			}
			set 
			{
				this.OnPropertyValueChange(_.FactDeliveryDate, _FactDeliveryDate , value);
				this._FactDeliveryDate = value;
			}
		}

		/// <summary>
		/// 应收款日期.
		/// </summary>
		public DateTime? NeedRecAmtDate
		{
			get 
			{
				return this._NeedRecAmtDate;
			}
			set 
			{
				this.OnPropertyValueChange(_.NeedRecAmtDate, _NeedRecAmtDate , value);
				this._NeedRecAmtDate = value;
			}
		}

		/// <summary>
		/// 实收款日期.
		/// </summary>
		public DateTime? FactRecAmtDate
		{
			get 
			{
				return this._FactRecAmtDate;
			}
			set 
			{
				this.OnPropertyValueChange(_.FactRecAmtDate, _FactRecAmtDate , value);
				this._FactRecAmtDate = value;
			}
		}

		/// <summary>
		/// 已收款金额.
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
		/// 预收金额.
		/// </summary>
		public Decimal? DepositAmount
		{
			get 
			{
				return this._DepositAmount;
			}
			set 
			{
				this.OnPropertyValueChange(_.DepositAmount, _DepositAmount , value);
				this._DepositAmount = value;
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
		/// 是否取消.
		/// </summary>
		public Boolean? IsCancel
		{
			get 
			{
				return this._IsCancel;
			}
			set 
			{
				this.OnPropertyValueChange(_.IsCancel, _IsCancel , value);
				this._IsCancel = value;
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
            return new Table< ORD_SalesOrderLine >("ORD_SalesOrderLine");
        }
		
        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        protected override Field GetIdentityField() {
            return _.SOLineID;
        }  			
		
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        protected override Field[] GetPrimaryKeyFields() {
            return new Field[] {
				_.SOLineGuid
			};
        }
			
	    /// <summary>
        /// 获取列信息
        /// </summary>
        protected override Field[] GetFields() {
            return new Field[] {
				_.SOLineID,		
				_.SOLineGuid,		
				_.SOLineCode,		
				_.ItemCode,		
				_.GCompanyID,		
				_.SOGuid,		
				_.CItemCode,		
				_.Model,		
				_.Brand,		
				_.Package,		
				_.Batch,		
				_.Quality,		
				_.MPQ,		
				_.MarkCode,		
				_.InvType,		
				_.Warehouse,		
				_.Location,		
				_.Qty,		
				_.SpotQty,		
				_.NotifyQty,		
				_.PurchaseQty,		
				_.StkInQty,		
				_.ReserveQty,		
				_.StkOutOccQty,		
				_.StkOutQty,		
				_.ShipmentQty,		
				_.ReturnOccQty,		
				_.ReturnQty,		
				_.Unit,		
				_.NTaxPrice,		
				_.UnitPrice,		
				_.Amount,		
				_.CommissionPrice,		
				_.CommissionAmount,		
				_.Demands,		
				_.Remark,		
				_.BDLineID,		
				_.NeedDeliveryDate,		
				_.FactDeliveryDate,		
				_.NeedRecAmtDate,		
				_.FactRecAmtDate,		
				_.ReceivedAmount,		
				_.DepositAmount,		
				_.CreatedEmpID,		
				_.CreatedEmpName,		
				_.CreatedTime,		
				_.UpdatedEmpID,		
				_.UpdatedEmpName,		
				_.UpdatedTime,		
				_.IsCancel,		
				_.IsDeleted		
			};
		}
		
	    /// <summary>
        /// 获取列数据
        /// </summary>
        protected override object[] GetValues() {
            return new object[] {
				this._SOLineID,		
				this._SOLineGuid,		
				this._SOLineCode,		
				this._ItemCode,		
				this._GCompanyID,		
				this._SOGuid,		
				this._CItemCode,		
				this._Model,		
				this._Brand,		
				this._Package,		
				this._Batch,		
				this._Quality,		
				this._MPQ,		
				this._MarkCode,		
				this._InvType,		
				this._Warehouse,		
				this._Location,		
				this._Qty,		
				this._SpotQty,		
				this._NotifyQty,		
				this._PurchaseQty,		
				this._StkInQty,		
				this._ReserveQty,		
				this._StkOutOccQty,		
				this._StkOutQty,		
				this._ShipmentQty,		
				this._ReturnOccQty,		
				this._ReturnQty,		
				this._Unit,		
				this._NTaxPrice,		
				this._UnitPrice,		
				this._Amount,		
				this._CommissionPrice,		
				this._CommissionAmount,		
				this._Demands,		
				this._Remark,		
				this._BDLineID,		
				this._NeedDeliveryDate,		
				this._FactDeliveryDate,		
				this._NeedRecAmtDate,		
				this._FactRecAmtDate,		
				this._ReceivedAmount,		
				this._DepositAmount,		
				this._CreatedEmpID,		
				this._CreatedEmpName,		
				this._CreatedTime,		
				this._UpdatedEmpID,		
				this._UpdatedEmpName,		
				this._UpdatedTime,		
				this._IsCancel,		
				this._IsDeleted		
			};
		}
		
	    /// <summary>
        /// 给当前实体赋值
        /// </summary>
        protected override void SetValues(IRowReader reader) {
            if ((false == reader.IsDBNull(_.SOLineID))) {
                this._SOLineID = reader.GetInt32(_.SOLineID);
            }
            if ((false == reader.IsDBNull(_.SOLineGuid))) {
                this._SOLineGuid = reader.GetGuid(_.SOLineGuid);
            }
            if ((false == reader.IsDBNull(_.SOLineCode))) {
                this._SOLineCode = reader.GetString(_.SOLineCode);
            }
            if ((false == reader.IsDBNull(_.ItemCode))) {
                this._ItemCode = reader.GetGuid(_.ItemCode);
            }
            if ((false == reader.IsDBNull(_.GCompanyID))) {
                this._GCompanyID = reader.GetGuid(_.GCompanyID);
            }
            if ((false == reader.IsDBNull(_.SOGuid))) {
                this._SOGuid = reader.GetGuid(_.SOGuid);
            }
            if ((false == reader.IsDBNull(_.CItemCode))) {
                this._CItemCode = reader.GetString(_.CItemCode);
            }
            if ((false == reader.IsDBNull(_.Model))) {
                this._Model = reader.GetString(_.Model);
            }
            if ((false == reader.IsDBNull(_.Brand))) {
                this._Brand = reader.GetString(_.Brand);
            }
            if ((false == reader.IsDBNull(_.Package))) {
                this._Package = reader.GetString(_.Package);
            }
            if ((false == reader.IsDBNull(_.Batch))) {
                this._Batch = reader.GetString(_.Batch);
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
            if ((false == reader.IsDBNull(_.InvType))) {
                this._InvType = reader.GetString(_.InvType);
            }
            if ((false == reader.IsDBNull(_.Warehouse))) {
                this._Warehouse = reader.GetString(_.Warehouse);
            }
            if ((false == reader.IsDBNull(_.Location))) {
                this._Location = reader.GetString(_.Location);
            }
            if ((false == reader.IsDBNull(_.Qty))) {
                this._Qty = reader.GetInt32(_.Qty);
            }
            if ((false == reader.IsDBNull(_.SpotQty))) {
                this._SpotQty = reader.GetInt32(_.SpotQty);
            }
            if ((false == reader.IsDBNull(_.NotifyQty))) {
                this._NotifyQty = reader.GetInt32(_.NotifyQty);
            }
            if ((false == reader.IsDBNull(_.PurchaseQty))) {
                this._PurchaseQty = reader.GetInt32(_.PurchaseQty);
            }
            if ((false == reader.IsDBNull(_.StkInQty))) {
                this._StkInQty = reader.GetInt32(_.StkInQty);
            }
            if ((false == reader.IsDBNull(_.ReserveQty))) {
                this._ReserveQty = reader.GetInt32(_.ReserveQty);
            }
            if ((false == reader.IsDBNull(_.StkOutOccQty))) {
                this._StkOutOccQty = reader.GetInt32(_.StkOutOccQty);
            }
            if ((false == reader.IsDBNull(_.StkOutQty))) {
                this._StkOutQty = reader.GetInt32(_.StkOutQty);
            }
            if ((false == reader.IsDBNull(_.ShipmentQty))) {
                this._ShipmentQty = reader.GetInt32(_.ShipmentQty);
            }
            if ((false == reader.IsDBNull(_.ReturnOccQty))) {
                this._ReturnOccQty = reader.GetInt32(_.ReturnOccQty);
            }
            if ((false == reader.IsDBNull(_.ReturnQty))) {
                this._ReturnQty = reader.GetInt32(_.ReturnQty);
            }
            if ((false == reader.IsDBNull(_.Unit))) {
                this._Unit = reader.GetString(_.Unit);
            }
            if ((false == reader.IsDBNull(_.NTaxPrice))) {
                this._NTaxPrice = reader.GetDecimal(_.NTaxPrice);
            }
            if ((false == reader.IsDBNull(_.UnitPrice))) {
                this._UnitPrice = reader.GetDecimal(_.UnitPrice);
            }
            if ((false == reader.IsDBNull(_.Amount))) {
                this._Amount = reader.GetDecimal(_.Amount);
            }
            if ((false == reader.IsDBNull(_.CommissionPrice))) {
                this._CommissionPrice = reader.GetDecimal(_.CommissionPrice);
            }
            if ((false == reader.IsDBNull(_.CommissionAmount))) {
                this._CommissionAmount = reader.GetDecimal(_.CommissionAmount);
            }
            if ((false == reader.IsDBNull(_.Demands))) {
                this._Demands = reader.GetString(_.Demands);
            }
            if ((false == reader.IsDBNull(_.Remark))) {
                this._Remark = reader.GetString(_.Remark);
            }
            if ((false == reader.IsDBNull(_.BDLineID))) {
                this._BDLineID = reader.GetInt32(_.BDLineID);
            }
            if ((false == reader.IsDBNull(_.NeedDeliveryDate))) {
                this._NeedDeliveryDate = reader.GetDateTime(_.NeedDeliveryDate);
            }
            if ((false == reader.IsDBNull(_.FactDeliveryDate))) {
                this._FactDeliveryDate = reader.GetDateTime(_.FactDeliveryDate);
            }
            if ((false == reader.IsDBNull(_.NeedRecAmtDate))) {
                this._NeedRecAmtDate = reader.GetDateTime(_.NeedRecAmtDate);
            }
            if ((false == reader.IsDBNull(_.FactRecAmtDate))) {
                this._FactRecAmtDate = reader.GetDateTime(_.FactRecAmtDate);
            }
            if ((false == reader.IsDBNull(_.ReceivedAmount))) {
                this._ReceivedAmount = reader.GetDecimal(_.ReceivedAmount);
            }
            if ((false == reader.IsDBNull(_.DepositAmount))) {
                this._DepositAmount = reader.GetDecimal(_.DepositAmount);
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
            if ((false == reader.IsDBNull(_.IsCancel))) {
                this._IsCancel = reader.GetBoolean(_.IsCancel);
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
            if ((false == typeof(ORD_SalesOrderLine).IsAssignableFrom(obj.GetType()))) {
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
            public static AllField All = new AllField< ORD_SalesOrderLine >();
			
		    /// <summary>
            /// 销售单明细ID - 字段名：SOLineID - 数据类型：Int32?
            /// </summary>
            public static Field SOLineID = new Field< ORD_SalesOrderLine >("SOLineID");
		    /// <summary>
            /// SOLineGuid - 字段名：SOLineGuid - 数据类型：Guid?
            /// </summary>
            public static Field SOLineGuid = new Field< ORD_SalesOrderLine >("SOLineGuid");
		    /// <summary>
            /// 销售料号（yyMMdd+四位随机数） - 字段名：SOLineCode - 数据类型：String
            /// </summary>
            public static Field SOLineCode = new Field< ORD_SalesOrderLine >("SOLineCode");
		    /// <summary>
            /// 库存guid(选择库存作为销售明细时带过来) - 字段名：ItemCode - 数据类型：Guid?
            /// </summary>
            public static Field ItemCode = new Field< ORD_SalesOrderLine >("ItemCode");
		    /// <summary>
            /// 所属公司GUID - 字段名：GCompanyID - 数据类型：Guid?
            /// </summary>
            public static Field GCompanyID = new Field< ORD_SalesOrderLine >("GCompanyID");
		    /// <summary>
            /// SOGuid - 字段名：SOGuid - 数据类型：Guid?
            /// </summary>
            public static Field SOGuid = new Field< ORD_SalesOrderLine >("SOGuid");
		    /// <summary>
            /// 客户料号 - 字段名：CItemCode - 数据类型：String
            /// </summary>
            public static Field CItemCode = new Field< ORD_SalesOrderLine >("CItemCode");
		    /// <summary>
            /// 型号 - 字段名：Model - 数据类型：String
            /// </summary>
            public static Field Model = new Field< ORD_SalesOrderLine >("Model");
		    /// <summary>
            /// 品牌 - 字段名：Brand - 数据类型：String
            /// </summary>
            public static Field Brand = new Field< ORD_SalesOrderLine >("Brand");
		    /// <summary>
            /// 封装 - 字段名：Package - 数据类型：String
            /// </summary>
            public static Field Package = new Field< ORD_SalesOrderLine >("Package");
		    /// <summary>
            /// 批号 - 字段名：Batch - 数据类型：String
            /// </summary>
            public static Field Batch = new Field< ORD_SalesOrderLine >("Batch");
		    /// <summary>
            /// 品质 - 字段名：Quality - 数据类型：String
            /// </summary>
            public static Field Quality = new Field< ORD_SalesOrderLine >("Quality");
		    /// <summary>
            /// 包装 - 字段名：MPQ - 数据类型：String
            /// </summary>
            public static Field MPQ = new Field< ORD_SalesOrderLine >("MPQ");
		    /// <summary>
            /// 标记码 - 字段名：MarkCode - 数据类型：String
            /// </summary>
            public static Field MarkCode = new Field< ORD_SalesOrderLine >("MarkCode");
		    /// <summary>
            /// 库存类型 - 字段名：InvType - 数据类型：String
            /// </summary>
            public static Field InvType = new Field< ORD_SalesOrderLine >("InvType");
		    /// <summary>
            /// 仓库 - 字段名：Warehouse - 数据类型：String
            /// </summary>
            public static Field Warehouse = new Field< ORD_SalesOrderLine >("Warehouse");
		    /// <summary>
            /// 位置 - 字段名：Location - 数据类型：String
            /// </summary>
            public static Field Location = new Field< ORD_SalesOrderLine >("Location");
		    /// <summary>
            /// 数量 - 字段名：Qty - 数据类型：Int32?
            /// </summary>
            public static Field Qty = new Field< ORD_SalesOrderLine >("Qty");
		    /// <summary>
            /// 现货预留数 - 字段名：SpotQty - 数据类型：Int32?
            /// </summary>
            public static Field SpotQty = new Field< ORD_SalesOrderLine >("SpotQty");
		    /// <summary>
            /// 通知数量 - 字段名：NotifyQty - 数据类型：Int32?
            /// </summary>
            public static Field NotifyQty = new Field< ORD_SalesOrderLine >("NotifyQty");
		    /// <summary>
            /// 采购数量 - 字段名：PurchaseQty - 数据类型：Int32?
            /// </summary>
            public static Field PurchaseQty = new Field< ORD_SalesOrderLine >("PurchaseQty");
		    /// <summary>
            /// 入库数量 - 字段名：StkInQty - 数据类型：Int32?
            /// </summary>
            public static Field StkInQty = new Field< ORD_SalesOrderLine >("StkInQty");
		    /// <summary>
            /// 采购预留数 - 字段名：ReserveQty - 数据类型：Int32?
            /// </summary>
            public static Field ReserveQty = new Field< ORD_SalesOrderLine >("ReserveQty");
		    /// <summary>
            /// 出库占有数量 - 字段名：StkOutOccQty - 数据类型：Int32?
            /// </summary>
            public static Field StkOutOccQty = new Field< ORD_SalesOrderLine >("StkOutOccQty");
		    /// <summary>
            /// 出库数量 - 字段名：StkOutQty - 数据类型：Int32?
            /// </summary>
            public static Field StkOutQty = new Field< ORD_SalesOrderLine >("StkOutQty");
		    /// <summary>
            /// 发运数量 - 字段名：ShipmentQty - 数据类型：Int32?
            /// </summary>
            public static Field ShipmentQty = new Field< ORD_SalesOrderLine >("ShipmentQty");
		    /// <summary>
            /// 退货占有数量 - 字段名：ReturnOccQty - 数据类型：Int32?
            /// </summary>
            public static Field ReturnOccQty = new Field< ORD_SalesOrderLine >("ReturnOccQty");
		    /// <summary>
            /// 退货数量 - 字段名：ReturnQty - 数据类型：Int32?
            /// </summary>
            public static Field ReturnQty = new Field< ORD_SalesOrderLine >("ReturnQty");
		    /// <summary>
            /// 单位 - 字段名：Unit - 数据类型：String
            /// </summary>
            public static Field Unit = new Field< ORD_SalesOrderLine >("Unit");
		    /// <summary>
            /// 未含税单价 - 字段名：NTaxPrice - 数据类型：Decimal?
            /// </summary>
            public static Field NTaxPrice = new Field< ORD_SalesOrderLine >("NTaxPrice");
		    /// <summary>
            /// 含税单价 - 字段名：UnitPrice - 数据类型：Decimal?
            /// </summary>
            public static Field UnitPrice = new Field< ORD_SalesOrderLine >("UnitPrice");
		    /// <summary>
            /// 小计金额 - 字段名：Amount - 数据类型：Decimal?
            /// </summary>
            public static Field Amount = new Field< ORD_SalesOrderLine >("Amount");
		    /// <summary>
            /// 佣金单价 - 字段名：CommissionPrice - 数据类型：Decimal?
            /// </summary>
            public static Field CommissionPrice = new Field< ORD_SalesOrderLine >("CommissionPrice");
		    /// <summary>
            /// 佣金金额 - 字段名：CommissionAmount - 数据类型：Decimal?
            /// </summary>
            public static Field CommissionAmount = new Field< ORD_SalesOrderLine >("CommissionAmount");
		    /// <summary>
            /// 采购要求 - 字段名：Demands - 数据类型：String
            /// </summary>
            public static Field Demands = new Field< ORD_SalesOrderLine >("Demands");
		    /// <summary>
            /// 备注 - 字段名：Remark - 数据类型：String
            /// </summary>
            public static Field Remark = new Field< ORD_SalesOrderLine >("Remark");
		    /// <summary>
            /// 需求明细ID - 字段名：BDLineID - 数据类型：Int32?
            /// </summary>
            public static Field BDLineID = new Field< ORD_SalesOrderLine >("BDLineID");
		    /// <summary>
            /// 需发货日期 - 字段名：NeedDeliveryDate - 数据类型：DateTime?
            /// </summary>
            public static Field NeedDeliveryDate = new Field< ORD_SalesOrderLine >("NeedDeliveryDate");
		    /// <summary>
            /// 实发货日期 - 字段名：FactDeliveryDate - 数据类型：DateTime?
            /// </summary>
            public static Field FactDeliveryDate = new Field< ORD_SalesOrderLine >("FactDeliveryDate");
		    /// <summary>
            /// 应收款日期 - 字段名：NeedRecAmtDate - 数据类型：DateTime?
            /// </summary>
            public static Field NeedRecAmtDate = new Field< ORD_SalesOrderLine >("NeedRecAmtDate");
		    /// <summary>
            /// 实收款日期 - 字段名：FactRecAmtDate - 数据类型：DateTime?
            /// </summary>
            public static Field FactRecAmtDate = new Field< ORD_SalesOrderLine >("FactRecAmtDate");
		    /// <summary>
            /// 已收款金额 - 字段名：ReceivedAmount - 数据类型：Decimal?
            /// </summary>
            public static Field ReceivedAmount = new Field< ORD_SalesOrderLine >("ReceivedAmount");
		    /// <summary>
            /// 预收金额 - 字段名：DepositAmount - 数据类型：Decimal?
            /// </summary>
            public static Field DepositAmount = new Field< ORD_SalesOrderLine >("DepositAmount");
		    /// <summary>
            ///  - 字段名：CreatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field CreatedEmpID = new Field< ORD_SalesOrderLine >("CreatedEmpID");
		    /// <summary>
            ///  - 字段名：CreatedEmpName - 数据类型：String
            /// </summary>
            public static Field CreatedEmpName = new Field< ORD_SalesOrderLine >("CreatedEmpName");
		    /// <summary>
            ///  - 字段名：CreatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field CreatedTime = new Field< ORD_SalesOrderLine >("CreatedTime");
		    /// <summary>
            ///  - 字段名：UpdatedEmpID - 数据类型：Int32?
            /// </summary>
            public static Field UpdatedEmpID = new Field< ORD_SalesOrderLine >("UpdatedEmpID");
		    /// <summary>
            ///  - 字段名：UpdatedEmpName - 数据类型：String
            /// </summary>
            public static Field UpdatedEmpName = new Field< ORD_SalesOrderLine >("UpdatedEmpName");
		    /// <summary>
            ///  - 字段名：UpdatedTime - 数据类型：DateTime?
            /// </summary>
            public static Field UpdatedTime = new Field< ORD_SalesOrderLine >("UpdatedTime");
		    /// <summary>
            /// 是否取消 - 字段名：IsCancel - 数据类型：Boolean?
            /// </summary>
            public static Field IsCancel = new Field< ORD_SalesOrderLine >("IsCancel");
		    /// <summary>
            /// 是否删除 - 字段名：IsDeleted - 数据类型：Boolean?
            /// </summary>
            public static Field IsDeleted = new Field< ORD_SalesOrderLine >("IsDeleted");
		}
	}
}