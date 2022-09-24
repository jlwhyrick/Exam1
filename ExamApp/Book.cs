using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;

namespace ExamApp
{
    public class Book
    {
        public int PageNum;
        public int CurPageNum;
        public BindingList<int> MarkList = new BindingList<int>();
        public string Title;
        public string Author;
        
        public Book( int pageNum, string title, string author)
        {
            PageNum = pageNum;
            CurPageNum = 1;
            Title = title;
            Author = author;
        }

        public void AddBookmark(int page)
        {
            if( MarkList.Count < 5 )
            {
                MarkList.Add(page);
            }
        }

        public void RemoveBookmark(int page)
        {
            if( MarkList.Contains(page))
            {
                MarkList.Remove(page);
            }
        }

        public BindingList<int> GetBookMarks()
        {
            return MarkList;
        }

        public string GetTitle()
        {
            return Title;
        }

        public int GetCurPage()
        {
            return CurPageNum;
        }

        public int GetPageNum()
        {
            return PageNum;
        }

        public override string ToString()
        {
            return $"{Title} by {Author}";
        }

    }
}
