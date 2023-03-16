using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Customer_Submit.Model.Define;
using New_Customer_Submit.Model;
namespace New_Customer_Submit.Controller
{
    public class Controller_SQL_Catergory
    {

        Controller_SQL_Function sql_function_controller = new Controller_SQL_Function();

        public List<string> SQL_Action_Category_Controller(SQL_Action_Category_Index mode_index,SQL_Action_Function_Index query_index, SqlConnection conn, string value)
        {
            List<string> Result = new List<string>();

            try
            {
                switch (mode_index)
                {
                    case SQL_Action_Category_Index.Test:
                        return sql_function_controller.SQL_Action_Function_Controller(mode_index,query_index, conn,value);
                    case SQL_Action_Category_Index.Get:
                        return sql_function_controller.SQL_Action_Function_Controller(mode_index,query_index, conn, value);
                    case SQL_Action_Category_Index.Update:
                        return sql_function_controller.SQL_Action_Function_Controller(mode_index, query_index, conn, value);
                    case SQL_Action_Category_Index.Insert:
                        return sql_function_controller.SQL_Action_Function_Controller(mode_index, query_index, conn, value);
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
