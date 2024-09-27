using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.YakimukVV.Sprint1.Task7.V23.Lib
{
    public class DataService : ISprint1Task7V23
    {
        public double Calculate(double x, double y)
        {
            double part1 = x - Math.Pow(10, Math.Sin(x));
            double part2 = (20 * Math.Pow(x, 2)) / (3 * Math.Pow(x, 3));
            double part3 = Math.Cos(Math.Pow(x, 2) - y);

            double z = part1 + part2 + part3;

            return Math.Round(z, 3);
        }
    }
}
