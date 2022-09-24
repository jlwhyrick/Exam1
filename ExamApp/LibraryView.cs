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
    public partial class LibraryView : Form
    {
        private Control _control = new Control();
        public LibraryView()
        {
            InitializeComponent();
            uxOpenBook.Enabled = false;            
        }

        private void uxOpenBook_Click(object sender, EventArgs e)
        {
            _control.OpenBook(uxListBox.SelectedIndex);
            BookView bookView = new BookView(_control);
            bookView.ShowDialog();
        }

        private void uxUpdateView_Click(object sender, EventArgs e)
        {
            _control.Synchronize();
            uxOpenBook.Enabled = true;
            uxListBox.DataSource = _control.BookList;
        }
    }
}
