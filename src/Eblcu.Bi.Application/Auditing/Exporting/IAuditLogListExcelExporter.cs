using System.Collections.Generic;
using Eblcu.Bi.Auditing.Dto;
using Eblcu.Bi.Dto;

namespace Eblcu.Bi.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
