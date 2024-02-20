using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshops
{
    class History
    {
        private Stack<Page> history;

        //constructor
        public History()
        {
            history = new Stack<Page>();
        }

        public void Add(Page page)
        {
            history.Push(page);
            Console.WriteLine($"Page added {page.Address} to history");

        }
        // Method to print history

        public void PrintHistory()
        {
            Console.WriteLine("Recent pages in history: ");
            foreach (var page in history) 
            {
                Console.WriteLine(page.Address);
            }
        }
        // Implement a method for removing last page from history
        public bool RemoveLastPage()
        {
            try
            {
                history.Pop();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public IEnumerable<Page> GetHistory()
        {
            return history.ToArray();
        }
    }
}
