using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBuoi1
{
    class Bai1
    {
        public static void BT()
        {
            Console.Write("Nhap so thu nhat: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("- Tong cua hai so la: {0}", a + b);
            Console.WriteLine("- Tich cua hai so la: {0}", a * b);
            Console.WriteLine("- Hieu cua hai so la: {0}", a - b);
        }
    }

    class Bai2
    {
        public static void BT()
        {
            //PT Bac nhat
            Console.Write("Nhap he so a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap he so b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem.");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("Nghiem cua phuong trinh la: x = " + x);
            }
            Console.WriteLine();

            //PT bac 2
            Console.WriteLine("Nhap a, b, c cua phuong trinh ax^2 + bx + c = 0:");
            Console.Write("Nhap he so a:");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap he so b:");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap he so c:");
            double c1 = Convert.ToDouble(Console.ReadLine());

            double delta = b1 * b1 - 4 * a1 * c1;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta == 0)
            {
                double x = -b1 / (2 * a1);
                Console.WriteLine("Phuong trinh co nghiem kep: x = " + x);
            }
            else
            {
                double x1 = (-b1 + Math.Sqrt(delta)) / (2 * a1);
                double x2 = (-b1 - Math.Sqrt(delta)) / (2 * a1);
                Console.WriteLine("Phuong trinh co hai nghiem phan biet: x1 = " + x1 + ", x2 = " + x2);
            }
        }
    }

    class Bai3
    {
        public static void BT()
        {
            Console.Write("Nhap do C: ");
            double doC = Convert.ToDouble(Console.ReadLine());

            double doK = doC + 273.15;
            double doF = doC * 9 / 5 + 32;
            Console.WriteLine(doC + " Do C = " + doK + " Do K = " + doF + " Do F");
        }
    }

    class Bai4
    {
        public static void BT()
        {
            Console.Write("Nhap vao mot so can tinh giai thua: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int giaiThua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
            }
            Console.WriteLine("Giai thua cua " + n + " la: " + giaiThua);
        }
    }

    class Bai5
    {
        public static void BT()
        {
            Console.Write("Nhap n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cac so nguyen to nho hon " + n + " la:");
            for (int i = 2; i < n; i++)
            {
                bool bl = true;
                for (int f = 2; f <= Math.Sqrt(i); f++)
                {
                    if (i % f == 0)
                    {
                        bl = false;
                        break;
                    }
                }
                if (bl)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }

    class Bai6
    {
        public static void BT()
        {
            Console.Write("Nhap vao mot so: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine(a + " la so chan");
            }
            else
            {
                Console.WriteLine(a + " la so le");
            }
        }
    }

    class Bai7
    {
        public static void BT()
        {
            Console.Write("Nhap vao mot so: ");
            int a = Convert.ToInt32(Console.ReadLine());
            bool bl = true;
            if (a <= 1)
            {
                bl = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        bl = false;
                        break;
                    }
                }
            }
            if (bl)
            {
                Console.WriteLine(a + " la so nguyen to.");
            }
            else
            {
                Console.WriteLine(a + " khong phai la so nguyen to.");
            }
        }
    }

    class Bai8
    {
        public static void BT()
        {
            Console.WriteLine("Nhap so phan tu cua mang:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Nhap cac phan tu cua mang:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu thu " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Mang so le:");
            foreach (int num in arr)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine("\nMang so chan:");
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }
    }

    class Bai9
    {
        public static void BT()
        {
            Console.WriteLine("Nhap so phan tu cua mang:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Nhap cac phan tu cua mang:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu thu " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine("Day tang dan:");
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\nDay giam dan:");
            Array.Reverse(arr);
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }

    class Bai10
    {
        public static void BT()
        {

        }
    }

    class Bai11
    {
        public static void BT()
        {
            Console.WriteLine("Nhap so phan tu cua day:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Nhap cac phan tu cua day:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu thu " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            Console.WriteLine("Tong cac phan tu cua day la: " + sum);
        }
    }

    class Bai12
    {
        public static void BT()
        {
            Console.WriteLine("Nhap so phan tu cua mang:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Nhap cac phan tu cua mang:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu thu " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Cac so le trong mang:");
            int tong = 0;
            foreach (int num in arr)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + " ");
                    tong += num;
                }
            }
            Console.WriteLine("\nTong cac so le trong mang: " + tong);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Bai11.BT();
            Console.ReadKey();
        }
    }
}


