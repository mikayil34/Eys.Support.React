using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Eys.Support.Authorization;

namespace Eys.Support
{
    [DependsOn(
        typeof(SupportCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SupportApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SupportAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SupportApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
