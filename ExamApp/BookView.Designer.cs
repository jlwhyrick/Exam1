
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
            this.uxDisplayPage.Size = new System.Drawing.Size(42, 15);
            this.uxDisplayPage.TabIndex = 1;
            this.uxDisplayPage.Text = "Page 1";
            // 
            // uxFlipPageForward
            // 
            this.uxFlipPageForward.Location = new System.Drawing.Point(410, 578);
            this.uxFlipPageForward.Name = "uxFlipPageForward";
            this.uxFlipPageForward.Size = new System.Drawing.Size(102, 77);
            this.uxFlipPageForward.TabIndex = 2;
            this.uxFlipPageForward.Text = "->";
            this.uxFlipPageForward.UseVisualStyleBackColor = true;
            // 
            // uxFlipPageBackward
            // 
            this.uxFlipPageBackward.Location = new System.Drawing.Point(264, 578);
            this.uxFlipPageBackward.Name = "uxFlipPageBackward";
            this.uxFlipPageBackward.Size = new System.Drawing.Size(102, 77);
            this.uxFlipPageBackward.TabIndex = 3;
            this.uxFlipPageBackward.Text = "<-";
            this.uxFlipPageBackward.UseVisualStyleBackColor = true;
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
            // 
            // uxRemoveBookmark
            // 
            this.uxRemoveBookmark.Location = new System.Drawing.Point(12, 60);
            this.uxRemoveBookmark.Name = "uxRemoveBookmark";
            this.uxRemoveBookmark.Size = new System.Drawing.Size(117, 40);
            this.uxRemoveBookmark.TabIndex = 6;
            this.uxRemoveBookmark.Text = "Remove Bookmark";
            this.uxRemoveBookmark.UseVisualStyleBackColor = true;
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 728);
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
    }
}