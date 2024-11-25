using DocumentFormat.OpenXml.Bibliography;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using SeleniumNew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Dashboard
{
    public class repoDashboard()
    {
        //public static AndroidDriver driver = SingletonDriver.GetDriver();
        //public static IWebElement menuStudies = driver.FindElement(By.XPath("//android.widget.Button[@text='Studies']"));
        //public static IWebElement labelStudies = driver.FindElement(By.XPath("(//android.view.View[@text='Studies'])[1]"));

        //OBJECT ELEMENTS PADA Gallery App

        //Object element halaman Dashboard
        public static string labelFlutter = "//android.view.View[@text='Flutter gallery']";
        public static string btnToogleDashboard = "//android.widget.Button[@text='Toggle options page']";
        public static string menuStudies = "//android.widget.Button[@text='Studies']";
        public static string menuStyle = "//android.widget.Button[@text='Style']";
        public static string menuMaterial = "//android.widget.Button[@text='Material']";
        public static string menuCupertino = "//android.widget.Button[@text='Cupertino']";
        public static string menuMedia = "//android.widget.Button[@text='Media']";

        //Object element halaman Dashboard -> Studies
        public static string labelStudies = "(//android.view.View[@text='Studies'])[1]";
        public static string btnBackStudies = "//android.widget.Button[@text='Back']";
        public static string btnToogleStudies = "//android.widget.Button[@text='Toggle options page']";
        public static string menuShrine = "//android.widget.Button[contains(@text, 'Shrine') and contains(@text, 'Basic shopping app')]";
        public static string menuContactProfile = "//android.widget.Button[contains(@text, 'Contact profile') and contains(@text, 'Address book entry with a flexible appbar')]";
        public static string menuAnimation = "//android.widget.Button[contains(@text, 'Animation') and contains(@text, 'Section organizer')]";

        //Object element halaman Dashboard -> Studies -> Shrine
        public static string imgShrine = "//android.widget.ImageView[@text='SHRINE']";
        public static string btnBackShrine = "//android.widget.Button[@text='Back']";
        public static string fieldUsername = "//android.widget.EditText[1]";
        public static string fieldPassword = "//android.widget.EditText[2]";
        public static string btnCancel = "//android.widget.Button[@text='CANCEL']";
        public static string btnNext = "//android.widget.Button[@text='NEXT']";
        public static string labelShrine = "//android.widget.Button[@text='SHRINE' and @index='0']";
        public static string btnSearchShrine = "(//android.widget.Button[@text='login'])[1]";
        public static string btnFilterShrine = "(//android.widget.Button[@text='login'])[2]";
        public static string productItem = "//android.widget.ImageView[contains(@text, 'Shrug bag') and contains(@text, '$198')]";

    }
}