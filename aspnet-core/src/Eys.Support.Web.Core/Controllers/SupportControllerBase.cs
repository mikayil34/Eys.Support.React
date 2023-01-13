using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Eys.Support.Controllers
{
    public abstract class SupportControllerBase: AbpController
    {
        protected SupportControllerBase()
        {
            LocalizationSourceName = SupportConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
