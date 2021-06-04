using System;
using System.Data;
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

            if (validate_data())
            {
                Book temporary_book = new Book(tb_book.Text, tb_author.Text, tb_publication.Text, dtp_purchase.Text, Convert.ToInt32(tb_price.Text), Convert.ToInt32(tb_quantity.Text));

                sql_cmd.CommandText = "INSERT INTO books_info(books_name, books_author_name, books_publication_name, books_purchase_date, books_price, books_quantity, available_quantity) " +
                                      "VALUES ('" + temporary_book.Title + "'," +
                                      "'" + temporary_book.Author + "'," +
                                      "'" + temporary_book.Publication + "'," +
                                      "'" + temporary_book.Purchase_Date + "'," +
                                      "" + temporary_book.Price + "," +
                                      "" + temporary_book.Quantity + "," +
                                      "" + temporary_book.Available_Quantity + ")";
                sql_cmd.ExecuteNonQuery();
                sql_con.Close();

                tb_book.Text = "";
                tb_author.Text = "";
                tb_publication.Text = "";
                dtp_purchase.Value = DateTime.Now;
                tb_price.Text = "";
                tb_quantity.Text = "";

                MessageBox.Show("Books Added Successfully.");
            }
            else
            {
                sql_con.Close();
                MessageBox.Show("Fail.");
            }

        }
        private bool validate_data()
        {
            // should check if book is already in the system
            // replace purchase date with publication date? 
            int book_price;
            bool book_price_success = Int32.TryParse(tb_price.Text.ToString(), out book_price);

            int book_quantity;
            bool book_quantity_success = Int32.TryParse(tb_quantity.Text.ToString(), out book_quantity);

            if (book_price_success && book_quantity_success)
            {
                if (book_quantity > Book.BOOK_MAX_QUANTITY)
                {
                    return false;
                }

                if(book_price > Book.BOOK_MAX_PRICE)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            if(tb_book.Text==string.Empty)
            {
                return false;
            }

            if (tb_author.Text == string.Empty)
            {
                return false;
            }

            if (tb_publication.Text==string.Empty)
            {
                return false;
            }

            if (dtp_purchase.Value.Date > DateTime.Today)
            {
                return false;
            }

            return true;
        }
    }
}
