using Tyuiu.YakimukVV.Sprint1.Task5.V1.Lib;
namespace Tyuiu.YakimukVV.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 2.0;
            double x2 = 14.0;
            double y1 = 5.0;
            double y2 = 10.0;
            int wait = 13;
            var res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Assert.AreEqual(wait, res);
        }
    }
}