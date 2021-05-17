using System;
using System.Collections.Generic;
using System.Text;

namespace EX5._2
{
   public static class Methods
    { 
    // public static string text = Console.ReadLine();
      public static char[] textArr;
     public  static int count = 0;
      public static int j = 0;
        public static int Words(string text, int n)
        {
            textArr = text.ToCharArray();
            for (int i = j; i < textArr.Length; )
            {
                if (!char.IsWhiteSpace(textArr[j]))
                {
                    for (i = j; i < n;)
                    {
                        count++;
                        //  Console.WriteLine(char.IsLetter(textArr[i]));
                      //  Console.WriteLine(count);
                        i++;
                    }
                    return count;
                }
                else
                {
                    i++;
                    j++;
                   // count++;
                }
               // return j;
            }
            return count;
        }
    }
}
