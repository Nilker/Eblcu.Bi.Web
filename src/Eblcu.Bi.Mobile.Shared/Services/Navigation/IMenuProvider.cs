using System.Collections.Generic;
using MvvmHelpers;
using Eblcu.Bi.Models.NavigationMenu;

namespace Eblcu.Bi.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}