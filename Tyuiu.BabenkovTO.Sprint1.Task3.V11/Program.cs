using Tyuiu.BabenkovTO.Sprint1.Task3.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнил: Бабенков Т. О. | ИИПб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнил: Бабенков Трофим Олегович | ИИПб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Напишите программу, которая вычисляет площадь треугольника, если        *");
        Console.WriteLine("* известны координаты его углов. Ответ округлить до 3 знаков после запятой*");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double x1, y1, x2, y2, x3, y3;
        Console.WriteLine("Укажите координаты вершин треугольника:");
        Console.Write("x1 = ");
        x1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("y1 = ");
        y1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("x2 = ");
        x2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("y2 = ");
        y2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("x3 = ");
        x3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("y3 = ");
        y3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        DataService ds = new DataService();
        var square = ds.TriangleArea(x1, y1, x2, y2, x3, y3);
        Console.WriteLine($"Площадь треугольника = {square} кв.см");
    }
}