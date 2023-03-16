using New_Customer_Submit.Model.Data_Set;
using New_Customer_Submit.View;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New_Customer_Submit.Model.UI_Function;

namespace New_Customer_Submit.Controller
{
    public class Controller_Real_Estate_Land_Certificate_UI
    {
        public List<string> House_Object_Controller(Real_Estate_Land_Certificate_UI_Index_Action Index, Real_Estate_Land_Certificate_Form real_estate_land_certificate_form, Loan_Data_Set loan_data, string Value)
        {
            Real_Estate_Land_Certificate_Form_UI real_estate_land_certificate_function = new Real_Estate_Land_Certificate_Form_UI();

            List<string> result = new List<string>();
            switch (Index)
            {
                /// House Object Controller
                case Real_Estate_Land_Certificate_UI_Index_Action.Load_House_Object_Data_Update_UI:
                    real_estate_land_certificate_function.Generate_House_Object_Group_Box(real_estate_land_certificate_form, loan_data);
                    real_estate_land_certificate_function.Update_House_Object_Box(real_estate_land_certificate_form, loan_data);
                    result.Add(string.Format("已完成 {0} 資料載入 \r\n", "房屋物件"));
                    break;
                case Real_Estate_Land_Certificate_UI_Index_Action.New_House_Object:
                    real_estate_land_certificate_function.New_House_Object_Group_Box(real_estate_land_certificate_form, ref loan_data, Value);
                    List<Loan_Data_Set.House_Object> house_object = JsonConvert.DeserializeObject<List<Loan_Data_Set.House_Object>>(loan_data.house_object_json);
                    real_estate_land_certificate_form.Generate_House_Remove_Button(house_object.Count - 1);
                    result.Add(string.Format("已完成 {0} 新房屋物件資料建置", house_object[house_object.Count - 1].House_ID));
                    break;
                
                default:
                    break;
            }
            return result;
        }

       

    }

    public enum Real_Estate_Land_Certificate_UI_Index_Action
    {
        /// House_Object
        New_House_Object,
        Load_House_Object_Data_Update_UI,
    }
}
