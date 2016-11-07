using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UPDWA.Models;

namespace UPDWA.Data
{
    public class AlertContext: DbContext
    {
        public AlertContext(DbContextOptions<AlertContext> options): base(options)
        {

        }

        public DbSet<Alert> Alerts { get; set; }
    }
}
