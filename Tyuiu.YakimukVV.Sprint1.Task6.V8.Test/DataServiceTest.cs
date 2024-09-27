using Tyuiu.YakimukVV.Sprint1.Task6.V8.Lib;
namespace Tyuiu.YakimukVV.Sprint1.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string input = "Hello World";
            string expected = "elloH orldW";
            string result = ds.MoveLetterToEnd(input);
            Assert.AreEqual(expected, result);

        }
    }
}