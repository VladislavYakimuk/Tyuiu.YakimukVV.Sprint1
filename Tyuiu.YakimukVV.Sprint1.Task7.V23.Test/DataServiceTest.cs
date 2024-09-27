using Tyuiu.YakimukVV.Sprint1.Task7.V23.Lib;
namespace Tyuiu.YakimukVV.Sprint1.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 10.0;
            double y = 5.0;
            double wait = 11.111;
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}