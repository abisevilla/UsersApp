using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UsersApp.Models;

namespace UsersApp.Data
{
    public class UsersAppContext : DbContext
    {

        public UsersAppContext (DbContextOptions<UsersAppContext> options ) : base(options)
        {

        }

        public DbSet<Client>  Clients{ get; set; }
        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                 new User { IdUser=1, UuserName = "admin", Password = "123", TypeUser = 1 },
                    new User { IdUser=2,UuserName = "test", Password = "123", TypeUser = 0 },
                    new User { IdUser = 3, UuserName = "test", Password = "123", TypeUser = 0 }
            );

            modelBuilder.Entity<Client>().HasData(
            new Client { ClientName = "Paola", LastNameClient = "Franco", Address = "San Salvador" },
            new Client { ClientName = "Maria", LastNameClient = "Gonzalez", Address = "San Salvador" },
            new Client { ClientName = "Carlos", LastNameClient = "Gutierrez", Address = "San Salvador" }
        );
            modelBuilder.Entity<Agenda>().HasData(
                new Agenda { IdAgenda=1, IdUser=2, Date=Convert.ToDateTime("01/02/2021"), State=2},
                new Agenda { IdAgenda = 2, IdUser = 2, Date = Convert.ToDateTime("02/02/2021"), State = 1 },
                new Agenda { IdAgenda = 3, IdUser = 2, Date = Convert.ToDateTime("03/02/2021"), State = 2 },
                new Agenda { IdAgenda = 4, IdUser = 2, Date = Convert.ToDateTime("04/02/2021"), State = 0 }

      );



        }
    }
}
