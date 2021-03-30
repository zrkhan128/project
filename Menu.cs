using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Assignment
{
    public class Menu
    {
        //private members of class
        private List<string> menuList;
        private String Title;
        public void Init(string title,string[] menuOptions)
        {
            this.menuList = menuOptions.ToList();
            this.Title = title;
        }
        //Display main menu on
        //screen along with title
        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("********");
            Console.Write(Title);
            Console.Write("********");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            //For each loop to print menu items
            menuList.ForEach(x => Console.WriteLine(x));
           
        }
    }
}
