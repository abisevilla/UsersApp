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
            context.Database.EnsureCreated();
            if (!context.Clients.Any())
            {
                var clients = new Client[]
                {
                    new Client{ClientName="Paola", LastNameClient="Franco", Address="San Salvador"}
                };

                foreach (var item in clients)
                {
                    context.Clients.Add(item);
                }

                context.SaveChanges();
            }
        }
    }
}
