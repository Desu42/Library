using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
/* TO DO IF TIME LEFT
 * INPUT SANITATION
*/

namespace Library
{
    public partial class login : Form
    {
        SqlConnection sql_con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management;Integrated Security=True;Pooling=False");
        int count = 0;
        public login()
        {
            InitializeComponent();
        }
        // execute sql command when clicking on login button
        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = sql_con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM library_person WHERE username='" + tb_user.Text + "' AND password='" + tb_pass.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            // if username and password do not match
            if (count == 0)
            {
                MessageBox.Show("Invalid login credentials.");
            }
            else
            {
                this.Hide();
                mdi_user mu = new mdi_user();
                mu.Show();
            }
        }

        // need this for every page load event, otherwise error
        private void login_Load(object sender, EventArgs e)
        {
            /*
            try
            {
                sql_con.Open();
                MessageBox.Show("Connection is active.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //MessageBox.Show("Connection to database failed.");
            }
            */

            if (sql_con.State == ConnectionState.Open)
            {
                sql_con.Close();
            }
            sql_con.Open();
        }
    }
}
