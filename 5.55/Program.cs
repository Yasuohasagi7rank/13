using System;

namespace _5._55
{
    class Program
    {
        static double Metod(string Z, double Min = -1.7E308, double Max = 1.7E308, double Exception1 = -1.7E308, double Exception2 = -1.7E308)
        {
            Console.WriteLine($"Введите {Z}:");
            double A;
            while (!(double.TryParse(Console.ReadLine(), out A) && A >= Min && A <= Max && A != Exception1 && A != Exception2));
            return A;
        }
        static void Main()
        {
            int B = (int)Metod("количество предметов", 1);
            double C = 0;
            for (int D = 1; D <= B; D++) C += Metod($"массу {D} предмета");
            Console.WriteLine(C / B);
            Console.ReadKey();
            Console.Clear();
        }
    }
    }
