using PageNavigationTestApp.Services;

namespace PageNavigationTestApp.ViewModels
{
    public class PrimaryViewModel : ViewModelBase
    {
        public bool GoToSecondaryView()
        {
            return NavigationService.Instance.Navigate(NavigationService.SecondaryViewType);
        }
    }
}
