using New_Customer_Submit.Model.Data_Set;
using New_Customer_Submit.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Customer_Submit.View.Template;
using System.Windows.Forms;
using System.Drawing;
using System.Reflection;
using New_Customer_Submit.Model.Data_Set;
using static New_Customer_Submit.Model.Data_Set.Loan_Data_Set;

namespace New_Customer_Submit.Model.UI_Function
{
    public class Modify_FormData_UI
    {


        #region Customer_Data_Panel
        #region Update_Customer_Data_UI_Function

        public Modify_Formdata_Form Generate_Customer_Group_Box(Modify_Formdata_Form modify_formdata_form, Loan_Data_Set loan_data)
        {
            int delta_x = 507;

            List<Loan_Data_Set.Customer> customer = JsonConvert.DeserializeObject<List<Loan_Data_Set.Customer>>(loan_data.customer_data_json);


            for (int i = 0; i <= customer.Count-1 ; i++)
            {
                Demo demo = new Demo();

                demo.groupBox1.Name = customer[i].Identity;
                demo.groupBox1.Text = customer[i].Identity + "_" + customer[i].Name;
                demo.groupBox1.Location = new Point(demo.groupBox1.Location.X + (delta_x * ((i+1) - 1)), demo.groupBox1.Location.Y);
                modify_formdata_form.Customer_Data_Panel.Controls.Add(demo.groupBox1);
                modify_formdata_form.Generate_Customer_Remove_Button(i);
            }


            return modify_formdata_form;
        }
        public Modify_Formdata_Form Update_Customer_Group_Box(Modify_Formdata_Form modify_formdata_form, Loan_Data_Set loan_data)
        {
            List<Loan_Data_Set.Customer> customer = JsonConvert.DeserializeObject<List<Loan_Data_Set.Customer>>(loan_data.customer_data_json);

            for (int i = 0; i <= customer.Count-1 ; i++)
            {
                List<GroupBox> List_Groupbox = new List<GroupBox>();
                foreach (Control item in modify_formdata_form.Customer_Data_Panel.Controls)
                {
                    if (item is GroupBox)
                    {
                        List_Groupbox.Add((GroupBox)item);
                    }
                }
                GroupBox groupbox = Return_Index_GROUPBOX(List_Groupbox, customer[i].Identity);
                Update_Customer_Group_Box_Data(groupbox, customer[i]);

            }




            return modify_formdata_form;
        }
        public Modify_Formdata_Form New_Customer_Group_Box(Modify_Formdata_Form modify_formdata_form,ref Loan_Data_Set loan_data, string Input_Identity)
        {
            int delta_x = 450;
            List<Loan_Data_Set.Customer> customer = JsonConvert.DeserializeObject<List<Loan_Data_Set.Customer>>(loan_data.customer_data_json);
            Loan_Data_Set.Customer new_customer = new Loan_Data_Set.Customer();
            customer.Add(new_customer);

            Demo demo = new Demo();
            customer[customer.Count - 1].Identity = Input_Identity;
            customer[customer.Count - 1].Name = "尚未取名";
            string new_customer_json = JsonConvert.SerializeObject(customer);

            demo.groupBox1.Name = customer[customer.Count-1].Identity;
            demo.groupBox1.Text = customer[customer.Count - 1].Identity + "_" + customer[customer.Count - 1].Name;
            demo.groupBox1.Location = new Point(demo.groupBox1.Location.X + (delta_x * ((customer.Count - 1) )), demo.groupBox1.Location.Y);

            modify_formdata_form.Customer_Data_Panel.MaximumSize = new Size(9999, 9999);
            modify_formdata_form.Customer_Data_Panel.Controls.Add(demo.groupBox1);
            loan_data.customer_data_json = new_customer_json;

            return modify_formdata_form;
        }


        #endregion

        #region Update_Customer_Data_Function

        private GroupBox Update_Customer_Group_Box_Data(GroupBox customer_group_box, Loan_Data_Set.Customer customer)
        {
            Panel Customer_Data_panel = new Panel();
            Panel Job_Data_panel = new Panel();
            Panel Contact_Asset_Data_panel = new Panel();
            foreach (Control item in customer_group_box.Controls)
            {
                if (item is Panel)
                {
                    if (item.Name.Equals("CUSTOMER_BASIC_DATA")) { Customer_Data_panel = (Panel)item; }
                    if (item.Name.Equals("JOB_DATA")) { Job_Data_panel = (Panel)item; }
                    if (item.Name.Equals("CONTACT_ASSET_DATA")) { Contact_Asset_Data_panel = (Panel)item; }
                }

            }

            Panel Updated_Customer_Data_Panel = Update_Customer_data(Customer_Data_panel, customer);
            Panel Updated_Job_Data_Panel = Update_Job_data(Job_Data_panel, customer);
            Panel Updated_Contact_Data_Panel = Update_Contact_data(Contact_Asset_Data_panel, customer);

            customer_group_box.Controls.Remove(Customer_Data_panel);
            customer_group_box.Controls.Add(Updated_Customer_Data_Panel);
            customer_group_box.Controls.Remove(Job_Data_panel);
            customer_group_box.Controls.Add(Updated_Job_Data_Panel);
            customer_group_box.Controls.Remove(Contact_Asset_Data_panel);
            customer_group_box.Controls.Add(Updated_Contact_Data_Panel);


            return customer_group_box;
        }
        public Panel Update_Customer_data(Panel customer_data_panel, Loan_Data_Set.Customer customer)
        {
            foreach (Control item in customer_data_panel.Controls)
            {
                try
                {
                    if (item.Name.Equals("IDENTITY_TEXTBOX")) { item.Text = customer.Identity; }
                    if (item.Name.Equals("NAME_TEXTBOX")) { item.Text = customer.Name; }
                    if (item.Name.Equals("BIRTHDAY_TEXTBOX")) { item.Text = customer.Customer_Data.Birthday; }
                    if (item.Name.Equals("AGE_TEXTBOX")) { item.Text = customer.Customer_Data.Age; }
                    if (item.Name.Equals("MARTIAL_STATUS_COMBOBOX")) { item.Text = customer.Customer_Data.Martial_Status; }
                    if (item.Name.Equals("Education_Combobox")) { item.Text = customer.Customer_Data.Education; }
                    if (item.Name.Equals("CELLPHONE_TEXTBOX")) { item.Text = customer.Customer_Data.CellPhone_Number; }
                    if (item.Name.Equals("PHONE_DISTACT_TEXTBOX")) { item.Text = customer.Customer_Data.Phone_District; }
                    if (item.Name.Equals("PHONE_NUMBER_TEXTBOX")) { item.Text = customer.Customer_Data.Phone_Number; }
                }
                catch (Exception)
                {

                    Console.WriteLine(String.Format("偵測到有客戶資料不齊全，客戶身分證為 {0}",customer.Identity));
                }

            }
            return customer_data_panel;
        }
        public Panel Update_Job_data(Panel Job_data_panel, Loan_Data_Set.Customer customer)
        {
            foreach (Control item in Job_data_panel.Controls)
            {
                if (item.Name.Equals("Identity_2_TEXTBOX")) { item.Text = customer.Identity; }
                if (item.Name.Equals("NAME_2_TEXTBOX")) { item.Text = customer.Name; }
                if (item.Name.Equals("COMPANY_NAME_TEXTBOX")) { item.Text = customer.Customer_Job_Data.Company_Name; }
                if (item.Name.Equals("COMPANY_UNIFORM_NUMBER_TEXTBOX")) { item.Text = customer.Customer_Job_Data.Company_Uniform_Number; }
                if (item.Name.Equals("COMPANY_PHONE_DISTRICT_TEXTBOX")) { item.Text = customer.Customer_Job_Data.Company_Phone_District; }
                if (item.Name.Equals("COMPANY_PHONE_NUMBER_TEXTBOX")) { item.Text = customer.Customer_Job_Data.Company_Phone_Number; }
                if (item.Name.Equals("JOB_TITTLE_TEXTBOX")) { item.Text = customer.Customer_Job_Data.Job_Tittle; }
                if (item.Name.Equals("MONTHLY_INCOME_TEXTBOX")) { item.Text = customer.Customer_Job_Data.Monthly_Income; }
                if (item.Name.Equals("YEARLY_INCOME_TEXTBOX")) { item.Text = customer.Customer_Job_Data.Yearly_Income; }
                if (item.Name.Equals("COMPANY_ADDRESS_TEXTBOX")) { item.Text = customer.Customer_Job_Data.Company_Address; }
            }
            return Job_data_panel;
        }
        public Panel Update_Contact_data(Panel Contact_Asset_data_panel, Loan_Data_Set.Customer customer)
        {
            foreach (Control item in Contact_Asset_data_panel.Controls)
            {
                if (item.Name.Equals("CONTACT_1_NAME_TEXTBOX")) { item.Text = customer.Customer_Asset_Contact_Data.Contact_1; }
                if (item.Name.Equals("CONTACT_1_CELLPHONE_TEXTBOX")) { item.Text = customer.Customer_Asset_Contact_Data.Contact_1_CellPhone; }
                if (item.Name.Equals("CONTACT_1_TITTLE_TEXTBOX")) { item.Text = customer.Customer_Asset_Contact_Data.Contact_1_Tittle; }
                if (item.Name.Equals("CONTACT_2_NAME_TEXTBOX")) { item.Text = customer.Customer_Asset_Contact_Data.Contact_2; }
                if (item.Name.Equals("CONTACT_2_CELLPHONE_TEXTBOX")) { item.Text = customer.Customer_Asset_Contact_Data.Contact_2_CellPhone; }
                if (item.Name.Equals("CONTACT_2_TITTLE_TEXTBOX")) { item.Text = customer.Customer_Asset_Contact_Data.Contact_2_Tittle; }
                if (item.Name.Equals("HAVE_CAR_STATUS")) { item.Text = customer.Customer_Asset_Contact_Data.Have_Car_Status; }
                if (item.Name.Equals("HAVE_CAR_BRAND")) { item.Text = customer.Customer_Asset_Contact_Data.Have_Car_Brand; }
                if (item.Name.Equals("HAVE_CAR_YEAR")) { item.Text = customer.Customer_Asset_Contact_Data.Have_Car_Year; }
                if (item.Name.Equals("OTHER")) { item.Text = customer.Customer_Asset_Contact_Data.Other; }
            }
            return Contact_Asset_data_panel;
        }
        public Button Update_Remove_Button(Button Remove_Button, Loan_Data_Set.Customer customer)
        {
            Modify_Formdata_Form modify_formadata_form = new Modify_Formdata_Form();
            Remove_Button.Name = customer.Identity + Remove_Button.Name;
            Remove_Button.Click += modify_formadata_form.Remove_Customer_Button_Click;
            return Remove_Button;
        }
        #endregion
        #endregion

        #region Application_Information
        public Modify_Formdata_Form Update_ApplicationInformation_Area(Modify_Formdata_Form modify_formdata_form, Loan_Data_Set loan_data)
        {
            modify_formdata_form.department.Text = loan_data.department;
            modify_formdata_form.loan_type.Text = loan_data.loan_type;
            modify_formdata_form.loan_period.Text = loan_data.loan_period;
            modify_formdata_form.repayment_type.Text = loan_data.repayment_type;
            modify_formdata_form.case_source.Text = loan_data.case_source;
            modify_formdata_form.salesman_name.Text = loan_data.salesman_name;
            modify_formdata_form.loan_purpose.Text = loan_data.loan_purpose;
            modify_formdata_form.apply_amount.Text = loan_data.apply_amount;
            modify_formdata_form.Project_Name.Text = "實作完畢，還未將資料嵌入資料庫。";


            return modify_formdata_form;
        }
        public Modify_Formdata_Form Update_FomrID_Information_Area(Modify_Formdata_Form modify_formdata_form, Loan_Data_Set loan_data)
        {
            Loan_Data_Set.Extends_Data extends_data = JsonConvert.DeserializeObject<Loan_Data_Set.Extends_Data>(loan_data.extend_data_json);

            modify_formdata_form.Contract.Text = loan_data.c_key;
            modify_formdata_form.Insert_Date.Text = "待補";
            modify_formdata_form.Audit_Time.Text = "待補";
            modify_formdata_form.Audit_Person.Text = "待補";
            modify_formdata_form.Proxy_Person.Text = "待補";
            modify_formdata_form.Current_Time.Text = DateTime.Now.ToString();
            if (extends_data.specialmark.Equals("true")) { modify_formdata_form.Special_Mark.Checked = true; } else { modify_formdata_form.Special_Mark.Checked = false; }



            return modify_formdata_form;
        }
        public Modify_Formdata_Form Load_Application_Information_Combobox_Data(Modify_Formdata_Form modify_formdata_form)
        {
            Combobox_Data_Set.Combobox_Data combobox_data = new Combobox_Data_Set.Combobox_Data();

            List<ComboBox> List_Combobox = new List<ComboBox>();

            foreach (Control item in modify_formdata_form.Controls)
            {
                if (item is GroupBox)
                {
                    foreach (Control item_item in item.Controls)
                    {
                        if (item_item is ComboBox)
                        {
                            List_Combobox.Add((ComboBox)item_item);
                        }
                    }
                }
            }

            foreach (ComboBox combobox in List_Combobox)
            {
                string[] combobox_data_arr = combobox_data.load_data(combobox.Name);
                foreach (                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      string combobox_data_string in combobox_data_arr)
                {
                    combobox.Items.Add(combobox_data_string);
                }

            }

            return modify_formdata_form;
        }


        #endregion

        #region CommonFunction
        public GroupBox Return_Index_GROUPBOX(List<GroupBox> List_Groupboxes, string IDENTITY)
        {
            foreach (GroupBox groupbox in List_Groupboxes)
            {
                if (groupbox.Name.Equals(IDENTITY))
                {
                    return groupbox;
                }
            }
            return null;
        }
        #endregion
    }
}
