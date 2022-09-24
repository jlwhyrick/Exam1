
namespace ExamApp
{
    partial class BookView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxTitle = new System.Windows.Forms.Label();
            this.uxDisplayPage = new System.Windows.Forms.Label();
            this.uxFlipPageForward = new System.Windows.Forms.Button();
            this.uxFlipPageBackward = new System.Windows.Forms.Button();
            this.uxDisplayBookmarks = new System.Windows.Forms.ListBox();
            this.uxSetBookmark = new System.Windows.Forms.Button();
            this.uxRemoveBookmark = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.uxPageSelect = new System.Windows.Forms.TextBox();
            this.uxEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxTitle
            // 
            this.uxTitle.AutoSize = true;
            this.uxTitle.Location = new System.Drawing.Point(229, 27);
            this.uxTitle.Name = "uxTitle";
            this.uxTitle.Size = new System.Drawing.Size(34, 15);
            this.uxTitle.TabIndex = 0;
            this.uxTitle.Text = "TITLE";
            // 
            // uxDisplayPage
            // 
            this.uxDisplayPage.AutoSize = true;
            this.uxDisplayPage.Location = new System.Drawing.Point(458, 679);
            this.uxDisplayPage.Name = "uxDisplayPage";
            this.uxDisplayPage.Size = new System.Drawing.Size(13, 15);
            this.uxDisplayPage.TabIndex = 1;
            this.uxDisplayPage.Text = "1";
            // 
            // uxFlipPageForward
            // 
            this.uxFlipPageForward.Location = new System.Drawing.Point(410, 578);
            this.uxFlipPageForward.Name = "uxFlipPageForward";
            this.uxFlipPageForward.Size = new System.Drawing.Size(102, 77);
            this.uxFlipPageForward.TabIndex = 2;
            this.uxFlipPageForward.Text = "->";
            this.uxFlipPageForward.UseVisualStyleBackColor = true;
            this.uxFlipPageForward.Click += new System.EventHandler(this.uxFlipPageForward_Click);
            // 
            // uxFlipPageBackward
            // 
            this.uxFlipPageBackward.Location = new System.Drawing.Point(264, 578);
            this.uxFlipPageBackward.Name = "uxFlipPageBackward";
            this.uxFlipPageBackward.Size = new System.Drawing.Size(102, 77);
            this.uxFlipPageBackward.TabIndex = 3;
            this.uxFlipPageBackward.Text = "<-";
            this.uxFlipPageBackward.UseVisualStyleBackColor = true;
            this.uxFlipPageBackward.Click += new System.EventHandler(this.uxFlipPageBackward_Click);
            // 
            // uxDisplayBookmarks
            // 
            this.uxDisplayBookmarks.FormattingEnabled = true;
            this.uxDisplayBookmarks.ItemHeight = 15;
            this.uxDisplayBookmarks.Location = new System.Drawing.Point(12, 577);
            this.uxDisplayBookmarks.Name = "uxDisplayBookmarks";
            this.uxDisplayBookmarks.Size = new System.Drawing.Size(175, 139);
            this.uxDisplayBookmarks.TabIndex = 4;
            // 
            // uxSetBookmark
            // 
            this.uxSetBookmark.Location = new System.Drawing.Point(12, 14);
            this.uxSetBookmark.Name = "uxSetBookmark";
            this.uxSetBookmark.Size = new System.Drawing.Size(117, 40);
            this.uxSetBookmark.TabIndex = 5;
            this.uxSetBookmark.Text = "Set Bookmark";
            this.uxSetBookmark.UseVisualStyleBackColor = true;
            this.uxSetBookmark.Click += new System.EventHandler(this.uxSetBookmark_Click);
            // 
            // uxRemoveBookmark
            // 
            this.uxRemoveBookmark.Location = new System.Drawing.Point(12, 60);
            this.uxRemoveBookmark.Name = "uxRemoveBookmark";
            this.uxRemoveBookmark.Size = new System.Drawing.Size(117, 40);
            this.uxRemoveBookmark.TabIndex = 6;
            this.uxRemoveBookmark.Text = "Remove Bookmark";
            this.uxRemoveBookmark.UseVisualStyleBackColor = true;
            this.uxRemoveBookmark.Click += new System.EventHandler(this.uxRemoveBookmark_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 679);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Page";
            // 
            // uxPageSelect
            // 
            this.uxPageSelect.Location = new System.Drawing.Point(343, 20);
            this.uxPageSelect.Name = "uxPageSelect";
            this.uxPageSelect.Size = new System.Drawing.Size(100, 23);
            this.uxPageSelect.TabIndex = 8;
            // 
            // uxEnter
            // 
            this.uxEnter.Location = new System.Drawing.Point(449, 20);
            this.uxEnter.Name = "uxEnter";
            this.uxEnter.Size = new System.Drawing.Size(75, 23);
            this.uxEnter.TabIndex = 9;
            this.uxEnter.Text = "Enter";
            this.uxEnter.UseVisualStyleBackColor = true;
            this.uxEnter.Click += new System.EventHandler(this.uxEnter_Click);
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 728);
            this.Controls.Add(this.uxEnter);
            this.Controls.Add(this.uxPageSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxRemoveBookmark);
            this.Controls.Add(this.uxSetBookmark);
            this.Controls.Add(this.uxDisplayBookmarks);
            this.Controls.Add(this.uxFlipPageBackward);
            this.Controls.Add(this.uxFlipPageForward);
            this.Controls.Add(this.uxDisplayPage);
            this.Controls.Add(this.uxTitle);
            this.Name = "BookView";
            this.Text = "BookView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxTitle;
        private System.Windows.Forms.Label uxDisplayPage;
        private System.Windows.Forms.Button uxFlipPageForward;
        private System.Windows.Forms.Button uxFlipPageBackward;
        private System.Windows.Forms.ListBox uxDisplayBookmarks;
        private System.Windows.Forms.Button uxSetBookmark;
        private System.Windows.Forms.Button uxRemoveBookmark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxPageSelect;
        private System.Windows.Forms.Button uxEnter;
    }
}