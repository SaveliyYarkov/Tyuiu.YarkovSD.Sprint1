using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.YarkovSD.Sprint1.Task6.V2.Lib
{
    public class DataService : ISprint1Task6V0
    {
        public string WorkWithText(string value)
        {
            if (value.Contains("Hello"))
            {
                value = "Слово Hello найдено в тексте";
            }
            else
            {
                value = "Слово Hello не найдено в тексте";
            }
            return value;
        }
    }
}