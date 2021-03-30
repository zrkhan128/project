using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Assignment
{
   public class User
    {
        //class properties
        public string Name { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }

        //class constructor
        public User(string name,int id,string password)
        {
            this.Name = name;
            this.Id = id;
            this.Password = password;
        }
        //login function
        public bool Login(User user)
        {
            //clear console
            Console.Clear();
            Validation validation = new Validation();
            //prompt user to provide login details
            Console.Write("What's your User ID?  ");
            //check wether user is valid or not
            int userId = validation.IsValidInteger(Console.ReadLine());
          
          //  Console.WriteLine();
            Console.Write("What's your password? ");
           // Console.WriteLine();
            //check password wether it is valid or not
            string password = validation.IsValidString(Console.ReadLine());

            //return user object for above username and password
            if (userId == user.Id && password == user.Password)
                return true;
            return false;
             
        }
       
    }
}
