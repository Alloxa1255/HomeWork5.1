using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    internal class Program
    {
        /// <summary>
        /// Пауза
        /// </summary>
        static void Pause()
        {
            Console.ReadLine();
        }
        /// <summary>
        /// Перестановка слов в предложении.
        /// </summary>
        /// <param name="inputPhrase"></param>
        /// <returns></returns>
        static string ReverseString(string inputPhrase)
        {
            string[] stringParts = SplitText(inputPhrase);
            string resultString = "";
            for (int i = stringParts.Length - 1; i >= 0; i--)
            {
                resultString += stringParts[i] + " ";
            }
            Console.WriteLine($"{resultString}");
            return resultString;
        }
        /// <summary>
        /// Разделение введенного текста на массив слов.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string[] SplitText(string text)
        {
            return text.Split();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст который нужно реверсировать: ");
            string inputPhrase = Console.ReadLine();
            ReverseString(inputPhrase);
            Pause();
        }
    }
}
