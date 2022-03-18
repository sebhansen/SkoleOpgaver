using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ex15_Disaheim
{
    public class Controller
    {
        public List<Book> Books;
        public List<Amulet> Amulets;
        public List<Course> Courses;

        public Controller() 
        {
            Books = new List<Book>();
            Amulets = new List<Amulet>();
            Courses = new List<Course>();
        }
        public void AddToList(Book book)
        {
            Books.Add(book);
        }

        public void AddToList(Amulet amulet)
        {
            Amulets.Add(amulet);
        }
        public void AddToList(Course course)
        {
            Courses.Add(course);
        }
    }
}
