using OpenQA.Selenium;
using System;


namespace March2023.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            //Create new time record


            // click on create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            // select Time option from dropdown
            IWebElement dropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            dropdown.Click();
            Thread.Sleep(3000);

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();

            // type code into code textbox
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("March2023");

            // type description into description textbox
            driver.FindElement(By.Id("Description")).SendKeys("March2023");

            // type price into price per unit textbox
            IWebElement priceOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceOverlap.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("12");

            // click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            // check if new Time record has been created successfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "March2023")
            {
                Console.WriteLine("New record has been created successfully.");
            }
            else
            {
                Console.WriteLine("Record hasn't been created.");
            }

            Thread.Sleep(20000);
        }
        public void EditTM(IWebDriver driver)
        {

            //Edit the new time record

            //Click on edit button
            IWebElement editTimerecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[2]/td[5]/a[1]"));
            editTimerecord.Click();

            //Edit time code from dropdown
            IWebElement tcDropdownEdit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
            tcDropdownEdit.Click();
            Thread.Sleep(3000);

            //Edit the code textbox
            IWebElement codeTextboxEdit = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            codeTextboxEdit.Clear();
            codeTextboxEdit.SendKeys("March2024");


            //Edit the Description textbox
            IWebElement descTextboxEdit = driver.FindElement(By.Id("Description"));
            descTextboxEdit.Clear();
            descTextboxEdit.SendKeys("March2024");

            //Edit the Price Per Unit textbox
            IWebElement priceEdit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement priceTextboxEdit = driver.FindElement(By.Id("Price"));

            priceEdit.Click();
            priceTextboxEdit.Clear();
            priceEdit.Click();
            priceTextboxEdit.SendKeys("140");

            //Click on Save button
            IWebElement saveBtnEdit = driver.FindElement(By.Id("SaveButton"));
            saveBtnEdit.Click();

            Thread.Sleep(5000);

            IWebElement goToLastPagination = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPagination.Click();

            IWebElement editCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));

            if (editCode.Text != "March2024")
            {
                Console.WriteLine("Record has been edited successfully.");
            }
            else
            {
                Console.WriteLine("Failed to edit record.");
            }
            Thread.Sleep(3000);
        }
        public void DeleteTM(IWebDriver driver)
        {
            //Delete the edited record

            //Click on delete code
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            deleteButton.Click();

            Thread.Sleep(5000);

            IWebElement delCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]"));

            if (delCode.Text != "March2024")
            {
                Console.WriteLine("Record Deleted Successfully");

            }
            else
            {
                Console.WriteLine("Doesn't Delete the Record Successfully");

            }

        }
    }
}
