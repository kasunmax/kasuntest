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


namespace Student_Registration
{
    public partial class Form3 : Form
    {


        public string empdet;
        Class1 obj1 = new Class1();
        SqlConnection connn;
        SqlCommand comm;
        private DataGridView dataGridView1 = new DataGridView();


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection con = obj1.Establishconnection();
            con.Open();
            DataSet ds = new DataSet();
            empdet = "SELECT Registrationtb.Student_Id,Registrationtb.Stu_Name,Registrationtb.DOB,Registrationtb.Grade_Point_Avg,Registrationtb.Active FROM Registrationtb ";
            SqlDataAdapter adp = new SqlDataAdapter(empdet, con);
            SqlCommandBuilder com = new SqlCommandBuilder(adp);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            //dataGridView1.DataSource = dt;

            

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SqlConnection con = obj1.Establishconnection();
            con.Open();

            try
            {
                string StrQuery = @"INSERT INTO Registrationtb VALUES (" + dataGridView1.Rows[0].Cells["Stu_Name"].Value + ", " + dataGridView1.Rows[1].Cells["DOB"].Value + ", " + dataGridView1.Rows[2].Cells["Grade_Point_Avg"].Value + ", " + dataGridView1.Rows[3].Cells["Active"].Value + ");";
            }
            catch (Exception)
            {
                
                throw;
            }
            DataSet ds = new DataSet();
            empdet = "SELECT Registrationtb.Student_Id,Registrationtb.Stu_Name,Registrationtb.DOB,Registrationtb.Grade_Point_Avg,Registrationtb.Active FROM Registrationtb ";
            SqlDataAdapter da= new SqlDataAdapter ();
            SqlCommandBuilder com = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();
            con.Close();
           
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtGrade_Point_Avg_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtStudent_Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
