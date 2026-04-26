using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Praktika.Extensions
{
    public static class StringExtension
    {
        public static string LongestWord(this string str)
        {
            string longest = "";
            string currentWord = "";

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (c == ' ' || c == '.' || c == ',' || c == '!' || c == '?' || c == ';')
                {
                    if (currentWord.Length > longest.Length)
                    {
                        longest = currentWord;
                    }
                    currentWord = "";
                }
                else
                {
                    currentWord += c;
                }
            }

            if (currentWord.Length > longest.Length)
            {
                longest = currentWord;
            }
            return longest;
        }
        public static bool IsPolindrom(this int number)
        {
            if (number < 0) return false;

            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                reversedNumber = (reversedNumber * 10) + lastDigit;
                number = number / 10;
            }
            return originalNumber == reversedNumber;
        }
        public static bool IsPrime(this int number)
        {
            for (int i = 2; i * i < number; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        public static int SumOfDigits(this int sum)
        {
            int total = 0;
            while (sum > 0)
            {
                total += sum % 10;
                sum /= 10;
            }
            return total;
        }
        public static int ReverseNumber(this int rev)
        {
            int reversed = 0;
            while (rev > 0)
            {
                reversed = reversed * 10 + rev % 10;
                rev /= 10;
            }
            return reversed;
        }
        public static bool IsArmstrong(this int number)
        {
            int originalNumber = number;
            int temp = number;
            int digitCount = 0;
            int sum = 0;
            while (temp > 0)
            {
                digitCount++;
                temp /= 10;
            }

            temp = number;
            while (temp > 0)
            {
                int digit = temp % 10;
                int powerResult = 1;
                for (int i = 0; i < digitCount; i++)
                {
                    powerResult *= digit;
                }

                sum += powerResult;
                temp /= 10;
            }
            return sum == originalNumber;
        }
        public static int SecondLargest(this int[] array)
        {
            int max1, max2;

            if (array[0] > array[1])
            {
                max1 = array[0];
                max2 = array[1];
            }
            else
            {
                max1 = array[1];
                max2 = array[0];
            }
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i] > max1)
                {
                    max2 = max1;
                    max1 = array[i];
                }
                else if (array[i] > max2 && array[i] < max1)
                {
                    max2 = array[i];
                }
            }

            if (max1 == max2)
            {
                return -1;
            }

            return max2;
        }
    }
}

