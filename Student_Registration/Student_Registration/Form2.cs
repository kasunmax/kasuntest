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
    public partial class Form2 : Form
    {

        public string empdet;
        Class1 obj1 = new Class1();
        SqlConnection connn;
        SqlCommand comm;
        private BindingSource bindingSource1 = new BindingSource();



        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_New_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bindingSource1;
            GetData("select * from Customers");
            SqlConnection con = obj1.Establishconnection();
            con.Open();
            DataSet ds = new DataSet();
            empdet = "SELECT Registrationtb.Student_Id,Registrationtb.Stu_Name,Registrationtb.DOB,Registrationtb.Grade_Point_Avg,Registrationtb.Active FROM Registrationtb ";
            SqlDataAdapter adp = new SqlDataAdapter(empdet, con);
            SqlCommandBuilder com = new SqlCommandBuilder(adp);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }



        private void GetData(string selectCommand)
        {
            try
            {
                
                String connectionString ="@ Data Source=DELL-PC;Initial Catalog=studentDB;User ID=sa;Password=*********** ";

                
                SqlDataAdapter adp = new SqlDataAdapter(selectCommand, connectionString);


                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adp);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adp.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("dddd");
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //SqlConnection con = obj1.Establishconnection();
            //con.Open();
            //SqlDataAdapter da = new SqlDataAdapter();

            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    string StrQuery = @"INSERT INTO Registrationtb VALUES (" + dataGridView1.Rows[i].Cells["Stu_Name"].Value + ", " + dataGridView1.Rows[i].Cells["DOB"].Value + ", " + dataGridView1.Rows[i].Cells["Grade_Point_Avg"].Value + ", " + dataGridView1.Rows[i].Cells["Active"].Value + ");";

            //    try
            //    {
            //        using (SqlConnection conn = new SqlConnection(StrQuery))
            //        {
            //            using (SqlCommand com = new SqlCommand(StrQuery, con))
            //            {
            //                conn.Open();
            //                comm.ExecuteNonQuery();
            //            }
            //        }
            //    }

            //    catch (Exception ee)
            //    {

            //        throw;
            //    }
            //}


            SqlConnection con = obj1.Establishconnection();
            //SqlConnection conn = new SqlConnection(constringg);
            //string constring = @"Data Source=DELL-PC;Initial Catalog=studentDB;User ID=sa;Password=*********** ";
            con.Open();
            try
            {


                string constringg = "INSERT INTO Registrationtb (Student_Id,Stu_Name,DOB,Grade_Point_Avg,Active) " + " VALUES (" + this.txtStudentId.Text.Trim() + ", " + this.txtName.Text.Trim() + ", " + this.txtStudentId.Text.Trim() + ", " + this.txtGradePointAvarage.Text.Trim() + ", " + this.checkBox1.Text.Trim() + "," + this.checkBox2.Text.Trim() + ");";

                SqlCommand oc = new SqlCommand(constringg, con);
                oc.ExecuteNonQuery();
                MessageBox.Show("successfully Inserted");

                //this.clear();
                con.Close();


            }
            catch (Exception ee)
            {
                throw;

            }
            SqlConnection conn = obj1.Establishconnection();
            conn.Open();
            DataSet ds = new DataSet();
            empdet = "SELECT Registrationtb.Student_Id,prdaemptb.Stu_Name,prdaemptb.DOB,prdaemptb.Grade_Point_Avg,prdaemptb.Active FROM Registrationtb";
            SqlDataAdapter adp = new SqlDataAdapter(empdet, con);
            SqlCommandBuilder com = new SqlCommandBuilder(adp);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridView1.DataSource = dt;


        }
    }
}

