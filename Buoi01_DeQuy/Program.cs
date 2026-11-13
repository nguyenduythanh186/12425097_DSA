using System;

namespace Buoi01_DeQuy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Để in được tiếng Việt có dấu
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== Bài 1 ===");
            int n1 = 5;
            Console.WriteLine($"S({n1}) = {DeQuy.Bai1(n1)}");

            Console.WriteLine("\n=== Bài 2 ===");
            int n2 = 4;
            Console.WriteLine($"S({n2}) = {DeQuy.Bai2(n2)}");

            Console.WriteLine("\n=== Bài 3 ===");
            int n3 = 4;
            Console.WriteLine($"S({n3}) = {DeQuy.Bai3(n3)}");

            Console.WriteLine("\n=== Bài 4 ===");
            double x = 2;
            int n4 = 3;
            Console.WriteLine($"{x}^{n4} = {DeQuy.Bai4(x, n4)}");

            Console.WriteLine("\n=== Bài 5 ===");
            int n5 = 24;
            Console.WriteLine($"Ước số lẻ lớn nhất của {n5} là: {DeQuy.Bai5(n5)}");

            Console.WriteLine("\n=== Bài 6 ===");
            int a = 24, b = 36;
            Console.WriteLine($"UCLN({a}, {b}) = {DeQuy.Bai6(a, b)}");

            Console.WriteLine("\n=== Bài 7 ===");
            int n7 = 12345;
            Console.WriteLine($"Số chữ số của {n7} là: {DeQuy.Bai7(n7)}");

            Console.WriteLine("\n=== Bài 8 ===");
            double n8 = 3;
            Console.WriteLine($"Kết quả căn thức lồng nhau đến {n8} là: {DeQuy.Bai8(n8)}");

            Console.WriteLine("\nNhấn phím bất kỳ để kết thúc...");
            Console.ReadKey();
        }
    }

    class DeQuy
    {
        public static int Bai1(int n)
        {
            if (n == 1) return 1;
            return Bai1(n - 1) + n;
        }

        public static int Bai2(int n)
        {
            if (n == 1) return 1;
            return Bai2(n - 1) + n * n;
        }

        public static double Bai3(int n)
        {
            if (n == 1) return 1.0;
            return Bai3(n - 1) + 1.0 / n;
        }

        public static double Bai4(double x, int n)
        {
            if (n == 0) return 1;
            return Bai4(x, n - 1) * x;
        }

        public static int Bai5(int n)
        {
            if (n % 2 != 0) return n;
            return Bai5(n / 2);
        }

        public static int Bai6(int a, int b)
        {
            if (b == 0) return a;
            return Bai6(b, a % b);
        }

        public static int Bai7(int n)
        {
            if (n == 0) return 0;
            return Bai7(n / 10) + 1;
        }

        public static double Bai8(double n, int i = 1)
        {
            if (i >= (int)n) return Math.Sqrt(n);
            return Math.Sqrt(i + Bai8(n, i + 1));
        }
    }
}