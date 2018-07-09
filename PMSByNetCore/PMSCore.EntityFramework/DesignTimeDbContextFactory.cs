using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace PMSCore.EntityFramework
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<PMSDBContext>
    {
        public PMSDBContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PMSDBContext>();
            builder.UseSqlServer("Data Source = Server = .; Persist Security info=True;Initial Catalog = PMSBatch; User ID = sa; Password=Qqq111!!!;");
            return new PMSDBContext(builder.Options);
        }
    }
}
