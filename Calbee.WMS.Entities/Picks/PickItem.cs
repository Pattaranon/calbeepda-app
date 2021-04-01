using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Calbee.WMS.Entities.Picks
{
    public class PickItem
    {
        public string carLicense { get; set; }

        public string containerNo { get; set; }

        public string device { get; set; }

        public string expiryDate { get; set; }

        public bool expiryDateControl { get; set; }

        public bool expiryDateControlFieldSpecified;

        public string itemName { get; set; }

        public string itemNumber { get; set; }

        public string location { get; set; }

        public bool lotControl { get; set; }

        public bool lotControlFieldSpecified;

        public string lotNumber { get; set; }

        public string lpn { get; set; }

        public string orderNumber { get; set; }

        public string ownerCode { get; set; }

        public string parentLpn { get; set; }

        public string pickBy { get; set; }

        public System.DateTime pickDate { get; set; }

        public bool pickDateFieldSpecified;

        public string pickStatus { get; set; }

        public string pickingListNumber { get; set; }

        public string plantCode { get; set; }

        public double quantityLoad { get; set; }

        public bool quantityLoadFieldSpecified;

        public double quantityPick { get; set; }

        public bool quantityPickFieldSpecified;

        public double quantityPlan { get; set; }

        public bool quantityPlanFieldSpecified;

        public double quantityStage { get; set; }

        public bool quantityStageFieldSpecified;

        public bool serialControl { get; set; }

        public bool serialControlFieldSpecified;

        public string serialNumber { get; set; }

        public string status { get; set; }

        public string toLocation { get; set; }

        public string toLpn { get; set; }

        public string toParentLpn { get; set; }

        public string uom { get; set; }

        public string warehouseCode { get; set; }
    }
}
