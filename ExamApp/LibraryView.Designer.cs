
namespace ExamApp
{
    partial class LibraryView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxListBox = new System.Windows.Forms.ListBox();
            this.uxOpenBook = new System.Windows.Forms.Button();
            this.uxUpdateView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxListBox
            // 
            this.uxListBox.FormattingEnabled = true;
            this.uxListBox.ItemHeight = 15;
            this.uxListBox.Location = new System.Drawing.Point(22, 33);
            this.uxListBox.Name = "uxListBox";
            this.uxListBox.Size = new System.Drawing.Size(288, 394);
            this.uxListBox.TabIndex = 0;
            // 
            // uxOpenBook
            // 
            this.uxOpenBook.Location = new System.Drawing.Point(22, 454);
            this.uxOpenBook.Name = "uxOpenBook";
            this.uxOpenBook.Size = new System.Drawing.Size(110, 93);
            this.uxOpenBook.TabIndex = 1;
            this.uxOpenBook.Text = "Open Book";
            this.uxOpenBook.UseVisualStyleBackColor = true;
            // 
            // uxUpdateView
            // 
            this.uxUpdateView.Location = new System.Drawing.Point(180, 454);
            this.uxUpdateView.Name = "uxUpdateView";
            this.uxUpdateView.Size = new System.Drawing.Size(115, 93);
            this.uxUpdateView.TabIndex = 2;
            this.uxUpdateView.Text = "Update View";
            this.uxUpdateView.UseVisualStyleBackColor = true;
            // 
            // LibraryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 625);
            this.Controls.Add(this.uxUpdateView);
            this.Controls.Add(this.uxOpenBook);
            this.Controls.Add(this.uxListBox);
            this.Name = "LibraryView";
            this.Text = "Library View";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox uxListBox;
        private System.Windows.Forms.Button uxOpenBook;
        private System.Windows.Forms.Button uxUpdateView;
    }
}

