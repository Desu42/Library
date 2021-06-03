using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace Library
{
    public partial class books_stock : Form
    {
        SqlConnection sql_con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management;Integrated Security=True;Pooling=False");
        public books_stock()
        {
            InitializeComponent();
        }

        private void books_stock_Load(object sender, EventArgs e)
        {
            if (sql_con.State==ConnectionState.Open)
            {
                sql_con.Close();
            }
            sql_con.Open();

            fill_books_info();
        }

        public void fill_books_info()
        {
            SqlCommand cmd = sql_con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT books_name, books_author_name, books_quantity, available_quantity from books_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_show_books.DataSource = dt;
        }

        private void dgv_books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string book_name_temp;
            book_name_temp = dgv_show_books.SelectedCells[0].Value.ToString();

            SqlCommand cmd = sql_con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM issue_books WHERE books_name='"+ book_name_temp.ToString()+"'and book_return_date=''";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_book_details.DataSource = dt;
        }

        private void tb_search_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand cmd = sql_con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT books_name, books_author_name, books_quantity, available_quantity from books_info WHERE books_name like('%"+tb_search.Text+"%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_show_books.DataSource = dt;
        }

        private void dgv_book_details_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string student_mail_temp;
            student_mail_temp = dgv_book_details.SelectedCells[6].Value.ToString();
            if (student_mail_temp!=string.Empty)
            {
                panel_send_email.Visible = true;
            }

            tb_email.Text = student_mail_temp.ToString();
        }

        private void btn_send_email_Click(object sender, EventArgs e)
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            // (username.password)
            smtp.Credentials = new NetworkCredential("django.agenda@gmail.com", "%A3*@8pTbGaz2duCJL%dW5FQBfhemsT4");
            //(from, to, subject, body)
            MailMessage mail = new MailMessage("django.agenda@gmail.com", tb_email.Text, "Return book asap.", tb_content.Text);
            mail.Priority = MailPriority.High;
            smtp.Send(mail);
            MessageBox.Show("Email sent.");
        }
    }
}
