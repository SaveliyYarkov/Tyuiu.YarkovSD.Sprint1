using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.YarkovSD.Sprint1.Task3.V13.Lib
{
    public class DataService : ISprint1Task3V14
    {
        public double ReverseNumber(int number)
        {
            int Number1 = number / 100;
            int Number2 = (number / 10) % 10;
            int Number3 = number % 10;
            return(Number3 * 100 + Number2 * 10 + Number1);
        }
    }
}