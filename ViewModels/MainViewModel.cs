using PageNavigationTestApp.Services;
using System;
using Windows.System;

namespace PageNavigationTestApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ulong MemoryUsage
        {
            get => this.memoryUsage;
            set => this.Set(ref this.memoryUsage, value);
        }

        private ulong memoryUsage = 0;

        public MainViewModel()
        {
            NavigationService.Instance.Navigated += OnNavigated;
        }

        private void OnNavigated(object sender, EventArgs e)
        {
            this.MemoryUsage = MemoryManager.AppMemoryUsage;
        }
    }
}
