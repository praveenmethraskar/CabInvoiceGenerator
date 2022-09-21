using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class UnitTest1
    {
        InvoiceGenerator invoice = null;

        [TestMethod]
        public void GivenDistanceAndTimeSouldReturnTotalFare()
        {
            invoice = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;

            double fare = invoice.CalculateFare(distance, time);
            double expected = 25;

            Assert.AreEqual(expected, fare);
        }

    }
}