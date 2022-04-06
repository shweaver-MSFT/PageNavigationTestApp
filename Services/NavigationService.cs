using PageNavigationTestApp.Views;
using System;
using Windows.UI.Xaml.Controls;

namespace PageNavigationTestApp.Services
{
    internal class NavigationService
    {
        public static readonly Type PrimaryViewType = typeof(PrimaryView);
        public static readonly Type SecondaryViewType = typeof(SecondaryView);

        public static NavigationService Instance { get; } = new NavigationService();

        public event EventHandler Navigated;

        private NavigationService()
        {
        }

        // The root frame of the app, holds the MainPage.
        public Frame RootFrame { get; set; }

        // The navigation frame for app views.
        public Frame NavigationFrame { get; set; }

        public bool NavigateRoot(Type sourcePageType, object parameter = null)
        {
            return this.RootFrame?.Navigate(sourcePageType, parameter) ?? false;
        }

        public bool Navigate(Type sourcePageType, object parameter = null)
        {
            var navigated = this.NavigationFrame?.Navigate(sourcePageType, parameter) ?? false;
            if (navigated)
            {
                this.Navigated?.Invoke(this, new EventArgs());
            }

            return navigated;
        }

        public bool GoBack()
        {
            if (this.NavigationFrame.CanGoBack)
            {
                this.NavigationFrame?.GoBack();
                return true;
            }

            return false;
        }
    }
}
