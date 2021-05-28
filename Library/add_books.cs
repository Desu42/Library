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
            //error here
            sql_cmd.CommandText = "INSERT INTO books_info VALUES ('"+tb_book.Text+"', '"+tb_author.Text+"', '"+tb_publication.Text+"', '"+dtp_purchase.Text+"', "+tb_price.Text+", "+tb_quantity.Text+")";
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
