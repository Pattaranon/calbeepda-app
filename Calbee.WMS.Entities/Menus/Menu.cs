using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Calbee.WMS.Entities.Menus
{
    public class Menu
    {
        public int Id { get; set; }
        public string MenuCode { get; set; }
        public string MenuName { get; set; }
        public string MenuGroup { get; set; }
        public string Platform { get; set; }
        public string Description { get; set; }
        public string ResourceKey { get; set; }
        public int Sequence { get; set; }
        public bool IsActive { get; set; }
    }
}
