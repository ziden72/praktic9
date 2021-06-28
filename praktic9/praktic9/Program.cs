using System;

namespace praktic9
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("1) Шахматная доска: ");
            int[,] op = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 0)
                        {
                            op[i, j] = 1;
                        }
                    }
                    else
                    {
                        if (j % 2 == 1)
                        {
                            op[i, j] = 1;
                        }
                    }
                }
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                    Console.Write(String.Format("{0,3}", op[i, j]));
                Console.WriteLine();
            }
            //2
            Console.WriteLine("2) Двумерный массив: ");
            int[,] h = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Random k = new Random();
                    int x = k.Next(0, 100);
                    h[i, j] = x;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write(String.Format("{0,3}", h[i, j]));
                Console.WriteLine();
            }
            //3
            int r = 0;
            int d = 0;
            for (int i = 0; i < 10; i++)
            {
                d++;
                for (int j = 0; j < 10; j++)
                {
                    r = r + h[i, j];
                    if (j == 9)
                    {
                        Console.WriteLine("3) Сумма " + d + " " + "строки = " + r);
                        r = 0;
                    }
                }
            }
            //4
            Console.WriteLine("4) Простые числа: ");
            int[,] h1 = new int[10, 10];
            int rt = 0;
            int tt = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (h[i, j] > 1)
                    {
                        for (int b = 2; b < h[i, j] - 1; b++)
                        {
                            if (h[i, j] % b == 0)
                            {
                                rt++;
                            }
                        }
                        if (rt == 0)
                        {
                            h1[i, j] = h[i, j];
                        }
                        else
                        {
                            rt = 0;
                        }
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(String.Format("{0,3}", h1[i, j]));
                }
                Console.WriteLine();
            }
        }
    }
}