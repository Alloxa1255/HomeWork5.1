using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Test
{
    internal class Program
    {
        static void Pause()
        {
            Console.ReadLine();
        }
        /// <summary>
        /// Разделение введеного текста на массив слов.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string[] Split(string text)
        {
            return text.Split();
        }
        /// <summary>
        /// Вывод на экран полученног массива.
        /// </summary>
        /// <param name="arr"></param>
        static void PrintText(string[] arr)
        {
            foreach (string e in arr)
                Console.WriteLine($"Слово: {e}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст который нужно разделить на слова: ");
            PrintText(Split(Console.ReadLine()));
            Pause();
        }
    }
}
