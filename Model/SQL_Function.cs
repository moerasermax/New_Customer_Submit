using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using New_Customer_Submit.Model.Data_Set;
using New_Customer_Submit.Model.Define;
using New_Customer_Submit.Model;
using Newtonsoft.Json;
using System.Reflection;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace New_Customer_Submit.Model
{
        public class SQL_Function
        {
            SQL_Operation sql_operation = new SQL_Operation();



            public List<string> Insert_New_Form(SQL_Action_Category_Index mode_index, SQL_Action_Function_Index query_index,SqlConnection conn, string value)
            {
                List<string> result = new List<string>();
            

                try
                {
                    string cmd_str = string.Format("Insert INTO {0} (c_key,personal_id,form_id) Values(@c_key,@personal_id,@form_id)", "loan_house_application");
                    SqlCommand cmd = new SqlCommand(cmd_str, conn);
                    sql_operation.SQL_PARAMETER_Insert(query_index, cmd, value);
                    result = sql_operation.SQL_Excute(mode_index, query_index, conn, cmd);
                }
                catch (Exception)
                {
                    result.Add("新增客戶的新表單資料發生錯誤，請聯絡【研發中心-郁宸】");
                }

            return result;
        }
            public List<string> Insert_New_Customer(SQL_Action_Category_Index mode_index,SQL_Action_Function_Index query_index, SqlConnection conn, string value)
            {
                List<string> result = new List<string>();

                try
                {
                    string cmd_str = string.Format("Insert INTO {0} (c_key,personal_id,form_id) Values(@c_key,@personal_id,@form_id)", "loan_house_application");
                    SqlCommand cmd = new SqlCommand(cmd_str, conn);
                    sql_operation.SQL_PARAMETER_Insert(query_index, cmd, value);
                    result = sql_operation.SQL_Excute(mode_index, query_index, conn, cmd);
                }   
                catch (Exception ex)
                {
                    result.Add("新增新客戶資料發生錯誤，請聯絡【研發中心-郁宸】");
                }
                return result;
            }
            public List<string> Update_Form_Data(SQL_Action_Category_Index mode_index, SQL_Action_Function_Index query_index, SqlConnection conn, string value)
            {
                List<string> result = new List<string>();
                Loan_Data_Set loan_data = JsonConvert.DeserializeObject<Loan_Data_Set>(value);



                
                try
                {
                    foreach (var item in loan_data.GetType().GetProperties())
                    {
                    if (!item.Name.Equals("c_key"))
                    {
                        string cmd_str = string.Format("Update loan_house_application SET {0} = @{1} where c_key = @c_key", item.Name, item.Name, loan_data.c_key);
                        SqlCommand cmd = new SqlCommand(cmd_str, conn);

                        string update_value = "";
                        if (!(item.GetValue(loan_data, null).ToString() is null))
                        {
                            update_value = item.GetValue(loan_data, null).ToString();
                        }

                        sql_operation.SQL_PARAMETER_Insert(query_index, cmd, "@" + item.Name + "_]" + update_value + "_]" + loan_data.c_key);
                        result = sql_operation.SQL_Excute(mode_index, query_index, conn, cmd);
                    }
                }
            }
                catch (Exception)
                {

                    result.Add("更新資料時發生問題，請聯絡【研發中心-郁宸】");
                }

                return result;
            }
            public List<string> Get_Form_Data(SQL_Action_Category_Index mode_index, SQL_Action_Function_Index query_index, SqlConnection conn, string value)
            {
                List<string> result = new List<string>();
                try
                {
                    string cmd_str = string.Format("Select * from {0} where personal_id = @P_ID AND form_id = @F_ID", "loan_house_application", value);
                    SqlCommand cmd = new SqlCommand(cmd_str, conn);

                    sql_operation.SQL_PARAMETER_Insert(query_index, cmd, value);
                    result = sql_operation.SQL_Excute(mode_index, query_index, conn, cmd);
                }
                catch (Exception)
                {

                    result.Add("測試連線發生問題，請聯絡【研發中心-郁宸】。");

                }
                return result;
            }
            public List<string> Get_Personal_FormID(SQL_Action_Category_Index mode_index,SQL_Action_Function_Index query_index ,SqlConnection conn, string value)
                {
                    List<string> result = new List<string>();

                    try
                    {
                        string cmd_str = string.Format("Select * from {0} where personal_id = @P_ID", "loan_house_application", value);
                        SqlCommand cmd = new SqlCommand(cmd_str, conn);

                        sql_operation.SQL_PARAMETER_Insert(query_index, cmd, value);
                        result = sql_operation.SQL_Excute(mode_index, query_index, conn, cmd);
                    }
                    catch (Exception)
                    {

                        result.Add("測試連線發生問題，請聯絡【研發中心-郁宸】。");

                    }
                    return result;
                }


            public List<string> Try_Connection(SqlConnection conn)
            {
                List<string> result = new List<string>();

                try
                {
                    conn.Open();
                    conn.Close();
                    result.Add("測試連線成功。");
                }
                catch (Exception)
                {

                    result.Add("測試連線發生問題，請聯絡【研發中心-郁宸】。");

                }
                return result;
            }




        }


    public class SQL_Operation
    {
        public SqlCommand SQL_PARAMETER_Insert(SQL_Action_Function_Index query_index, SqlCommand cmd, string value)
        {
            string[] value_arr;
            switch (query_index)
            {
                case SQL_Action_Function_Index.Get_Personal_FormID:
                    cmd.Parameters.AddWithValue("@P_ID", value);
                    return cmd;
                case SQL_Action_Function_Index.Get_Form_Data:
                    value_arr = value.Split(',');
                    cmd.Parameters.AddWithValue("@P_ID", value_arr[0]);
                    cmd.Parameters.AddWithValue("@F_ID", value_arr[1]);
                    return cmd;
                case SQL_Action_Function_Index.Update_Form_Data:
                    value_arr = Regex.Split(value, "_]");
                    cmd.Parameters.AddWithValue(value_arr[0], value_arr[1]);
                    cmd.Parameters.AddWithValue("@c_key", value_arr[2]);
                    return cmd;
                case SQL_Action_Function_Index.New_Customer:
                    cmd.Parameters.AddWithValue("@c_key", value + "_F0001");
                    cmd.Parameters.AddWithValue("@personal_id", value);
                    cmd.Parameters.AddWithValue("@form_id", "F0001");
                    return cmd;
                case SQL_Action_Function_Index.New_Form:
                    string[] data_arr = value.Split('_');
                    cmd.Parameters.AddWithValue("@c_key", value);
                    cmd.Parameters.AddWithValue("@personal_id", data_arr[0]);
                    cmd.Parameters.AddWithValue("@form_id", data_arr[1]);
                    return cmd;
                default:
                    return cmd;
            }



        }

        public List<string> SQL_Excute(SQL_Action_Category_Index mode_index, SQL_Action_Function_Index query_index, SqlConnection conn, SqlCommand cmd)
        {
            List<string> result = new List<string>();
            DataProcess_Function data_process = new DataProcess_Function();

            try
            {
                switch (mode_index)
                {

                    case SQL_Action_Category_Index.Get:

                        DataTable dataTable = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dataTable);
                        conn.Close();
                        da.Dispose();
                        result =  data_process.Process_SQL_Result(query_index, dataTable);

                        break;
                    case SQL_Action_Category_Index.Update:
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            result.Add("資料庫更新完畢\r\n");
                            break;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                            break;
                        }
                    case SQL_Action_Category_Index.Insert:
                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            result.Add("新資料新增完成\r\n");
                            break;
                        }
                        catch (Exception ex) 
                        {

                            result.Add("新增資料發生問題，麻煩請重新確認\r\n");
                            break;
                        }

                    default:
                        result.Add("搜尋不到指定功能，請聯絡【研發中心-郁宸】。");
                        break;
                }
            }
            catch (Exception)
            {
                result.Add("搜尋資料時發生問題，請聯絡【研發中心-郁宸】。");
            }

            return result;


        } 


    }





}
