using System;

namespace EX_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.k = 0;
            Message.max = 0;
            Console.WriteLine("Введите text");
            string text = Console.ReadLine();
            Console.WriteLine("Введите n");
            int n = int.Parse(Console.ReadLine());
            Message.Message1(text, n);
            Console.WriteLine($"{Message.k}");
            Console.WriteLine("Удалить из сообщения все слова, которые заканчиваются на заданный символ.");
            char v = char.Parse(Console.ReadLine());
            Message.Message2(text, v);
            Console.WriteLine("Самое длинное слово: ");
            Message.Message3(text);

        }
    }
}
