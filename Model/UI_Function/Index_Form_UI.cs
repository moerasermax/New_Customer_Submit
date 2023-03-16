using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using New_Customer_Submit.Model.Data_Set;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
namespace New_Customer_Submit.Model.UI_Function
{
    public class Index_Form_UI
    {

        public CheckBox Update_Extends_UI(CheckBox Special_Mark, string Extends_Data_Json)
        {

            try
            {
                Loan_Data_Set.Extends_Data extends_data = JsonConvert.DeserializeObject<Loan_Data_Set.Extends_Data>(Extends_Data_Json);

                if (extends_data.specialmark.Equals("true"))
                {
                    Special_Mark.Checked = true;
                }

            }
            catch (Exception)
            {
            }


            return Special_Mark;
        }
        public ComboBox Update_FormID(ComboBox Form_ID_Combobox,List<string> Form_ID)
        {
            Form_ID_Combobox.Items.Clear();
            foreach (string item in Form_ID)
            {
                Form_ID_Combobox.Items.Add(item);
            }
            return Form_ID_Combobox;
        }


    }
}
