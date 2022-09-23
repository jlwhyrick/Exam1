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

        public Book OpenBook(int bookIndex)
        {
            _book = _bookList[bookIndex]
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
            _book.MarkList.Add(i);
        }

        public void Remove(int i)
        {
            _book.MarkList.Remove(i);
        }

        public List<string> CreateBookLibrary()
        {
            using (StreamReader stream = new StreamReader("BookLibrary.txt"))
            {
                while (!stream.EndOfStream)
                {
                    string line = stream.ReadLine();
                    string[] info = line.Split(',');
                    Book newBook = Book(Convert.ToInt32(info[0]), info[1], info[2]);
                    _bookList.Add(newBook);
                }
            } 
        }
    }
}
