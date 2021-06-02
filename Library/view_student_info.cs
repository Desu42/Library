using System;
using System.IO;
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
    public partial class view_student_info : Form
    {
        SqlConnection sql_con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=library_management;Integrated Security=True;Pooling=False");
        string pwd;
        string wanted_path;
        DialogResult result;
        public view_student_info()
        {
            InitializeComponent();
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void view_student_info_Load(object sender, EventArgs e)
        {
            
            if (sql_con.State==ConnectionState.Open)
            {
                sql_con.Close();
            }
            sql_con.Open();

            fill_grid();
        }

        public void fill_grid()
        {
            dgv_student.Columns.Clear();
            dgv_student.Refresh();
            int i = 0;
            SqlCommand cmd = sql_con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM student_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv_student.DataSource = dt;

            Bitmap img;
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "student image";
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imageColumn.Width = 100;
            dgv_student.Columns.Add(imageColumn);

            foreach (DataRow dr in dt.Rows)
            {
                // PATH IS BAD
                Console.WriteLine(projectDirectory);
                Console.WriteLine(dr["student_image"].ToString());
                Console.WriteLine(projectDirectory + "\\Library\\" + dr["student_image"].ToString());

                img = new Bitmap(projectDirectory + "\\Library\\" + dr["student_image"].ToString());
                img = (Bitmap)resizeImage(img, new Size(100, 100));
                dgv_student.Rows[i].Cells[8].Value = img;
                dgv_student.Rows[i].Height = 100;
                i++;
            }
        }

        private void tb_search_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                // Show Image Properly
                dgv_student.Columns.Clear();
                dgv_student.Refresh();
                int i = 0;

                if (sql_con.State == ConnectionState.Open)
                {
                    sql_con.Close();
                }
                sql_con.Open();

                SqlCommand cmd = sql_con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM student_info WHERE student_name LIKE('%" + tb_search.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgv_student.DataSource = dt;

                Bitmap img;
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn.HeaderText = "student image";
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageColumn.Width = 100;
                dgv_student.Columns.Add(imageColumn);

                foreach (DataRow dr in dt.Rows)
                {
                    // PATH IS BAD
                    Console.WriteLine(projectDirectory);
                    Console.WriteLine(dr["student_image"].ToString());
                    Console.WriteLine(projectDirectory + "\\Library\\" + dr["student_image"].ToString());

                    img = new Bitmap(projectDirectory + "\\Library\\" + dr["student_image"].ToString());
                    img = (Bitmap)resizeImage(img, new Size(100, 100));
                    dgv_student.Rows[i].Cells[8].Value = img;
                    dgv_student.Rows[i].Height = 100;
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgv_student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(dgv_student.SelectedCells[0].Value.ToString());

            SqlCommand cmd = sql_con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM student_info WHERE id="+i+"";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                tb_name.Text = dr["student_name"].ToString();
                tb_enrolment_no.Text = dr["student_enrolment_no"].ToString();
                tb_department.Text = dr["student_department"].ToString();
                tb_semester.Text = dr["student_sem"].ToString();
                tb_contact.Text = dr["student_contact"].ToString();
                tb_email.Text = dr["student_email"].ToString();
            }
        }

        private void btn_select_image_Click(object sender, EventArgs e)
        {
            pwd = Class1.GetRandomPassword(20);
            wanted_path = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            result = ofd_select_new_image.ShowDialog();
            // for some reason this doesn't work - it actually works NOW.
            // refer to https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.filedialog.filter?view=net-5.0
            ofd_select_new_image.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*jpg|GIF Files (*.gif)|*.gif";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (result == DialogResult.OK) // Test result
            {
                int i;
                i = Convert.ToInt32(dgv_student.SelectedCells[0].Value.ToString());
                string img_path;
                File.Copy(ofd_select_new_image.FileName, wanted_path + "\\student_images\\" + pwd + ".jpg");

                img_path = "student_images\\" + pwd + ".jpg";

                SqlCommand cmd = sql_con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE student_info SET student_name='" + tb_name.Text + "', " +
                    "student_image='" + img_path.ToString() + "'," +
                    "student_enrolment_no='" + tb_enrolment_no.Text + "', " +
                    "student_department='" + tb_department.Text + "', " +
                    "student_sem='" + tb_semester.Text + "', " +
                    "student_contact='" + tb_contact.Text + "', " +
                    "student_email='" + tb_email.Text + "'WHERE id=" + i + "";
                cmd.ExecuteNonQuery();
                fill_grid();
                MessageBox.Show("Record Updated Successfully!");
            }
            // need to first cancel adding image in order to change other stuff.
            else if(result==DialogResult.Cancel)
            {
                int i;
                i = Convert.ToInt32(dgv_student.SelectedCells[0].Value.ToString());
                SqlCommand cmd = sql_con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE student_info SET student_name='" + tb_name.Text + "', " +
                    "student_enrolment_no='" + tb_enrolment_no.Text + "', " +
                    "student_department='" + tb_department.Text + "', " +
                    "student_sem='" + tb_semester.Text + "', " +
                    "student_contact='" + tb_contact.Text + "', " +
                    "student_email='" + tb_email.Text + "'WHERE id=" + i + "";
                cmd.ExecuteNonQuery();
                fill_grid();
                MessageBox.Show("Record Updated Successfully!");
            }
        }
    }
}
