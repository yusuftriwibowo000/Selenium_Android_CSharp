using OpenQA.Selenium;
using SeleniumNew;
using LibraryPDF;
using OpenQA.Selenium.Appium.Android;
using Repository_Dashboard;
using LibraryExcel;
using OpenQA.Selenium.Appium.MultiTouch;

namespace GlobalLibrary
{
    public class LibGlobal
    {
        private static AndroidDriver driver = SingletonDriver.GetDriver();
        //Akses Menu Studies
        public static void AksesMenuStudies(string excelFilePath, string excelSheetName)
        {
            //AndroidDriver driver = SingletonDriver.GetDriver();
            try
            {
                IWebElement labelFlutter = driver.FindElement(By.XPath(repoDashboard.labelFlutter));
                IWebElement btnToogleDashboard = driver.FindElement(By.XPath(repoDashboard.btnToogleDashboard));

                if (labelFlutter != null && btnToogleDashboard != null) //validasi berhasil launching app
                {
                    LibPDF.CaptureScreen("Berhasil Launching Aplikasi Gallery", "Passed");
                    IWebElement menuStudies = driver.FindElement(By.XPath(repoDashboard.menuStudies));
                    if (menuStudies != null)
                    {
                        menuStudies.Click();
                        try
                        {
                            IWebElement labelStudies = driver.FindElement(By.XPath(repoDashboard.labelStudies));
                            IWebElement btnBackStudies = driver.FindElement(By.XPath(repoDashboard.btnBackStudies));
                            IWebElement btnToogleStudies = driver.FindElement(By.XPath(repoDashboard.btnToogleStudies));
                            if (labelStudies != null && btnBackStudies != null && btnToogleStudies != null)
                            {
                                LibPDF.CaptureScreen("Berhasil Masuk Menu Studies", "Passed");
                            }
                            else
                            {
                                LibPDF.CaptureScreen("Gagal Masuk Menu Studies", "Failed");
                                driver.Quit();
                                LibPDF.GeneratePDF(excelFilePath, excelSheetName);
                                Environment.Exit(1);
                            }
                        }
                        catch
                        {
                            LibPDF.CaptureScreen("Object Pada Menu Studies Tidak Ditemukan", "Failed");
                            driver.Quit();
                            LibPDF.GeneratePDF(excelFilePath, excelSheetName);
                            Environment.Exit(1);
                        }
                    }
                    else
                    {
                        LibPDF.CaptureScreen("Menu Studies Tidak Muncul", "Failed");
                        driver.Quit();
                        LibPDF.GeneratePDF(excelFilePath, excelSheetName);
                        Environment.Exit(1);
                    }
                }
                else
                {
                    LibPDF.CaptureScreen("Gagal Launching Aplikasi Gallery", "Failed");
                    driver.Quit();
                    LibPDF.GeneratePDF(excelFilePath, excelSheetName);
                    Environment.Exit(1);
                }
            }
            catch
            {
                LibPDF.CaptureScreen("Object Pada Dashboard Tidak Ditemukan", "Failed");
                driver.Quit();
                LibPDF.GeneratePDF(excelFilePath, excelSheetName);
                Environment.Exit(1);
            }
        }

        //Akses Submenu
        public static void AksesSubmenu(string submenu, string excelFilePath, string excelSheetName)
        {
            //AndroidDriver driver = SingletonDriver.GetDriver();
            try
            {
                IWebElement menuShrine = driver.FindElement(By.XPath(repoDashboard.menuShrine));
                IWebElement menuContactProfile = driver.FindElement(By.XPath(repoDashboard.menuContactProfile));
                IWebElement menuAnimation = driver.FindElement(By.XPath(repoDashboard.menuAnimation));
                
                switch(submenu)
                {
                    case "SHRINE" :
                        menuShrine.Click();
                        try
                        {
                            IWebElement imgShrine = driver.FindElement(By.XPath(repoDashboard.imgShrine));
                            IWebElement btnBackShrine = driver.FindElement(By.XPath(repoDashboard.btnBackShrine));

                            if(imgShrine != null && btnBackShrine != null)
                            {
                                LibPDF.CaptureScreen("Berhasil Masuk Submenu Shrine", "Passed");
                            }
                            else
                            {
                                LibPDF.CaptureScreen("Gagal Masuk Submenu Shrine", "Failed");
                                driver.Quit();
                                LibPDF.GeneratePDF(excelFilePath, excelSheetName);
                                Environment.Exit(1);
                            }
                        }
                        catch
                        {
                            LibPDF.CaptureScreen("Object Pada Submenu '" + submenu + "' Tidak Ditemukan", "Failed");
                            driver.Quit();
                            LibPDF.GeneratePDF(excelFilePath, excelSheetName);
                            Environment.Exit(1);
                        }
                        break;

                    case "CONTACT PROFILE":
                        menuContactProfile.Click();
                        break;

                    case "ANIMATION":
                        menuAnimation.Click();
                        break;
                }
            }
            catch
            {
                LibPDF.CaptureScreen("Object Pada Submenu '"+submenu+"' Tidak Ditemukan", "Failed");
                driver.Quit();
                LibPDF.GeneratePDF(excelFilePath, excelSheetName);
                Environment.Exit(1);
            }
        }

        //Login pada submenu Shrine
        public static void LoginSubmenuShrine(string excelFilePath, string excelSheetName)
        {
            //AndroidDriver driver = SingletonDriver.GetDriver();
            //string dtUsername = LibExcel.GetDataExcel(excelFilePath,"USERNAME",excelSheetName);
            //string dtPassword = LibExcel.GetDataExcel(excelFilePath, "PASSWORD", excelSheetName);
            try
            {
                //IWebElement fieldUsername = driver.FindElement(By.XPath(repoDashboard.fieldUsername));
                //IWebElement fieldPassword = driver.FindElement(By.XPath(repoDashboard.fieldPassword));
                IWebElement btnNext = driver.FindElement(By.XPath(repoDashboard.btnNext));

                //if (fieldUsername != null && fieldPassword!= null && btnNext != null)
                if (btnNext != null)
                {
                    //fieldUsername.Click();
                    //fieldUsername.Clear();
                    //driver.Navigate().Back();
                    //fieldUsername.SendKeys("Test");
                    //fieldPassword.Click();
                    //fieldPassword.Clear();
                    //driver.Navigate().Back();
                    //fieldPassword.SendKeys("Test");
                    //string inputanUsername = fieldUsername.GetAttribute("text");
                    //string inputanPassword = fieldPassword.GetAttribute("text");
                    //if (inputanUsername == dtUsername && inputanPassword == dtPassword)
                    //{
                    //    LibPDF.CaptureScreen("Isi Username dan Password", "Done");
                        btnNext.Click();
                        try
                        {
                            IWebElement labelShrine = driver.FindElement(By.XPath(repoDashboard.labelShrine));
                            IWebElement btnSearchShrine = driver.FindElement(By.XPath(repoDashboard.btnSearchShrine));
                            IWebElement btnFilterShrine = driver.FindElement(By.XPath(repoDashboard.btnFilterShrine));
                            if (labelShrine != null && btnSearchShrine != null && btnFilterShrine != null)
                            {
                                LibPDF.CaptureScreen("Berhasil Masuk Halaman Produk Shrine", "Passed");
                            }
                            else
                            {
                                LibPDF.CaptureScreen("Gagal Masuk Halaman Produk Shrine", "Failed");
                            }
                        }
                        catch
                        {
                            LibPDF.CaptureScreen("Object Pada Halaman Produk Shrine Tidak Ditemukan ", "Failed");
                            driver.Quit();
                            LibPDF.GeneratePDF(excelFilePath, excelSheetName);
                            Environment.Exit(1);
                        }
                    //}
                    //else
                    //{
                    //    LibPDF.CaptureScreen("Username dan Password Tidak Diisi", "Failed");
                    //    Environment.Exit(1);
                    //}
                }
                else
                {
                    LibPDF.CaptureScreen("Object Pada Submenu Shrine Tidak Ditemukan ", "Failed");
                    driver.Quit();
                    LibPDF.GeneratePDF(excelFilePath, excelSheetName);
                    Environment.Exit(1);
                }
            }
            catch
            {
                LibPDF.CaptureScreen("Object Pada Submenu Shrine Tidak Ditemukan ", "Failed");
                driver.Quit();
                LibPDF.GeneratePDF(excelFilePath, excelSheetName);
                Environment.Exit(1);
            }
        }

        //Add to cart
        public static void AddtoCart()
        {
            
            int maxSwipes = 15;
            //bool elementPresent = false;

            for (int i = 0; i < maxSwipes; i++)
            {
                try
                {
                    // Cek apakah elemen hadir
                    IWebElement productItem = driver.FindElement(By.XPath(repoDashboard.productItem));
                    if (productItem.Displayed)
                    {
                        string namaProduct = productItem.GetAttribute("text");
                        LibPDF.CaptureScreen("Berikut Product Item : "+namaProduct, "Done");
                        break;
                    }
                }
                catch (NoSuchElementException)
                {
                    SwipeLeft();
                }
            }

            //if (!elementPresent)
            //{
            //    LibPDF.CaptureScreen("Product Item Tidak Ditemukan", "Failed");
            //    //Environment.Exit(1);
            //}
        }

        static void SwipeLeft()
        {
            var size = driver.Manage().Window.Size;
            int startX = (int)(size.Width * 0.9); // Mulai dari 90% dari lebar layar
            int endX = (int)(size.Width * 0.1); // Akhiri di 10% dari lebar layar
            int y = size.Height / 2; // Posisi vertikal tengah layar

            var touchAction = new TouchAction(driver);
            touchAction
                .Press(startX, y)
                //.Wait(1000)
                .MoveTo(endX, y)
                .Release()
                .Perform();
        }
    }
}