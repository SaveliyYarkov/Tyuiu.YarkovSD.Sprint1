using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.YarkovSD.Sprint1.Task4.V10.Lib
{
    public class DataService : ISprint1Task4V10
    {
        public double Calculate(double x)
        {
            return Math.Round((1 + Math.Cos(x)) / (Math.Sin(x) * Math.Sin(x)), 3);
        }      
    }
}