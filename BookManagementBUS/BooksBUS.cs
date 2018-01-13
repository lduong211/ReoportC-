using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookManagementDAL;

namespace BookManagementBUS
{
    public class BooksBUS
    {
        BookContext booksBUS = new BookContext();

        /// <summary>
        /// show all list books
        /// </summary>
        /// <returns></returns>
        public List<Sach> LoadBooks()
        {
            return booksBUS.LoadBooks();
        }
    }
}
