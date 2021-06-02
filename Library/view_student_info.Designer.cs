
namespace Library
{
    partial class view_student_info
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
            this.dgv_student = new System.Windows.Forms.DataGridView();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_semester = new System.Windows.Forms.Label();
            this.lbl_department = new System.Windows.Forms.Label();
            this.lbl_enrolment_no = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_select_image = new System.Windows.Forms.Button();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_contact = new System.Windows.Forms.TextBox();
            this.tb_department = new System.Windows.Forms.TextBox();
            this.tb_semester = new System.Windows.Forms.TextBox();
            this.tb_enrolment_no = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.ofd_select_new_image = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_student
            // 
            this.dgv_student.AllowUserToAddRows = false;
            this.dgv_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_student.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_student.Location = new System.Drawing.Point(321, 2);
            this.dgv_student.Name = "dgv_student";
            this.dgv_student.RowHeadersWidth = 51;
            this.dgv_student.RowTemplate.Height = 24;
            this.dgv_student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_student.Size = new System.Drawing.Size(1493, 415);
            this.dgv_student.TabIndex = 0;
            this.dgv_student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_student_CellClick);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(38, 69);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(195, 22);
            this.tb_search.TabIndex = 1;
            this.tb_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyUp);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.Location = new System.Drawing.Point(50, 26);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(162, 25);
            this.lbl_search.TabIndex = 3;
            this.lbl_search.Text = "Search Student";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_email);
            this.panel1.Controls.Add(this.lbl_contact);
            this.panel1.Controls.Add(this.lbl_semester);
            this.panel1.Controls.Add(this.lbl_department);
            this.panel1.Controls.Add(this.lbl_enrolment_no);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_select_image);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(this.tb_contact);
            this.panel1.Controls.Add(this.tb_department);
            this.panel1.Controls.Add(this.tb_semester);
            this.panel1.Controls.Add(this.tb_enrolment_no);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(321, 460);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 287);
            this.panel1.TabIndex = 4;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(444, 198);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(65, 25);
            this.lbl_email.TabIndex = 13;
            this.lbl_email.Text = "Email";
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contact.Location = new System.Drawing.Point(444, 123);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(87, 25);
            this.lbl_contact.TabIndex = 12;
            this.lbl_contact.Text = "Contact";
            // 
            // lbl_semester
            // 
            this.lbl_semester.AutoSize = true;
            this.lbl_semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_semester.Location = new System.Drawing.Point(444, 50);
            this.lbl_semester.Name = "lbl_semester";
            this.lbl_semester.Size = new System.Drawing.Size(104, 25);
            this.lbl_semester.TabIndex = 11;
            this.lbl_semester.Text = "Semester";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_department.Location = new System.Drawing.Point(21, 194);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(123, 25);
            this.lbl_department.TabIndex = 10;
            this.lbl_department.Text = "Department";
            // 
            // lbl_enrolment_no
            // 
            this.lbl_enrolment_no.AutoSize = true;
            this.lbl_enrolment_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_enrolment_no.Location = new System.Drawing.Point(21, 125);
            this.lbl_enrolment_no.Name = "lbl_enrolment_no";
            this.lbl_enrolment_no.Size = new System.Drawing.Size(148, 25);
            this.lbl_enrolment_no.TabIndex = 9;
            this.lbl_enrolment_no.Text = "Enrolment No.";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(21, 50);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(68, 25);
            this.lbl_name.TabIndex = 8;
            this.lbl_name.Text = "Name";
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(875, 139);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(154, 64);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_select_image
            // 
            this.btn_select_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select_image.Location = new System.Drawing.Point(875, 45);
            this.btn_select_image.Name = "btn_select_image";
            this.btn_select_image.Size = new System.Drawing.Size(154, 64);
            this.btn_select_image.TabIndex = 6;
            this.btn_select_image.Text = "Select Image";
            this.btn_select_image.UseVisualStyleBackColor = true;
            this.btn_select_image.Click += new System.EventHandler(this.btn_select_image_Click);
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(579, 195);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(232, 30);
            this.tb_email.TabIndex = 5;
            // 
            // tb_contact
            // 
            this.tb_contact.Location = new System.Drawing.Point(579, 120);
            this.tb_contact.Name = "tb_contact";
            this.tb_contact.Size = new System.Drawing.Size(232, 30);
            this.tb_contact.TabIndex = 4;
            // 
            // tb_department
            // 
            this.tb_department.Location = new System.Drawing.Point(196, 195);
            this.tb_department.Name = "tb_department";
            this.tb_department.Size = new System.Drawing.Size(232, 30);
            this.tb_department.TabIndex = 3;
            // 
            // tb_semester
            // 
            this.tb_semester.Location = new System.Drawing.Point(579, 45);
            this.tb_semester.Name = "tb_semester";
            this.tb_semester.Size = new System.Drawing.Size(232, 30);
            this.tb_semester.TabIndex = 2;
            // 
            // tb_enrolment_no
            // 
            this.tb_enrolment_no.Location = new System.Drawing.Point(196, 120);
            this.tb_enrolment_no.Name = "tb_enrolment_no";
            this.tb_enrolment_no.Size = new System.Drawing.Size(232, 30);
            this.tb_enrolment_no.TabIndex = 1;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(196, 45);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(232, 30);
            this.tb_name.TabIndex = 0;
            // 
            // ofd_select_new_image
            // 
            this.ofd_select_new_image.FileName = "openFileDialog1";
            // 
            // view_student_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.dgv_student);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "view_student_info";
            this.Text = "view_student_info";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.view_student_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_student)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_student;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_contact;
        private System.Windows.Forms.TextBox tb_department;
        private System.Windows.Forms.TextBox tb_semester;
        private System.Windows.Forms.TextBox tb_enrolment_no;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label lbl_semester;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.Label lbl_enrolment_no;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_select_image;
        private System.Windows.Forms.OpenFileDialog ofd_select_new_image;
    }
}