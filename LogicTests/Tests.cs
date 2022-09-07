using LabOneTaskIf;
using NUnit.Framework;

namespace LogicTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void GetSomePrice()
        {
            var fullPrice = 51234;

            var response = Logic.GetCost(fullPrice);

            Assert.AreEqual("512 rubbles and 34 cents", response);
        }
        
        [Test]
        public void GetOtherPrice()
        {
            var fullPrice = 122;

            var response = Logic.GetCost(fullPrice);

            Assert.AreEqual("1 rubbles and 22 cents", response);
        }
        
        [Test]
        public void GetZeroPrice()
        {
            var fullPrice = 0;

            var response = Logic.GetCost(fullPrice);

            Assert.AreEqual("0 rubbles and 0 cents", response);
        }
    }
}