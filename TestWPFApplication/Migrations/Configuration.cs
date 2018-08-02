using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Migrations;

using TestWPFApplication.Data;

namespace TestWPFApplication.Migrations
{
    public class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            MigrationsDirectory = @"Migrations";
        }

        protected override void Seed(DataContext context)
        {
            base.Seed(context);
        }
    }
}
