using System.Globalization;
using Tyuiu.BabenkovTO.Sprint1.Task6.V1.Lib;
internal class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Бабенков Т. О. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Работа со строками класс String                                   *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Бабенков Трофим Олегович | ИИПб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Напишите программу, которая выводит код введенного пользователем символа*");
        Console.WriteLine("* Программа должна завершать работу в результате ввода, например, точки.  *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string a;
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        bool Flag = true;
        while (Flag = true)
        {
            Console.Write("Укажите символ: ");
            a =  Console.ReadLine();
            if(a.Length > 1)
            {
                Flag = false;
                Console.WriteLine("Программа завершена.");
                break;
            }
            if (a[0] == '.')
            {
                Flag = false;
                Console.WriteLine("Программа завершена.");
                break;
            }
            else
            {
                Console.WriteLine($"Символ: {a[0]} Код: {ds.SymbolCode(a)} \n");
            }
        }
    }
}