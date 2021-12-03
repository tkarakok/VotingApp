using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp
{
    class Category : ICategoryDirector
    {
        private string categoryName;
        private int vote;

        Category category;

        public int Vote { get => vote; set => vote = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }

        public void SetCategory()
        {
            Console.Write(" ENTER NEW CATEGORY NAME : ");
            category.CategoryName = Console.ReadLine();
        }

        public void GetCategory()
        {
            Console.WriteLine(" CATEGORY NAME : {0}",   category.CategoryName);
        }

        
        
        public void Reset()
        {
            category = new Category();
        }

        
    }
}
