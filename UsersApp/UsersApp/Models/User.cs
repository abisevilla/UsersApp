using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UsersApp.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UuserName { get; set; }
        public string Password { get; set; }
        public int TypeUser { get; set; }


    }
}
