using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
{
    class Users : IUsersDirector
    {
        public string name;
        public string surName;
        public string userName;
       

        Users users;

        public void Reset()
        {
            users = new Users();
        }

        public void SetUser()
        {
            Console.Write(" ENTER USER NAME :");
            users.name = Console.ReadLine();
            Console.Write(" ENTER USER SURNAME :");
            users.surName = Console.ReadLine();
            Console.Write(" ENTER USER USERNAME :");
            users.userName = Console.ReadLine();
        }

        public void GetUser()
        {
            Console.WriteLine("");
            Console.WriteLine(" USER NAME        : {0}" , users.name);
            Console.WriteLine(" USER SURNAME     : {0}" , users.surName);
            Console.WriteLine(" USER USERNAME    : {0}" , users.userName);
        }

        public bool CheckUser(string userName)
        {
            if (users.userName.Contains(userName))
            {
                return true;
            }
            return false;
        }

    }
}
