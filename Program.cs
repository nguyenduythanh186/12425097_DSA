using System;

namespace TH1_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int choice;

            do
            {
                Console.WriteLine("\n================== MENU BÀI TẬP ĐỆ QUY ==================");
                Console.WriteLine("1. Bài 1: Tính S(n) = 1 + 2 + ... + n");
                Console.WriteLine("2. Bài 2: Tính S(n) = 1 + 2^2 + ... + n^2");
                Console.WriteLine("3. Bài 3: Tính S(n) = 1 + 1/2 + ... + 1/n");
                Console.WriteLine("4. Bài 4: Tính lũy thừa S(x, n) = x^n");
                Console.WriteLine("5. Bài 5: Tìm ước số lẻ lớn nhất của n");
                Console.WriteLine("6. Bài 6: Tìm ước chung lớn nhất (UCLN) của a và b");
                Console.WriteLine("7. Bài 7: Đếm số lượng chữ số của n");
                Console.WriteLine("8. Bài 8: Tính căn thức lồng nhau sqrt(1 + sqrt(2 + ... + sqrt(n)))");
                Console.WriteLine("0. Thoát chương trình");
                Console.Write("--> Mời bạn chọn bài (0-8): ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Lựa chọn không hợp lệ! Vui lòng nhập số từ 0 đến 8.");
                    continue;
                }

                Console.WriteLine("---------------------------------------------------------");

                switch (choice)
                {
                    case 1:
                        Console.Write("Nhập vào số n: ");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"==> Kết quả S({n1}) = {DeQuy.Bai1(n1)}");
                        break;

                    case 2:
                        Console.Write("Nhập vào số n: ");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"==> Kết quả S({n2}) = {DeQuy.Bai2(n2)}");
                        break;

                    case 3:
                        Console.Write("Nhập vào số n: ");
                        int n3 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"==> Kết quả S({n3}) = {DeQuy.Bai3(n3)}");
                        break;

                    case 4:
                        Console.Write("Nhập cơ số x: ");
                        double x = double.Parse(Console.ReadLine());
                        Console.Write("Nhập số mũ n: ");
                        int n4 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"==> Kết quả {x}^{n4} = {DeQuy.Bai4(x, n4)}");
                        break;

                    case 5:
                        Console.Write("Nhập vào số n: ");
                        int n5 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"==> Ước số lẻ lớn nhất của {n5} là: {DeQuy.Bai5(n5)}");
                        break;

                    case 6:
                        Console.Write("Nhập số a: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Nhập số b: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine($"==> UCLN({a}, {b}) = {DeQuy.Bai6(a, b)}");
                        break;

                    case 7:
                        Console.Write("Nhập vào số n: ");
                        int n7 = int.Parse(Console.ReadLine());
                        Console.WriteLine($"==> Số chữ số của {n7} là: {DeQuy.Bai7(n7)}");
                        break;

                    case 8:
                        Console.Write("Nhập vào số n: ");
                        double n8 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"==> Kết quả căn thức lồng nhau đến {n8} là: {DeQuy.Bai8(n8)}");
                        break;

                    case 0:
                        Console.WriteLine("Cảm ơn bạn đã sử dụng chương trình. Tạm biệt!");
                        break;

                    default:
                        Console.WriteLine("Lựa chọn không tồn tại! Vui lòng chọn lại từ 0 đến 8.");
                        break;
                }

                if (choice != 0)
                {
                    Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                    Console.ReadKey();
                }

            } while (choice != 0);
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
            if (n == 1) return 1;
            return Bai3(n - 1) + 1.0 / n;
        }

        public static double Bai4(double x, int n)
        {
            if (n == 0) return 1;
            return Bai4(x, n - 1) * x;
        }

        public static int Bai5(int n)
        {
            if (n % 2 == 1) return n;
            return Bai5(n / 2);
        }

        public static int Bai6(int a, int b)
        {
            if (a % b == 0) return b;
            return Bai6(b, a % b);
        }

        public static int Bai7(int n)
        {
            if (n == 0) return 0;
            return Bai7(n / 10) + 1;
        }

        public static double Bai8(double n, int i = 1)
        {
            if (i == n) return Math.Sqrt(n);
            return Math.Sqrt(i + Bai8(n, i + 1));
        }
    }
}