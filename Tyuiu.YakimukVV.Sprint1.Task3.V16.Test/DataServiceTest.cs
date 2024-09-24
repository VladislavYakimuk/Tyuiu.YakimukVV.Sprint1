using Tyuiu.YakimukVV.Sprint1.Task3.V16.Lib;
namespace Tyuiu.YakimukVV.Sprint1.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 2.0;
            double x2 = 5.0;
            var b = ds.CoeffOfQuadraticEquation(x1, x2);
            Assert.AreEqual(-7.0, b);

        }
    }
}