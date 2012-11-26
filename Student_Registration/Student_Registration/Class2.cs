using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Student_Registration
{
    class Class2
    {
        public SqlConnection Establishconnection()
        {
            string constringg = @"Data Source=DELL-PC;Initial Catalog=studentDB;User ID=sa;Password=***********";
            try
            {
                SqlConnection conn = new SqlConnection(constringg);

                return conn;
            }
            catch (Exception ee)
            {

                return null;
            }


        }

    
    }
}
