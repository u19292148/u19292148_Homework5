using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u19292148_Homework5.Models
{
    public class Borrow
    {
        public int BorrowID { get; set; }
        public Student Student { get; set; }
        public Book Book { get; set; }
        public String TakenDate { get; set; }
        public String BroughtDate { get; set; }

        public Borrow()
        {
            Student = new Student();
            Book = new Book();
        }
    }
}