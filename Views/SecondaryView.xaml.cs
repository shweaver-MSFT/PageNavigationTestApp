using PageNavigationTestApp.ViewModels;
using Windows.UI.Xaml;

namespace PageNavigationTestApp.Views
{
    public sealed partial class SecondaryView : ViewBase
    {
        public SecondaryViewModel ViewModel { get; } = new SecondaryViewModel();

        public SecondaryView()
        {
            this.InitializeComponent();
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.GoBackToPrimaryView();
        }
    }
}
