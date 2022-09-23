using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApp
{
    public class Book
    {
        private int _pageNum;
        private int _curPageNum;
        private List<int> _markList;
        private string _title;
        private string _author;
        
        public Book( int pageNum, int curPage, string title, string author)
        {
            _pageNum = pageNum;
            _curPageNum = curPage;
            _title = title;
            _author = author;
        }

        public void AddBookmark(int page)
        {
            if( _markList.Count < 5 )
            {
                _markList.Add(page);
            }
        }

        public List<int> GetBookMarks()
        {
            return _markList;
        }

        public string GetTitle()
        {
            return _title;
        }

        public int GetCurPage()
        {
            return _curPageNum;
        }

        public int GetPageNum()
        {
            return _pageNum;
        }

    }
}
