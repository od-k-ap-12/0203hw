using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0203hw
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1

            Random r = new Random();
            int[] A = new int[5];
            for (int i = 0; i < 5; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            double[,] B = new double[3, 4];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)

                {
                    B[i, j] = r.Next(1, 10);
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            double max = A[0];
            double min = A[0];
            double totalsum = 0;
            double totalmult = 0;
            double evensumA = 0;
            double oddcolssumB = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
                if (A[i] < min)
                {
                    min = A[i];
                }
                totalsum += A[i];
                totalmult *= A[i];
                if (A[i] % 2 == 0)
                {
                    evensumA += A[i];
                }
            }
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)

                {
                    if (B[i, j] > max)
                    {
                        max = B[i, j];
                    }
                    if (B[i, j] < min)
                    {
                        min = B[i, j];
                    }
                    totalsum += B[i, j];
                    totalmult *= B[i, j];
                    if (j % 2 != 0)
                    {
                        oddcolssumB += B[i, j];
                    }
                }
            }
            #endregion

            #region 2
            int[,] C = new int[5, 5];
            min = 0; max = 0; totalsum = 0;
            int minindex = -1; int maxindex = -1;
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)

                {
                    C[i, j] = r.Next(-100, 100);
                    if (C[i, j] > max)
                    {
                        max = C[i, j];
                        maxindex = (5 * i) + j;

                    }
                    if (C[i, j] < min)
                    {
                        min = C[i, j];
                        minindex = (5 * i) + j;

                    }
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int counter = 0;
            if (maxindex < minindex)
            {
                foreach (int i in C)
                {
                    if (counter > maxindex && counter < minindex)
                    {
                        totalsum += i;
                    }
                    counter++;
                }
            }
            if (maxindex > minindex)
            {
                foreach (int i in C)
                {
                    if (counter < maxindex && counter > minindex)
                    {
                        totalsum += i;
                    }
                    counter++;
                }
            }
            Console.WriteLine("sum: " + totalsum + " maxindex: " + maxindex + " minindex: " + minindex);
            #endregion

            #region 3
            Console.WriteLine("Enter a string in EN:");
            string s = Console.ReadLine();
            Console.WriteLine(s);
            char[] charArray = s.ToCharArray();
            Console.WriteLine("Encrypt(1) or Decrypt(2)?");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    foreach (char i in charArray)
                    {
                        if ((int)i == 32)
                        {
                            Console.Write(" ");
                        }
                        else if ((int)i >= 120)
                        {
                            char a = (char)((3 - (122 - (int)i)) + 96);
                            Console.Write(a);
                        }
                        else if ((int)i >= 88)
                        {
                            char a = (char)((3 - (90 - (int)i)) + 64);
                            Console.Write(a);
                        }
                        else
                        {
                            char a = (char)((int)i + 3);
                            Console.Write(a);
                        }
                    }
                    break;
                case 2:
                    foreach (char i in charArray)
                    {
                        if ((int)i == 32)
                        {
                            Console.Write(" ");
                        }
                        else if ((int)i <= 99)
                        {
                            char a = (char)(123 - (3 - ((int)i - 97)));
                            Console.Write(a);
                        }
                        else if ((int)i <= 67)
                        {
                            char a = (char)(91 - (3 - ((int)i - 65)));
                            Console.Write(a);
                        }
                        else
                        {
                            char a = (char)((int)i - 3);
                            Console.Write(a);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            Console.WriteLine();

            #endregion

            #region 4
            int[,] arr1 = new int[4, 4];
            int[,] arr2 = new int[4, 4];
            int[,] arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)

                {
                    arr1[i, j] = r.Next(1, 10);
                    Console.Write(arr1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)

                {
                    arr2[i, j] = r.Next(1, 10);
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Умножить матрицу на число(1), Сложить две матрицы(2), Умножить две матрицы(3): ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
             
                case 1:
                    Console.WriteLine("Число?");
                    int number = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < arr2.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr2.GetLength(1); j++)

                        {
                            arr1[i,j] *= number;
                            Console.Write(arr1[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    if (arr1.GetLength(1) != arr2.GetLength(1) || arr1.GetLength(0) != arr2.GetLength(0))
                    {
                        Console.WriteLine("Error");
                    }
                    else
                    {
                        for (int i = 0; i < arr2.GetLength(0); i++)
                        {
                            for (int j = 0; j < arr2.GetLength(1); j++)

                            {
                                arr1[i, j] += arr2[i, j];
                                Console.Write(arr1[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                case 3:
                    if (arr1.GetLength(2) != arr2.GetLength(1))
                    {
                        Console.WriteLine("Error");
                    }
                    else
                    {
                        for (int i = 0; i < arr1.GetLength(0); i++)
                        {
                            for (int j = 0; j < arr2.GetLength(1); j++)

                            {
                                for (int k = 0; k < arr1.GetLength(1); k++)
                                {
                                    arr3[i, j] = arr1[i, k] * arr2[k, j];
                                    Console.WriteLine(arr3[i, j] + " ");
                                }
                            }
                            Console.WriteLine();
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            #endregion





        }
    }
}
