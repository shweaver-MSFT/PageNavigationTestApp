using Windows.UI.Xaml.Controls;

namespace PageNavigationTestApp.Views
{
    public class ViewBase : Page
    {
        public ViewBase()
        {
            // Uncomment to fix the memory leak issue by caching and re-using the page:
            // this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Required;
        }
    }
}
