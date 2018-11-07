using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop_Web_App_Lab_21.Controllers
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
        public static bool IsDigit(char[] phoneArray)
        {
            
            foreach (char c in phoneArray)
                {
                    if (!(char.IsDigit(c)))
                    {
                        return false;
                    }
                }
            return true;
            
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
        public static bool ValidPhone(string input)
        {
            bool valid = true;
            try
            {
                string first, second, third, phoneDigits;
                

                if (input.Length == 12)
                {
                    first = input.Substring(0, 3);
                    second = input.Substring(4, 3);
                    third = input.Substring(8, 4);
                    phoneDigits = first + second + third;

                    char[] inputArray = input.ToCharArray();
                    char[] phoneArray = phoneDigits.ToCharArray();

                    if (!(inputArray[3] == '-' && inputArray[7] == '-'))
                    {
                        valid = false;
                    }

                    if (!(IsDigit(phoneArray)))
                    {
                        valid = false;
                    }

                }
                else
                {
                    valid = false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please Try Again:");
            }
            return valid;
        }
        public static bool TruePW(string trying)
        {
            if ((trying.Length > 6 && trying.Length <16))
            {
                char[] tryArray = trying.ToCharArray();
                foreach (char c in tryArray)
                {
                    if (!(char.IsDigit(c) || char.IsLetter(c)))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
