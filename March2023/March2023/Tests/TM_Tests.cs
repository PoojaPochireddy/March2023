using March2023.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//open chrome browser
IWebDriver driver = new ChromeDriver();

//login page object initilization and definition
LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginSteps(driver);

//Home page object initilization and definiton
HomePage homePageObj = new HomePage();
homePageObj.GoToHomePage(driver);

//TM page object initilization and definition
TMPage tmPageObject = new TMPage();
tmPageObject.CreateTM(driver);

//Edit TM
tmPageObject.EditTM(driver);

//Delete TM
tmPageObject.DeleteTM(driver);





