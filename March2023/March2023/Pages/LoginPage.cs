using OpenQA.Selenium;


namespace March2023.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            //Launch turn up portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2fTimeMaterial");

            //Identify username textbox and enter valid username
            IWebElement Username = driver.FindElement(By.Id("UserName"));
            Username.SendKeys("hari");

            //Identify password textbox and enter valid password
            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("123123");

            //Identify login button and click on it
            IWebElement Login = driver.FindElement(By.XPath("//input[@value='Log in']"));
            Login.Click();

            IWebElement hellohari = driver.FindElement(By.XPath("//a[normalize-space()='Hello hari!']"));

            if (hellohari.Text == "Hello hari!")
            {
                Console.WriteLine("User has loged in Successfully");
            }
            else
            {
                Console.WriteLine("User has not logged in sucessfully");

            }
        }
    }
}
