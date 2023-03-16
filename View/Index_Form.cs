using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;
using New_Customer_Submit.Controller;
using New_Customer_Submit.Model.Define;
using New_Customer_Submit.Model.Data_Set;
using New_Customer_Submit.Model.UI_Function;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using New_Customer_Submit.Model;

namespace New_Customer_Submit.View
{
    public partial class index_form : Form
    {
        Index_Form_UI index_form_ui_function = new Index_Form_UI();
        Controller_SQL_Catergory sql_category_controller = new Controller_SQL_Catergory();
        SQL_Conn_Set sql_conn_set = new SQL_Conn_Set();
        Loan_Data_Set loan_data = new Loan_Data_Set();


        public index_form()
        {
            InitializeComponent();
        }




        private void Get_Personal_Form_Click(object sender, EventArgs e)
        {
            // Load Conn 
            sql_conn_set.SQL_Conn_Load();
            SqlConnection conn = sql_conn_set.Get_Conn(sql_conn_set.conn_str);

            
            try
            {
                // Process
                List<string> data = sql_category_controller.SQL_Action_Category_Controller(SQL_Action_Category_Index.Get, SQL_Action_Function_Index.Get_Personal_FormID, conn, Personal_id.Text);

                // Update UI
                index_form_ui_function.Update_FormID(Form_ID_Combobox, data);
                Get_Form_Data.Enabled = true;

                // Response Result
                ConsoleBox.Text += string.Format("已完成 {0} 的單號獲取\r\n",Personal_id.Text);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void Test_Connection_Click(object sender, EventArgs e)
        {
            // Load Conn 
            sql_conn_set.SQL_Conn_Load();

            // Process
            SqlConnection conn =  sql_conn_set.Get_Conn(sql_conn_set.conn_str);

            // Response Result
            ConsoleBox.Text += string.Format("{0} \r\n", sql_category_controller.SQL_Action_Category_Controller(SQL_Action_Category_Index.Test, SQL_Action_Function_Index.Try_Connection, conn, "")[0]);
        }

        private void Get_Form_Data_Click(object sender, EventArgs e)
        {
            Get_FromID_Data();
        }

        private void Get_FromID_Data()
        {
            if (Form_ID_Combobox.Text.Equals(""))
            {
                MessageBox.Show("請先選擇要查詢的表單號");
            }
            else
            {

                // Load Conn 
                sql_conn_set.SQL_Conn_Load();
                SqlConnection conn = sql_conn_set.Get_Conn(sql_conn_set.conn_str);

                // Process
                string value = Personal_id.Text + "," + Form_ID_Combobox.Text;
                List<string> data_json = sql_category_controller.SQL_Action_Category_Controller(SQL_Action_Category_Index.Get, SQL_Action_Function_Index.Get_Form_Data, conn, value);

                // Data Process
                Loan_Data_Set data = JsonConvert.DeserializeObject<List<Loan_Data_Set>>(data_json[0])[0];
                loan_data = data;
                DataProcess_Function dataprocess_function = new DataProcess_Function();
                dataprocess_function.Compare_Loan_Null_Object(ref loan_data);


                // Update UI
                Update_Index_UI();

                // Response Result
                if (data_json[0].Length <= 10)
                {
                    ConsoleBox.Text += string.Format("{0}", data_json[0]);
                }
                else
                {
                    ConsoleBox.Text += string.Format("已完成 {0} 的 {1} 單號資料\r\n", Personal_id.Text, Form_ID_Combobox.Text);
                }
            }
        }

        private void Update_Index_UI()
        {
            index_form_ui_function.Update_Extends_UI(Special_Mark, loan_data.extend_data_json);

        }

        private void Modify_FormData_Click(object sender, EventArgs e)
        {
            Modify_Formdata_Form modify_formdata_form = new Modify_Formdata_Form(loan_data);
            modify_formdata_form.Show();

        }

        private void New_Customer_Click(object sender, EventArgs e)
        {
            string value;
            string P_ID = Personal_id.Text;
            value = P_ID;
            try
            {
                //Load Conn
                sql_conn_set.SQL_Conn_Load();
                SqlConnection conn = sql_conn_set.Get_Conn(sql_conn_set.conn_str);

                // Process
                ConsoleBox.Text += string.Format("{0} \r\n", sql_category_controller.SQL_Action_Category_Controller(SQL_Action_Category_Index.Insert, SQL_Action_Function_Index.New_Customer, conn, value)[0]);
            }
            catch (Exception)
            {
                ConsoleBox.Text += "連線發生錯誤，請聯繫【研發中心】。";
            }

        }

        private void New_Form_Click(object sender, EventArgs e)
        {
            string value;
            string P_ID = Personal_id.Text;
            value = P_ID;
            try
            {
                //Load Conn
                sql_conn_set.SQL_Conn_Load();
                SqlConnection conn = sql_conn_set.Get_Conn(sql_conn_set.conn_str);

                // Process
                List<string> data = sql_category_controller.SQL_Action_Category_Controller(SQL_Action_Category_Index.Get, SQL_Action_Function_Index.Get_Personal_FormID, conn, Personal_id.Text);
                string Form_NO = (data.Count + 1).ToString().PadLeft(4, '0');
                sql_category_controller.SQL_Action_Category_Controller(SQL_Action_Category_Index.Insert, SQL_Action_Function_Index.New_Form, conn, Personal_id.Text + "_F" + Form_NO);



            }
            catch (Exception)
            {
                ConsoleBox.Text += "連線發生錯誤，請聯繫【研發中心】。";
            }

        }
    }
}
