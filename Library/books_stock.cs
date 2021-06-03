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
    }
}
