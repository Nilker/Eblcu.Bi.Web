namespace Eblcu.Bi.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}