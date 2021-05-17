using System;

namespace EX_5._2
{
    public class Message
    {
        public static char[] textArr;
        public static int k;
        public static int max;
        public static void Message1(string text, int n)
        {
            var textArr = text.Split(new char[] { ' ' });

            foreach (var item in textArr)
            {
                if (item.Length <= n)
                {
                    Console.WriteLine(item);
                    k++;
                }
            }
        }
        public static void Message2(string text, char v)
        {
            var textArr = text.Split(new char[] { ' ' });

            foreach (var item in textArr)
            {
                var textArr2 = item.ToCharArray();

                if (v != textArr2[item.Length - 1])
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static void Message3(string text)
        {
            var textArr = text.Split(new char[] { ' ' });
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (textArr[i].Length > max)
                {
                    max = textArr[i].Length;
                    Console.WriteLine(textArr[i]);
                }

            }
        }
    }
}
