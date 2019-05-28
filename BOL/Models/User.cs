using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BOL.Models
{
    public class User
    {
        [Key]
        public string UserEmail { get; set; }

        public int RoleId { get; set; }

        public  Role Role { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public ICollection<Order> Orders { get; set; }
        }
    }
}
