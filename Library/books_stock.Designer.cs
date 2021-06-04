
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
            this.panel_send_email = new System.Windows.Forms.Panel();
            this.lbl_send_email_description = new System.Windows.Forms.Label();
            this.lbl_content = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.btn_send_email = new System.Windows.Forms.Button();
            this.tb_content = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book_details)).BeginInit();
            this.panel_send_email.SuspendLayout();
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
            this.dgv_book_details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_book_details.Size = new System.Drawing.Size(614, 278);
            this.dgv_book_details.TabIndex = 1;
            this.dgv_book_details.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_book_details_CellClick);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(115, 125);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(310, 30);
            this.tb_search.TabIndex = 2;
            this.tb_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyUp);
            // 
            // lbl_search_book
            // 
            this.lbl_search_book.AutoSize = true;
            this.lbl_search_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search_book.Location = new System.Drawing.Point(150, 81);
            this.lbl_search_book.Name = "lbl_search_book";
            this.lbl_search_book.Size = new System.Drawing.Size(242, 31);
            this.lbl_search_book.TabIndex = 3;
            this.lbl_search_book.Text = "Enter Book Name";
            // 
            // panel_send_email
            // 
            this.panel_send_email.Controls.Add(this.lbl_send_email_description);
            this.panel_send_email.Controls.Add(this.lbl_content);
            this.panel_send_email.Controls.Add(this.lbl_email);
            this.panel_send_email.Controls.Add(this.btn_send_email);
            this.panel_send_email.Controls.Add(this.tb_content);
            this.panel_send_email.Controls.Add(this.tb_email);
            this.panel_send_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_send_email.Location = new System.Drawing.Point(12, 188);
            this.panel_send_email.Name = "panel_send_email";
            this.panel_send_email.Size = new System.Drawing.Size(547, 440);
            this.panel_send_email.TabIndex = 4;
            this.panel_send_email.Visible = false;
            // 
            // lbl_send_email_description
            // 
            this.lbl_send_email_description.AutoSize = true;
            this.lbl_send_email_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_send_email_description.Location = new System.Drawing.Point(117, 22);
            this.lbl_send_email_description.Name = "lbl_send_email_description";
            this.lbl_send_email_description.Size = new System.Drawing.Size(296, 31);
            this.lbl_send_email_description.TabIndex = 6;
            this.lbl_send_email_description.Text = "Send email to student";
            // 
            // lbl_content
            // 
            this.lbl_content.AutoSize = true;
            this.lbl_content.Location = new System.Drawing.Point(23, 160);
            this.lbl_content.Name = "lbl_content";
            this.lbl_content.Size = new System.Drawing.Size(88, 25);
            this.lbl_content.TabIndex = 4;
            this.lbl_content.Text = "Content";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(23, 101);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(65, 25);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Email";
            // 
            // btn_send_email
            // 
            this.btn_send_email.Location = new System.Drawing.Point(161, 376);
            this.btn_send_email.Name = "btn_send_email";
            this.btn_send_email.Size = new System.Drawing.Size(166, 48);
            this.btn_send_email.TabIndex = 2;
            this.btn_send_email.Text = "Send email";
            this.btn_send_email.UseVisualStyleBackColor = true;
            this.btn_send_email.Click += new System.EventHandler(this.btn_send_email_Click);
            // 
            // tb_content
            // 
            this.tb_content.Location = new System.Drawing.Point(161, 160);
            this.tb_content.Multiline = true;
            this.tb_content.Name = "tb_content";
            this.tb_content.Size = new System.Drawing.Size(369, 200);
            this.tb_content.TabIndex = 1;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(161, 96);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(369, 30);
            this.tb_email.TabIndex = 0;
            // 
            // books_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 653);
            this.Controls.Add(this.panel_send_email);
            this.Controls.Add(this.lbl_search_book);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.dgv_book_details);
            this.Controls.Add(this.dgv_show_books);
            this.Name = "books_stock";
            this.Text = "books_stock";
            this.Load += new System.EventHandler(this.books_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book_details)).EndInit();
            this.panel_send_email.ResumeLayout(false);
            this.panel_send_email.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_show_books;
        private System.Windows.Forms.DataGridView dgv_book_details;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label lbl_search_book;
        private System.Windows.Forms.Panel panel_send_email;
        private System.Windows.Forms.Label lbl_content;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Button btn_send_email;
        private System.Windows.Forms.TextBox tb_content;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_send_email_description;
    }
}