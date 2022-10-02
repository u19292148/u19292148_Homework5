using System;
using System.Linq;
using System.Web.Mvc;
using u19292148_Homework5.Models;
using System.Collections.Generic;



namespace u19292148_Homework5.Controllers
{
    
    public class HomeController : Controller
    {
        private DataService dataService = new DataService();
        public int empty;
        public ActionResult Index(string searchText, string authorText, string typeText)
        {
            List<Book> books = dataService.getAllBooks(searchText,authorText,typeText);
           
            
            if (empty == 0)
            {
                ViewBag.check = "Available";
            }
            else
            {
                ViewBag.check = "Out";
            }
            return View(books);
        }


        public ActionResult ViewStudents(string searchText, string selectClass,string bookID, string IDBorrow)
        {
            List<Student> students = dataService.getAllStudents(searchText,selectClass);
            ViewBag.Text = bookID;
            ViewBag.borrow = IDBorrow;
            return View(students);
        }

        public ActionResult ViewBook(int bookID, string bookName)
        {
            
            List<Borrow> borrows = dataService.viewSelectedBook(bookID);
            List<Borrow> borrows1 = dataService.getBorrowID(bookID);
            var temp = borrows1.Select(a => a.BorrowID).FirstOrDefault();
            ViewBag.Temp = temp; 
            ViewBag.Text = bookID;
            ViewBag.BookName = bookName;
             empty = borrows.Count(x => x.BroughtDate == "");
            if (empty == 0)
            {
                ViewBag.check = "- Book Available";
            }
            else
            {
                ViewBag.check = "- Book Out";
            }
            
            return View(borrows);
            
        }

        public ActionResult BorrowBook(int studentID, int bookID)
        {
           
            dataService.BorrowBook(studentID,bookID);
            return RedirectToAction("ViewBook", new { bookID = bookID});
        }

        public ActionResult ReturnBook(int borrowID, int IDbook)
        {
            dataService.ReturnBook(borrowID);
            return RedirectToAction("ViewBook", new { bookID = IDbook });
        }



        




    }
}