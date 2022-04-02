using System;

namespace ClassLibrary1
{
    public static class ExtentionMethods
    {

        public static bool IsOdd(this int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;

        }

        public static bool IsEven(this int num)
        {
            if (num %2 ==0)
            {
                return true;
            }
            return false;
        }
        public static bool IsContainsDigit(this string str)
        {
            foreach( var item in str) 
            {
                if (char.IsDigit(item))
                {

                    return true;
                }


            }
            return false;

        }


        public static string ToCapitalize(this string str)
        {
            string newstr = "";

            if (char.IsUpper(str[0]))
            {
                return str;
            }
            newstr = newstr + char.ToUpper(str[0]);
            for (int i=1 ; i<str.Length; i++ ) 
            {
                newstr = newstr + str[i];

            }
            return newstr;
        }

        public static int[] GetValueIndexes(this string str, char ch)
        {
            int[] intArr = new int[0];
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    Array.Resize(ref intArr, intArr.Length + 1);
                    intArr[intArr.Length - 1] = i;
                }
            }
            return intArr;
        }

    }
}
