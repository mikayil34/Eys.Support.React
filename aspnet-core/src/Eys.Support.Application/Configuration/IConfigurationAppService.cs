using System.Threading.Tasks;
using Eys.Support.Configuration.Dto;

namespace Eys.Support.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
