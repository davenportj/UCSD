using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UPDWA.Models;

namespace UPDWA.Data
{
    public static class DbInitializer
    {
        public static void Initialize(AlertContext context)
        {
            context.Database.EnsureCreated();

            if (context.Alerts.Any())
            {
                return;
            }

            var Alerts = new Alert[]
            {
                new Alert { Message = "Here is Alert 1", FirstPosted = DateTime.Now },
                new Alert { Message = "Here is Alert 2", FirstPosted = DateTime.Now.AddDays(1) },
                new Alert { Message = "Here is Alert 3", FirstPosted = DateTime.Now.AddDays(2) }
            };

            foreach(Alert a in Alerts)
            {
                context.Alerts.Add(a);
            }
            context.SaveChanges();
        }
    }
}
