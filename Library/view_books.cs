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
            display_books();
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

        private void dgv_books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel_edit.Visible = true;
            int i;
            i = Convert.ToInt32(dgv_books.SelectedCells[0].Value.ToString());
            try
            {
                sql_con.Open();
                SqlCommand cmd = sql_con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM books_info WHERE id="+i+"";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    tb_book.Text = dr["books_name"].ToString();
                    tb_author.Text = dr["books_author_name"].ToString();
                    tb_publication.Text = dr["books_publication_name"].ToString();
                    dtp_purchase.Value = Convert.ToDateTime(dr["books_purchase_date"].ToString());
                    tb_price.Text = dr["books_price"].ToString();
                    tb_quantity.Text = dr["books_quantity"].ToString();
                }

                sql_con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            // DRY - make a function for this. 
            int i;
            i = Convert.ToInt32(dgv_books.SelectedCells[0].Value.ToString());
            try
            {
                sql_con.Open();
                SqlCommand cmd = sql_con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE books_info SET books_name='"+tb_book.Text+"', " +
                    "books_author_name='"+tb_author.Text+"', " +
                    "books_publication_name='"+tb_publication.Text+"', " +
                    "books_purchase_date='"+dtp_purchase.Text+"', " +
                    "books_price="+tb_price.Text+", " +
                    "books_quantity="+tb_quantity.Text+" WHERE id="+i+"";
                                    

                cmd.ExecuteNonQuery();
                sql_con.Close();
                display_books();
                MessageBox.Show("Books updated successfully.");
                panel_edit.Visible = false;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void display_books()
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
    }
}
