using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_6
{
    static class Class1
    {
        //3)
       
            public static int GetLetterCount(this string str, char c)
            {
                int counter = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == c)
                        counter++;
                }
                return counter;
            }
        }
    }
}
