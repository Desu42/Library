
namespace Library
{
    partial class issue_books
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_department = new System.Windows.Forms.TextBox();
            this.tb_semester = new System.Windows.Forms.TextBox();
            this.tb_contact = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_book_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_department = new System.Windows.Forms.Label();
            this.lbl_semester = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_book_name = new System.Windows.Forms.Label();
            this.lbl_search_description = new System.Windows.Forms.Label();
            this.dtp_book_issue_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_issue_date = new System.Windows.Forms.Label();
            this.btn_issue_books = new System.Windows.Forms.Button();
            this.lb_books = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_books);
            this.panel1.Controls.Add(this.btn_issue_books);
            this.panel1.Controls.Add(this.lbl_issue_date);
            this.panel1.Controls.Add(this.dtp_book_issue_date);
            this.panel1.Controls.Add(this.lbl_search_description);
            this.panel1.Controls.Add(this.lbl_book_name);
            this.panel1.Controls.Add(this.lbl_email);
            this.panel1.Controls.Add(this.lbl_contact);
            this.panel1.Controls.Add(this.lbl_semester);
            this.panel1.Controls.Add(this.lbl_department);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.tb_book_name);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(this.tb_contact);
            this.panel1.Controls.Add(this.tb_semester);
            this.panel1.Controls.Add(this.tb_department);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.tb_search);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(26, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1322, 733);
            this.panel1.TabIndex = 0;
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(44, 79);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(287, 30);
            this.tb_search.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(44, 138);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(287, 60);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search Student";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(733, 41);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(371, 30);
            this.tb_name.TabIndex = 2;
            // 
            // tb_department
            // 
            this.tb_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_department.Location = new System.Drawing.Point(733, 101);
            this.tb_department.Name = "tb_department";
            this.tb_department.Size = new System.Drawing.Size(371, 30);
            this.tb_department.TabIndex = 3;
            // 
            // tb_semester
            // 
            this.tb_semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_semester.Location = new System.Drawing.Point(733, 168);
            this.tb_semester.Name = "tb_semester";
            this.tb_semester.Size = new System.Drawing.Size(371, 30);
            this.tb_semester.TabIndex = 4;
            // 
            // tb_contact
            // 
            this.tb_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_contact.Location = new System.Drawing.Point(733, 225);
            this.tb_contact.Name = "tb_contact";
            this.tb_contact.Size = new System.Drawing.Size(371, 30);
            this.tb_contact.TabIndex = 5;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(733, 285);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(371, 30);
            this.tb_email.TabIndex = 6;
            // 
            // tb_book_name
            // 
            this.tb_book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_book_name.Location = new System.Drawing.Point(733, 420);
            this.tb_book_name.Name = "tb_book_name";
            this.tb_book_name.Size = new System.Drawing.Size(371, 30);
            this.tb_book_name.TabIndex = 7;
            this.tb_book_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_book_name_KeyDown);
            this.tb_book_name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_book_name_KeyUp);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(523, 44);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(68, 25);
            this.lbl_name.TabIndex = 8;
            this.lbl_name.Text = "Name";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Location = new System.Drawing.Point(523, 104);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(123, 25);
            this.lbl_department.TabIndex = 9;
            this.lbl_department.Text = "Department";
            // 
            // lbl_semester
            // 
            this.lbl_semester.AutoSize = true;
            this.lbl_semester.Location = new System.Drawing.Point(523, 171);
            this.lbl_semester.Name = "lbl_semester";
            this.lbl_semester.Size = new System.Drawing.Size(104, 25);
            this.lbl_semester.TabIndex = 10;
            this.lbl_semester.Text = "Semester";
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Location = new System.Drawing.Point(523, 228);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(87, 25);
            this.lbl_contact.TabIndex = 11;
            this.lbl_contact.Text = "Contact";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(523, 288);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(65, 25);
            this.lbl_email.TabIndex = 12;
            this.lbl_email.Text = "Email";
            // 
            // lbl_book_name
            // 
            this.lbl_book_name.AutoSize = true;
            this.lbl_book_name.Location = new System.Drawing.Point(523, 423);
            this.lbl_book_name.Name = "lbl_book_name";
            this.lbl_book_name.Size = new System.Drawing.Size(123, 25);
            this.lbl_book_name.TabIndex = 13;
            this.lbl_book_name.Text = "Book Name";
            // 
            // lbl_search_description
            // 
            this.lbl_search_description.AutoSize = true;
            this.lbl_search_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search_description.Location = new System.Drawing.Point(29, 23);
            this.lbl_search_description.Name = "lbl_search_description";
            this.lbl_search_description.Size = new System.Drawing.Size(338, 29);
            this.lbl_search_description.TabIndex = 14;
            this.lbl_search_description.Text = "Enter Student Enrolment No";
            // 
            // dtp_book_issue_date
            // 
            this.dtp_book_issue_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_book_issue_date.Location = new System.Drawing.Point(733, 349);
            this.dtp_book_issue_date.Name = "dtp_book_issue_date";
            this.dtp_book_issue_date.Size = new System.Drawing.Size(371, 30);
            this.dtp_book_issue_date.TabIndex = 15;
            // 
            // lbl_issue_date
            // 
            this.lbl_issue_date.AutoSize = true;
            this.lbl_issue_date.Location = new System.Drawing.Point(523, 354);
            this.lbl_issue_date.Name = "lbl_issue_date";
            this.lbl_issue_date.Size = new System.Drawing.Size(170, 25);
            this.lbl_issue_date.TabIndex = 16;
            this.lbl_issue_date.Text = "Book Issue Date";
            // 
            // btn_issue_books
            // 
            this.btn_issue_books.Location = new System.Drawing.Point(528, 595);
            this.btn_issue_books.Name = "btn_issue_books";
            this.btn_issue_books.Size = new System.Drawing.Size(147, 73);
            this.btn_issue_books.TabIndex = 17;
            this.btn_issue_books.Text = "Issue Books";
            this.btn_issue_books.UseVisualStyleBackColor = true;
            this.btn_issue_books.Click += new System.EventHandler(this.btn_issue_books_Click);
            // 
            // lb_books
            // 
            this.lb_books.FormattingEnabled = true;
            this.lb_books.ItemHeight = 25;
            this.lb_books.Location = new System.Drawing.Point(733, 473);
            this.lb_books.Name = "lb_books";
            this.lb_books.Size = new System.Drawing.Size(371, 204);
            this.lb_books.TabIndex = 18;
            this.lb_books.Visible = false;
            this.lb_books.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb_books_MouseClick);
            this.lb_books.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_books_KeyDown);
            // 
            // issue_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 771);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "issue_books";
            this.Text = "issue_books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.issue_books_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.TextBox tb_book_name;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_contact;
        private System.Windows.Forms.TextBox tb_semester;
        private System.Windows.Forms.TextBox tb_department;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_book_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label lbl_semester;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_search_description;
        private System.Windows.Forms.Label lbl_issue_date;
        private System.Windows.Forms.DateTimePicker dtp_book_issue_date;
        private System.Windows.Forms.Button btn_issue_books;
        private System.Windows.Forms.ListBox lb_books;
    }
}