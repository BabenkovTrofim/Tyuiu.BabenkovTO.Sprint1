using Tyuiu.BabenkovTO.Sprint1.Task7.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Бабенков Т. О. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнил: Бабенков Трофим Олегович | ИИПб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по       *");
        Console.WriteLine("* исходным значениям данных, вводимых пользователем.                      *");
        Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*           2(   ( 1 ))    x                                              *");
        Console.WriteLine("*    z = cos (sin( - )) + y                                               *");
        Console.WriteLine("*            (   ( x ))                                                   *");
        Console.WriteLine("***************************************************************************");
        double x, y;
        Console.Write("Введите X: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите Y: ");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        DataService ds = new DataService();
        var z = ds.Calculate(x, y);
        Console.WriteLine($"z = {z}");
    }
}