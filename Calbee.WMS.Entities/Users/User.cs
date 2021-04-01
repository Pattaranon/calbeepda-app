using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Calbee.WMS.Entities.Users
{
    public class User
    {
        public int UserId { get; set; }
        public int UserGroupId { get; set; }
        public int EmployeeId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
    }
}
