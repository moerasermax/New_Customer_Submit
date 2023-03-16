using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Customer_Submit.Model.Data_Set
{
    public class Loan_Data_Set
    {
        #region MyRegion
            public string c_key { get; set; }
            public string personal_id { get; set; }
            public string form_id { get; set; }
            public string form_status { get; set; }
            public string department { get; set; }
            public string salesman_name { get; set; }
            public string loan_type { get; set; }
            public string loan_period { get; set; }
            public string repayment_type { get; set; }
            public string case_source { get; set; }
            public string loan_purpose { get; set; }
            public string apply_amount { get; set; }
            public string name { get; set; }
            public string birthday { get; set; }
            public string marital_status { get; set; }
            public string education { get; set; }
            public string gender { get; set; }
            public string number_children { get; set; }
            public string phone_number { get; set; }
            public string name_company { get; set; }
            public string phone_company { get; set; }
            public string uniform_number { get; set; }
            public string career { get; set; }
            public string job_title { get; set; }
            public string income_monthly { get; set; }
            public string mobile_number { get; set; }
            public string address_company { get; set; }
            public string personal_remark { get; set; }
            public string contact_data_json { get; set; }
            public string car_data_json { get; set; }
            public string house_address { get; set; }
            public string house_type { get; set; }
            public string house_decoration_status { get; set; }
            public string house_area_size { get; set; }
            public string house_building_completion_date { get; set; }
            public string house_parking_type { get; set; }
            public string house_total_floors { get; set; }
            public string house_floors_this { get; set; }
            public string house_building_age { get; set; }
            public string house_is_rental { get; set; }
            public string attach_file_type_json { get; set; }
            public string attach_file_remark { get; set; }
            public string house_main_building_json { get; set; }
            public string house_main_land_number_json { get; set; }
            public string house_debt_status_data_json { get; set; }
            public string house_debt_remark { get; set; }
            public string house_debt_bank { get; set; }
            public string house_debt_bank_other { get; set; }
            public string house_land_tax_self { get; set; }
            public string house_land_tax_normal { get; set; }
            public string house_land_tax_datetime { get; set; }
            public string house_other_status_json { get; set; }
            public string final_total_loan_amount { get; set; }
            public string final_repayment_monthly { get; set; }
            public string creater_acct { get; set; }
            public string create_date { get; set; }
            public string creater_name { get; set; }
            public string price_predictor_name { get; set; }
            public string predit_price { get; set; }
            public string predit_date { get; set; }
            public string final_price { get; set; }
            public string final_date { get; set; }
            public string location_level { get; set; }
            public string market_level { get; set; }
            public string remark_predit { get; set; }
            public string house_information_picture_json { get; set; }
            public string house_status { get; set; }
            public string auditor_name { get; set; }
            public string audit_date { get; set; }
            public string remark_audit { get; set; }
            public string result_card { get; set; }
            public string result_card_bonus { get; set; }
            public string credit_confirm_items_json { get; set; }
            public string a01_auditor_leader_signer { get; set; }
            public string a01_confirm_signer { get; set; }
            public string a01_remark { get; set; }
            public string a02_general_manager_signer { get; set; }
            public string a02_audit_date_general_manager { get; set; }
            public string a02_remark { get; set; }
            public string a03_consultant_signer { get; set; }
            public string a03_audit_date_consultant { get; set; }
            public string a03_remark { get; set; }
            public string a04_chairman_signer { get; set; }
            public string a04_audit_date_chairman { get; set; }
            public string a04_remark { get; set; }
            public string a05_credit_committee { get; set; }
            public string a05_audit_date_committee { get; set; }
            public string a05_remark { get; set; }
            public string can_loan_amount { get; set; }
            public string total_debt_amount_after_loan { get; set; }
            public string loan_options_json { get; set; }
            public string status_after_loan_json { get; set; }
            public string end_house_owner { get; set; }
            public string end_house_owner_id { get; set; }
            public string end_house_owner_birthday { get; set; }
            public string end_house_owner_mobile { get; set; }
            public string end_house_owner_address { get; set; }
            public string end_customer_options_json { get; set; }
            public string end_total_loan_amount { get; set; }
            public string end_repayment_monthly { get; set; }
            public string end_total_margin { get; set; }
            public string end_total_fee { get; set; }
            public string end_pre_period { get; set; }
            public string end_first_repayment_date { get; set; }
            public string end_setting_amount { get; set; }
            public string end_repayment_acct { get; set; }
            public string end_contract_id { get; set; }
            public string end_project_id { get; set; }
            public string end_setting_date { get; set; }
            public string end_repayment_period { get; set; }
            public string end_remark { get; set; }
            public string end_checking_list_must_json { get; set; }
            public string end_checking_list_if_setting_json { get; set; }
            public string end_checking_list_fisttime_json { get; set; }
            public string end_customer_status { get; set; }
            public string end_final_status { get; set; }
            public string end_final_recorder_acct { get; set; }
            public string end_final_recoder_name { get; set; }
            public string end_final_record_date { get; set; }
            public string end_confirm_manager { get; set; }
            public string end_confirm_employee { get; set; }
            public string end_final_confirm_date { get; set; }
            public string z_final_feeling_json { get; set; }
            public string z_final_profit_json { get; set; }
            public string z_final_remark { get; set; }
            public string predit_recoder_acct { get; set; }
            public string predit_recod_datetime { get; set; }
            public string predit_recoder_name { get; set; }
            public string event_id_signature { get; set; }
            public string isThisCreateDebtAcctbook { get; set; }
            public string extend_data_json { get; set; }
            public string customer_data_json { get; set; }
            public string house_object_json { get; set; }
            public string real_estate_certificate { get; set; }

        #endregion

        public class Extends_Data
        {
            public string specialmark { get; set; }
        }
        /// 客戶資料
        public class Customer
        {
            public string Identity { get; set; }
            public string Name { get; set; }
            public Customer_Basic_Data_class Customer_Data { get; set; }
            public Customer_Job_Data_class Customer_Job_Data { get; set; }
            public Customer_Asset_Contact_Data_class Customer_Asset_Contact_Data { get; set; }
            public class Customer_Basic_Data_class
            {
                public string Birthday { get; set; }
                public string Age { get; set; }
                public string Martial_Status { get; set; }
                public string Education { get; set; }
                public string CellPhone_Number { get; set; }
                public string Phone_District { get; set; }
                public string Phone_Number { get; set; }

            }
            public class Customer_Job_Data_class
            {
                    public string Company_Name { get; set; }
                    public string Company_Uniform_Number { get; set; }
                    public string Company_Phone_District { get; set; }
                    public string Company_Phone_Number { get; set; }
                    public string Job_Tittle { get; set; }
                    public string Monthly_Income { get; set; }
                    public string Yearly_Income { get; set; }
                    public string Company_Address { get; set; }
                }
            public class Customer_Asset_Contact_Data_class
            {
                    public string Contact_1 { get; set; }
                    public string Contact_1_CellPhone { get; set; }
                    public string Contact_1_Tittle { get; set; }
                    public string Contact_2 { get; set; }
                    public string Contact_2_CellPhone { get; set; }
                    public string Contact_2_Tittle { get; set; }
                    public string Have_Car_Status { get; set; }
                    public string Have_Car_Brand { get; set; }
                    public string Have_Car_Year { get; set; }
                    public string Other { get; set; }



             }
        }
        /// 房屋物件
        public class House_Object
        {
            public string House_ID { get; set; }
            public string House_Address { get; set; }
            public string House_Type { get; set; }
            public string House_Area_Size { get; set; }
            public string House_Building_Completion_Date { get; set; }
            public string House_Decoration_Status { get; set; }
            public string House_Total_Floors { get; set; }
            public string House_Floors_This { get; set; }
            public string House_Parking_Type { get; set; }
            public string House_Building_Age { get; set; }
            public string Register_Reason { get; set; }
            public string Register_Reason_Date { get; set; }
            public string Holiding_Time { get; set; }
            public string House_Renting_Status { get; set; }
            public List<string> House_Real_Estate_No { get; set; } 
        }

        public class Real_Estate_Certificate
        {
            public string real_estate_certificate_no { get; set; }
            public string real_estate_district { get; set; }
            public string real_estate_section { get; set; }
            public string real_estate_building_no { get; set; }
            public string property_range_molecular { get; set; }
            public string property_range_denominator { get; set; }
            public string main_building_feet { get; set; }
            public string main_building_meters { get; set; }
            public string attached_building_feet { get; set; }
            public string attached_building_meters { get; set; }
            public string holder_area_feet { get; set; }
            public string holder_area_meters { get; set; }
            public string real_estate_remark { get; set; }
            public List<public_facility_data> public_facility { get; set; }

           public class public_facility_data
            {
                public string right_range_molecular { get; set; }
                public string right_range_denominator { get; set; }
                public string public_facility_remark { get; set; }
                public string public_facility_feet { get; set; }
                public string public_facility_meters { get; set; }
                public string holder_area_feet { get; set; }
                public string holder_area_meters { get; set; }
            }







        }
    }




}
