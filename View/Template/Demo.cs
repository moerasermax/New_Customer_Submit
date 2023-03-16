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
using Microsoft.VisualBasic;
namespace New_Customer_Submit.View.Template
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();

            Prepare_Combobox_Data();


        }

        public void Prepare_Combobox_Data()
        {
            Combobox_Data_Set.Combobox_Data combobox_data = new Combobox_Data_Set.Combobox_Data();

            /// Customer Combobox
            foreach (Control item in this.CUSTOMER_BASIC_DATA.Controls)
            {
                if(item is ComboBox)
                {
                    string[] combobox_data_arr = combobox_data.load_data((item.Name));
                    Load_combobox_data((ComboBox)item, combobox_data_arr);

                }

            }

            /// House Object Combobox
            foreach (Control item in this.House_Object_Data.Controls)
            {
                if (item is ComboBox)
                {
                    string[] combobox_data_arr = combobox_data.load_data((item.Name));
                    Load_combobox_data((ComboBox)item, combobox_data_arr);

                }

            }
        }

        public ComboBox Load_combobox_data(ComboBox combobox, string[] combobox_data)
        {
            foreach (string combobox_data_string in combobox_data)
            {
                combobox.Items.Add(combobox_data_string);
            }
            return combobox;
        }

        private void New_House_Object_Click(object sender, EventArgs e)
        {
            string Input_House_ID = Interaction.InputBox("請輸入「建號」");
            bool Add_Compare = true;
            foreach (var item in real_estate_no.Items)
            {
                if (item.ToString().Equals(Input_House_ID))
                {
                    Add_Compare = false;
                }
            }
            if (Add_Compare)
            {
                real_estate_no.Items.Add(Input_House_ID);
            }
            else
            {
                MessageBox.Show("您輸入的「建號」已存在，請重新輸入");
            }

        }

        private void remove_real_estate_no_Click(object sender, EventArgs e)
        {
           real_estate_no.Items.RemoveAt(real_estate_no.SelectedIndex);
        }
    }
    
}
