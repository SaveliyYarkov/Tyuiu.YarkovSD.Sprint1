using Tyuiu.YarkovSD.Sprint1.Task0.V19.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "������ #1 | ��������: ����� �. �. | ����-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ������ #1                                                               *");
        Console.WriteLine("* ����: ������� ������ ������ � C#                                        *");
        Console.WriteLine("* ������� #0                                                              *");
        Console.WriteLine("* ������� #19                                                             *");
        Console.WriteLine("* ��������: ����� ������� ���������| ����-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* �������:                                                                *");
        Console.WriteLine("* �������� ���������, ������� ��������� ��������� 4/2*5/(3+2)*5           *");
        Console.WriteLine("* � �������� ��������� �� ������.                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* �������� ������:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* 4/2*5/(3+2)*5                                                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ���������:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate());

        Console.ReadKey();
    }
}