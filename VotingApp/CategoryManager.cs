using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
{
    class CategoryManager
    {
        public List<Category> categories = new List<Category> ();
        
        public void CategoryAdd(Category categoryDirector)
        {
            categoryDirector.Reset();
            categoryDirector.SetCategory();
            categories.Add(categoryDirector);
            Console.Clear();
        }

        public void CategorySort()
        {
            foreach (var item in categories)
            {
                item.GetCategory();
            }
        }

        public void GetResults()
        {
            foreach (var item in categories)
            {
                Console.WriteLine("{0} -> {1} " , item.CategoryName, item.Vote);
                
            }
        }
    }
}
