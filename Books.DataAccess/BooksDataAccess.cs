using Books.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Books.DataAccess.Common;

namespace Books.DataAccess
{
    public class BooksDataAccess : CommonBase
    {
        private BookModelDBContext BookModelDBContext = new BookModelDBContext();
        public BooksDataAccess() { }

        
         public List<BooksModel> SelectBooks()
        {
            var findValue = BookModelDBContext.BooksModels;
            return findValue.ToList();
        }

    }
}
