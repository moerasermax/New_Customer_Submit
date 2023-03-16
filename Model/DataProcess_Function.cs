using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Customer_Submit.Model.Define;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Windows.Forms;
using New_Customer_Submit.Model.Data_Set;
using New_Customer_Submit.View.Template;
using static New_Customer_Submit.Model.Data_Set.Loan_Data_Set;

namespace New_Customer_Submit.Model
{
    public class DataProcess_Function
    {
        public void Update_Customer_Contact_Asset_Data(Panel panel,ref List<Loan_Data_Set.Customer> list_customers, int index_count)
        {
            foreach (Control item in panel.Controls)
            {
                if (item is TextBox)
                {
                    TextBox data_textbox = new TextBox();
                    data_textbox = item as TextBox;
                    if (item.Text is null) { item.Text = ""; }
                    if (item.Name.Equals("CONTACT_1_NAME_TEXTBOX")) { list_customers[index_count].Customer_Asset_Contact_Data.Contact_1 = data_textbox.Text; }
                    if (item.Name.Equals("CONTACT_1_CELLPHONE_TEXTBOX")) { list_customers[index_count].Customer_Asset_Contact_Data.Contact_1_CellPhone = data_textbox.Text; }
                    if (item.Name.Equals("CONTACT_1_TITTLE_TEXTBOX")) { list_customers[index_count].Customer_Asset_Contact_Data.Contact_1_Tittle = data_textbox.Text; }
                    if (item.Name.Equals("CONTACT_2_NAME_TEXTBOX")) { list_customers[index_count].Customer_Asset_Contact_Data.Contact_2 = data_textbox.Text; }
                    if (item.Name.Equals("CONTACT_2_CELLPHONE_TEXTBOX")) { list_customers[index_count].Customer_Asset_Contact_Data.Contact_2_CellPhone = data_textbox.Text; }
                    if (item.Name.Equals("CONTACT_2_TITTLE_TEXTBOX")) { list_customers[index_count].Customer_Asset_Contact_Data.Contact_2_Tittle = data_textbox.Text; }
                    if (item.Name.Equals("HAVE_CAR_STATUS")) { list_customers[index_count].Customer_Asset_Contact_Data.Have_Car_Status = data_textbox.Text; }
                    if (item.Name.Equals("HAVE_CAR_BRAND")) { list_customers[index_count].Customer_Asset_Contact_Data.Have_Car_Brand = data_textbox.Text; }
                    if (item.Name.Equals("HAVE_CAR_YEAR")) { list_customers[index_count].Customer_Asset_Contact_Data.Have_Car_Year = data_textbox.Text; }
                    if (item.Name.Equals("OTHER")) { list_customers[index_count].Customer_Asset_Contact_Data.Other = data_textbox.Text; }

                }

            }
        }
        public void Update_Customer_Job_Data(Panel panel,ref List<Loan_Data_Set.Customer> list_customers, int index_count)
        {

            foreach (Control item in panel.Controls)
            {
                if (item is TextBox)
                {
                    TextBox data_textbox = new TextBox();
                    data_textbox = item as TextBox;
                    if (item.Text is null) { item.Text = ""; }

                    if (item.Name.Equals("COMPANY_NAME_TEXTBOX")) { list_customers[index_count].Customer_Job_Data.Company_Name = data_textbox.Text; }
                    if (item.Name.Equals("COMPANY_UNIFORM_NUMBER_TEXTBOX")) { list_customers[index_count].Customer_Job_Data.Company_Uniform_Number = data_textbox.Text; }
                    if (item.Name.Equals("COMPANY_PHONE_DISTRICT_TEXTBOX")) { list_customers[index_count].Customer_Job_Data.Company_Phone_District = data_textbox.Text; }
                    if (item.Name.Equals("COMPANY_PHONE_NUMBER_TEXTBOX")) { list_customers[index_count].Customer_Job_Data.Company_Phone_Number = data_textbox.Text; }
                    if (item.Name.Equals("JOB_TITTLE_TEXTBOX")) { list_customers[index_count].Customer_Job_Data.Job_Tittle = data_textbox.Text; }
                    if (item.Name.Equals("MONTHLY_INCOME_TEXTBOX")) { list_customers[index_count].Customer_Job_Data.Monthly_Income = data_textbox.Text; }
                    if (item.Name.Equals("YEARLY_INCOME_TEXTBOX")) { list_customers[index_count].Customer_Job_Data.Yearly_Income = data_textbox.Text; }
                    if (item.Name.Equals("COMPANY_ADDRESS_TEXTBOX")) { list_customers[index_count].Customer_Job_Data.Company_Address = data_textbox.Text; }
                }

            }

        }
        public void Update_Customer_Basic_Data(Panel panel,ref List<Loan_Data_Set.Customer> list_customers,int index_count)
        {
            
            foreach (Control item in panel.Controls)
            {
                if(item is TextBox)
                {
                    TextBox data_textbox = new TextBox();
                    data_textbox = item as TextBox;
                    if(item.Text is null) { item.Text = ""; }
                    if (item.Name.Equals("IDENTITY_TEXTBOX")) { list_customers[index_count].Identity = data_textbox.Text; }
                    if (item.Name.Equals("NAME_TEXTBOX")) { list_customers[index_count].Name = data_textbox.Text; }
                    if (item.Name.Equals("BIRTHDAY_TEXTBOX")) { list_customers[index_count].Customer_Data.Birthday = data_textbox.Text;  }
                    if (item.Name.Equals("AGE_TEXTBOX")) { list_customers[index_count].Customer_Data.Age = data_textbox.Text; }
                    if (item.Name.Equals("CELLPHONE_TEXTBOX")) { list_customers[index_count].Customer_Data.CellPhone_Number = data_textbox.Text; }
                    if (item.Name.Equals("PHONE_DISTACT_TEXTBOX")) { list_customers[index_count].Customer_Data.Phone_District = data_textbox.Text; }
                    if (item.Name.Equals("PHONE_NUMBER_TEXTBOX")) { list_customers[index_count].Customer_Data.Phone_Number = data_textbox.Text; }
                }
                ComboBox data_combobox = new ComboBox();
                data_combobox = item as ComboBox;
                if (item.Name.Equals("MARTIAL_STATUS_COMBOBOX")) { list_customers[index_count].Customer_Data.Martial_Status = data_combobox.Text; }
                if (item.Name.Equals("Education_Combobox")) { list_customers[index_count].Customer_Data.Education = data_combobox.Text; }
            }

        }
        public List<string> Update_Loan_Customer_DataStatus(Panel Customer_Data_Panel,ref Loan_Data_Set loand_data)
        {
            List<string> result = new List<string>();

            try
            {
                List<Panel> list_panel = new List<Panel>();
                List<Loan_Data_Set.Customer> list_cusotmer = new List<Loan_Data_Set.Customer>(); ///建立 list 整體
                int index_count = 0;

                /// Load Data
                foreach (Control item in Customer_Data_Panel.Controls)
                {


                    if (item is GroupBox)
                    {
                        /// 建立新的Class以供其他新客戶
                        Loan_Data_Set.Customer customers = new Loan_Data_Set.Customer();
                        Loan_Data_Set.Customer.Customer_Basic_Data_class customner_basic_data = new Loan_Data_Set.Customer.Customer_Basic_Data_class();
                        Loan_Data_Set.Customer.Customer_Job_Data_class customer_job_data = new Loan_Data_Set.Customer.Customer_Job_Data_class();
                        Loan_Data_Set.Customer.Customer_Asset_Contact_Data_class customer_Asset_Contact_Data = new Loan_Data_Set.Customer.Customer_Asset_Contact_Data_class();
                        list_cusotmer.Add(customers);
                        customers.Customer_Data = new Loan_Data_Set.Customer.Customer_Basic_Data_class();
                        customers.Customer_Job_Data = new Loan_Data_Set.Customer.Customer_Job_Data_class();
                        customers.Customer_Asset_Contact_Data = new Loan_Data_Set.Customer.Customer_Asset_Contact_Data_class();

                        list_panel.Clear();
                        /// 將 基本資料、工作、聯絡人區塊分出
                        foreach (var item_item in item.Controls)
                        {
                            if (item_item is Panel)
                            {
                                list_panel.Add(item_item as Panel);
                            }
                        }

                        /// Process

                        foreach (Panel panel in list_panel)
                        {
                            if (panel.Name.Equals("CUSTOMER_BASIC_DATA")) { Update_Customer_Basic_Data(panel,ref list_cusotmer, index_count); }
                            if (panel.Name.Equals("JOB_DATA")) { Update_Customer_Job_Data(panel,ref list_cusotmer, index_count); }
                            if (panel.Name.Equals("CONTACT_ASSET_DATA")) { Update_Customer_Contact_Asset_Data(panel,ref list_cusotmer, index_count); }
                        }

                        index_count += 1;
                    }


                }
                string customer_data_json = JsonConvert.SerializeObject(list_cusotmer);
                loand_data.customer_data_json = customer_data_json;
                result.Add(string.Format("客戶資料更新完成。\r\n"));
            }
            catch (Exception EX)
            {

                result.Add("客戶 資料儲存時，發生資料解析錯誤，請聯絡【研發中心-郁宸】");
            }
            
            return result;
        }


        /// House_Object
        public void Update_House_Object_Data(GroupBox groupbox,ref List<Loan_Data_Set.House_Object> list_house_object, int index_count)
        {
            list_house_object[index_count].House_ID = groupbox.Name;
            foreach (Control item in groupbox.Controls)
            {
                TextBox data_textbox = new TextBox();
                ComboBox data_combobbox = new ComboBox();
                if (item is TextBox)
                    {
                        data_textbox = item as TextBox;
                        if (item.Text is null) { item.Text = ""; }
                    }
                    if (item is ComboBox)
                    {
                        data_combobbox = item as ComboBox;
                        if (data_combobbox is null) { item.Text = ""; }
                    }

                    // Textbox
                    if (item.Name.Equals("Holiding_Time_TEXTBOX")) { list_house_object[index_count].Holiding_Time = data_textbox.Text; }
                    if (item.Name.Equals("House_Address_TEXTBOX")) { list_house_object[index_count].House_Address= data_textbox.Text; }
                    if (item.Name.Equals("House_Area_Size_TEXTBOX")) { list_house_object[index_count].House_Area_Size = data_textbox.Text; }
                    if (item.Name.Equals("House_Building_Age_TEXTBOX")) { list_house_object[index_count].House_Building_Age = data_textbox.Text; }
                    if (item.Name.Equals("House_Building_Completion_Date_TEXTBOX")) { list_house_object[index_count].House_Building_Completion_Date = data_textbox.Text; }
                    if (item.Name.Equals("House_Floors_This_TEXTBOX")) { list_house_object[index_count].House_Floors_This = data_textbox.Text; }
                    if (item.Name.Equals("House_Total_Floors_TEXTBOX")) { list_house_object[index_count].House_Total_Floors = data_textbox.Text; }
                    if (item.Name.Equals("Register_Reason_Date_TEXTBOX")) { list_house_object[index_count].Register_Reason_Date = data_textbox.Text; }
                    if (item.Name.Equals("Register_Reason_TEXTBOX")) { list_house_object[index_count].Register_Reason = data_textbox.Text; }
                    if (item.Name.Equals("House_Type_CHECKBOX")) { list_house_object[index_count].House_Type = data_textbox.Text; }

                    /// Combobox
                    ComboBox data_combobox = new ComboBox();
                    data_combobox = item as ComboBox;
                    if (item.Name.Equals("House_Decoration_Status_COMBOBOX")) { list_house_object[index_count].House_Decoration_Status = data_combobox.Text; }
                    if (item.Name.Equals("House_Renting_Status_COMBOBOX")) { list_house_object[index_count].House_Renting_Status = data_combobox.Text; }
                    if (item.Name.Equals("House_Parking_Type_COMBOBOX")) { list_house_object[index_count].House_Parking_Type = data_combobox.Text; }
                    if (item.Name.Equals("House_Type_COMBOBOX")) { list_house_object[index_count].House_Type = data_combobox.Text; }

                    /// Listbox
                    if (item.Name.Equals("real_estate_no"))
                    {
                        ListBox item_listbox = item as ListBox;
                        list_house_object[index_count].House_Real_Estate_No = new List<string>();

                        foreach (var list_item in item_listbox.Items)
                        {
                            list_house_object[index_count].House_Real_Estate_No.Add(list_item as string);
                        }
                    }
            }
        }
        public List<string> Update_Loan_House_DataStatus(Panel House_Object, ref Loan_Data_Set loand_data)
        {
            List<string> result = new List<string>();

            try
            {
                List<Loan_Data_Set.House_Object> list_house_object = new List<Loan_Data_Set.House_Object>(); ///建立 list 整體
                int index_count = 0;


                /// Load Data
                foreach (Control item in House_Object.Controls)
                {
                    Loan_Data_Set.House_Object new_house_object = new Loan_Data_Set.House_Object();

                    if ( item is GroupBox)
                    {
                        list_house_object.Add(new_house_object);
                        Update_House_Object_Data(item as GroupBox, ref list_house_object, index_count);
                        index_count += 1;
                    }

                    
                }

                /// Process
                string House_Object_json = JsonConvert.SerializeObject(list_house_object);
                loand_data.house_object_json = House_Object_json;
                result.Add(string.Format("房屋物件資料更新完成。\r\n"));

            }
            catch (Exception)
            {

                result.Add("房屋物件 資料儲存時，發生資料解析錯誤，請聯絡【研發中心-郁宸】");
            }

            return result;
        }
        public List<string> Process_SQL_Result(SQL_Action_Function_Index query_str , DataTable dataTable)
        {
            List<string> result = new List<string>();

            try
            {
                switch (query_str)
                {

                    case SQL_Action_Function_Index.Get_Personal_FormID:
                        foreach (DataRow dr in dataTable.Rows)
                        {
                            /// Summary
                            /// 1. 將要用的資料[form_id]直接存進list
                            /// 2. 後續若要新增可以使用【字串連接法】、【二維List List<List<string>>】
                            /// Summary
                            string return_str = dr["form_id"].ToString();
                            result.Add(return_str);
                        }
                        break;

                    case SQL_Action_Function_Index.Get_Form_Data:

                        DataGridView Save_Data_Grid = new DataGridView();
                        Save_Data_Grid.DataSource = dataTable;

                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            string data_json = JsonConvert.SerializeObject(dataTable.Rows[i].Table);
                            result.Add(data_json);
                        }
                        return result;


                    default:
                        result.Add("資料無法解析，請聯絡【研發中心-郁宸】。");
                        break;
                }



            }
            catch (Exception)
            {

                result.Add("資料解析發生錯誤，請聯絡【研發中心-郁宸】。");
            }


            return result;
        }


        /// 檢查是否具有空的物件(初始化Null的物件)
        public void Compare_Loan_Null_Object(ref Loan_Data_Set loan_data)
        {
            foreach (var item in loan_data.GetType().GetProperties())
            {

                if(item.GetValue(loan_data) is null)
                {
                    item.SetValue(loan_data, "");
                }

                if (item.Name.Equals("extend_data_json"))
                {
                    item.SetValue(loan_data, "{\"specialmark\":\"false\"}");
                }

                if (item.Name.Equals("house_object_json"))
                {
                    item.SetValue(loan_data, "[{\r\n\"House_ID\":\"H0001\",\r\n\"House_Address\":\"\",\r\n\"House_Type\":\"\",\r\n\"House_Area_Size\":\"\",\r\n\"House_Building_Completion_Date\":\"\",\r\n\"House_Decoration_Status\":\"\",\r\n\"House_Total_Floors\":\"\",\r\n\"House_Floors_This\":\"\",\r\n\"House_Parking_Type\":\"\",\r\n\"House_Building_Age\":\"\",\r\n\"Register_Reason\":\"\",\r\n\"Register_Reason_Date\":\"\",\r\n\"Holiding_Time\":\"\",\r\n\"House_Renting_Status\":\"\"\r\n,\r\n\"House_Real_Estate_No\":[\"\"]}]");
                }

                if (item.Name.Equals("real_estate_certificate"))
                {
                    item.SetValue(loan_data, null);
                }
            }

        }
    }
}
