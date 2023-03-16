using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using New_Customer_Submit.Model;
using New_Customer_Submit.Model.Data_Set;
using New_Customer_Submit.Model.Define;
using New_Customer_Submit.Model.UI_Function;
using New_Customer_Submit.Controller;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.VisualBasic;
using New_Customer_Submit.View.Template;
using System.Data.SqlClient;

namespace New_Customer_Submit.View
{
    public partial class Real_Estate_Land_Certificate_Form : Form
    {
        DataProcess_Function dataprocess_function = new DataProcess_Function();
        List<Loan_Data_Set.Real_Estate_Certificate> list_real_estate_certificate = new List<Loan_Data_Set.Real_Estate_Certificate>();
        Controller_Real_Estate_Land_Certificate_UI real_estate_land_certificate_ui_controller = new Controller_Real_Estate_Land_Certificate_UI();
        Loan_Data_Set temp_loan_data;
        bool Current_Update_Every_Chane_Off = false; /// 先將隨時更新資料表給關掉，等匯入完資料再開始執行的開關。


        public Real_Estate_Land_Certificate_Form(ref Loan_Data_Set loan_data)
        {
            temp_loan_data = loan_data;
            if(loan_data.real_estate_certificate != null)
            {
                list_real_estate_certificate = JsonConvert.DeserializeObject<List<Loan_Data_Set.Real_Estate_Certificate>>(loan_data.real_estate_certificate);
            }
            InitializeComponent();
        }
        private void Real_Estate_Land_Certificate_Form_Load(object sender, EventArgs e)
        {
            Update_House_Object_UI();
            Current_Update_Every_Chane_Off = false;
            Real_Estate_Land_Certificate_Form_UI function_real_estate_land_certificate_ui = new Real_Estate_Land_Certificate_Form_UI();
            if (temp_loan_data.real_estate_certificate != null)
            {
                function_real_estate_land_certificate_ui.Load_Column_Data(real_estate_land_datagridview, list_real_estate_certificate);
                Current_Update_Every_Chane_Off = true;
            }
        }


        /// Remove Button 處理事件
        public void Generate_House_Remove_Button(int index)
        {
            int delta_y = 250;
            Demo demo = new Demo();
            List<Loan_Data_Set.House_Object> house_object = JsonConvert.DeserializeObject<List<Loan_Data_Set.House_Object>>(temp_loan_data.house_object_json);
            Button Remove_Button = new Button();
            Remove_Button.Name = house_object[index].House_ID + "_"+ demo.remove_house_object_button.Name; /// Customer Index
            Remove_Button.Click += Remove_House_Object_Button_Click;
            Remove_Button.Text = demo.remove_house_object_button.Text;
            Remove_Button.Size = demo.remove_house_object_button.Size;
            Remove_Button.Location = new Point(demo.remove_house_object_button.Location.X, demo.remove_house_object_button.Location.Y + (delta_y * (index)));
            this.House_Object_Panel.Controls.Add(Remove_Button);
            Remove_Button.BringToFront();
        }
        public void Remove_House_Object_Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            List<Loan_Data_Set.House_Object> house_object = JsonConvert.DeserializeObject<List<Loan_Data_Set.House_Object>>(temp_loan_data.house_object_json);



            List<GroupBox> List_GroupBox = new List<GroupBox>();

            ///先搜尋 Customer_Data Panel
            foreach (Control item in this.House_Object_Panel.Controls)
            {
                ///再蒐集 GroupBox
                if (item is GroupBox)
                {
                    List_GroupBox.Add((GroupBox)item);
                }
            }

            ///接著跑 執行刪除
            Remove_House_Object_Data(ref house_object, ref List_GroupBox, clickedButton);
            foreach (Control item in this.House_Object_Panel.Controls)
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
                        this.House_Object_Panel.Controls.Remove(item);
                        compare_delete = true;
                    }

                }


            }
            clickedButton.Dispose();
        }
        public List<string> Remove_House_Object_Data(ref List<Loan_Data_Set.House_Object> list_house_object, ref List<GroupBox> List_Groupbox, Button Remove_Button)
        {
            List<string> result = new List<string>();
            string[] Remove_Button_Arr = Remove_Button.Name.Split('_');
            string Remove_House_Object_ID = Remove_Button_Arr[0];
            try
            {
                /// 刪除 Class 內的資料
                foreach (Loan_Data_Set.House_Object house_object_data in list_house_object)
                {
                    if (house_object_data.House_ID.Equals(Remove_House_Object_ID))
                    {
                        list_house_object.Remove(house_object_data);
                        break;
                    }
                }

                /// 刪除GroupBox的List 指定資料 - 需實作

                foreach (GroupBox GB in List_Groupbox)
                {
                    if (GB.Name.Equals(Remove_House_Object_ID))
                    {
                        /// 刪除 Class 內的資料
                        /// 刪除GroupBox的List 指定資料
                        List_Groupbox.RemoveAt(List_Groupbox.IndexOf(GB));
                        break;
                    }
                }

                string House_Object_Current_Data_Json = JsonConvert.SerializeObject(list_house_object);
                temp_loan_data.house_object_json = House_Object_Current_Data_Json;

            }
            catch (Exception)
            {
                result.Add("刪除客戶失敗，請聯絡【研發中心-郁宸】。");
            }

            return result;
        }


        /// Table 處理事件
        public void Update_House_Object_UI()
        {
            Log_Textbox.Text += real_estate_land_certificate_ui_controller.House_Object_Controller(Real_Estate_Land_Certificate_UI_Index_Action.Load_House_Object_Data_Update_UI, this, temp_loan_data, "")[0];
        }
        private void New_Estate_Click(object sender, EventArgs e)
        {
            string real_estate_str = "";
            string[] real_estate_arr;

            /// 尋找建物謄本 TextBox 並將資料彙整
            foreach (Control item in this.House_Object_Panel.Controls)
            {
                if(item is GroupBox)
                {
                    foreach (Control item_item in item.Controls)
                    {
                        if (item_item.Name.Equals("real_estate_no"))
                        {
                            ListBox listbox = item_item as ListBox;
                            foreach (var list_item in listbox.Items)
                            {
                                real_estate_str += list_item.ToString() + ",";
                            }
                        }
                    }
                }
            }

            real_estate_arr = real_estate_str.Split(',');

            try
            {
                for (int i = 0; i < real_estate_arr.Length-1; i++)
                {
                    Real_Estate_Land_Certificate_Form_UI function_real_estate_land_certificate_ui = new Real_Estate_Land_Certificate_Form_UI();
                    function_real_estate_land_certificate_ui.New_Estate_Data(real_estate_land_datagridview, real_estate_arr[i]);
                }

                    Current_Update_Every_Chane_Off = true;
            }
            catch (Exception)
            {

                MessageBox.Show("請重新輸入【謄本編號】。");
            }



        }
        private void New_Public_Facility_Click(object sender, EventArgs e)
        {
            string Input_real_estate_land_certificate_no = Interaction.InputBox("輸入哪個建物的公設", "請輸入");

            if (Input_real_estate_land_certificate_no.Length >= 4)
            {
                Real_Estate_Land_Certificate_Form_UI function_real_estate_land_certificate_ui = new Real_Estate_Land_Certificate_Form_UI();
                function_real_estate_land_certificate_ui.New_Public_Facility(real_estate_land_datagridview, Input_real_estate_land_certificate_no);
                Current_Update_Every_Chane_Off = true;
            }
            else
            {
                MessageBox.Show("請重新輸入【謄本編號】。");
            }

        }

        /// 動態運算部分
        private void real_certificate_datagridview_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (Current_Update_Every_Chane_Off)
            {
                Real_Estate_Land_Certificate_Form_UI function_real_estate_land_certificate_ui = new Real_Estate_Land_Certificate_Form_UI();
                function_real_estate_land_certificate_ui.Update_Column_New_Data(real_estate_land_datagridview);
            }

        }


        private void New_House_Object_Click(object sender, EventArgs e)
        {
                List<Loan_Data_Set.House_Object> house_object = JsonConvert.DeserializeObject<List<Loan_Data_Set.House_Object>>(temp_loan_data.house_object_json);

                string Input_House_ID = Interaction.InputBox("請輸入", "請輸入新房屋物件的編號");

                if (Input_House_ID.Length > 0)
                {
                    //判斷是否有存在的房屋物件編號了
                    bool compare_pass = true;
                    for (int i = 0; i <= house_object.Count - 1; i++)
                    {
                        if (house_object[i].House_ID == Input_House_ID)
                        {
                            compare_pass = false;
                        }
                    }

                    //處理新增流程
                    if (compare_pass == true)
                    {
                        Log_Textbox.Text += real_estate_land_certificate_ui_controller.House_Object_Controller(Real_Estate_Land_Certificate_UI_Index_Action.New_House_Object, this, temp_loan_data, Input_House_ID)[0];
                    }
                    else
                    {
                        MessageBox.Show(String.Format("此房屋編號 {0} 已存在，請重新確認。\r\n", Input_House_ID));
                    }

                }
                else
                {
                    MessageBox.Show(String.Format("輸入值為空，請重新確認。"));
                }
        }

        private void Saving_Click(object sender, EventArgs e)
        {
            dataprocess_function.Update_Loan_House_DataStatus(House_Object_Panel, ref temp_loan_data); /// Update
            string loan_data_json = JsonConvert.SerializeObject(temp_loan_data);
            SQL_Conn_Set sql_conn_set = new SQL_Conn_Set();
            // Load Conn 
            sql_conn_set.SQL_Conn_Load();

            // Process
            SqlConnection conn = sql_conn_set.Get_Conn(sql_conn_set.conn_str);

            Controller_SQL_Catergory sql_category_controller = new Controller_SQL_Catergory();
            Log_Textbox.Text += sql_category_controller.SQL_Action_Category_Controller(SQL_Action_Category_Index.Update, SQL_Action_Function_Index.Update_Form_Data, conn, loan_data_json)[0];

        }

        private void Remove_Single_Row_Click(object sender, EventArgs e)
        {
            try
            {
                real_estate_land_datagridview.Rows.RemoveAt(real_estate_land_datagridview.CurrentCell.RowIndex);

            }
            catch (Exception)
            {
                MessageBox.Show("資料行不存在");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string list_json = JsonConvert.SerializeObject(list_real_estate_certificate);
            MessageBox.Show(list_json);
        }
    }
}
