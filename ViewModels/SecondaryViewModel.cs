using PageNavigationTestApp.Services;

namespace PageNavigationTestApp.ViewModels
{
    public class SecondaryViewModel : ViewModelBase
    {
        public bool GoBackToPrimaryView()
        {
            return NavigationService.Instance.GoBack();
        }
    }
}
