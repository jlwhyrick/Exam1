using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ExamApp
{
    public class Control
    {
        private Book _book;
        private BindingList<Book> _bookList = new BindingList<Book>();

        public Control()
        {
            _bookList.AllowEdit = true;
        }

        public void Synchronize()
        {

        }

        public void OpenBook(Book book)
        {

        }

        public void PageSelect(int i)
        {

        }

        public void FlipPage(Direction dir)
        {

        }

        public void Set(int i)
        {

        }

        public void Remove(int i)
        {

        }

        public List<string> CreateBookLibrary()
        {

        }
    }
}
