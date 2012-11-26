using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Student_Registration
{
    class Class1
    {

        public SqlConnection Establishconnection()
        {
            string constring = @"Data Source=DELL-PC;Initial Catalog=studentDB;User ID=sa;Password=*********** ";
            try
            {
                SqlConnection con = new SqlConnection(constring);

                return con;
            }
            catch (Exception ee)
            {

                return null;
            }


        }

    }
}
