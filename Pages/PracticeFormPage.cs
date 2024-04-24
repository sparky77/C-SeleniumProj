using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

public class PracticeFormPage
{
    private IWebDriver driver;

    // Define locators as private readonly fields
    private readonly By firstName = By.Id("firstName");
    private readonly By lastName = By.Id("lastName");
    private readonly By submitButton = By.Id("submit");

    // Constructor to initialize the WebDriver
    public PracticeFormPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    // Methods to interact with elements
    public void EnterFirstName(string name)
    {
        driver.FindElement(firstName).SendKeys(name);
    }

    public void EnterLastName(string name)
    {
        driver.FindElement(lastName).SendKeys(name);
    }

    public void SubmitForm()
    {
    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
    IWebElement submitBtn = wait.Until(ExpectedConditions.ElementToBeClickable(submitButton));

    IWebElement element = driver.FindElement(submitButton);
    ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", element);


    //submitBtn.Click();
    }
}
