using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Eys.Support.MultiTenancy;

namespace Eys.Support.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
