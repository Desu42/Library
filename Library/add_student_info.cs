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
using System.IO;

namespace Library
{
    public partial class add_student_info : Form
    {
        // THIS SHOULD BE STATIC
        SqlConnection sql_con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management;Integrated Security=True;Pooling=False");

        string pwd;
        string wanted_path;
        public add_student_info()
        {
            InitializeComponent();
        }

        private void btn_add_photo_Click(object sender, EventArgs e)
        {
            pwd = Class1.GetRandomPassword(20);
            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            DialogResult result = openFileDialog1.ShowDialog();
            // for some reason this doesn't work
            // refer to https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.filedialog.filter?view=net-5.0
            openFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*jpg|GIF Files (*.gif)|*.gif";
            if(result == DialogResult.OK) // Test result
            {
                pb_student.ImageLocation = openFileDialog1.FileName;
                pb_student.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            //pictureBox1.ImageLocation = @"..\..\student_images\" + pwd + ".jpg";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string img_path;
                File.Copy(openFileDialog1.FileName, wanted_path + "\\student_images\\" + pwd + ".jpg");

                img_path = "student_images\\" + pwd + ".jpg";

                sql_con.Open();
                SqlCommand cmd = sql_con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO student_info values('" + tb_name.Text + "', " +
                    "'" + img_path.ToString() + "', " +
                    "'" + tb_enrolment_number.Text + "', " +
                    "'" + tb_department.Text + "', " +
                    "'" + tb_sem.Text + "', " +
                    "'" + tb_contact.Text + "', " +
                    "'" + tb_email.Text + "')";
                cmd.ExecuteNonQuery();
                sql_con.Close();

                MessageBox.Show("Student added successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
