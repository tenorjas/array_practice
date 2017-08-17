using System;
using System.Collections.Generic;
using System.Linq;

namespace array_practice
{
    class Program
    {
        public static int countMults(int[] nums, int divisibility)
        {
            if (divisibility == 0)
            {
                Console.WriteLine("Can not divide by 0.");
                return 0;
            }
            else
            {
                int divisibleCount = 0;
                foreach (var num in nums)
                {
                    if (num % divisibility == 0)
                    {
                        Console.WriteLine($"{num} is divisible by {divisibility}.");
                        divisibleCount ++;
                    }
                }
                return divisibleCount;
            }
        }

        public static bool hasThreeNonAdjacentThrees(int[] nums)
        {
            int numberOfThrees = 0;
            bool adjacentThrees = false;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 3 && nums[i+1] == 3)
                {
                    adjacentThrees = true;
                }
            }  

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 3)
                {
                    numberOfThrees ++;
                }
            }
            

            if (!adjacentThrees && numberOfThrees == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool containsString(char[] letters, string word)
        {
            var letterCount = word.Where(l => letters.Contains(l)).Count();
            //letterCount = where l(current character in word) is equal to l(current character in Letters array) add to the count
            return letterCount == word.Length;
        }

        static void Main(string[] args)
        {
            // testing countMults function
            int[] numbers = {1,2,3,5,6,7};
            int divisiBility = 2;

            var divisibilityCount = countMults(numbers, divisiBility);
            Console.WriteLine($"{divisibilityCount} numbers are divisible by {divisiBility}");

            // testing adjacent threes function
            int[] myArray = {3,1,3,1,3};
            Console.WriteLine("Does the array have exactly three non-adjacent threes?");
            Console.WriteLine(hasThreeNonAdjacentThrees(myArray));

            // testing contains word function
            char[] lettersArray = {'a','z','z','z','a','a','a','t','c','c','z'};
            string Word = "cat";

            Console.WriteLine(containsString(lettersArray, Word));
        }
    }
}
