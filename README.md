# Page Navigation Test App

This test app demonstrates a memory leak issue when navigating to/from pages in UWP apps.
See `ViewBase.cs` for a tip on how to "fix" the issue by using `NavigationCacheMode.Required`:

![image](https://user-images.githubusercontent.com/25832310/162053209-ebef70dc-6f4c-4322-a29f-32b39a183baf.png)

Also, when running the app notice how the memory will increase when navigating forward, but not when navigating backwards.
