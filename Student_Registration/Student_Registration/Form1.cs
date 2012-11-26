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
    public partial class Form1 : Form
    {

        public string empdet;
        Class1 obj1 = new Class1();
        SqlConnection connn;
        SqlCommand comm;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNew_Registration_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit ();
        }

        private void Form1_Load(object sender, EventArgs e)
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
    }
}
