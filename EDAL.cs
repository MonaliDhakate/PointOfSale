using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PointOfSale
{
    public class EDAL:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ConnectionString = ConfigurationManager.AppSettings["SqlConnectionString"];
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        public DbSet<finalpayment> payments { get; set; }
    }
}
