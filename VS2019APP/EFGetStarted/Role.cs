using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFGetStarted
{
    //[Table("Role")]
    public class Role
    {
        public int RoleID { get; set; }

        public string RoleName { get; set; }
    }
}
