using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleDesc { get; set; }

        public ICollection<User> Users { get; set; }
    }

}
