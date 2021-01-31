using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersApp.Models;

namespace UsersApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(UsersAppContext context)
        {
            //context.Database.EnsureCreated();
            //if (!context.Clients.Any())
            //{
            //    var clients = new Client[]
            //    {
            //        new Client{ClientName="Paola", LastNameClient="Franco", Address="San Salvador"}
            //    };

            //    foreach (var item in clients)
            //    {
            //        context.Clients.Add(item);
            //    }
            //    var users = new User[]
            //    {
            //        new User{ IdUser=1,UuserName="admin" ,Password="123", TypeUser=1},
            //        new User{ IdUser=2,UuserName="test" ,Password="123", TypeUser=0}
            //    };
            //    context.Users.AddRange(users);
            //    context.SaveChanges();
            //}
        }
    }
}
