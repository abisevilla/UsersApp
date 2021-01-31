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
                 new User { IdUser=1, UuserName = "admin", Password = "123", TypeUser = 1 , Name="admin 1", LastName="admin1"},
                    new User { IdUser=2,UuserName = "test", Password = "123", TypeUser = 0 , Name = "tester 1", LastName = "testing" },
                    new User { IdUser = 3, UuserName = "test", Password = "123", TypeUser = 0, Name = "tester 2", LastName = "test" }
            );

            modelBuilder.Entity<Client>().HasData(
            new Client { IdClient=1, ClientName = "Paola", LastNameClient = "Franco", Address = "San Salvador" },
            new Client { IdClient =2 , ClientName = "Maria", LastNameClient = "Gonzalez", Address = "San Salvador" },
            new Client { IdClient=3,ClientName = "Carlos", LastNameClient = "Gutierrez", Address = "San Salvador" }
        );
            modelBuilder.Entity<Agenda>().HasData(
                new Agenda { IdAgenda=1, IdUser=2, Date=Convert.ToDateTime("01/02/2021"), State=2},
                new Agenda { IdAgenda = 2, IdUser = 2, Date = Convert.ToDateTime("02/02/2021"), State = 1 },
                new Agenda { IdAgenda = 3, IdUser = 2, Date = Convert.ToDateTime("03/02/2021"), State = 2 },
                new Agenda { IdAgenda = 4, IdUser = 2, Date = Convert.ToDateTime("04/02/2021"), State = 0 },
                   new Agenda { IdAgenda = 5, IdUser = 2, Date = Convert.ToDateTime("02/02/2021"), State = 1 },
                new Agenda { IdAgenda = 6, IdUser = 3, Date = Convert.ToDateTime("03/02/2021"), State = 2 },
                new Agenda { IdAgenda = 7, IdUser = 3, Date = Convert.ToDateTime("04/02/2021"), State = 0 },
                   new Agenda { IdAgenda = 8, IdUser = 3, Date = Convert.ToDateTime("05/02/2021"), State = 1 },
                new Agenda { IdAgenda = 9, IdUser = 3, Date = Convert.ToDateTime("06/02/2021"), State = 2 },
                new Agenda { IdAgenda = 10, IdUser = 3, Date = Convert.ToDateTime("07/02/2021"), State = 0 }

      );



        }
    }
}
