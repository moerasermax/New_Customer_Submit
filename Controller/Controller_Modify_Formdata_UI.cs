using New_Customer_Submit.Model.Data_Set;
using New_Customer_Submit.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Customer_Submit.Model.UI_Function;
using Newtonsoft.Json;

namespace New_Customer_Submit.Controller
{
    public class Controller_Modify_Formdata_UI
    {


        public List<string> Modify_UI_Controller(Modify_Form_Action_Index Index, Modify_Formdata_Form modify_formdata_form, Loan_Data_Set loan_data,string Value)
        {
            Modify_FormData_UI modify_formdata_ui_function = new Modify_FormData_UI();

            List<string> result = new List<string>();
            try
            {
                switch (Index)
                {
                    case Modify_Form_Action_Index.Update_UI:              
                        modify_formdata_form = modify_formdata_ui_function.Update_FomrID_Information_Area(modify_formdata_form, loan_data);
                        modify_formdata_form = modify_formdata_ui_function.Update_ApplicationInformation_Area(modify_formdata_form, loan_data);
                        result.Add(string.Format("已完成 {0} 的表單資料載入\r\n", loan_data.c_key));
                        break;

                    /// Customer Controller
                    case Modify_Form_Action_Index.Load_Customer_Data_Update_UI:
                        modify_formdata_form = modify_formdata_ui_function.Generate_Customer_Group_Box(modify_formdata_form, loan_data);
                        modify_formdata_form = modify_formdata_ui_function.Update_Customer_Group_Box(modify_formdata_form, loan_data);
                        result.Add(string.Format("已完成 {0} 的資料載入\r\n", "客戶資料"));
                        break;
                    case Modify_Form_Action_Index.New_Customer:
                        modify_formdata_ui_function.New_Customer_Group_Box(modify_formdata_form, ref loan_data, Value) ;
                        List<Loan_Data_Set.Customer> customer = JsonConvert.DeserializeObject<List<Loan_Data_Set.Customer>>(loan_data.customer_data_json);
                        modify_formdata_form.Generate_Customer_Remove_Button(customer.Count-1);
                        result.Add(string.Format("已完成 {0} 的新客戶的建置\r\n", Value));
                        break;

                    case Modify_Form_Action_Index.Load_Application_Information_Combobox_Data_Update_UI:
                        modify_formdata_ui_function.Load_Application_Information_Combobox_Data(modify_formdata_form);
                        result.Add(string.Format("已完成 {0} 資料載入\r\n", "下拉式選單"));
                        break;
                    default:
                        result.Add(string.Format("錯誤找不到指定的流程，請聯絡【研發中心-郁宸】。\r\n", loan_data.c_key));
                        break;
                }
            }
            catch (Exception)
            {

                result.Add(string.Format("資料載入發生問題，請向【研發中心-郁宸】確認。\r\n錯誤代號：{0} \r\n", Index));
            }

            return result;
        }




    }


    public enum Modify_Form_Action_Index{
        /// Common
        Update_UI,
        Load_Application_Information_Combobox_Data_Update_UI,
        /// Customer
        New_Customer,
        Load_Customer_Data_Update_UI,

        
    }
}
