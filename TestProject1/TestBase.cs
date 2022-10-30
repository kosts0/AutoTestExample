using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NUnitTest
{
    [TestFixture]
    public class TestBase : BaseTest
    {
        [Test]
        public void TestMethod()
        {
            Driver.Url = "https://codeforces.com/";
            Thread.Sleep(TimeSpan.FromSeconds(30));
            Assert.AreEqual("https://codeforces.com/", Driver.Url, "Неверный url");
        }
        [Test]
        public void TestMethod2()
        {
            Driver.Url = "https://codeforces.com/register";
            Thread.Sleep(TimeSpan.FromSeconds(30));
            Assert.AreNotEqual("https://codeforces.com/register", Driver.Url, "Неверный url 2");
        }
    }
}
