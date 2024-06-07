using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.bd
{
   
        internal sealed class Config : DbMigrationsConfiguration<MyDbContext>
        {
            public Config()
            {
                AutomaticMigrationsEnabled = true;
                AutomaticMigrationDataLossAllowed = true;
            }
        
    }
}
