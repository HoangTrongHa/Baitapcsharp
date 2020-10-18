using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int n, i, j, tmp; 


            Console.Write("\nNhap diem cua 10 hoc sinh trong lop:\n");
            Console.Write("--------------------------------------------\n");

            Console.Write("Nhap kich co mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] > arr1[i])
                    {
                        //cach trao doi gia tri
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.Write("\n3 BAN HOC SINH CO SO DIEM CAO NHAT LA:\n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
    }
}