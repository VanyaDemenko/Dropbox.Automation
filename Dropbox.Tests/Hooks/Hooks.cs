using Allure.Commons;
using Dropbox.UI.Drivers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Dropbox.Tests.Hooks
{
    [Binding]
    public class Hooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            AllureLifecycle.Instance.CleanupResultDirectory();
        }

        [BeforeScenario("@UI")]
        public void BeforeScenario()
        {
            DriverProvider.StartBrowser();
        }

        [AfterScenario("@UI")]
        public void AfterScenario()
        {
            DriverProvider.StopBrowser();
        }

        [AfterStep("@UI")]
        public void AfterStep(ScenarioContext context)
        {
            if (context.TestError == null) return;
            var content = CaptureScreenShot();
            AllureLifecycle.Instance.AddAttachment("ScreenShot of Failed scenario", "application/png", content);
        }

        private byte[] CaptureScreenShot() => ((ITakesScreenshot)DriverProvider.Driver).GetScreenshot().AsByteArray;
    }
}
