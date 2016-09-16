﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZNLCRM.Entity.DBModel;

namespace ZNLCRM.Entity.UserModel.SPM
{
    [Serializable]
    public class ORD_SalesOrderLineResult : ORD_SalesOrderLine
    {
        public List<ORD_PurchaseNoticeResult> NoticeResultList { get; set; }
        
        public int? NoNotifyQty { get; set; }
    }
}