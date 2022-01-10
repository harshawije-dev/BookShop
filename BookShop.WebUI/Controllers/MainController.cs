using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Books.Model;
using Books.BusinessLayer;
using System.Web.Mvc;

namespace BookShop.WebUI.Controllers
{
    public class MainController : Controller
    {
        
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public JsonResult BookRegister(List<BooksModel> bookObject)
        {
            using(BooksBusinessLayer booksBusinessLayer = new BooksBusinessLayer())
            {
                booksBusinessLayer.SaveBookDB(bookObject);
            }
            return Json(bookObject);
        }
    }
}