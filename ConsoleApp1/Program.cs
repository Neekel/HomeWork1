using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    class Program
    {

        static void Main(string[] args)
        {
            //Задание 5.Дано целое число N(> 0), найти число, полученное при прочтении
            //числа N справа налево. Например, если было введено число 345, то программа
            //должна вывести число 543

            Console.WriteLine("TASK 5 ");
            Console.WriteLine("Enter any big number (like: 3456789) to reverse it >>");

            string reversNum;
            string num = Console.ReadLine();
            char[] arr;

            arr = num.ToCharArray();
            Console.WriteLine($"You entered num: {num}");
            Array.Reverse(arr);
            reversNum = new string(arr);
            Console.WriteLine($"Reversed num: {reversNum}");
            Console.ReadLine();


            //Даны целые положительные числа A и B(A < B).Вывести все целые
            //числа от A до B включительно; каждое число должно выводиться на новой строке;
            //при этом каждое число должно выводиться количество раз, равное его значению. 
            //Например: если А = 3, а В = 7, то программа должна сформировать в консоли
            //следующий вывод

            Console.WriteLine("TASK 4 ");
            Console.WriteLine("Enter first number (like 6 -12");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number (like 1 -5");
            int x = int.Parse(Console.ReadLine());

            while (x <= y)
            {
                for (int i = 1; i <= x; i++)
                    Console.Write("{0}", x);
                x++;
                Console.WriteLine();
            }


            //Задание 1. Написать программу, которая считывает символы с клавиатуры, пока не 
            //будет введена точка.Программа должна сосчитать количество введенных
            //пользователем пробелов.

            Console.WriteLine("TASK 1 ");
            Console.WriteLine("Enter symbols with spaces, for end tap dot >'.' :");
            char input;
            int spaces = 0;
            do
            {
                input = Console.ReadKey().KeyChar;
                if (input == ' ')
                    spaces++;
            }
            while (input != '.');

            Console.WriteLine("\nSpaces: " + spaces);
            Console.WriteLine("\n");



            //Задание 2. Ввести с клавиатуры номер трамвайного билета (6-значное число) и проверить является ли данный билет счастливым (если на билете напечатано 
            //шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то
            //этот билет считается счастливым).
            Console.WriteLine("TASK 2 ");
            Console.WriteLine("Enter 6 numbers of your ticket: ");
            int[] number = new int[6];
            for (int k = 0; k < 6; k++)
            {
                number[k] = int.Parse(Console.ReadLine());
            }

            int sum1 = 0;
            int[] nomer1 = { number[0], number[1], number[2] };
            foreach (int w in nomer1)
                sum1 += w;
            Console.WriteLine("The sum of first 3 numbers = {0}", sum1);

            int sum2 = 0;
            int[] nomer2 = { number[3], number[4], number[5] };
            foreach (int j in nomer2)
                sum2 += j;
            Console.WriteLine("The sum of second 3 numbers = {0}", sum2);

            if (sum1 == sum2)
                Console.WriteLine("Your ticket is lucky!");
            else
                Console.WriteLine("Your ticket is no lucky.");

            Console.WriteLine("\n\n");

            //Задание 3.Числовые значения символов нижнего регистра в коде ASCII
            //отличаются от значений символов верхнего регистра на величину 32.Используя эту
            //информацию, написать программу, которая считывает с клавиатуры и конвертирует
            //все символы нижнего регистра в символы верхнего регистра и наоборот

            Console.WriteLine("TASK 3 ");
            int ascnum;
            char symbol2;
            do
            {
                Console.WriteLine("Enter big symbol to convert it ti small, press dot '.' to exit ");
                do
                {
                    ascnum = Console.Read();
                    symbol2 = (char)ascnum;
                } while (symbol2 == '\n' | symbol2 == '\r');

                if (ascnum >= 65 && ascnum <= 90)
                {
                    ascnum += 32;
                    symbol2 = (char)ascnum;
                    Console.WriteLine(symbol2);
                }
                else if (ascnum >= 97 && ascnum <= 122)
                {
                    ascnum -= 32;
                    symbol2 = (char)ascnum;
                    Console.WriteLine(symbol2);
                }
                else if (ascnum == 46)
                {
                    break;
                }
                else
                {
                    symbol2 = (char)ascnum;
                    Console.WriteLine(symbol2);
                }
            } while (ascnum != 46);

            Console.WriteLine();


            



            

        }
    }
}





