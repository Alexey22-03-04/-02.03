using System;
internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Вычисление значения числа ПИ методом Монте-Карло \n2. Вычисление площади фигуры методом Монте-Карло\n3. ПРАКТИКА");
            Console.Write("Ответ: ");
            int num = Convert.ToInt32(Console.ReadLine());
            double s;
            int n;
            switch (num)
            {
                case 1:
                    n = 1000000;
                    Console.WriteLine("Число повторений: " + n);
                    s = Kryg(n);
                    Console.WriteLine("Результат pi = " + s);
                    Console.WriteLine("Точное pi = " + Math.PI);
                    break;
                case 2:
                    n = 1000000;
                   // Console.WriteLine("Число повторений: " + n);
                    Console.Write("Введите ширину базового прямоугольника -> ");
                    double b = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Введите высоту базового прямоугольника -> ");
                    double a = Convert.ToSingle(Console.ReadLine());
                    s = Pryam(n, a, b);
                    Console.WriteLine("Результат s = " + s);
                    break;
                case 3:
                    n = 1000000;
                    Console.WriteLine("Число повторений: " + n);
                    Zadanie1(n);
                    Zadanie2(n);
                    Zadanie3(n);
                    Zadanie4(n);
                    Zadanie5(n);
                    Zadanie6(n);
                    break;
            }
            Console.WriteLine("Повтор действий? (1 - да | 2 - нет)");
            if (Convert.ToInt32(Console.ReadLine()) == 2)
            {
                break;
            }
        }
    }
    static double Kryg(int n)
    {
        Random rnd = new Random();
        double k = 0;
        for (int i = 0; i < n; i++)
        {
            double x = (rnd.NextDouble() * 4) - 2;
            double y = (rnd.NextDouble() * 4) - 2;
            if (x * x + y * y <= 4)
            {
                k++;
            }
        }
        return 4 * (k / n);
    }
    static double Pryam(int n, double a, double b)
    {
        Random rnd = new Random();
        double k = 0;
        for (int i = 0; i < n; i++)
        {
            double x = (rnd.NextDouble() * 9);
            double y = (rnd.NextDouble() * 5);
            if ((x / 3 <= y) && (y <= (x * (10 - x)) / 5))
            {
                k++;
            }
        }
        return (k / n) * 45;
    }
    static void Zadanie1(int n)
    {
        Random rnd = new Random();
        double k = 0;
        for (int i = 0; i < n; i++)
        {
            double x = (rnd.NextDouble() * 20) - 5;
            double y = rnd.NextDouble();
            if (y <= Math.Sin(x) && y >= 0)
            {
                k++;
            }
        }
        double s = (k / n) * 20;
        Console.WriteLine("Решение 1. S = " + s);
    }
    static void Zadanie2(int n)
    {
        Random rnd = new Random();
        double k = 0;
        for (int i = 0; i < n; i++)
        {
            double x = (rnd.NextDouble() * 10);
            double y = (rnd.NextDouble() * 10);
            if (y <= (x * (8 - x)) / 2 && y >= x / 2)
            {
                k++;
            }
        }
        double s = (k / n) * 100;
        Console.WriteLine("Решение 2. S = " + s);
    }
    static void Zadanie3(int n)
    {
        Random rnd = new Random();
        double k = 0;
        for (int i = 0; i < n; i++)
        {
            double x = (rnd.NextDouble() * 15);
            double y = (rnd.NextDouble() * 6);
            if (y >= Math.Pow((x - 6), 2) / 6 && y <= 6)
            {
                k++;
            }
        }
        double s = (k / n) * 90;
        Console.WriteLine("Решение 3. S = " + s);
    }
    static void Zadanie4(int n)
    {
        Random rnd = new Random();
        double k = 0;
        for (int i = 0; i < n; i++)
        {
            double x = (rnd.NextDouble() * 15);
            double y = (rnd.NextDouble() * 4);
            if (y <= (x * (12 - x)) / 9 && y >= x / 5)
            {
                k++;
            }
        }
        double s = (k / n) * 60;
        Console.WriteLine("Решение 4. S = " + s);
    }
    static void Zadanie5(int n)
    {
        Random rnd = new Random();
        double k = 0;
        for (int i = 0; i < n; i++)
        {
            double x = (rnd.NextDouble() * 8);
            double y = (rnd.NextDouble() * 4);
            if (y <= (x * (8 - x)) / 4 && y >= (8 - x) / 8)
            {
                k++;
            }
        }
        double s = (k / n) * 32;
        Console.WriteLine("Решение 5. S = " + s);

    }
    static void Zadanie6(int n)
    {
        Random r = new Random();
        double k = 0;
        for (int i = 0; i < n; i++)
        {
            double x = (r.NextDouble() * 3);
            double y = (r.NextDouble() * 1);
            if (y >= (x - 2) * (x - 2) / 2 && y <= Math.Sin(x)) k++;
        }
        double s = (k / n) * 3;
        Console.WriteLine("Решение 6. S = " + s);
    }
}
