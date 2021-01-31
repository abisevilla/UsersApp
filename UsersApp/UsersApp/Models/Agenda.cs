using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UsersApp.Models
{
    public class Agenda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAgenda { get; set; }
        public int IdUser { get; set; }
        public User User { get; set; }

        public DateTime Date { get; set; }

        public int State { get; set; }
    }
}
