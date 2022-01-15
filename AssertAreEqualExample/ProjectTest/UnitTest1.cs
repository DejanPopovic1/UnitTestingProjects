using NUnit.Framework;
using Project;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Calculator calculator = new Calculator();
            int result1 = calculator.Add(15, 65);
            Assert.AreEqual(result1, 80);
            int result2 = calculator.Add(100, 4);
            Assert.AreEqual(result2, 104);
            int result3 = calculator.Add(200, 3);
            Assert.AreEqual(result3, 203);
            int result4 = calculator.Add(15, 0);
            Assert.AreEqual(result4, 15);
            int result5 = calculator.Add(0, 7);
            Assert.AreEqual(result5, 7);
            int result6 = calculator.Add(0, 0);
            Assert.AreEqual(result6, 0);
        }
    }
}