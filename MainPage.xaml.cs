using PageNavigationTestApp.Services;
using PageNavigationTestApp.ViewModels;
using PageNavigationTestApp.Views;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace PageNavigationTestApp
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            NavigationService.Instance.NavigationFrame = this.NavigationFrame;
            NavigationService.Instance.Navigate(typeof(PrimaryView), e.Parameter);
        }
    }
}
