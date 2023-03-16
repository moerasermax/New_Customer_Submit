using New_Customer_Submit.Model.Data_Set;
using New_Customer_Submit.View.Template;
using New_Customer_Submit.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace New_Customer_Submit.Model.UI_Function
{
    public class Real_Estate_Land_Certificate_Form_UI
    {
        Modify_FormData_UI modify_formdata_ui = new Modify_FormData_UI();

            
        /// 因要做複合式的表格，因此需要先定義表格內容的欄位。
        public DataGridView Load_Column_Data(DataGridView real_certificate_datagridview, List<Loan_Data_Set.Real_Estate_Certificate> list_real_estate_certificate)
        {
            for (int i = 0; i <= list_real_estate_certificate.Count - 1; i++)
            {
                /// 建物
                real_certificate_datagridview = Load_Building_Column_Data(real_certificate_datagridview, list_real_estate_certificate[i]);

                /// 公設
                real_certificate_datagridview = Load_Public_Facility_Column_Data(real_certificate_datagridview, list_real_estate_certificate[i]);

                /// 持平
                real_certificate_datagridview = Load_holder_area_Column_Data(real_certificate_datagridview, list_real_estate_certificate[i]);
            }
            return real_certificate_datagridview;
        }
        private DataGridView Load_holder_area_Column_Data(DataGridView real_certificate_datagridview, Loan_Data_Set.Real_Estate_Certificate real_estate_certificate)
        {
            DataGridViewRow datarow = new DataGridViewRow();
            for (int i = 0; i <= real_estate_certificate.public_facility.Count - 1; i++)
            {
                /// 置入資料
                datarow = real_certificate_datagridview.Rows[0].Clone() as DataGridViewRow;
                datarow.Cells[0].Value = real_estate_certificate.real_estate_certificate_no + "_t"; /// 類別區 哪種資料
                datarow.Cells[1].Value = real_estate_certificate.real_estate_certificate_no ; /// 謄本編號

                datarow.DefaultCellStyle.BackColor = Color.Red;

                /// 計算公設加總(m2)
                double total_feet = 0.00;
                double total_public_facility_feet = 0.00;
                for (int j = 0; j <= real_estate_certificate.public_facility.Count -1  ; j++)
                {
                    total_public_facility_feet += double.Parse(real_estate_certificate.public_facility[j].public_facility_feet);
                }

                /// 計算面積
                total_feet = double.Parse(real_estate_certificate.main_building_feet) + double.Parse(real_estate_certificate.attached_building_feet) + total_public_facility_feet; /// 加總所有面積
                total_feet = total_feet * double.Parse(real_estate_certificate.property_range_molecular) / double.Parse(real_estate_certificate.property_range_denominator); /// * 權力範圍分數

                /// 更新畫面
                datarow.Cells[17].Value = total_feet.ToString();
                datarow.Cells[18].Value = (total_feet*0.3025).ToString();

            }
            real_certificate_datagridview.Rows.Add(datarow);

            return real_certificate_datagridview;
        }
        private DataGridView Load_Public_Facility_Column_Data(DataGridView real_certificate_datagridview, Loan_Data_Set.Real_Estate_Certificate real_estate_certificate)
        {
            for (int i = 0; i <= real_estate_certificate.public_facility.Count-1 ; i++)
            {
                DataGridViewRow datarow = new DataGridViewRow();
                datarow = (DataGridViewRow)real_certificate_datagridview.Rows[0].Clone();
                datarow.Cells[0].Value = real_estate_certificate.real_estate_certificate_no + "_p"; /// 類別區 哪種資料
                datarow.Cells[1].Value = real_estate_certificate.real_estate_certificate_no;/// 謄本資料編號
                datarow.Cells[2].Value = real_estate_certificate.real_estate_district;/// 地區/鄉鎮區
                datarow.Cells[3].Value = real_estate_certificate.real_estate_section; /// 段
                datarow.Cells[4].Value = real_estate_certificate.real_estate_certificate_no; /// 建號
                datarow.Cells[11].Value = real_estate_certificate.public_facility[i].right_range_molecular; /// 權力範圍-分子
                datarow.Cells[12].Value = real_estate_certificate.public_facility[i].right_range_denominator;/// 權力範圍-分母
                datarow.Cells[13].Value = real_estate_certificate.public_facility[i].public_facility_feet; /// 公設面積-平方公尺
                datarow.Cells[14].Value = (double.Parse(datarow.Cells[13].Value.ToString()) *0.3025).ToString(); /// 公設面積-坪數
                datarow.Cells[15].Value = (double.Parse(datarow.Cells[13].Value.ToString()) * double.Parse(datarow.Cells[11].Value.ToString()) / double.Parse(datarow.Cells[12].Value.ToString())).ToString(); /// 公設持平面積-平方公尺
                datarow.Cells[16].Value = (double.Parse(datarow.Cells[15].Value.ToString()) * 0.3025).ToString();/// 公設持平面積-坪數
                datarow.Cells[19].Value = real_estate_certificate.public_facility[i].public_facility_remark; /// 公設-備註
                real_certificate_datagridview.Rows.Add(datarow);

            }

            return real_certificate_datagridview;
        }
        private DataGridView Load_Building_Column_Data(DataGridView real_certificate_datagridview, Loan_Data_Set.Real_Estate_Certificate real_estate_certificate)
        {
            DataGridViewRow datarow = new DataGridViewRow();
            datarow = (DataGridViewRow)real_certificate_datagridview.Rows[0].Clone();
            datarow.Cells[0].Value = real_estate_certificate.real_estate_certificate_no + "_b"; /// 類別區 哪種資料
            datarow.Cells[1].Value = real_estate_certificate.real_estate_certificate_no;/// 謄本資料編號
            datarow.Cells[2].Value = real_estate_certificate.real_estate_district;/// 地區/鄉鎮區
            datarow.Cells[3].Value = real_estate_certificate.real_estate_section; /// 段
            datarow.Cells[4].Value = real_estate_certificate.real_estate_certificate_no; /// 建號
            datarow.Cells[5].Value = real_estate_certificate.property_range_molecular; ///產權範圍-分子
            datarow.Cells[6].Value = real_estate_certificate.property_range_denominator; /// 產權範圍-分母
            datarow.Cells[7].Value = real_estate_certificate.main_building_feet; /// 主建物-平方公尺
            datarow.Cells[8].Value = (double.Parse(datarow.Cells[7].Value.ToString()) * 0.3025).ToString(); /// 主建物-坪數
            datarow.Cells[9].Value = real_estate_certificate.attached_building_feet; /// 附屬建物-平方公尺
            datarow.Cells[10].Value = (double.Parse(datarow.Cells[9].Value.ToString()) *0.3025).ToString(); /// 附屬建物-坪數
            datarow.Cells[19].Value = real_estate_certificate.real_estate_remark; /// 建物-備註
            real_certificate_datagridview.Rows.Add(datarow);    
            return real_certificate_datagridview;
            real_certificate_datagridview.AutoGenerateColumns = false;
        }


        /// 動態運算
        public DataGridView Update_Column_New_Data(DataGridView real_certificate_datagridview)
        {
            double total_feet = 0.00;
            double delta_feet = 0.00;

                foreach (DataGridViewRow item in real_certificate_datagridview.Rows)
                {
                    if (!(item.Cells[0].Value is null))
                    {
                        string[] Compare_Type_Arr = item.Cells[0].Value.ToString().Split('_');
                        if (!(item.Cells[7].Value is null)) { item.Cells[8].Value = (double.Parse(item.Cells[7].Value.ToString()) * 0.3025).ToString(); delta_feet += double.Parse(item.Cells[7].Value.ToString()); } /// 主建物-坪數
                        if (!(item.Cells[9].Value is null)) { item.Cells[10].Value = (double.Parse(item.Cells[9].Value.ToString()) * 0.3025).ToString(); delta_feet += double.Parse(item.Cells[9].Value.ToString()); } /// 附屬建物-坪數
                        if (!(item.Cells[13].Value is null)) { item.Cells[14].Value = (double.Parse(item.Cells[13].Value.ToString()) * 0.3025).ToString(); } /// 公設面積-坪數
                        if (!(item.Cells[15].Value is null)) { item.Cells[15].Value = (double.Parse(item.Cells[13].Value.ToString()) * double.Parse(item.Cells[11].Value.ToString()) / double.Parse(item.Cells[12].Value.ToString())).ToString(); delta_feet += double.Parse(item.Cells[15].Value.ToString()); } /// 公設持平面積-平方公尺)
                        if (!(item.Cells[15].Value is null)) { item.Cells[16].Value = (double.Parse(item.Cells[15].Value.ToString()) * 0.3025).ToString(); }/// 公設持平面積-坪數
                        if (Compare_Type_Arr[1].Equals("t"))
                        {
                            item.Cells[17].Value = total_feet.ToString(); /// 持分面積-平方公尺
                            item.Cells[18].Value = (double.Parse(item.Cells[17].Value.ToString()) * 0.3025).ToString(); /// 持分面積-坪數
                            total_feet = 0.00;
                        }
                        else
                        {
                            total_feet += delta_feet;
                            delta_feet = 0.00;
                        }
                    }
                }
            return real_certificate_datagridview;
        }

        /// 新增建物
        public DataGridView New_Estate_Data(DataGridView real_certificate_datagridview, string real_estate_certificate_no)
        {

            /// 檢查是否有重複的謄本編號
            bool Exist_Compare = false;
            foreach (DataGridViewRow item in real_certificate_datagridview.Rows)
            {
                if((item.Index != real_certificate_datagridview.RowCount - 1))
                {
                    if (item.Cells[1].Value.ToString().Equals(real_estate_certificate_no))
                    {
                        Exist_Compare = true;
                        break;
                    }
                }
            }

            if(Exist_Compare == true)
            {
                MessageBox.Show(string.Format("此戶籍謄本編號 {0} 已存在此",real_estate_certificate_no));
            }
            else
            {
                /// 新增建物資料行流程
                DataGridViewRow datarow = new DataGridViewRow();
                datarow = real_certificate_datagridview.Rows[0].Clone() as DataGridViewRow;
                datarow.Cells[0].Value = real_estate_certificate_no + "_b";
                datarow.Cells[1].Value = real_estate_certificate_no;
                datarow.Cells[4].Value = real_estate_certificate_no;
                real_certificate_datagridview.Rows.Add(datarow);

                /// 清理記憶體
                datarow = null;

                /// 新增建物公設行流程
                datarow = new DataGridViewRow();
                datarow = real_certificate_datagridview.Rows[0].Clone() as DataGridViewRow;
                datarow.Cells[0].Value = real_estate_certificate_no + "_p";
                datarow.Cells[1].Value = real_estate_certificate_no;
                real_certificate_datagridview.Rows.Add(datarow);

                /// 清理記憶體
                datarow = null;

                /// 新增建物持方行流程
                datarow = new DataGridViewRow();
                datarow = real_certificate_datagridview.Rows[0].Clone() as DataGridViewRow;
                datarow.Cells[0].Value = real_estate_certificate_no + "_t";
                datarow.Cells[1].Value = real_estate_certificate_no;
                real_certificate_datagridview.Rows.Add(datarow);
            }

            return real_certificate_datagridview;
        }

        /// 新增公設
        public DataGridView New_Public_Facility(DataGridView real_certificate_datagridview, string real_estate_certificate_no)
        {

            /// 檢查是否有重複的謄本編號
            bool Exist_Compare = false;
            foreach (DataGridViewRow item in real_certificate_datagridview.Rows)
            {
                if ((item.Index != real_certificate_datagridview.RowCount - 1))
                {
                    if (item.Cells[1].Value.ToString().Equals(real_estate_certificate_no))
                    {
                        Exist_Compare = true;
                        break;
                    }
                }
            }

            if (Exist_Compare)
            {
                DataGridViewRow datarow = new DataGridViewRow();
                datarow = real_certificate_datagridview.Rows[0].Clone() as DataGridViewRow;
                datarow.Cells[0].Value = real_estate_certificate_no + "_p";
                datarow.Cells[1].Value = real_estate_certificate_no;
                real_certificate_datagridview.Rows.Add(datarow);
            }
            else
            {
                MessageBox.Show(string.Format("戶籍謄本編號 {0} 不存在！\r\n請先建立該【建物資料】", real_estate_certificate_no));

            }

            
            return real_certificate_datagridview;
        }





        #region House_Object_Panel
        public Real_Estate_Land_Certificate_Form Generate_House_Object_Group_Box(Real_Estate_Land_Certificate_Form modify_formdata_form, Loan_Data_Set loan_data)
        {


                int delta_y = 250;
                List<Loan_Data_Set.House_Object> house_object = JsonConvert.DeserializeObject<List<Loan_Data_Set.House_Object>>(loan_data.house_object_json);
                for (int i = 0; i <= house_object.Count - 1; i++)
                {
                    Demo demo = new Demo();

                    demo.House_Object_Data.Name = house_object[i].House_ID;
                    demo.House_Object_Data.Text = house_object[i].House_ID;
                    demo.House_Object_Data.Location = new Point(demo.House_Object_Data.Location.X - demo.House_Object_Data.Location.X, demo.House_Object_Data.Location.Y + (delta_y * (i)));
                    modify_formdata_form.House_Object_Panel.Controls.Add(demo.House_Object_Data);
                    modify_formdata_form.Generate_House_Remove_Button(i);
                }

            
            return modify_formdata_form;
        }
        public Real_Estate_Land_Certificate_Form New_House_Object_Group_Box(Real_Estate_Land_Certificate_Form modify_formdata_form, ref Loan_Data_Set loan_data, string Input_HouseID)
        {
            int delta_y = 250;
            List<Loan_Data_Set.House_Object> house_object = JsonConvert.DeserializeObject<List<Loan_Data_Set.House_Object>>(loan_data.house_object_json);
            Loan_Data_Set.House_Object new_house_object = new Loan_Data_Set.House_Object();
            house_object.Add(new_house_object);

            Demo demo = new Demo();
            house_object[house_object.Count - 1].House_ID = Input_HouseID;
            string new_house_object_json = JsonConvert.SerializeObject(house_object);

            demo.House_Object_Data.Name = house_object[house_object.Count - 1].House_ID;
            demo.House_Object_Data.Text = house_object[house_object.Count - 1].House_ID;
            demo.House_Object_Data.Location = new Point(demo.House_Object_Data.Location.X - demo.House_Object_Data.Location.X, demo.House_Object_Data.Location.Y + (delta_y * (house_object.Count - 1)));

            modify_formdata_form.House_Object_Panel.MaximumSize = new Size(9999, 9999);
            modify_formdata_form.House_Object_Panel.Controls.Add(demo.House_Object_Data);
            loan_data.house_object_json = new_house_object_json;

            return modify_formdata_form;
        }
        public Real_Estate_Land_Certificate_Form Update_House_Object_Box(Real_Estate_Land_Certificate_Form modify_formdata_form, Loan_Data_Set loan_data)
        {
            List<Loan_Data_Set.House_Object> house_object = JsonConvert.DeserializeObject<List<Loan_Data_Set.House_Object>>(loan_data.house_object_json);


            List<GroupBox> list_groupbox = new List<GroupBox>();
            for (int i = 0; i <= house_object.Count - 1; i++)
            {
                foreach (Control item in modify_formdata_form.House_Object_Panel.Controls)
                {
                    if (item is GroupBox)
                    {
                        list_groupbox.Add(item as GroupBox);
                    }
                }
                GroupBox groupbox = modify_formdata_ui.Return_Index_GROUPBOX(list_groupbox, house_object[i].House_ID);
                Update_House_Object_Groupbox_data(groupbox, house_object[i]);
            }
            return modify_formdata_form;
        }
        public GroupBox Update_House_Object_Groupbox_data(GroupBox groupbox, Loan_Data_Set.House_Object house_object)
        {
            foreach (Control item in groupbox.Controls)
            {
                // Textbox
                if (item.Name.Equals("House_Address_TEXTBOX")) { item.Text = house_object.House_Address; }
                if (item.Name.Equals("House_Area_Size_TEXTBOX")) { item.Text = house_object.House_Area_Size; }
                if (item.Name.Equals("House_Building_Completion_Date_TEXTBOX")) { item.Text = house_object.House_Building_Completion_Date; }
                if (item.Name.Equals("House_Total_Floors_TEXTBOX")) { item.Text = house_object.House_Total_Floors; }
                if (item.Name.Equals("House_Floors_This_TEXTBOX")) { item.Text = house_object.House_Floors_This; }
                if (item.Name.Equals("House_Building_Age_TEXTBOX")) { item.Text = house_object.House_Building_Age; }
                if (item.Name.Equals("Register_Reason_TEXTBOX")) { item.Text = house_object.Register_Reason; }
                if (item.Name.Equals("Register_Reason_Date_TEXTBOX")) { item.Text = house_object.Register_Reason_Date; }
                if (item.Name.Equals("Holiding_Time_TEXTBOX")) { item.Text = house_object.Holiding_Time; }

                // Combobox
                if (item.Name.Equals("House_Decoration_Status_COMBOBOX")) { item.Text = house_object.House_Decoration_Status; }
                if (item.Name.Equals("House_Renting_Status_COMBOBOX")) { item.Text = house_object.House_Renting_Status; }
                if (item.Name.Equals("House_Parking_Type_COMBOBOX")) { item.Text = house_object.House_Parking_Type; }
                if (item.Name.Equals("House_Type_COMBOBOX")) { item.Text = house_object.House_Type; }

                /// Listbox
                if (item.Name.Equals("real_estate_no"))
                {

                    ListBox item_listbox = item as ListBox;

                    /// 防止舊資料有不存在 House_Real_Estate_No 的
                    if (house_object.House_Real_Estate_No is null)
                    {
                        house_object.House_Real_Estate_No = new List<string>();
                    }
                    /// 新增編號至 ListBox
                    foreach (string Real_Estate_No in house_object.House_Real_Estate_No)
                    {
                        if (!Real_Estate_No.Equals(""))
                        {
                            item_listbox.Items.Add(Real_Estate_No);
                        }
                    }
                }
            }
            return groupbox;
        }




        #endregion
    }

}

