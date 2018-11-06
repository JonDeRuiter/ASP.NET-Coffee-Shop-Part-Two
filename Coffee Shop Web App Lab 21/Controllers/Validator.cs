using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Coffee_Shop
{
    class Validator
    {

        //Methods
        public static string NotEmpty(string input)
        {
            input = input.Trim();
            try
            {
                if (input == null || input == "")
                {
                    throw new Exception("Input is empty. ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Please try again: ");
                input = NotEmpty(Console.ReadLine());
            }
            return input;
        }
        public static string IsABC(string input)
        {
            input = NotEmpty(input);
            char[] charArray = input.ToCharArray();
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (!(char.IsLetter(charArray[i])))
                    {
                        throw new Exception("This value may only contain letters.");
                    }                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Please try again: ");
                input = IsABC(Console.ReadLine());
            }
            return input;
        }
        public static string IsName(string input)
        {
            input = NotEmpty(input);
            char[] letterArray = input.ToCharArray();

            try
            {
                if (!(Char.IsUpper(letterArray[0])))
                {
                    throw new Exception("This value must start with an Uppercase letter.");
                }
                foreach (char c in letterArray)
                {
                    if (!(char.IsLetter(c)) && !(char.IsSeparator(c)))
                    {
                        throw new Exception("This value may only contain letters");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Please try again: ");
                input = IsName(Console.ReadLine());

            }
            return input;

        }
        public static int IsDigit(string input)
        {
            char[] charArray = input.ToCharArray();
            int x;
            try
            {
                for (int i = 0; i < charArray.Length; i++)
                {
                    if (!(char.IsDigit(charArray[i])))
                    {
                        throw new Exception("Entry must be an integer.");
                    }
                }
                return int.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return x = IsDigit(Console.ReadLine());
            }
        }
        public static int DigitInRange(string input, int y)
        {
            int x;
            try
            {
                x = IsDigit(input);
                if (x <= y && x > 0)
                {
                    return x;
                }
                else
                {
                    throw new Exception($"Your input {x} is not within the range of {y}.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Please try again: ");
                x = DigitInRange(Console.ReadLine(), y);
                return x;
            }
        }
        public static int DigitInRange(string input, int min, int max)
        {
            int x;
            try
            {
                x = IsDigit(input);
                if (x >= min && x <= max)
                {
                    return x;
                }
                else
                {
                    throw new Exception($"Your input {x} is not within the range of {min} to {max}.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Please try again: ");
                x = DigitInRange(Console.ReadLine(), min, max);
                return x;
            }
        }
    }
}
