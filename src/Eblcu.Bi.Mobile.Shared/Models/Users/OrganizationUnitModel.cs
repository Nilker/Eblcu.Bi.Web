using Abp.AutoMapper;
using Eblcu.Bi.Organizations.Dto;

namespace Eblcu.Bi.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}