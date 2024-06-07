using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.bd
{
   
        // Контекст базы данных
        public class MyDbContext : DbContext
        {
            public MyDbContext(string connectionString) : base(connectionString) { }

            public DbSet<User> Users { get; set; }
            public DbSet<Report> Reports { get; set; }
            public DbSet<Polygon> Polygons { get; set; }
            public DbSet<TCamera> Cameras { get; set; }
        }


     
    
}
