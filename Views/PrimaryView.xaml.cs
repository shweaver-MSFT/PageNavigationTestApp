using PageNavigationTestApp.ViewModels;
using Windows.UI.Xaml;

namespace PageNavigationTestApp.Views
{
    public sealed partial class PrimaryView : ViewBase
    {
        public PrimaryViewModel ViewModel { get; } = new PrimaryViewModel();

        public PrimaryView()
        {
            this.InitializeComponent();
        }

        private void NavigateButton_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.GoToSecondaryView();
        }
    }
}
