
namespace Library
{
    partial class return_books
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
            this.panel_search = new System.Windows.Forms.Panel();
            this.lbl_enrolment_number = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel_show_book = new System.Windows.Forms.Panel();
            this.dgv_show_books = new System.Windows.Forms.DataGridView();
            this.panel_book_info = new System.Windows.Forms.Panel();
            this.lbl_book_name = new System.Windows.Forms.Label();
            this.lbl_show_book_name = new System.Windows.Forms.Label();
            this.lbl_issue_date = new System.Windows.Forms.Label();
            this.lbl_show_issue_date = new System.Windows.Forms.Label();
            this.lbl_select_return_date = new System.Windows.Forms.Label();
            this.dtp_return_date = new System.Windows.Forms.DateTimePicker();
            this.btn_return_book = new System.Windows.Forms.Button();
            this.panel_search.SuspendLayout();
            this.panel_show_book.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_books)).BeginInit();
            this.panel_book_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_search
            // 
            this.panel_search.Controls.Add(this.btn_search);
            this.panel_search.Controls.Add(this.tb_search);
            this.panel_search.Controls.Add(this.lbl_enrolment_number);
            this.panel_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_search.Location = new System.Drawing.Point(47, 32);
            this.panel_search.Name = "panel_search";
            this.panel_search.Size = new System.Drawing.Size(377, 251);
            this.panel_search.TabIndex = 0;
            // 
            // lbl_enrolment_number
            // 
            this.lbl_enrolment_number.AutoSize = true;
            this.lbl_enrolment_number.Location = new System.Drawing.Point(45, 38);
            this.lbl_enrolment_number.Name = "lbl_enrolment_number";
            this.lbl_enrolment_number.Size = new System.Drawing.Size(247, 25);
            this.lbl_enrolment_number.TabIndex = 0;
            this.lbl_enrolment_number.Text = "Enter Enrolment Number";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(48, 93);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(256, 30);
            this.tb_search.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(48, 160);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(256, 46);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search Books";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel_show_book
            // 
            this.panel_show_book.Controls.Add(this.dgv_show_books);
            this.panel_show_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_show_book.Location = new System.Drawing.Point(430, 33);
            this.panel_show_book.Name = "panel_show_book";
            this.panel_show_book.Size = new System.Drawing.Size(935, 249);
            this.panel_show_book.TabIndex = 1;
            this.panel_show_book.Visible = false;
            // 
            // dgv_show_books
            // 
            this.dgv_show_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_show_books.Location = new System.Drawing.Point(10, 16);
            this.dgv_show_books.Name = "dgv_show_books";
            this.dgv_show_books.RowHeadersWidth = 51;
            this.dgv_show_books.RowTemplate.Height = 24;
            this.dgv_show_books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_show_books.Size = new System.Drawing.Size(922, 216);
            this.dgv_show_books.TabIndex = 0;
            this.dgv_show_books.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_show_books_CellClick);
            // 
            // panel_book_info
            // 
            this.panel_book_info.Controls.Add(this.btn_return_book);
            this.panel_book_info.Controls.Add(this.dtp_return_date);
            this.panel_book_info.Controls.Add(this.lbl_select_return_date);
            this.panel_book_info.Controls.Add(this.lbl_show_issue_date);
            this.panel_book_info.Controls.Add(this.lbl_issue_date);
            this.panel_book_info.Controls.Add(this.lbl_show_book_name);
            this.panel_book_info.Controls.Add(this.lbl_book_name);
            this.panel_book_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_book_info.Location = new System.Drawing.Point(50, 343);
            this.panel_book_info.Name = "panel_book_info";
            this.panel_book_info.Size = new System.Drawing.Size(1123, 182);
            this.panel_book_info.TabIndex = 2;
            this.panel_book_info.Visible = false;
            // 
            // lbl_book_name
            // 
            this.lbl_book_name.AutoSize = true;
            this.lbl_book_name.Location = new System.Drawing.Point(40, 41);
            this.lbl_book_name.Name = "lbl_book_name";
            this.lbl_book_name.Size = new System.Drawing.Size(123, 25);
            this.lbl_book_name.TabIndex = 0;
            this.lbl_book_name.Text = "Book Name";
            // 
            // lbl_show_book_name
            // 
            this.lbl_show_book_name.AutoSize = true;
            this.lbl_show_book_name.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_show_book_name.Location = new System.Drawing.Point(175, 41);
            this.lbl_show_book_name.Name = "lbl_show_book_name";
            this.lbl_show_book_name.Size = new System.Drawing.Size(170, 25);
            this.lbl_show_book_name.TabIndex = 1;
            this.lbl_show_book_name.Text = "PLACEHOLDER";
            // 
            // lbl_issue_date
            // 
            this.lbl_issue_date.AutoSize = true;
            this.lbl_issue_date.Location = new System.Drawing.Point(40, 123);
            this.lbl_issue_date.Name = "lbl_issue_date";
            this.lbl_issue_date.Size = new System.Drawing.Size(115, 25);
            this.lbl_issue_date.TabIndex = 2;
            this.lbl_issue_date.Text = "Issue Date";
            // 
            // lbl_show_issue_date
            // 
            this.lbl_show_issue_date.AutoSize = true;
            this.lbl_show_issue_date.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_show_issue_date.Location = new System.Drawing.Point(175, 123);
            this.lbl_show_issue_date.Name = "lbl_show_issue_date";
            this.lbl_show_issue_date.Size = new System.Drawing.Size(170, 25);
            this.lbl_show_issue_date.TabIndex = 3;
            this.lbl_show_issue_date.Text = "PLACEHOLDER";
            // 
            // lbl_select_return_date
            // 
            this.lbl_select_return_date.AutoSize = true;
            this.lbl_select_return_date.Location = new System.Drawing.Point(419, 41);
            this.lbl_select_return_date.Name = "lbl_select_return_date";
            this.lbl_select_return_date.Size = new System.Drawing.Size(183, 25);
            this.lbl_select_return_date.TabIndex = 4;
            this.lbl_select_return_date.Text = "Select return date";
            // 
            // dtp_return_date
            // 
            this.dtp_return_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_return_date.Location = new System.Drawing.Point(424, 113);
            this.dtp_return_date.Name = "dtp_return_date";
            this.dtp_return_date.Size = new System.Drawing.Size(172, 30);
            this.dtp_return_date.TabIndex = 6;
            // 
            // btn_return_book
            // 
            this.btn_return_book.Location = new System.Drawing.Point(777, 69);
            this.btn_return_book.Name = "btn_return_book";
            this.btn_return_book.Size = new System.Drawing.Size(213, 52);
            this.btn_return_book.TabIndex = 7;
            this.btn_return_book.Text = "Return Book";
            this.btn_return_book.UseVisualStyleBackColor = true;
            this.btn_return_book.Click += new System.EventHandler(this.btn_return_book_Click);
            // 
            // return_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 556);
            this.Controls.Add(this.panel_book_info);
            this.Controls.Add(this.panel_show_book);
            this.Controls.Add(this.panel_search);
            this.Name = "return_books";
            this.Text = "return_books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.return_books_Load);
            this.panel_search.ResumeLayout(false);
            this.panel_search.PerformLayout();
            this.panel_show_book.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show_books)).EndInit();
            this.panel_book_info.ResumeLayout(false);
            this.panel_book_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label lbl_enrolment_number;
        private System.Windows.Forms.Panel panel_show_book;
        private System.Windows.Forms.DataGridView dgv_show_books;
        private System.Windows.Forms.Panel panel_book_info;
        private System.Windows.Forms.DateTimePicker dtp_return_date;
        private System.Windows.Forms.Label lbl_select_return_date;
        private System.Windows.Forms.Label lbl_show_issue_date;
        private System.Windows.Forms.Label lbl_issue_date;
        private System.Windows.Forms.Label lbl_show_book_name;
        private System.Windows.Forms.Label lbl_book_name;
        private System.Windows.Forms.Button btn_return_book;
    }
}