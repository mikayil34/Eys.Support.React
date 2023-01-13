using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Eys.Support.EntityFrameworkCore
{
    public static class SupportDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SupportDbContext> builder, string connectionString)
        {
            builder.UseNpgsql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SupportDbContext> builder, DbConnection connection)
        {
            builder.UseNpgsql(connection);
        }

        //public static void Configure(DbContextOptionsBuilder<SupportDbContext> builder, string connectionString)
        //{
        //    builder.UseSqlServer(connectionString);
        //}

        //public static void Configure(DbContextOptionsBuilder<SupportDbContext> builder, DbConnection connection)
        //{
        //    builder.UseSqlServer(connection);
        //}
    }
}
