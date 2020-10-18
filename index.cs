using System;

namespace bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float cannang = 0;
            Console.Write("Nhap can nang cua hoc sinh: ");
            cannang = Convert.ToInt32(Console.ReadLine());
            if(cannang<20)
            {
                Console.Write("Suy dinh duong");
            }

            else if (cannang < 35)
            {
                Console.Write("Binh thuong");
            }
            else
            {
                Console.Write("Beo phi");
            }
        }
    }
}