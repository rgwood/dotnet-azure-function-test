using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reilly.Function;

namespace test_project
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAzureFunction()
        {
            Assert.IsTrue(TimerTriggerCSharp.ReturnTrueForUnitTest(), "Static method in Azure Function works");
        }
    }
}
