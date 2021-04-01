using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Calbee.WMS.Entities.Counts
{
    public class CountItem
    {
        private string countBy { get; set; }
        private string countDate { get; set; }
        private string countNumber { get; set; }
        private double countQty { get; set; }
        private string device { get; set; }
        private string expiryDate { get; set; }
        private string itemName { get; set; }
        private string itemNumber { get; set; }
        private string lPN { get; set; }
        private string location { get; set; }
        private string lotNumber { get; set; }
        private string parentLPN { get; set; }
        private string plantCode { get; set; }
        private string serialNumber { get; set; }
        private string status { get; set; }
        private string uom { get; set; }
        private string warehouseCode { get; set; }
    }
}
