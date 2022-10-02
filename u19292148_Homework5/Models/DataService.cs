using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace u19292148_Homework5.Models
{
    public class DataService
    {
        private String ConnectionString;
        public static List<ClassList> details = null;
        public static List<AuthorList> authorLists = null;
        public static List<TypeList> typeLists = null;

        public DataService()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            details = new List<ClassList>();
            details.Add(new ClassList { List = "9A", Value = "9A" });
            details.Add(new ClassList { List = "9B", Value = "9B" });
            details.Add(new ClassList { List = "9C", Value = "9C" });
            details.Add(new ClassList { List = "9D", Value = "9D" });
            details.Add(new ClassList { List = "9E", Value = "9E" });
            details.Add(new ClassList { List = "10A", Value = "10A" });
            details.Add(new ClassList { List = "10B", Value = "10B" });
            details.Add(new ClassList { List = "10C", Value = "10C" });
            details.Add(new ClassList { List = "10D", Value = "10D" });
            details.Add(new ClassList { List = "10E", Value = "10E" });
            details.Add(new ClassList { List = "11A", Value = "11A" });
            details.Add(new ClassList { List = "11B", Value = "11B" });
            details.Add(new ClassList { List = "11C", Value = "11C" });
            details.Add(new ClassList { List = "11D", Value = "11D" });
            details.Add(new ClassList { List = "11E", Value = "11E" });
            details.Add(new ClassList { List = "12A", Value = "12A" });
            details.Add(new ClassList { List = "12B", Value = "12B" });
            details.Add(new ClassList { List = "12C", Value = "12C" });
            details.Add(new ClassList { List = "12D", Value = "12D" });
            details.Add(new ClassList { List = "12E", Value = "12E" });

            authorLists = new List<AuthorList>();
            authorLists.Add(new AuthorList { List = "Howells", Value = "Howells" });
            authorLists.Add(new AuthorList { List = "Brown", Value = "Brown" });
            authorLists.Add(new AuthorList { List = "London", Value = "London" });
            authorLists.Add(new AuthorList { List = "Blaisdell", Value = "Blaisdell" });
            authorLists.Add(new AuthorList { List = "Butler", Value = "Butler" });
            authorLists.Add(new AuthorList { List = "Machen", Value = "Machen" });
            authorLists.Add(new AuthorList { List = "Lucretius", Value = "Lucretius" });
            authorLists.Add(new AuthorList { List = "Tagore", Value = "Tagore" });
            authorLists.Add(new AuthorList { List = "Asimov", Value = "Asimov" });
            authorLists.Add(new AuthorList { List = "Dickens", Value = "Dickens" });
            authorLists.Add(new AuthorList { List = "Emerson", Value = "Emerson" });
            authorLists.Add(new AuthorList { List = "Canfield", Value = "Canfield" });
            authorLists.Add(new AuthorList { List = "Boccaccio", Value = "Boccaccio" });
            authorLists.Add(new AuthorList { List = "Orwell", Value = "Orwell" });
            authorLists.Add(new AuthorList { List = "Ovid", Value = "Ovid" });
            authorLists.Add(new AuthorList { List = "Stevenson", Value = "Stevenson" });
            authorLists.Add(new AuthorList { List = "Woolf", Value = "Woolf" });
            authorLists.Add(new AuthorList { List = "Eliot", Value = "Eliot" });
            authorLists.Add(new AuthorList { List = "Edwards", Value = "Edwards" });
            authorLists.Add(new AuthorList { List = "Dostoevsky", Value = "Dostoevsky" });
            authorLists.Add(new AuthorList { List = "Dickinson", Value = "Dickinson" });
            authorLists.Add(new AuthorList { List = "Ferber", Value = "Ferber" });
            authorLists.Add(new AuthorList { List = "LeFanu", Value = "LeFanu" });
            authorLists.Add(new AuthorList { List = "DosPassos", Value = "DosPassos" });
            authorLists.Add(new AuthorList { List = "Stuart", Value = "Stuart" });
            authorLists.Add(new AuthorList { List = "Nabokov", Value = "Nabokov" });
            authorLists.Add(new AuthorList { List = "Spyri", Value = "Spyri" });
            authorLists.Add(new AuthorList { List = "Dowson", Value = "Dowson" });
            authorLists.Add(new AuthorList { List = "Foote", Value = "Foote" });
            authorLists.Add(new AuthorList { List = "Grey", Value = "Grey" });
            authorLists.Add(new AuthorList { List = "Lovecraft", Value = "Lovecraft" });
            authorLists.Add(new AuthorList { List = "Pepys", Value = "Pepys" });
            authorLists.Add(new AuthorList { List = "Sweetser", Value = "Sweetser" });
            authorLists.Add(new AuthorList { List = "Lampton", Value = "Lampton" });
            authorLists.Add(new AuthorList { List = "Goose", Value = "Goose" });
            authorLists.Add(new AuthorList { List = "Abbott", Value = "Abbott" });


            typeLists = new List<TypeList>();
            typeLists.Add(new TypeList { List = "Science fiction", Value = "Science fiction" });
            typeLists.Add(new TypeList { List = "Satire", Value = "Satire" });
            typeLists.Add(new TypeList { List = "Drama", Value = "Drama" });
            typeLists.Add(new TypeList { List = "Action and Adventure", Value = "Action and Adventure" });
            typeLists.Add(new TypeList { List = "Romance", Value = "Romance" });
            typeLists.Add(new TypeList { List = "Mystery", Value = "Mystery" });
            typeLists.Add(new TypeList { List = "Horror", Value = "Horror" });
            typeLists.Add(new TypeList { List = "Health", Value = "Health" });
            typeLists.Add(new TypeList { List = "Guide", Value = "Guide" });
            typeLists.Add(new TypeList { List = "Diaries", Value = "Diaries" });
            typeLists.Add(new TypeList { List = "Comics", Value = "Comics" });
            typeLists.Add(new TypeList { List = "Diaries", Value = "Diaries" });
            typeLists.Add(new TypeList { List = "Journals", Value = "Journals" });
            typeLists.Add(new TypeList { List = "Biographies", Value = "Biographies" });
            typeLists.Add(new TypeList { List = "Fantasy", Value = "Fantasy" });
            typeLists.Add(new TypeList { List = "History", Value = "History" });
            typeLists.Add(new TypeList { List = "Science", Value = "Science" });
            typeLists.Add(new TypeList { List = "Art", Value = "Art" });

        }

        public List<Student> getAllStudents(string searchText,string selectClass)
        {
            List<Student> students = new List<Student>();

            using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string SqlQuery = "Select * from students where name like '%" +searchText+ "%' and class like  '%" +selectClass+ "%'";
                SqlCommand cmd = new SqlCommand(SqlQuery, connection);

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Student details = new Student();

                        details.StudentID = Convert.ToInt32(reader["studentId"]);
                        details.StudentName = reader["name"].ToString();
                        details.StudentSurname = reader["surname"].ToString();
                        details.StudentBirthDate = reader["birthdate"].ToString();
                        details.StudentGender = reader["gender"].ToString();
                        details.StudentClass = reader["class"].ToString();
                        details.StudentPoint = Convert.ToInt32(reader["point"]);


                        students.Add(details);
                    }
                }
            }
            return students;
        }


        public List<Book> getAllBooks(string searchText,string authorText,string typeText)
        {
            List<Book> books = new List<Book>();

            using(SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string SqlQuery = "Select books.bookId, books.name,authors.surname,types.name as typeNames,books.pagecount,books.point from books inner join authors" +
                                   " on books.authorId = authors.authorId" +
                                    " inner join types" +
                                    " on books.typeId = types.typeId" +
                                    " where books.name like '%" + searchText + "%' and authors.surname like '%" +authorText + "%' and types.name like '%" + typeText +"%'"; 
                SqlCommand cmd = new SqlCommand(SqlQuery, connection);

                using(SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Book book = new Book();

                        book.BookID = Convert.ToInt32(reader["bookId"]);
                        book.BookName = reader["name"].ToString();
                        book.Author.AuthorSurname = reader["surname"].ToString();
                        book.Type.TypeName = reader["typeNames"].ToString();
                        book.PageCount = Convert.ToInt32(reader["pagecount"]);
                        book.Point = Convert.ToInt32(reader["point"]);

                        books.Add(book);
                    }
                }
            }
            return books;
        }

       public List<Borrow> viewSelectedBook(int bookID)
        {
            List<Borrow> borrows = new List<Borrow>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string SqlQuery = "select borrows.borrowId,borrows.takenDate, borrows.broughtDate,students.name,students.surname from borrows" +
                                   " inner join students on borrows.studentId = students.studentId inner join books" + 
                                    " on borrows.bookId = books.bookId where books.bookId = " + bookID +
                                    " ORDER BY borrows.borrowId desc";

                SqlCommand cmd = new SqlCommand(SqlQuery, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Borrow borrow = new Borrow();

                        borrow.BorrowID = Convert.ToInt32(reader["borrowId"]);
                        borrow.TakenDate = reader["takenDate"].ToString();
                        borrow.BroughtDate = reader["broughtDate"].ToString();
                        borrow.Student.StudentName = reader["name"].ToString();
                        borrow.Student.StudentSurname = reader["surname"].ToString();
                        

                        borrows.Add(borrow);

                    }
                }
            }
            return (borrows);
        }

        public List<Borrow> getBorrowID(int ID)
        {
            List<Borrow> borrows = new List<Borrow>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string SqlQuery = "select borrowId from borrows where bookId = " + ID + " and broughtDate is null";

                SqlCommand cmd = new SqlCommand(SqlQuery, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Borrow borrow = new Borrow();

                        borrow.BorrowID = Convert.ToInt32(reader["borrowId"]);

                        borrows.Add(borrow);
                    }
                        
                }
            }
            return (borrows);
        }

        public void BorrowBook(int studentID,int bookID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string SqlQuery = "Insert into borrows(studentId,bookId,takenDate,broughtDate) values(" + studentID + "," + bookID +",GETDATE(),null)";
            SqlCommand command = new SqlCommand(SqlQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void ReturnBook(int borrowID)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string SqlQuery = "Update borrows set broughtDate = GETDATE() where borrowId = " + borrowID;
            SqlCommand command = new SqlCommand(SqlQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}