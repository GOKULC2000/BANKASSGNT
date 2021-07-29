using BANKASSGNT;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        bank bnk= new bank();
        [Test]
        public void TestMethod1()
        {
            int prod = bnk.prod(3, 5);
            Assert.GreaterOrEqual(prod, 1);
        }
        [Test]
        public void TestMethod2( )
        {
            int maxamnt = bnk.getvalue(500, 23);
            Assert.LessOrEqual(maxamnt, 100000);
        }
      
    }
}
