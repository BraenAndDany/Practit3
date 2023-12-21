using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace practice3
{
    internal class Program
    {
        static string NumberToLetters(int number)
        {
            string result;
            if (number > 0)
            {
                int alphabets = (number - 1) / 26;
                int remainder = (number - 1) % 26;
                result = ((char)('A' + remainder)).ToString();
                if (alphabets > 0)
                    result = NumberToLetters(alphabets) + result;
            }
            else
                result = null;
            return result;
        }
        static void Main(string[] args)
        {
            //long[] digits = { 2, 6, 8, 3, 2, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,0,0,0,0,0,0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //long numb = 111;
            //long copy = 0;

            //for (int i = digits.Length-1;i>-1;i--)
            //{
            //    copy = digits[i]+numb;
            //    digits[i] = copy%10;
            //    numb = copy/10;
            //}
            //long[] sch = digits;
            //if (numb > 0)
            //{
            //    Array.Resize(ref digits, digits.Length+numb.ToString().Length);
            //    digits[0] = numb;
            //    for (int i = 0; i < digits.Length; i++)
            //    {
            //        if (i != sch.Length-1)
            //        {
            //            digits[i+numb.ToString().Length] = sch[i];

            //        }
            //        else
            //        {
            //            break;
            //        }

            //    }
            //}
            //digits[digits.Length-1] = sch[sch.Length-1];
            //for (int i = 0; i < digits.Length; i++)
            //{
            //    Console.Write(digits[i]);
            //}

            //List<int> people = new List<int>() { 4, 3, 2, 1, 3 };
            //int number = 3;
            //people.Insert(number, people[people.Count - 1]);
            //people.RemoveAt(people.Count - 1);
            //for (int i = 0; i < people.Count; i++)
            //{
            //    Console.Write(people[i] + " ");
            //}

            int number = 1712;
            Console.WriteLine(NumberToLetters(number));
        }
    }
}
