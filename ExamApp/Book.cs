using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public class Book
    {
        public int PageNum;
        public int CurPageNum;
        public List<int> MarkList;
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

        public List<int> GetBookMarks()
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

    }
}
