using New_Customer_Submit.Model;
using New_Customer_Submit.Model.Define;
using New_Customer_Submit.Model.Data_Set;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Customer_Submit.Controller
{
    public class Controller_SQL_Function
    {
        SQL_Function sql_function = new SQL_Function();


        public List<string> SQL_Action_Function_Controller(SQL_Action_Category_Index mode_index,SQL_Action_Function_Index query_index, SqlConnection conn, string value)
        {

            List<string> Result = new List<string>();

            try
            {
                switch (query_index)
                {
                    case SQL_Action_Function_Index.Try_Connection:
                        return sql_function.Try_Connection(conn);
                    case SQL_Action_Function_Index.Get_Personal_FormID:
                        return sql_function.Get_Personal_FormID(mode_index,query_index, conn, value);
                    case SQL_Action_Function_Index.Get_Form_Data:
                        return sql_function.Get_Form_Data(mode_index, query_index, conn, value);
                    case SQL_Action_Function_Index.Update_Form_Data:
                        return sql_function.Update_Form_Data(mode_index, query_index, conn, value);
                    case SQL_Action_Function_Index.New_Customer:
                        return sql_function.Insert_New_Customer(mode_index, query_index, conn, value);
                    case SQL_Action_Function_Index.New_Form:
                        return sql_function.Insert_New_Form(mode_index,query_index,conn,value);
                    default:
                        break;
                }



            }
            catch (Exception)
            {

                Result.Add("發生異常問題，請聯絡【研發中心-郁宸】。");
            }




            return Result;
        }



    }
}
