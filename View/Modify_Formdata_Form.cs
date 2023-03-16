using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using New_Customer_Submit.Model.Data_Set;
using New_Customer_Submit.Model.UI_Function;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using Microsoft.VisualBasic.Logging;
using System.Reflection;
using New_Customer_Submit.Controller;
using New_Customer_Submit.View.Template;
using System.Security.Principal;
using New_Customer_Submit.Model.Define;
using System.Data.SqlClient;
using New_Customer_Submit.Model;

namespace New_Customer_Submit.View
{
    public partial class Modify_Formdata_Form : Form
    {
        Loan_Data_Set loan_data =  new Loan_Data_Set();
        Controller_Modify_Formdata_UI modify_ui_controller = new Controller_Modify_Formdata_UI();

        public Modify_Formdata_Form()
        {

        }

        public Modify_Formdata_Form(Loan_Data_Set loan_data_set)
        {
            InitializeComponent();
            loan_data = loan_data_set;

            Load_Application_Information_Area_Data();
            Load_Application_Information_Area_Combobox_Data();

            Update_Customer_UI();
            Log_Textbox.Text += String.Format("已完成 {0} 客戶 的 {1} 訂單載入\r\n", loan_data.personal_id, loan_data.form_id);
            
        }

        #region Common

        public void Update_Loan_Data_Status()
        {

            loan_data.department = department.Text;
            loan_data.loan_type = loan_type.Text;
            loan_data.loan_period = loan_period.Text;
            loan_data.repayment_type = repayment_type.Text;
            loan_data.case_source = case_source.Text;
            loan_data.loan_purpose = loan_purpose.Text;
            loan_data.apply_amount = apply_amount.Text;
            // 專案名稱還沒
            loan_data.salesman_name = salesman_name.Text;

            DataProcess_Function dataprocess_function = new DataProcess_Function();

            dataprocess_function.Update_Loan_Customer_DataStatus(Customer_Data_Panel, ref loan_data);




        }
        public void Load_Application_Information_Area_Combobox_Data()
        {
            Log_Textbox.Text += modify_ui_controller.Modify_UI_Controller(Modify_Form_Action_Index.Load_Application_Information_Combobox_Data_Update_UI, this, loan_data, "")[0];
        }
        public void Load_Application_Information_Area_Data()
        {
            Log_Textbox.Text += modify_ui_controller.Modify_UI_Controller(Modify_Form_Action_Index.Update_UI, this, loan_data, "")[0];
        }
        private void Saving_Click(object sender, EventArgs e)
        {
            // Pro-Process
            Update_Loan_Data_Status();
            string loan_data_json = JsonConvert.SerializeObject(loan_data);
            SQL_Conn_Set sql_conn_set = new SQL_Conn_Set();
            // Load Conn 
            sql_conn_set.SQL_Conn_Load();

            // Process
            SqlConnection conn = sql_conn_set.Get_Conn(sql_conn_set.conn_str);

            Controller_SQL_Catergory sql_category_controller = new Controller_SQL_Catergory();
            Log_Textbox.Text += sql_category_controller.SQL_Action_Category_Controller(SQL_Action_Category_Index.Update, SQL_Action_Function_Index.Update_Form_Data, conn, loan_data_json)[0];

        }


        #endregion

        #region Customer_Data_
        public void Update_Customer_UI()
        {
            Log_Textbox.Text += modify_ui_controller.Modify_UI_Controller(Modify_Form_Action_Index.Load_Customer_Data_Update_UI, this, loan_data, "")[0];
        }
        private void New_Customer_Click(object sender, EventArgs e)
        {
            List<Loan_Data_Set.Customer> customer = JsonConvert.DeserializeObject<List<Loan_Data_Set.Customer>>(loan_data.customer_data_json);

            string Input_Identity = Interaction.InputBox("請輸入", "請輸入新客戶的身分證字號");

            if (Input_Identity.Length > 0)
            {
                //判斷是否有存在的身分證了
                bool compare_pass = true;
                for (int i = 0; i <= customer.Count - 1; i++)
                {
                    if (customer[i].Identity == Input_Identity)
                    {
                        compare_pass = false;
                    }
                }

                //處理新增流程
                if (compare_pass == true)
                {
                    Log_Textbox.Text += modify_ui_controller.Modify_UI_Controller(Modify_Form_Action_Index.New_Customer, this, loan_data, Input_Identity)[0];



                }
                else
                {
                    MessageBox.Show(String.Format("此身分證{0}已存在，請重新確認。\r\n", Input_Identity));
                }

            }
            else
            {
                MessageBox.Show(String.Format("輸入值為空，請重新確認。"));
            }


        }
        public void Generate_Customer_Remove_Button(int index)
        {
            int delta_x = 450;
            Demo demo = new Demo();
            List<Loan_Data_Set.Customer> customer = JsonConvert.DeserializeObject<List<Loan_Data_Set.Customer>>(loan_data.customer_data_json);
            Button Remove_Button = new Button();
            Remove_Button.Name = customer[index].Identity + demo._Delete_Button.Name; /// Customer Index
            Remove_Button.Click += Remove_Customer_Button_Click;
            Remove_Button.Text = demo._Delete_Button.Text;
            Remove_Button.Location = new Point(demo._Delete_Button.Location.X + (delta_x * (index)), demo._Delete_Button.Location.Y);
            this.Customer_Data_Panel.Controls.Add(Remove_Button);
            Remove_Button.BringToFront();

        }
        public void Remove_Customer_Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            List<Loan_Data_Set.Customer> customer = JsonConvert.DeserializeObject<List<Loan_Data_Set.Customer>>(loan_data.customer_data_json);



            List<GroupBox> List_GroupBox = new List<GroupBox>();

            ///先搜尋 Customer_Data Panel
            foreach (Control item in this.Customer_Data_Panel.Controls)
            {
                ///再蒐集 GroupBox
                if (item is GroupBox)
                {
                    List_GroupBox.Add((GroupBox)item);
                }
            }

            ///接著跑 執行刪除
            Remove_Customer_Data(ref customer, ref List_GroupBox, clickedButton);
            foreach (Control item in this.Customer_Data_Panel.Controls)
            {

                if (item is GroupBox)
                {
                    bool compare_delete = true;

                    for (int i = 0; i <= List_GroupBox.Count - 1; i++)
                    {
                        if (item.Name.Equals(List_GroupBox[i].Name))
                        {

                            compare_delete = false;

                        }
                    }

                    if (compare_delete)
                    {
                        this.Customer_Data_Panel.Controls.Remove(item);
                        compare_delete = true;
                    }

                }


            }

            clickedButton.Dispose();

        }
        public List<string> Remove_Customer_Data(ref List<Loan_Data_Set.Customer> List_Customer, ref List<GroupBox> L_Groupbox, Button Remove_Button)
        {
            List<string> result = new List<string>();
            string[] Remove_Button_Arr = Remove_Button.Name.Split('_');
            string Remove_Customer_ID = Remove_Button_Arr[0];
            try
            {
                /// 刪除 Class 內的資料
                foreach (Loan_Data_Set.Customer customer_data in List_Customer)
                {
                    if (customer_data.Identity.Equals(Remove_Customer_ID))
                    {
                        List_Customer.Remove(customer_data);
                        break;
                    }
                }

                /// 刪除GroupBox的List 指定資料 - 需實作

                foreach (GroupBox GB in L_Groupbox)
                {
                    if (GB.Name.Equals(Remove_Customer_ID))
                    {
                        /// 刪除 Class 內的資料
                        /// 刪除GroupBox的List 指定資料
                        L_Groupbox.RemoveAt(L_Groupbox.IndexOf(GB));
                        break;
                    }
                }

                string Customer_Current_Data_Json = JsonConvert.SerializeObject(List_Customer);
                loan_data.customer_data_json = Customer_Current_Data_Json;

            }
            catch (Exception)
            {
                result.Add("刪除客戶失敗，請聯絡【研發中心-郁宸】。");
            }

            return result;
        }

        #endregion


        private void NextPage_Click(object sender, EventArgs e)
        {
            Real_Estate_Land_Certificate_Form real_estate_land_certificate_form = new Real_Estate_Land_Certificate_Form(ref loan_data);
            real_estate_land_certificate_form.Show();
        }
    }
}
