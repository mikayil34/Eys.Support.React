using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Eys.Support.Authorization.Roles;
using Eys.Support.Authorization.Users;
using Eys.Support.MultiTenancy;
using System;

namespace Eys.Support.EntityFrameworkCore
{
    public class SupportDbContext : AbpZeroDbContext<Tenant, Role, User, SupportDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SupportDbContext(DbContextOptions<SupportDbContext> options)
            : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }
    }
}
