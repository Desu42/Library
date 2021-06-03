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
    public partial class return_books : Form
    {
        SqlConnection sql_con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management;Integrated Security=True;Pooling=False");
        public return_books()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            panel_show_book.Visible = true;
            fill_grid(tb_search.Text);
        }

        private void return_books_Load(object sender, EventArgs e)
        {
            if(sql_con.State==ConnectionState.Open)
            {
                sql_con.Close();
            }
            sql_con.Open();
        }
        public void fill_grid(string enrolment)
        {
            SqlCommand cmd = sql_con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM issue_books WHERE student_enrolment_number='"+tb_search.Text+"'AND book_return_date=''";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_show_books.DataSource = dt;
        }

        private void dgv_show_books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel_book_info.Visible = true;
            int i;
            i = Convert.ToInt32(dgv_show_books.SelectedCells[0].Value.ToString());

            SqlCommand cmd = sql_con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM issue_books WHERE id="+i+"";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                lbl_show_book_name.Text = dr["books_name"].ToString();
                lbl_show_issue_date.Text = dr["books_issue_date"].ToString();
            }
        }

        private void btn_return_book_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dgv_show_books.SelectedCells[0].Value.ToString());

            SqlCommand cmd = sql_con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE issue_books set book_return_date='"+dtp_return_date.Value.ToString()+"' WHERE id=" + i + "";
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = sql_con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "UPDATE books_info SET available_quantity=available_quantity+1 WHERE books_name='"+lbl_show_book_name.Text+"'";
            cmd1.ExecuteNonQuery();

            MessageBox.Show("Book returned successfully!");
            panel_book_info.Visible = false;

            fill_grid(tb_search.Text);
        }
    }
}
