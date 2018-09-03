using Eblcu.Bi.Dto;

namespace Eblcu.Bi.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}