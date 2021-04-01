using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Calbee.WMS.Entities.Receives
{
    public class ReceiveItem
    {
        public string PlantCode { get; set; }
        public string WarehouseCode { get; set; }
        public string OrderNumber { get; set; }
        public string ReceiveNumber { get; set; }
        public string Location { get; set; }
        public string ItemNumber { get; set; }
        public string ItemName { get; set; }
        public double QuantityReceive { get; set; }
        public string Uom { get; set; }
        public string Status { get; set; }
        public string ParentLPN { get; set; }
        public string LPN { get; set; }
        public string LotNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string SerialNumber { get; set; }
        public string ReceiveDate { get; set; }
        public string ReceiveBy { get; set; }
        public string Device { get; set; }
    }
}
