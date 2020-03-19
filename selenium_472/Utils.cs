using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;


namespace Desktop
{
 
    public class Utils
    {
        public IWebDriver driver = new ChromeDriver();

        //public void Waitingpage(int seconds)
        //{
        //    System.Threading.Thread.Sleep(seconds * 1000);
        //}


        //[Fact]
        public void Logar()
        {

            // driver.Navigate().GoToUrl("https://google.com");
            //driver.Manage().Window.Size = new System.Drawing.Size(1241, 697);
            //driver.FindElement(By.Id("Login1_UserName")).Click();
            //driver.FindElement(By.Id("Login1_UserName")).SendKeys("samuel.evangelista");
            //driver.FindElement(By.Id("Login1_Password")).SendKeys("P@ssword1");
            //Waitingpage(1);
            //driver.FindElement(By.Id("Login1_LoginButton")).Click();
            Assert.Equal("Google", driver.Title);

        }

        [Theory]
        [InlineData("googlee")]
        [InlineData("google")]
        [InlineData("Google")]
        public void Theory(string expected)
        {

            driver.Navigate().GoToUrl("https://google.com");
            //driver.Manage().Window.Size = new System.Drawing.Size(1241, 697);
            //driver.FindElement(By.Id("Login1_UserName")).Click();
            //driver.FindElement(By.Id("Login1_UserName")).SendKeys("samuel.evangelista");
            //driver.FindElement(By.Id("Login1_Password")).SendKeys("P@ssword1");
            //Waitingpage(1);
            //driver.FindElement(By.Id("Login1_LoginButton")).Click();
            Assert.Equal(expected, driver.Title);

        }

        //public void Deslogar()
        //{
        //    driver.FindElement(By.Id("cmdLogoff")).Click();

        //}

        //public void CSSSelectorbyXPath(string XPath)
        //{
        //    Waitingpage(5);
        //    driver.FindElement(By.XPath(XPath)).Click();

        //}

        //public void CSSSelectorbyId(string Id, string Nome)
        //{
        //    driver.SwitchTo().Frame(1);
        //    driver.FindElement(By.Id(Id)).SendKeys(Nome);
        //    driver.FindElement(By.Id(Id)).SendKeys(Keys.Enter);

        //}

        //public void Consulta(string XPath, string Nome)
        //{
        //    Waitingpage(3);
        //    driver.SwitchTo().Frame(1);
        //    driver.FindElement(By.XPath(XPath)).SendKeys(Nome);
        //    driver.FindElement(By.XPath(XPath)).SendKeys(Keys.Enter);

        //}

        //public void Click()
        //{

        //    Waitingpage(5);

        //}

    }

}
