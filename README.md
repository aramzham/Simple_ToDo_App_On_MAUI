# Simple_ToDo_App_On_MAUI

Steps to start working with .Net MAUI:
- download the necessary workload using ```dotnet workload install maui``` command
- install all required dependencies for Android and/or for iOS using your IDE f.e. ```JetBrains Rider``` or ```VS installer```
  - follow instructions in [this link](https://blog.jetbrains.com/dotnet/2022/05/25/macos-environment-setup-for-maui-development/#Installing_MAUI_Check) if you're using ```JetBrains Rider```
  - or [this video](https://www.youtube.com/watch?v=LrZwd-f0M4It=4641s) if you use ```VS```
- create a virtual device using ```Android Device Manager```, in this example we'll be using ```Google Pixel 3a + PlayStore```
- Run ```maui-check``` to see if everything is ready for the run.
  - If you don't have the ```maui-check``` tool, you can get it by running the ```dotnet tool install -g Redth.Net.Maui.Check``` command
