using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Calbee.WMS.Entities.Warehouses
{
    public class Warehouse
    {
        public int WarehouseId { get; set; }
        public string WarehouseCode { get; set; }
        public string WarehouseName { get; set; }
        public bool IsActive { get; set; }
    }

}
