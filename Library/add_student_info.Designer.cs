
namespace Library
{
    partial class add_student_info
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_department = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_add_photo = new System.Windows.Forms.Button();
            this.tb_enrolment_number = new System.Windows.Forms.TextBox();
            this.tb_department = new System.Windows.Forms.TextBox();
            this.tb_sem = new System.Windows.Forms.TextBox();
            this.tb_contact = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.pb_student = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_student)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pb_student);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(this.tb_contact);
            this.panel1.Controls.Add(this.tb_sem);
            this.panel1.Controls.Add(this.tb_department);
            this.panel1.Controls.Add(this.tb_enrolment_number);
            this.panel1.Controls.Add(this.btn_add_photo);
            this.panel1.Controls.Add(this.tb_name);
            this.panel1.Controls.Add(this.lbl_email);
            this.panel1.Controls.Add(this.lbl_phone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_department);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 482);
            this.panel1.TabIndex = 0;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(36, 50);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(68, 25);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Photo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(764, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student No.";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_department.Location = new System.Drawing.Point(36, 131);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(123, 25);
            this.lbl_department.TabIndex = 3;
            this.lbl_department.Text = "Department";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Semester";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(764, 128);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(113, 25);
            this.lbl_phone.TabIndex = 5;
            this.lbl_phone.Text = "Phone No.";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(39, 200);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(65, 25);
            this.lbl_email.TabIndex = 6;
            this.lbl_email.Text = "Email";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(180, 48);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(155, 30);
            this.tb_name.TabIndex = 7;
            // 
            // btn_add_photo
            // 
            this.btn_add_photo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_photo.Location = new System.Drawing.Point(510, 43);
            this.btn_add_photo.Name = "btn_add_photo";
            this.btn_add_photo.Size = new System.Drawing.Size(155, 35);
            this.btn_add_photo.TabIndex = 8;
            this.btn_add_photo.Text = "Add Photo";
            this.btn_add_photo.UseVisualStyleBackColor = true;
            this.btn_add_photo.Click += new System.EventHandler(this.btn_add_photo_Click);
            // 
            // tb_enrolment_number
            // 
            this.tb_enrolment_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_enrolment_number.Location = new System.Drawing.Point(912, 43);
            this.tb_enrolment_number.Name = "tb_enrolment_number";
            this.tb_enrolment_number.Size = new System.Drawing.Size(155, 30);
            this.tb_enrolment_number.TabIndex = 9;
            // 
            // tb_department
            // 
            this.tb_department.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_department.Location = new System.Drawing.Point(180, 129);
            this.tb_department.Name = "tb_department";
            this.tb_department.Size = new System.Drawing.Size(155, 30);
            this.tb_department.TabIndex = 10;
            // 
            // tb_sem
            // 
            this.tb_sem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sem.Location = new System.Drawing.Point(510, 127);
            this.tb_sem.Name = "tb_sem";
            this.tb_sem.Size = new System.Drawing.Size(155, 30);
            this.tb_sem.TabIndex = 11;
            // 
            // tb_contact
            // 
            this.tb_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_contact.Location = new System.Drawing.Point(912, 123);
            this.tb_contact.Name = "tb_contact";
            this.tb_contact.Size = new System.Drawing.Size(155, 30);
            this.tb_contact.TabIndex = 12;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(180, 195);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(155, 30);
            this.tb_email.TabIndex = 13;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(367, 366);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(197, 49);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Add Student";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pb_student
            // 
            this.pb_student.Location = new System.Drawing.Point(653, 200);
            this.pb_student.Name = "pb_student";
            this.pb_student.Size = new System.Drawing.Size(286, 257);
            this.pb_student.TabIndex = 15;
            this.pb_student.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // add_student_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 590);
            this.Controls.Add(this.panel1);
            this.Name = "add_student_info";
            this.Text = "add_student_info";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_contact;
        private System.Windows.Forms.TextBox tb_sem;
        private System.Windows.Forms.TextBox tb_department;
        private System.Windows.Forms.TextBox tb_enrolment_number;
        private System.Windows.Forms.Button btn_add_photo;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_department;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pb_student;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}