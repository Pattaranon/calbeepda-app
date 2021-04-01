using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Calbee.WMS.Entities.Locations
{
    public class Location
    {
        public int LocationId { get; set; }
        public int WarehouseId { get; set; }
        public string LocationCode { get; set; }
        public string LocationName { get; set; }
        public string LocationType { get; set; }
        public bool LpnControlled { get; set; }
        public int? PickSequence { get; set; }
        public bool IsActive { get; set; }
    }
}
