using System;

class Program
{
    static void Main()
    {
        double S = 1.0;
        int i = 1;
        
        while (i <= 15) {
            S *= (Math.Sin(i) * Math.Sin(i) + Math.Cos(1.0 / i) * Math.Cos(1.0 / i)) / (i * i);
            i++;
        }
        Console.WriteLine("Результат за допомогою while: " + S.ToString("F30"));

        S = 1.0;
        i = 1;
        do {
            S *= (Math.Sin(i) * Math.Sin(i) + Math.Cos(1.0 / i) * Math.Cos(1.0 / i)) / (i * i);
            i++;
        } while (i <= 15);
        Console.WriteLine("Результат за допомогою do-while: " + S.ToString("F30"));

        S = 1.0;
        for (i = 1; i <= 15; i++) {
            S *= (Math.Sin(i) * Math.Sin(i) + Math.Cos(1.0 / i) * Math.Cos(1.0 / i)) / (i * i);
        }
        Console.WriteLine("Результат за допомогою for: " + S.ToString("F30"));

        S = 1.0;
        for (i = 15; i >= 1; i--) {
            S *= (Math.Sin(i) * Math.Sin(i) + Math.Cos(1.0 / i) * Math.Cos(1.0 / i)) / (i * i);
        }
        Console.WriteLine("Результат за допомогою for (у зворотному порядку): " + S.ToString("F30"));
    }
}