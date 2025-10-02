using Tyuiu.YarkovSD.Sprint1.Task6.V2.Lib;

namespace Tyuiu.YarkovSD.Sprint1.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (ds.CheckHello(str) == true)
                Console.WriteLine("Слово 'Hello' найдено в строке");
            else
                Console.WriteLine("Слово 'Hello' не найдено в строке");


            Console.ReadKey();

        }
    }
}