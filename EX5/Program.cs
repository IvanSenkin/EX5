using System;

namespace EX5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("" +
                "введите логин, по правилу: \n-от 2 до 10 символов,\n-только буквы " +
                "латинского алфавита,\n-два первых символа должны быть цифры:");
            Console.WriteLine("");
            while (true)
            {
                string P = Console.ReadLine();
                char[] arr;
                arr = P.ToCharArray();
                int i = new int();
                if (P.Length > 2 && P.Length <= 10)
                {
                    if (char.IsDigit(arr[0]) && char.IsDigit(arr[1]))
                    {
                        for (i = 2; i < P.Length;)
                        {
                            if (char.IsDigit(arr[i]) || (char.IsLower(arr[i]) && arr[i] >= 'a' && arr[i] <= 'z'))
                            {
                                i++;
                            }
                            else
                            {
                                Console.WriteLine("Введен верний регистр или не латинские символы\nПопробуйте еще раз\n");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Первые два символа не цифры\nПопробуйте еще раз\n");
                    }
                }
                else
                {
                    Console.WriteLine("Не верная длина\nПопробуйте еще раз\n");
                }
                if (i == P.Length) // мне не нравится логика по которой я определяю, что все элементы массиа норм
                {
                    Console.WriteLine("Верно!\n");
                }
            }
        }
    }
}
