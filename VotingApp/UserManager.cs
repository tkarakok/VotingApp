using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
{
    class UserManager
    {
        public List<Users> usersDirectors = new List<Users>();

        public void UserAdd(Users usersDirector)
        {
            usersDirector.Reset();
            usersDirector.SetUser();
            usersDirectors.Add(usersDirector);
            Console.Clear();
        }

        public void UserSort()
        {
            foreach (var item in usersDirectors)
            {
                item.GetUser();
            }
        }

        public bool VoteUserCheck(string userName)
        {
            foreach (var item in usersDirectors)
            {
                if (item.CheckUser(userName))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
