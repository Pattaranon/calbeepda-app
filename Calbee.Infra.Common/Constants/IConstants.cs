using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Calbee.Infra.Common.Constants
{
    public static class IConstants
    {
        /// <summary>
        /// IPAddress
        /// </summary>
        // Calbee WMS
        public static string ipAddress = "192.168.1.133";

        // Local WMS
        //public static string ipAddress = "43.229.78.24";

        /// <summary>
        /// Service Timeout
        /// </summary>
        public static int timeOut = 40000;

        /// <summary>
        /// รหัสผู้ใช้งาน UserId
        /// </summary>
        public static int _UserID = 0;

        /// <summary>
        /// ระบายสี Writing Color
        /// </summary>
        public static System.Drawing.Color Color;

        /// <summary>
        /// รหัสผู้รับงาน ReceiveId
        /// </summary>
        public static decimal _ReceiveID = 0;

        /// <summary>
        /// รหัสใบสั่งสินค้า InvoiceId
        /// </summary>
        public static string _InvoiceID;

        /// <summary>
        /// การแสดงรายละเอียดของ Error catch
        /// </summary>
        public static string CatchFlag = "N";

        /// <summary>
        /// Used platform
        /// Y = Windows CE
        /// N = Windows Client
        /// </summary>
        public static string platformWinCE = "Y";
    }
}
