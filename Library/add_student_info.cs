using System;
using System.Data;
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
            DialogResult result = opf_add_student.ShowDialog();
            opf_add_student.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*jpg|GIF Files (*.gif)|*.gif";
            if(result == DialogResult.OK) // Test result
            {
                pb_student.ImageLocation = opf_add_student.FileName;
                pb_student.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            //pb_student.ImageLocation = @"..\..\student_images\" + pwd + ".jpg";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (validate_data())
            {
                try
                {
                    string img_path;
                    File.Copy(opf_add_student.FileName, wanted_path + "\\student_images\\" + pwd + ".jpg");

                    img_path = "student_images\\" + pwd + ".jpg";
                    // initialize variables before initializing temporary student?
                    Student temporary_student = new Student(tb_name.Text, img_path.ToString(), Convert.ToInt32(tb_enrolment_number.Text),
                        tb_department.Text, tb_sem.Text, tb_contact.Text, tb_email.Text);

                    sql_con.Open();
                    SqlCommand cmd = sql_con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "INSERT INTO student_info values('" + temporary_student.Name + "', " +
                        "'" + temporary_student.Image + "', " +
                        "'" + temporary_student.Enrolment_Number + "', " +
                        "'" + temporary_student.Department + "', " +
                        "'" + temporary_student.Semester + "', " +
                        "'" + temporary_student.Contact + "', " +
                        "'" + temporary_student.Email + "')";
                    cmd.ExecuteNonQuery();
                    sql_con.Close();

                    MessageBox.Show("Student added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                sql_con.Close();
                MessageBox.Show("Fail.");
            }

        }

        private bool validate_data()
        {
            // add regex validators, for example phone number.
            int enrolment_number;
            bool enrolment_number_success = Int32.TryParse(tb_enrolment_number.Text.ToString(), out enrolment_number);

            if (enrolment_number_success)
            {

            }
            else
            {
                return false;
            }

            if (tb_name.Text==string.Empty)
            {
                return false;
            }

            if (tb_enrolment_number.Text==string.Empty)
            {
                return false;
            }

            if(tb_department.Text==string.Empty)
            {
                return false;
            }

            if (tb_sem.Text==string.Empty)
            {
                return false;
            }

            if (tb_contact.Text==string.Empty)
            {
                return false;
            }

            if (tb_email.Text==string.Empty)
            {
                return false;
            }

            return true;
        }
    }
}
