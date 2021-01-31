using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsersApp.Models
{
    public class AgendaModel
    {
        public int IdAgenda { get; set; }
        public int IdUser { get; set; }
        public User User { get; set; }

        public string Date { get; set; }

        public int State { get; set; }
    }
}
