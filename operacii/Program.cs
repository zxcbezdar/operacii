using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите значение b: ");
        double b = double.Parse(Console.ReadLine());

        double result1 = Math.Pow(a, 3) - 3 * Math.Pow(a, 2) * b + 3 * a * Math.Pow(b, 2) - Math.Pow(b, 3);
        Console.WriteLine($"Формула 1: a^3 - 3a^2b + 3ab^2 - b^3 = {result1} при a={a}, b={b}");

        double result2 = Math.Pow(a, 3) + 3 * Math.Pow(a, 2) * b + 3 * a * Math.Pow(b, 2) + Math.Pow(b, 3);
        Console.WriteLine($"Формула 2: a^3 + 3a^2b + 3ab^2 + b^3 = {result2} при a={a}, b={b}");

        double result3 = (a + b) * (Math.Pow(a, 2) - a * b + Math.Pow(b, 2));
        Console.WriteLine($"Формула 3: (a+b)(a^2-ab+b^2) = {result3} при a={a}, b={b}");

        double result4 = (a - b) * (Math.Pow(a, 2) + a * b + Math.Pow(b, 2));
        Console.WriteLine($"Формула 4: (a-b)(a^2+ab+b^2) = {result4} при a={a}, b={b}");

        double result5 = (a - b) * (a + b);
        Console.WriteLine($"Формула 5: (a -b)*(a+b) = {result5} при a={a}, b={b}");

        double result6 = Math.Pow(a, 2) - 2 * a * b + Math.Pow(b, 2);
        Console.WriteLine($"Формула 6: a^2-2ab+b^2 = {result6} при a={a}, b={b}");

        double result7 = Math.Pow(a, 2) + 2 * a * b + Math.Pow(b, 2);
        Console.WriteLine($"Формула 7: a^2+2ab+b^2 = {result7} при a={a}, b={b}");
    }
}



