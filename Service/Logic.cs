using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal class Logic
    {
        public List<Book> books;

        public Logic()
        {
            books = new List<Book>();
        }


        public bool AddNewBook(int Id, string Name, int amount, int edition, string synopsis)
        {

            foreach (Book item in books)
            {
                if(item.BookId == Id)
                {
                    item.StockAvailable += amount;
                    return true;
                }
            }



            return true;
        }

    }
}
