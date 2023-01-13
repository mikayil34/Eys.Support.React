using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Eys.Support.Configuration.Dto;

namespace Eys.Support.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SupportAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
