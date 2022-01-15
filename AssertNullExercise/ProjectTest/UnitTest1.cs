using NUnit.Framework;
using Project;

//See: http://www.biology.arizona.edu/biomath/tutorials/quadratic/roots.html
//See: https://www.mathsisfun.com/quadratic-equation-solver.html
namespace TestProject1
{
    public class Tests
    {
        //Test for two real roots
        [Test]
        public void Test1()
        {
            Quadratic quadratic = new Quadratic(2, -11, 5);
            double root1 = 0, root2 = 0;
            quadratic.Roots(ref root1, ref root2);
            Assert.AreEqual(5.0d, root1);
            Assert.AreEqual(0.5d, root2);
        }

        //Test for one real root
        [Test]
        public void Test2()
        {
            Quadratic quadratic = new Quadratic(-4, 12, -9);
            double root1 = 0, root2 = 0;
            quadratic.Roots(ref root1, ref root2);
            Assert.AreEqual(1.5d, root1);
            Assert.AreEqual(1.5d, root2);
        }

        //Test for no real roots
        [Test]
        public void Test3()
        {
            Quadratic quadratic = new Quadratic(1, -3, 4);
            double root1 = 0, root2 = 0;
            quadratic.Roots(ref root1, ref root2);
            //TODO: Insert your code here
            Assert.IsNaN(root1);
            Assert.IsNaN(root2);
            Assert.Fail();
        }

    }
}