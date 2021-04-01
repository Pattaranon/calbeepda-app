using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Calbee.Infra.Common.Constants
{
    public static class WConstants
    {
        /// <summary>
        /// userName logIn
        /// </summary>
        public static string userName = string.Empty;

        /// <summary>
        /// userId logIn
        /// </summary>
        public static int userId = 999;

        /// <summary>
        /// warehouseSelect เลือกคลังสินค้า
        /// </summary>
        public static string wareHouseDDL = string.Empty;

        /// <summary>
        /// forkLiftSelect เลือก ForkLift
        /// </summary>
        public static string forkLiftDDL = string.Empty;

        /// <summary>
        /// ประเภทสถานที่จัดเก็บ
        /// </summary>
        public static string locationType = "FORK";

        /// <summary>
        /// ประเภทสถานที่จัดเก็บ ของหน้าจอ Receive
        /// </summary>
        public static string receiveLocationType = "RSTG";

        /// <summary>
        /// ประเภทสถานที่จัดเก็บ ของหน้าจอ Putaway to stagging
        /// </summary>
        public static string putawayStagingLocationType = "STG";

        /// <summary>
        /// ประเภทสถานที่จัดเก็บ ของหน้าจอ Load
        /// </summary>
        public static string dockDoorLocationType = "DOCKDOOR";

        /// <summary>
        /// ประเภทสถานะงานรับ
        /// </summary>
        public static string reciveItemStatusType = "inventory";

        /// <summary>
        /// ประเภทใบสั่ง orderType
        /// </summary>
        public static string orderProductionType = "Production";

        /// <summary>
        /// PlantCode
        /// </summary>
        public static string planCode = "SPT";

        /// <summary>
        /// SubTranType = PickUp 
        /// </summary>
        public static string PickupTranType = "INV_PICKUP";

        /// <summary>
        /// SubTranType = Change Status 
        /// </summary>
        public static string ChangeStatusTranType = "INV_STATUSCHANGE";

        /// <summary>
        /// SubTranType = Change Location 
        /// </summary>
        public static string ChangeLocationTranType = "INV_TRANSFER";

        /// <summary>
        /// SubTranType = Putaway
        /// </summary>
        public static string PutawayTranType = "INV_PUTAWAY";

        /// <summary>
        /// รูปแบบวันที่ formatDate = yyyy-MM-dd
        /// </summary>
        public static string formatDateString = "yyyy-MM-dd";
        /// <summary>
        /// รูปแบบวันที่ formatDate = yyyyMMdd
        /// </summary>
        public static string formatDateStrings = "yyyyMMdd";
        /// <summary>
        /// รูปแบบวันที่ formatDate = dd-MM-yyyy
        /// </summary>
        public static string formatDayDateString = "dd-MM-yyyy";

        /// <summary>
        /// Dropdown default ALL
        /// </summary>
        public static string defaultDropdownALL = "ALL";

        /// <summary>
        /// Dropdown default Select
        /// </summary>
        public static string defaultDropdownSelect = "Select";

        /// <summary>
        /// ItemStatus default
        /// </summary>
        public static string defaultItemStatus = "Normal";

        /// <summary>
        /// event Enter
        /// 112 = F1, 
        /// 113 = F2, 
        /// 114 = F3, 
        /// 115 = F4, 
        /// 116 = F5, 
        /// 117 = F6, 
        /// 118 = F7, 
        /// 119 = F8, 
        /// 120 = F9, 
        /// 121 = F10, 
        /// 122 = F11
        /// </summary>
        public static int eventEnter = 112;
        public static int eventForceExit = 122;

        /// <summary>
        /// Program Name on HH
        /// </summary>
        public static string defaultProgramName = "WMS-HH";
    }
}
 