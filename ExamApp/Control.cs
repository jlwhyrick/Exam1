using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;

namespace ExamApp
{
    public class Control
    {
        private Book _book;
        public BindingList<Book> BookList = new BindingList<Book>();

        public Control()
        {
            BookList.AllowEdit = true;
        }

        public void Synchronize()
        {
            BookList = CreateBookLibrary();
        }

        public Book OpenBook(int bookIndex)
        {
            _book = BookList[bookIndex];
            return _book;
        }

        public void PageSelect(int i)
        {
            _book.CurPageNum = i;
        }

        public void FlipPage(Direction dir)
        {
            if(dir == Direction.backward)
            {
                _book.CurPageNum--;
            }
            else
            {
                _book.CurPageNum++;
            }
        }

        public void Set(int i)
        {
            _book.AddBookmark(i);
        }

        public void Remove(int i)
        {
            _book.RemoveBookmark(i);
        }

        public BindingList<Book> CreateBookLibrary()
        {
            BindingList<Book> BookList = new BindingList<Book>();
            using (StreamReader stream = new StreamReader("BookLibrary.txt"))
            {
                while (!stream.EndOfStream)
                {
                    string line = stream.ReadLine();
                    string[] info = line.Split(',');
                    Book newBook = new Book(Convert.ToInt32(info[0]), info[1], info[2]);
                    BookList.Add(newBook);
                }
            }
            return BookList;
        }

        public Book GetBook()
        {
            return _book;
        }
    }
}
