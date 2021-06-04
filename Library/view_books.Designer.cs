
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
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.lbl_book = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search_author = new System.Windows.Forms.Button();
            this.tb_search_author = new System.Windows.Forms.TextBox();
            this.lbl_author = new System.Windows.Forms.Label();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.dtp_purchase = new System.Windows.Forms.DateTimePicker();
            this.btn_edit = new System.Windows.Forms.Button();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_publication = new System.Windows.Forms.TextBox();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.tb_book = new System.Windows.Forms.TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_purchase_date = new System.Windows.Forms.Label();
            this.lbl_publication = new System.Windows.Forms.Label();
            this.lbl_author_2 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_books
            // 
            this.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books.Location = new System.Drawing.Point(281, 37);
            this.dgv_books.Name = "dgv_books";
            this.dgv_books.RowHeadersWidth = 51;
            this.dgv_books.RowTemplate.Height = 24;
            this.dgv_books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_books.Size = new System.Drawing.Size(983, 333);
            this.dgv_books.TabIndex = 0;
            this.dgv_books.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_books_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.tb_search);
            this.panel1.Controls.Add(this.lbl_book);
            this.panel1.Location = new System.Drawing.Point(12, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 169);
            this.panel1.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(73, 105);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(109, 40);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(15, 63);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(237, 22);
            this.tb_search.TabIndex = 1;
            this.tb_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyUp);
            // 
            // lbl_book
            // 
            this.lbl_book.AutoSize = true;
            this.lbl_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book.Location = new System.Drawing.Point(68, 21);
            this.lbl_book.Name = "lbl_book";
            this.lbl_book.Size = new System.Drawing.Size(123, 25);
            this.lbl_book.TabIndex = 0;
            this.lbl_book.Text = "Book Name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_search_author);
            this.panel2.Controls.Add(this.tb_search_author);
            this.panel2.Controls.Add(this.lbl_author);
            this.panel2.Location = new System.Drawing.Point(12, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 152);
            this.panel2.TabIndex = 2;
            // 
            // btn_search_author
            // 
            this.btn_search_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_author.Location = new System.Drawing.Point(73, 93);
            this.btn_search_author.Name = "btn_search_author";
            this.btn_search_author.Size = new System.Drawing.Size(109, 40);
            this.btn_search_author.TabIndex = 2;
            this.btn_search_author.Text = "Search";
            this.btn_search_author.UseVisualStyleBackColor = true;
            this.btn_search_author.Click += new System.EventHandler(this.btn_search_author_Click);
            // 
            // tb_search_author
            // 
            this.tb_search_author.Location = new System.Drawing.Point(15, 53);
            this.tb_search_author.Name = "tb_search_author";
            this.tb_search_author.Size = new System.Drawing.Size(237, 22);
            this.tb_search_author.TabIndex = 1;
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.Location = new System.Drawing.Point(68, 25);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(138, 25);
            this.lbl_author.TabIndex = 0;
            this.lbl_author.Text = "Author Name";
            // 
            // panel_edit
            // 
            this.panel_edit.Controls.Add(this.dtp_purchase);
            this.panel_edit.Controls.Add(this.btn_edit);
            this.panel_edit.Controls.Add(this.tb_quantity);
            this.panel_edit.Controls.Add(this.tb_price);
            this.panel_edit.Controls.Add(this.tb_publication);
            this.panel_edit.Controls.Add(this.tb_author);
            this.panel_edit.Controls.Add(this.tb_book);
            this.panel_edit.Controls.Add(this.lbl_quantity);
            this.panel_edit.Controls.Add(this.lbl_price);
            this.panel_edit.Controls.Add(this.lbl_purchase_date);
            this.panel_edit.Controls.Add(this.lbl_publication);
            this.panel_edit.Controls.Add(this.lbl_author_2);
            this.panel_edit.Controls.Add(this.lbl_name);
            this.panel_edit.Location = new System.Drawing.Point(139, 441);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(905, 175);
            this.panel_edit.TabIndex = 3;
            this.panel_edit.Visible = false;
            // 
            // dtp_purchase
            // 
            this.dtp_purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_purchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_purchase.Location = new System.Drawing.Point(569, 32);
            this.dtp_purchase.Name = "dtp_purchase";
            this.dtp_purchase.Size = new System.Drawing.Size(152, 30);
            this.dtp_purchase.TabIndex = 13;
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(759, 50);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(128, 69);
            this.btn_edit.TabIndex = 12;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // tb_quantity
            // 
            this.tb_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quantity.Location = new System.Drawing.Point(569, 106);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(152, 30);
            this.tb_quantity.TabIndex = 11;
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.Location = new System.Drawing.Point(569, 68);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(152, 30);
            this.tb_price.TabIndex = 10;
            // 
            // tb_publication
            // 
            this.tb_publication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_publication.Location = new System.Drawing.Point(174, 107);
            this.tb_publication.Name = "tb_publication";
            this.tb_publication.Size = new System.Drawing.Size(145, 30);
            this.tb_publication.TabIndex = 8;
            // 
            // tb_author
            // 
            this.tb_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_author.Location = new System.Drawing.Point(174, 70);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(145, 30);
            this.tb_author.TabIndex = 7;
            // 
            // tb_book
            // 
            this.tb_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_book.Location = new System.Drawing.Point(174, 29);
            this.tb_book.Name = "tb_book";
            this.tb_book.Size = new System.Drawing.Size(145, 30);
            this.tb_book.TabIndex = 6;
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(363, 104);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(93, 25);
            this.lbl_quantity.TabIndex = 5;
            this.lbl_quantity.Text = "Quantity";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(363, 70);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(61, 25);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price";
            // 
            // lbl_purchase_date
            // 
            this.lbl_purchase_date.AutoSize = true;
            this.lbl_purchase_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purchase_date.Location = new System.Drawing.Point(363, 32);
            this.lbl_purchase_date.Name = "lbl_purchase_date";
            this.lbl_purchase_date.Size = new System.Drawing.Size(151, 25);
            this.lbl_purchase_date.TabIndex = 3;
            this.lbl_purchase_date.Text = "Purchase date";
            // 
            // lbl_publication
            // 
            this.lbl_publication.AutoSize = true;
            this.lbl_publication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_publication.Location = new System.Drawing.Point(7, 107);
            this.lbl_publication.Name = "lbl_publication";
            this.lbl_publication.Size = new System.Drawing.Size(118, 25);
            this.lbl_publication.TabIndex = 2;
            this.lbl_publication.Text = "Publication";
            // 
            // lbl_author_2
            // 
            this.lbl_author_2.AutoSize = true;
            this.lbl_author_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author_2.Location = new System.Drawing.Point(7, 70);
            this.lbl_author_2.Name = "lbl_author_2";
            this.lbl_author_2.Size = new System.Drawing.Size(76, 25);
            this.lbl_author_2.TabIndex = 1;
            this.lbl_author_2.Text = "Author";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(3, 29);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(123, 25);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Book Name";
            // 
            // view_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 675);
            this.Controls.Add(this.panel_edit);
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
            this.panel_edit.ResumeLayout(false);
            this.panel_edit.PerformLayout();
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
        private System.Windows.Forms.Panel panel_edit;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_publication;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.TextBox tb_book;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_purchase_date;
        private System.Windows.Forms.Label lbl_publication;
        private System.Windows.Forms.Label lbl_author_2;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DateTimePicker dtp_purchase;
    }
}