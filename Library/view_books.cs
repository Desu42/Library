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
    public partial class view_books : Form
    {
        SqlConnection sql_con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management;Integrated Security=True;Pooling=False");

        public view_books()
        {
            InitializeComponent();
        }

        private void view_books_Load(object sender, EventArgs e)
        {
            try
            {
                sql_con.Open();
                SqlCommand cmd = sql_con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM books_info";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_books.DataSource = dt;

                sql_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                sql_con.Open();
                SqlCommand cmd = sql_con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM books_info WHERE books_name LIKE('%"+tb_search.Text+"%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_books.DataSource = dt;

                sql_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void tb_search_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                sql_con.Open();
                SqlCommand cmd = sql_con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM books_info WHERE books_name LIKE('%" + tb_search.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_books.DataSource = dt;

                sql_con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btn_search_author_Click(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                sql_con.Open();
                SqlCommand cmd = sql_con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM books_info WHERE books_author_name LIKE('%" + tb_search_author.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                dgv_books.DataSource = dt;

                sql_con.Close();

                if(i==0)
                {
                    MessageBox.Show("No books found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
    }
}
