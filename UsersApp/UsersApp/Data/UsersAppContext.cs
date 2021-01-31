using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
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



    }
}
