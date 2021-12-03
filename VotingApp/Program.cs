using System;

namespace VotingApp
{
    class Program : UserManager
    {
        static void Main(string[] args)
        {
            CategoryManager categoryManager = new();
            UserManager userManager = new();
         
            MainMenu(categoryManager, userManager);
        }

        public static void MainMenu(CategoryManager categoryManager, UserManager userManager)
        {
            Console.WriteLine(" welcome to voting app ");
            Console.WriteLine(" please select process which one you want \n 1 - Category Add \n 2 - Category Sort \n 3 - User Add \n 4 - User Sort \n 5 - Vote Category \n 6 - See Results");
            int choose = Convert.ToInt32(Console.ReadLine());
            Process(choose, categoryManager, userManager);
        }

        public static void Process(int param, CategoryManager categoryManager, UserManager userManager)
        {
            Console.Clear();
            switch (param)
            {
                case 1:
                    Category category = new();
                    categoryManager.CategoryAdd(category);
                    MainMenu(categoryManager, userManager);
                    
                    break;
                case 2:
                    Console.Clear();
                    categoryManager.CategorySort();
                    BackToMenu(categoryManager, userManager);
                    break;
                case 3:
                    Console.Clear();
                    Users users = new Users();
                    userManager.UserAdd(users);
                    MainMenu(categoryManager, userManager);
                    break;
                case 4:
                    Console.Clear();
                    userManager.UserSort();
                    BackToMenu(categoryManager,userManager);
                    break;
                case 5:
                    Console.Clear();
                    Vote(categoryManager,userManager);
                    break;
                case 6:
                    Console.Clear();
                    Results(categoryManager,userManager);
                    break;
                default:
                    break;
            }
        }

        public static void BackToMenu(CategoryManager categoryManager, UserManager userManager)
        {
            top:
            Console.WriteLine(" Back to main menu enter input 'y' ");
            string menu = Console.ReadLine();
            if (menu == "y")
            {
                Console.Clear();
                MainMenu(categoryManager,userManager);
            }
            else
            {
                Console.WriteLine(" wrong input value please enter 'y' on keyboard ");
                goto top;
            }
        }

        public static void Vote(CategoryManager categoryManager, UserManager userManager)
        {
            again:
            Console.Clear();
            Console.WriteLine(" PLEASE ENTER USERNAME ");
            string userName = Console.ReadLine();
            if (userManager.VoteUserCheck(userName))
            {
                Console.Clear();
                Console.WriteLine(" succesfully logined vote system");
                categoryManager.CategorySort();
                Console.WriteLine(" \n Please write the category id you want to vote for \n");
                int categoryName = Convert.ToInt32(Console.ReadLine());
                categoryManager.categories[categoryName - 1].Vote += 1;
                Console.WriteLine(categoryManager.categories[categoryName - 1 ].Vote);
                MainMenu(categoryManager,userManager);
            }
            else
            {
                register:
                Console.WriteLine(" please correct username or register system \n 1 - Try Again \n 2 - Register");
                int choose = Convert.ToInt32(Console.ReadLine());
                if (choose == 1)
                {
                    goto again;
                }
                else if (choose == 2)
                {
                    Console.Clear();
                    Users users = new Users();
                    userManager.UserAdd(users);
                    goto again;
                }
                else
                {
                    Console.WriteLine(" wrong input value please enter valid value");
                    goto register;
                }
            }
                
            
        }

        public static void Results(CategoryManager categoryManager, UserManager userManager)
        {
            categoryManager.GetResults();
            BackToMenu(categoryManager,userManager);
        }
    }
}
