using System;

namespace EX5._2
{
   //Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
  //а) Вывести только те слова сообщения, которые содержат не более n букв.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string Text = Console.ReadLine();
            Console.WriteLine("1 - Вывести слова, не более n букв");
            int v = int.Parse(Console.ReadLine());
            switch (v)
            {
                case 1:
                    Console.Write("Введите n: ");
                    int n = int.Parse(Console.ReadLine());
                    Methods.Words(Text, n);
                    Console.WriteLine();
                 break;

            }
        }
    }
}
