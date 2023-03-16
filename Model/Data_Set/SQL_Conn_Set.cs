using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace New_Customer_Submit.Model.Data_Set
{
    public class SQL_Conn_Set
    {
        public string Data_Source { get; set; }
        public string Data_Base { get; set; }
        public string User_id { get; set; }
        public string Password { get; set; }
        public string conn_str { get; set; }

        public void SQL_Conn_Load()
        {
            Data_Source = "tcp:192.168.1.115,55888\\SQLEXPRESS";
            Data_Base = "RiskForm";
            User_id = "tammy2";
            Password = "tammymoon";
            conn_str = string.Format("Data Source={0}; Database={1}; Trusted_Connection={2};user id={3};password={4}", Data_Source, Data_Base, "false", User_id, Password);
        }

        public SqlConnection Get_Conn(string conn_str)
        {
            return new SqlConnection(conn_str);
        }
    }
}
