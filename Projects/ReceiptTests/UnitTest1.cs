
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RetailStore;

namespace ReceiptTests
{
    [TestClass]
    public class ReceiptTest
    {
        [TestMethod]
        public void Receipt_Greater_Than_Zero()
        {
            Receipt purchase = new Receipt (12233, "08/02/2017", 188, "Susan", "Abbey",
                "123 Any Street", "555-555-5555", 701, "Widget", 12.99M, 2);
            Assert.AreEqual(12233, purchase.ReceiptNumber);
        }

        [TestMethod]
        public void CustomerNumber_Greater_Than_Zero()
        {
            Receipt purchase = new Receipt (12233, "08/02/2017", 188, "Susan", "Abbey",
                "123 Any Street", "555-555-5555", 701, "Widget", 12.99M, 2);
            Assert.AreEqual(12233, purchase.ReceiptNumber);
        }
    }
}