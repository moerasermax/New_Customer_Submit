using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Customer_Submit.Model.Data_Set
{ 
public class Combobox_Data_Set
{
    public class Combobox_Data
    {   
        public string[] load_data(string Combobox_name)
        {
            string[] status = { "異常" };
            string[] Department = { "A01 鑫全城", "A02 錠鈊", "A03 其他行銷公司", "A04 佑霆投顧商行", "A05 數位國際資融", "A06 炎杰企業社", "A07 鼎昇財經有限公司", "A08 鼎騰財經有限公司", "A09 鼎匯財經有限公司", "A10 寬磊有限公司", "A11 上鐠開發顧問商行", "A12 眾庭環球開發實業" };
            string[] Loan_type = { "房貸" };
            string[] Repayment_type = { "先息後本", "本利攤還" };
            string[] marital_status = { "已婚", "未婚" };
            string[] Education = { "就讀中", "高中職以下", "大專", "大學", "碩士", "博士" };
            string[] Gender = { "男", "女" };
            string[] number_children = { "0", "1", "2", "3", "4", "5", "6以上(含)" };
            string[] career = { "金融", "商貿", "政府機關", "醫療", "教育", "娛樂媒體", "建築", "交通運輸", "製造", "餐飲", "服務", "學生", "退休", "無業", "裝修", "房產仲介", "航空", "家管", "農林", "軍警", "科技業", "一般商業" };
            string[] house_type = { "公寓", "華廈", "透天", "大樓", "土地", "辦公大樓", "廠房" };
            string[] house_decoration_status = { "無", "簡易", "一般", "中檔", "高檔" };
            string[] house_parking_type = { "坡平", "坡機", "機平", "機機", "機械循環" };
            string[] house_is_rental = { "是", "否" };
            string[] Project_Name = {"無專案", "普惠", "120", "即時與", "南霸天屠龍" };
            if (Combobox_name.ToLower().Equals("department")) { return Department; }
            if (Combobox_name.ToLower().Equals("loan_type")) { return Loan_type; }
            if (Combobox_name.ToLower().Equals("repayment_type")) { return Repayment_type; }
            if (Combobox_name.ToLower().Equals("martial_status_combobox")) { return marital_status; }
            if (Combobox_name.ToLower().Equals("education_combobox")) { return Education; }
            if (Combobox_name.ToLower().Equals("gender")) { return Gender; }
            if (Combobox_name.ToLower().Equals("number_children")) { return number_children; }
            if (Combobox_name.ToLower().Equals("career")) { return career; }
            if (Combobox_name.ToLower().Equals("house_type_combobox")) { return house_type; }
            if (Combobox_name.ToLower().Equals("house_decoration_status_combobox")) { return house_decoration_status; }
            if (Combobox_name.ToLower().Equals("house_parking_type_combobox")) { return house_parking_type; }
            if (Combobox_name.ToLower().Equals("house_renting_status_combobox")) { return house_is_rental; }
            if (Combobox_name.ToLower().Equals("project_name")) { return Project_Name; }
            return status;
        }

    }


}
}