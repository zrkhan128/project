using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Assignment
{
    class Validation
    {
        //Method to check for null string
        public string IsValidString(string text)
        {
            while (text.Trim().Length <= 0)
            {
                Console.Write("\nInvalid string size, enter valid string: ");
                text = Console.ReadLine();
            }
            return text;
        }
        //Method to validate integer
        public int IsValidInteger(string input)
        {
            int number;
            while (!int.TryParse(input, out number))
            {
                Console.Write("\nInvalid enter, Plz enter valid number: ");
                input = Console.ReadLine();
            }
            return number;
        }
        //Method to validate number in range
        public bool IsNumberInRange(int number,int start,int end)
        {
            if (number > start && number < end)
                return true;
            return false;
        }

        internal string IsValidTheme(string v)
        {
            //loop untill user provide valid theme name
            string theme=v;
          while(!theme.Equals("light") && !theme.Equals("dark"))
            {
                Console.WriteLine("Plz enter valid theme name , light or dark.");
                theme = Console.ReadLine();
            }
            return theme;
        }
    }
}
