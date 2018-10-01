using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("RoleDetails")]
     public class RoleDetails
    {
            [Key]
            public int roleId { get; set; }
            public string roleName { get; set; }
    }
}
}
