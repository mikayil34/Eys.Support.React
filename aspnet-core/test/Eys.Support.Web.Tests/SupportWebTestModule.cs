using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Eys.Support.EntityFrameworkCore;
using Eys.Support.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Eys.Support.Web.Tests
{
    [DependsOn(
        typeof(SupportWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SupportWebTestModule : AbpModule
    {
        public SupportWebTestModule(SupportEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SupportWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SupportWebMvcModule).Assembly);
        }
    }
}