using OpenQA.Selenium.Appium.Android;
using SeleniumNew;
using LibraryPDF;
using GlobalLibrary;

namespace MobileTesting
{
    class Testing
    {
        public static AndroidDriver driver = SingletonDriver.GetDriver();
        public static string excelFilePath = LibPDF.projectDir + "/Excel/TC0001_AksesMenuStudies.xlsx";
        public static string excelSheetName = "TC0001";

        static void Main(string[] args)
        {
            LibPDF.InitializeDocument(excelFilePath, excelSheetName); // Initialize document before tests
            LibPDF.CreateCover();

            LibGlobal.AksesMenuStudies(excelFilePath,excelSheetName);
            LibGlobal.AksesSubmenu("SHRINE",excelFilePath,excelSheetName);
            LibGlobal.LoginSubmenuShrine(excelFilePath, excelSheetName);
            LibGlobal.AddtoCart();

            LibPDF.GeneratePDF(excelFilePath, excelSheetName);
            driver.Quit();  
        }
    }
}