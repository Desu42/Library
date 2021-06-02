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

namespace Library
{
    public partial class issue_books : Form
    {
        SqlConnection sql_con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management;Integrated Security=True;Pooling=False");

        public issue_books()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int i = 0;
            SqlCommand cmd = sql_con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM student_info WHERE student_enrolment_no='"+tb_search.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if(i==0)
            {
                MessageBox.Show("Enrolment number not found.");
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    tb_name.Text = dr["student_name"].ToString();
                    tb_department.Text = dr["student_department"].ToString();
                    tb_semester.Text = dr["student_sem"].ToString();
                    tb_contact.Text = dr["student_contact"].ToString();
                    tb_email.Text = dr["student_email"].ToString();

                }
            }
        }

        private void issue_books_Load(object sender, EventArgs e)
        {
            if(sql_con.State==ConnectionState.Open)
            {
                sql_con.Close();
            }
            sql_con.Open();
        }

        private void tb_book_name_KeyUp(object sender, KeyEventArgs e)
        {
            int count = 0;

            if(e.KeyCode != Keys.Enter)
            {
                lb_books.Items.Clear();

                SqlCommand cmd = sql_con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM books_info WHERE books_name LIKE('%" +tb_book_name.Text+"%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());

                if(count>0)
                {
                    lb_books.Visible = true;
                    foreach (DataRow dr in dt.Rows)
                    {
                        lb_books.Items.Add(dr["books_name"].ToString());
                    }
                }
            }
        }

        private void tb_book_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lb_books.Focus();
                // might need to select 1 value to allow arrow keys
                lb_books.SelectedIndex = 0;
            }
        }

        private void lb_books_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tb_book_name.Text = lb_books.SelectedItem.ToString();
                // might need to select 1 value to allow arrow keys
                lb_books.Visible = false;
            }
        }

        private void lb_books_MouseClick(object sender, MouseEventArgs e)
        {
            tb_book_name.Text = lb_books.SelectedItem.ToString();
            // might need to select 1 value to allow arrow keys
            lb_books.Visible = false;
        }

        private void btn_issue_books_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = sql_con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO issue_books(student_enrolment_number, student_name, student_department, student_semester, student_contact, student_email, books_name, books_issue_date) " +
                "VALUES('"+ tb_search.Text+"'," +
                "'"+ tb_name.Text+"'," +
                "'"+ tb_department.Text+"'," +
                "'"+ tb_semester.Text+"'," +
                "'"+ tb_contact.Text+"'," +
                "'"+ tb_email.Text+"'," +
                "'"+ tb_book_name.Text+"'," +
                "'"+ dtp_book_issue_date.Text+"')";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Books Issues Successfully!");
        }
    }
}
