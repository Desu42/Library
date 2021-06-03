
namespace Library
{
    partial class books_stock
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
            this.dgv_show_books = new System.Windows.Forms.DataGridView();
            this.dgv_book_details = new System.Windows.Forms.DataGridView();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.lbl_search_book = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book_details)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_show_books
            // 
            this.dgv_show_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_show_books.Location = new System.Drawing.Point(585, 27);
            this.dgv_show_books.Name = "dgv_show_books";
            this.dgv_show_books.RowHeadersWidth = 51;
            this.dgv_show_books.RowTemplate.Height = 24;
            this.dgv_show_books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_show_books.Size = new System.Drawing.Size(614, 278);
            this.dgv_show_books.TabIndex = 0;
            this.dgv_show_books.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_books_CellClick);
            // 
            // dgv_book_details
            // 
            this.dgv_book_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_book_details.Location = new System.Drawing.Point(585, 351);
            this.dgv_book_details.Name = "dgv_book_details";
            this.dgv_book_details.RowHeadersWidth = 51;
            this.dgv_book_details.RowTemplate.Height = 24;
            this.dgv_book_details.Size = new System.Drawing.Size(614, 278);
            this.dgv_book_details.TabIndex = 1;
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(46, 126);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(363, 30);
            this.tb_search.TabIndex = 2;
            this.tb_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyUp);
            // 
            // lbl_search_book
            // 
            this.lbl_search_book.AutoSize = true;
            this.lbl_search_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search_book.Location = new System.Drawing.Point(133, 79);
            this.lbl_search_book.Name = "lbl_search_book";
            this.lbl_search_book.Size = new System.Drawing.Size(180, 25);
            this.lbl_search_book.TabIndex = 3;
            this.lbl_search_book.Text = "Enter Book Name";
            // 
            // books_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 653);
            this.Controls.Add(this.lbl_search_book);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.dgv_book_details);
            this.Controls.Add(this.dgv_show_books);
            this.Name = "books_stock";
            this.Text = "books_stock";
            this.Load += new System.EventHandler(this.books_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_show_books;
        private System.Windows.Forms.DataGridView dgv_book_details;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label lbl_search_book;
    }
}