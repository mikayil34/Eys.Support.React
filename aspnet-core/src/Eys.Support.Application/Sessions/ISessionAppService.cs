using System.Threading.Tasks;
using Abp.Application.Services;
using Eys.Support.Sessions.Dto;

namespace Eys.Support.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
