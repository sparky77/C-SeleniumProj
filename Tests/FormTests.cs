using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

[TestFixture]
public class FormTests
{
    private IWebDriver? driver;
    private PracticeFormPage? practiceFormPage;

    [SetUp]
    public void Setup()
    {
        new DriverManager().SetUpDriver(new ChromeConfig(), VersionResolveStrategy.MatchingBrowser);
        driver = new ChromeDriver();
        practiceFormPage = new PracticeFormPage(driver);
        
    }

    [Test]
    public void TestSubmitForm()
    {
        practiceFormPage?.EnterFirstName("John");
        practiceFormPage?.EnterLastName("Doe");
        practiceFormPage?.SubmitForm();
        Assert.Pass();
    }

    [TearDown]
    public void TearDown()
    {
        driver?.Quit();
    }
}