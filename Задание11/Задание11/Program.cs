using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Задание11
{
    class Program
    {
        static int Check(string num)
        {
            if (num[0] == '-')
                return -3;

            for (int i = 0; i < num.Length; i++)
            {
                if (!char.IsDigit(num[i]))
                {
                    return -1;
                }
            }

            for (int i = 0; i < num.Length; i++)
            {
                if (int.Parse(num[i].ToString()) > 1)
                {
                    return -2;
                }
            }

            return 1;
        }

        static void Shifrovanie()
        {

            int check = 0;

            while (check <1)
            {     Console.WriteLine("Введите число");
            string num = Console.ReadLine();
             check = Check(num);
            
                if (check == 1)
                {
                    int[] arr = new int[num.Length];

                    for (int i = 0; i < num.Length; i++)
                    {
                        arr[i] = int.Parse(num[i].ToString());
                    }

                    int[] newArr = new int[num.Length];
                    newArr[0] = arr[0];

                    for (int i = 1; i < num.Length; i++)
                    {
                        if (arr[i] == arr[i - 1])
                            newArr[i] = 1;
                        else
                            newArr[i] = 0;
                    }

                    Console.WriteLine("Зашифрованная последовательность:");
                    for (int i = 0; i < num.Length; i++)
                    {
                        Console.Write(newArr[i]);
                    }
                    Console.WriteLine();

                    
                }
                else if (check == -1)
                {
                    Console.WriteLine("Ошибка. Вы ввели не число.");
                }
                else if (check == -2)
                {
                    Console.WriteLine("Ошибка. Число должно состоять только из 0 и 1");
                }

            }
        }
        static void Deshifrovanie()
        {
            int check = 0;

            while (check < 1)
            {
                Console.WriteLine("Введите число");
                string num = Console.ReadLine();
                check = Check(num);

                if (check == 1)
                {
                    int[] arr = new int[num.Length];

                    for (int i = 0; i < num.Length; i++)
                    {
                        arr[i] = int.Parse(num[i].ToString());
                    }

                    int[] newArr = new int[num.Length];
                    newArr[0] = arr[0];

                    for (int i = 1; i < num.Length; i++)
                    {
                        if (arr[i] == 0)//если ноль, то отличаются с предыдущим
                            newArr[i] = newArr[i - 1] == 1 ? 0 : 1; //если пред = 0 то 1, а если 1 то 0
                         //Convert.ToInt32((!Convert.ToBoolean(newArr[i - 1])));
                        else
                            newArr[i] = newArr[i - 1];//если эл-т 1, то повторяем пред
                    }
                    //string newNum = string.Join("", newArr);

                    Console.WriteLine($"Расшифрованная последовательность:");
                    for (int i = 0; i < num.Length; i++)
                    {
                        Console.Write(newArr[i]);
                    }
                    Console.WriteLine();
                }
                else if (check == -1)
                {
                    Console.WriteLine("Ошибка. Вы ввели не число.");
                }
                else if (check == -2)
                {
                    Console.WriteLine("Ошибка. Число должно состоять только из 0 и 1");
                }

            }
        }
        static void Main(string[] args)
        {
            Shifrovanie();

            Deshifrovanie();

            Console.ReadLine();
        }
    }
}
