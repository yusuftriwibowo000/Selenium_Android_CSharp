using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium;
using LibraryPDF;

namespace SeleniumNew
{
    public sealed class SingletonDriver
    {
        private static AndroidDriver driver;

        private SingletonDriver() { }

        public static AndroidDriver GetDriver()
        {
            if (driver == null)
            {
                //String pathApp = "C:\\Users\\HP\\Documents\\MobileTesting\\flutter-app (1).apk";
                String pathApp = LibPDF.projectDir + "/flutter-app (1).apk";

                // Desired Capabilities
                AppiumOptions options = new AppiumOptions();
                options.AddAdditionalAppiumOption(MobileCapabilityType.PlatformName, "Android");
                options.DeviceName = "1319da2d";
                options.App = pathApp;
                options.AddAdditionalAppiumOption("appPackage", "io.flutter.demo.gallery");
                options.AddAdditionalAppiumOption("appActivity", "io.flutter.demo.gallery.MainActivity");

                // Initialize the driver
                driver = new AndroidDriver(new Uri("http://localhost:4723/wd/hub"), options);
            }
            return driver;
        }
    }
}