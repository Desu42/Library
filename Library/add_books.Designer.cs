
namespace Library
{
    partial class add_books
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
            this.tb_book = new System.Windows.Forms.TextBox();
            this.tb_author = new System.Windows.Forms.TextBox();
            this.tb_publication = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.lbl_book = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.lbl_publication = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.dtp_purchase = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tb_book
            // 
            this.tb_book.Location = new System.Drawing.Point(403, 109);
            this.tb_book.Name = "tb_book";
            this.tb_book.Size = new System.Drawing.Size(147, 22);
            this.tb_book.TabIndex = 0;
            // 
            // tb_author
            // 
            this.tb_author.Location = new System.Drawing.Point(403, 146);
            this.tb_author.Name = "tb_author";
            this.tb_author.Size = new System.Drawing.Size(147, 22);
            this.tb_author.TabIndex = 1;
            // 
            // tb_publication
            // 
            this.tb_publication.Location = new System.Drawing.Point(403, 187);
            this.tb_publication.Name = "tb_publication";
            this.tb_publication.Size = new System.Drawing.Size(147, 22);
            this.tb_publication.TabIndex = 2;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(403, 274);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(147, 22);
            this.tb_price.TabIndex = 4;
            // 
            // tb_quantity
            // 
            this.tb_quantity.Location = new System.Drawing.Point(403, 316);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(147, 22);
            this.tb_quantity.TabIndex = 5;
            // 
            // lbl_book
            // 
            this.lbl_book.AutoSize = true;
            this.lbl_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_book.Location = new System.Drawing.Point(198, 109);
            this.lbl_book.Name = "lbl_book";
            this.lbl_book.Size = new System.Drawing.Size(111, 25);
            this.lbl_book.TabIndex = 6;
            this.lbl_book.Text = "Book name";
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_author.Location = new System.Drawing.Point(198, 151);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(124, 25);
            this.lbl_author.TabIndex = 7;
            this.lbl_author.Text = "Author name";
            // 
            // lbl_publication
            // 
            this.lbl_publication.AutoSize = true;
            this.lbl_publication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_publication.Location = new System.Drawing.Point(198, 192);
            this.lbl_publication.Name = "lbl_publication";
            this.lbl_publication.Size = new System.Drawing.Size(161, 25);
            this.lbl_publication.TabIndex = 8;
            this.lbl_publication.Text = "Publication name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Purchase date";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(198, 279);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(56, 25);
            this.lbl_price.TabIndex = 10;
            this.lbl_price.Text = "Price";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(198, 321);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(85, 25);
            this.lbl_quantity.TabIndex = 11;
            this.lbl_quantity.Text = "Quantity";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(331, 374);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(76, 37);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dtp_purchase
            // 
            this.dtp_purchase.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_purchase.Location = new System.Drawing.Point(403, 231);
            this.dtp_purchase.Name = "dtp_purchase";
            this.dtp_purchase.Size = new System.Drawing.Size(147, 22);
            this.dtp_purchase.TabIndex = 13;
            // 
            // add_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtp_purchase);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_publication);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.lbl_book);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_publication);
            this.Controls.Add(this.tb_author);
            this.Controls.Add(this.tb_book);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_books";
            this.Text = "add_books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_book;
        private System.Windows.Forms.TextBox tb_author;
        private System.Windows.Forms.TextBox tb_publication;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.Label lbl_book;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Label lbl_publication;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DateTimePicker dtp_purchase;
    }
}