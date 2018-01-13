using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementDAL
{
    public class BookContext
    {
        BookManagementEntities dbContext = new BookManagementEntities();

        /// <summary>
        /// load all list books
        /// </summary>
        /// <returns></returns>
        public List<Sach> LoadBooks()
        {
            return dbContext.Saches.ToList();
        }
    }
}
