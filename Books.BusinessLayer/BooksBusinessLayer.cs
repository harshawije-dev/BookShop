using Books.BusinessLayer.Common;
using Books.DataAccess;
using Books.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.BusinessLayer
{
    public class BooksBusinessLayer : CommonBase
    {
        public BooksBusinessLayer() { }

        public List<BooksModel> SaveBookDB(List<BooksModel> booksModel)
        {
            var isbnNumber = (from mo in booksModel
                                 select mo.ISBN).First();

            
            BookAuthentication(isbnNumber);
            return booksModel;
        }
        
        private static string BookAuthentication(int isbnNumber)
        {
            string result = "Default...";

            using (BooksDataAccess booksDataAccess = new BooksDataAccess())
            {
                var getIdintityNumber = booksDataAccess.SelectBooks();
                if (getIdintityNumber.Count != 0)
                {
                    result = "ISBN Number already Exsits";
                }
                else
                {
                    result = "No record found";
                }
            }

            return result;
        }
    }
}
