using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_OPP
{
    abstract class Account
    {
        public string PasswordChecker(string passw)
        {
            char[] password = passw.ToCharArray();
            foreach(char i in password)
            {
                if(password.Length>=8 && Char.IsUpper(password[i]) == true)
                {
                    Console.WriteLine(i);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("shifre yanliw daxil edilib !!!");
                    Console.ReadKey();
                }
                
                return passw;
            }
        }
        public void ShowInfo()
        {
            

        }
    }
    class User : Account
    {
        public string fullname;
        public string email;
        public string password;

    }
}
