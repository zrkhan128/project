using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Assignment
{
    public class App
    {
        private User mainUser;
        Menu menu;
        public App()
        {
            //instantiate default user object
            User user = new User("demo",123456789,"password");
            this.mainUser = user;
           //instantiate menu object
            menu = new Menu();
            //menu list options
            menu.Init("Main Menu", new string[] { "1. Login", "2. About", "3. Exit" });
            menu.Display();
            Selection();

        }
        public void Selection()
        {
            //execute menu option on user choice
            Validation validation = new Validation();
            Console.WriteLine();
            Console.Write("Please make your selection: ");
            int choice = validation.IsValidInteger(Console.ReadLine());
            switch (choice)
            {
                
                case 1:
                    bool loggedIn = mainUser.Login(mainUser);
                    //if login successfull show success message
                    if (loggedIn)
                    {
                        Console.WriteLine();
                        Console.WriteLine("User Found!");
                    }
                    //otherwise show user not found
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("User details not found.");
                    }
                    Continue();
                    break;
                case 2:
                    About();
                    Continue();
                    break;
                case 3:
                    Exit();
                    Continue();
                    break;
                default:
                    Continue();
                    break;
            }
        }

        private void Continue()
        {
            Console.WriteLine();
            
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            
            menu.Display();
            Selection();
        }

        private void Exit()
        {
            Console.Clear();
            Console.WriteLine("Exiting...");
            Console.ReadKey();
            Environment.Exit(0);
        }

        private void About()
        {
            Console.Clear();
            Console.WriteLine("This is the about section");
        }
    }
}
