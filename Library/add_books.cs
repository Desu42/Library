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
    public partial class add_books : Form
    {
        SqlConnection sql_con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management;Integrated Security=True;Pooling=False");
        public add_books()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            sql_con.Open();
            SqlCommand sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandType = CommandType.Text;

            //int book_price = Convert.ToInt32(tb_price.Text.ToString());
            //int book_quantity = Convert.ToInt32(tb_quantity.Text.ToString());

            sql_cmd.CommandText = "INSERT INTO books_info(books_name, books_author_name, books_publication_name, books_purchase_date, books_price, books_quantity, available_quantity) " +
                "VALUES ('"+tb_book.Text+"'," +
                "'"+tb_author.Text+"'," +
                "'"+tb_publication.Text+"'," +
                "'"+dtp_purchase.Text+"'," +
                ""+ tb_price.Text + "," +
                ""+ tb_quantity.Text + "," +
                ""+ tb_quantity.Text + ")";
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();

            tb_book.Text = "";
            tb_author.Text = "";
            tb_publication.Text = "";
            // dtp_purchase
            tb_price.Text = "";
            tb_quantity.Text = "";

            MessageBox.Show("Books Added Successfully.");
        }
    }
}
