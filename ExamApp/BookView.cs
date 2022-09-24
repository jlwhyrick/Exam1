using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamApp
{
    public partial class BookView : Form
    {
        private Control _control;
        private Book _book;
        public BookView(Control control)
        {
            InitializeComponent();
            _control = control;
            _book = control.GetBook();
            uxTitle.Text = _book.Title;
            uxDisplayBookmarks.DataSource = _book.MarkList;
            uxFlipPageBackward.Enabled = false;
            uxRemoveBookmark.Enabled = false;
        }

        private void uxSetBookmark_Click(object sender, EventArgs e)
        {
            _control.Set(Convert.ToInt32(uxDisplayPage.Text));
            uxSetBookmark.Enabled = false;
            uxRemoveBookmark.Enabled = true;
        }

        private void uxRemoveBookmark_Click(object sender, EventArgs e)
        {
            _control.Remove(Convert.ToInt32(uxDisplayPage.Text));
            uxSetBookmark.Enabled = true;
            uxRemoveBookmark.Enabled = false;
        }

        private void uxFlipPageForward_Click(object sender, EventArgs e)
        {
            _control.FlipPage(Direction.foward);
            uxDisplayPage.Text = _book.CurPageNum.ToString();
            if(_book.CurPageNum == _book.PageNum)
            {
                uxFlipPageForward.Enabled = false;
            }
            if(_book.CurPageNum > 1 )
            {
                uxFlipPageBackward.Enabled = true;
            }
            if( _book.MarkList.Contains(_book.CurPageNum) )
            {
                uxRemoveBookmark.Enabled = true;
                uxSetBookmark.Enabled = false;
            }
            else
            {
                if( _book.MarkList.Count >= 5)
                {
                    uxRemoveBookmark.Enabled = false;
                    uxSetBookmark.Enabled = false;
                }
                else
                {
                    uxRemoveBookmark.Enabled = false;
                    uxSetBookmark.Enabled = true;
                }
                
            }
        }

        private void uxFlipPageBackward_Click(object sender, EventArgs e)
        {
            _control.FlipPage(Direction.backward);
            uxDisplayPage.Text = _book.CurPageNum.ToString();
            if(_book.CurPageNum == 1)
            {
                uxFlipPageBackward.Enabled = false;
            }
            if(_book.CurPageNum < _book.PageNum)
            {
                uxFlipPageForward.Enabled = true;
            }
            if (_book.MarkList.Contains(_book.CurPageNum))
            {
                uxRemoveBookmark.Enabled = true;
                uxSetBookmark.Enabled = false;
            }
            else
            {
                if (_book.MarkList.Count >= 5)
                {
                    uxRemoveBookmark.Enabled = false;
                    uxSetBookmark.Enabled = false;
                }
                else
                {
                    uxRemoveBookmark.Enabled = false;
                    uxSetBookmark.Enabled = true;
                }
            }
        }

        private void uxEnter_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(uxPageSelect.Text) <= _book.PageNum && Convert.ToInt32(uxPageSelect.Text) >= 1)
            {
                uxDisplayPage.Text = uxPageSelect.Text;
                _control.PageSelect(Convert.ToInt32(uxPageSelect.Text));
            }
            
        }
    }
}
