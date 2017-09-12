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
            Console.WriteLine("Введите число");
            string num = Console.ReadLine();

            int check = Check(num);
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

                string newNum = string.Join("", newArr);

                Console.WriteLine($"Зашифрованная последовательность = {newNum}");
            }
            else if (check == -1)
            {

            }

        }

        static void Deshifrovanie()
        {
            Console.WriteLine("Введите число");
            string num = Console.ReadLine();

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

            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.Write(newArr[i]);
            //}
            //Console.WriteLine();

            string newNum = string.Join("", newArr);

            Console.WriteLine($"Расшифрованная последовательность = {newNum}");
        }

        static void Main(string[] args)
        {
            Shifrovanie();

            Deshifrovanie();

            Console.ReadLine();
        }
    }
}
