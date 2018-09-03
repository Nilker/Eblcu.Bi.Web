using Xamarin.Forms.Internals;

namespace Eblcu.Bi.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}