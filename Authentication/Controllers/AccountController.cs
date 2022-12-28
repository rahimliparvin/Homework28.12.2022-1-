using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Practices_26._12._2022.Controllers
{
    public class AccountController
    {
        public void Login()
        {
            Console.WriteLine("Add email:");
            string email = Console.ReadLine();

            Console.WriteLine("Add password:");
            string password = Console.ReadLine();

            int roleId = 1;

            IAccountService account = new AccountService();

            string result = account.Login(email, password, roleId);
            Console.WriteLine(result);
        }
    }
}
