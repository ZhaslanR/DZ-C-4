using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    { 
        static void Main(string[] args)
        {
            ToDo1();
            Console.ReadLine();
        }
        private static void ToDo()
        {
            int number1, number2, result;
            Console.WriteLine("Ведите два числа для деление числитель{1} знаминатель{2}");
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            try
            {
                result = number1 / number2;
                Console.WriteLine(result);
            }
            catch (ArgumentNullException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        private static int counter = 0;
        private static void ToDo1()
        {
            int[] mas = new int[6];
            try
            {
                for(int i = 0;i<=5;i++)
                {
                    mas[i] = counter++;
                    Console.WriteLine(mas[i]);
                }
            }
            catch(IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Завершение обработки массива");
            }
        }
    }
}
