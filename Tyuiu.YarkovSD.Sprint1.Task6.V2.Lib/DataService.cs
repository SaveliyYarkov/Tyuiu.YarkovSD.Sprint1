using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.YarkovSD.Sprint1.Task6.V2.Lib
{
    public class DataService : ISprint1Task6V2
    {
        public bool CheckHello(string x)
        {
            if (x.Contains("Hello"))
            return true;
            else
            return false;
            
        }
    }
}