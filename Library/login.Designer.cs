
namespace Library
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_login_title = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbUser);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.tb_pass);
            this.panel1.Controls.Add(this.lbl_pass);
            this.panel1.Controls.Add(this.tb_user);
            this.panel1.Controls.Add(this.lbl_user);
            this.panel1.Controls.Add(this.lbl_login_title);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 515);
            this.panel1.TabIndex = 0;
            // 
            // lbl_login_title
            // 
            this.lbl_login_title.AutoSize = true;
            this.lbl_login_title.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_title.Location = new System.Drawing.Point(251, 22);
            this.lbl_login_title.Name = "lbl_login_title";
            this.lbl_login_title.Size = new System.Drawing.Size(340, 72);
            this.lbl_login_title.TabIndex = 5;
            this.lbl_login_title.Text = "WELCOME";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(341, 190);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(174, 34);
            this.lbl_user.TabIndex = 6;
            this.lbl_user.Text = "USERNAME";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(546, 201);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(234, 22);
            this.tb_user.TabIndex = 7;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(341, 306);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(180, 34);
            this.lbl_pass.TabIndex = 8;
            this.lbl_pass.Text = "PASSWORD";
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(546, 318);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.Size = new System.Drawing.Size(234, 22);
            this.tb_pass.TabIndex = 9;
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_login.Location = new System.Drawing.Point(402, 405);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(189, 50);
            this.btn_login.TabIndex = 10;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // pbUser
            // 
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(31, 157);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(225, 225);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbUser.TabIndex = 11;
            this.pbUser.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 545);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(877, 592);
            this.Name = "login";
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_login_title;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.PictureBox pbUser;
    }
}

