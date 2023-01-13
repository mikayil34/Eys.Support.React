using System.Threading.Tasks;
using Abp.Application.Services;
using Eys.Support.Authorization.Accounts.Dto;

namespace Eys.Support.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
