using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace PMSCore.EntityFramework
{
    public class PMSDBContext:DbContext
    {
        public DbSet<SysUser> SysUser { get; set; }
        //数据库连接字符串
        string sqlConn = "Data Source = Server = .; Persist Security info=True;Initial Catalog = PMSBatch; User ID = sa; Password=Qqq111!!!;";
        
        public string ConnStr { get; set; }
        public PMSDBContext(DbContextOptions<PMSDBContext> options)
            :base(options)
        {
            //ConnStr = configuration.GetConnectionString("Connection");
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SysUser>();
        }
    }
}
