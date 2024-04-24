using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

[TestFixture]
public class FormTests
{
    private IWebDriver driver;
    private PracticeFormPage practiceFormPage;

    [SetUp]
    public void Setup()
    {
        new DriverManager().SetUpDriver(new ChromeConfig());
        driver = new ChromeDriver();
        practiceFormPage = new PracticeFormPage(driver);
        driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
    }

    [Test]
    public void TestSubmitForm()
    {
        practiceFormPage.EnterFirstName("John");
        practiceFormPage.EnterLastName("Doe");
        practiceFormPage.SubmitForm();
        Assert.Pass();
        // Add assertions here to verify the test result
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}