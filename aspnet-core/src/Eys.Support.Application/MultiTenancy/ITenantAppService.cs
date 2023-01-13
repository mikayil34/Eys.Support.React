using Abp.Application.Services;
using Eys.Support.MultiTenancy.Dto;

namespace Eys.Support.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

