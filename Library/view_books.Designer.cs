
namespace Library
{
    partial class view_books
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
            this.dgv_books = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_book = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_author = new System.Windows.Forms.Label();
            this.tb_search_author = new System.Windows.Forms.TextBox();
            this.btn_search_author = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_books
            // 
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Location = new System.Drawing.Point(271, 37);
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.RowHeadersWidth = 51;
            this.dgv_books.RowTemplate.Height = 24;
            this.dgv_books.Size = new System.Drawing.Size(983, 333);
            this.dgv_books.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.tb_search);
            this.panel1.Controls.Add(this.lbl_book);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 157);
            this.panel1.TabIndex = 1;
            // 
            // lbl_book
            // 
            this.lbl_book.AutoSize = true;
            this.lbl_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book.Location = new System.Drawing.Point(19, 54);
            this.lbl_book.Name = "lbl_book";
            this.lbl_book.Size = new System.Drawing.Size(90, 17);
            this.lbl_book.TabIndex = 0;
            this.lbl_book.Text = "Book Name";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(127, 49);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(100, 22);
            this.tb_search.TabIndex = 1;
            this.tb_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyUp);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(73, 109);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_search_author);
            this.panel2.Controls.Add(this.tb_search_author);
            this.panel2.Controls.Add(this.lbl_author);
            this.panel2.Location = new System.Drawing.Point(12, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 130);
            this.panel2.TabIndex = 2;
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.Location = new System.Drawing.Point(19, 29);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(102, 17);
            this.lbl_author.TabIndex = 0;
            this.lbl_author.Text = "Author Name";
            // 
            // tb_search_author
            // 
            this.tb_search_author.Location = new System.Drawing.Point(127, 24);
            this.tb_search_author.Name = "tb_search_author";
            this.tb_search_author.Size = new System.Drawing.Size(100, 22);
            this.tb_search_author.TabIndex = 1;
            // 
            // btn_search_author
            // 
            this.btn_search_author.Location = new System.Drawing.Point(73, 78);
            this.btn_search_author.Name = "btn_search_author";
            this.btn_search_author.Size = new System.Drawing.Size(75, 23);
            this.btn_search_author.TabIndex = 2;
            this.btn_search_author.Text = "Search";
            this.btn_search_author.UseVisualStyleBackColor = true;
            this.btn_search_author.Click += new System.EventHandler(this.btn_search_author_Click);
            // 
            // view_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_books);
            this.Name = "view_books";
            this.Text = "view_books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.view_books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_books;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label lbl_book;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_search_author;
        private System.Windows.Forms.TextBox tb_search_author;
        private System.Windows.Forms.Label lbl_author;
    }
}