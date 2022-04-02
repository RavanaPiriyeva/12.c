using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public static  class ExtentionMethods
    {
        public static bool CheckGroupNo(this string str)
        {
            int count = 0;
            if (str.Length == 4 && char.IsUpper(str[0]))
            {
                for (int i = 1; i < str.Length; i++) 
            {
               
            if(char.IsDigit(str[i]) )
                {
                        count++;
                }
            if (count == 3)
                    {
                        return true;
                    }
                    }
            }
            return false;
        }
        public static bool CheckFullname(this string str)
        {
            var result = str.Split(" ");
            if(result.Length == 2)
            {
                if(char.IsUpper(result[0][0]) && char.IsUpper((char)result[1][0])&& result[0].Length>2 && result[1].Length>2)
                {
                    return true;
                }


            }
            return false;

        }
    }
}
