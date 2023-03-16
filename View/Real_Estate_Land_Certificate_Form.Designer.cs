using System.Windows.Forms;

namespace New_Customer_Submit.View
{
    partial class Real_Estate_Land_Certificate_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Estate_Land_Certificate = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Remove_Single_Row = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.New_Public_Facility = new System.Windows.Forms.Button();
            this.real_estate_land_datagridview = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.real_estate_certificate_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.real_estate_district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.real_estate_section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.real_estate_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.property_range_molecular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.property_range_denominator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.main_building_feet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.main_building_meters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attached_building_feet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attached_building_meters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.right_range_denominator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.right_range_molecular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.public_facility_feet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.public_facility_meters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holder_area_feet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.holder_area_meters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_holder_area_feet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_holder_area_meters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.New_Estate = new System.Windows.Forms.Button();
            this.House_Object_Panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Log_Textbox = new System.Windows.Forms.TextBox();
            this.New_House_Object = new System.Windows.Forms.Button();
            this.Saving = new System.Windows.Forms.Button();
            this.Estate_Land_Certificate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_land_datagridview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Estate_Land_Certificate
            // 
            this.Estate_Land_Certificate.Controls.Add(this.button1);
            this.Estate_Land_Certificate.Controls.Add(this.Remove_Single_Row);
            this.Estate_Land_Certificate.Controls.Add(this.label4);
            this.Estate_Land_Certificate.Controls.Add(this.label3);
            this.Estate_Land_Certificate.Controls.Add(this.label2);
            this.Estate_Land_Certificate.Controls.Add(this.label1);
            this.Estate_Land_Certificate.Controls.Add(this.New_Public_Facility);
            this.Estate_Land_Certificate.Controls.Add(this.real_estate_land_datagridview);
            this.Estate_Land_Certificate.Location = new System.Drawing.Point(12, 296);
            this.Estate_Land_Certificate.Name = "Estate_Land_Certificate";
            this.Estate_Land_Certificate.Size = new System.Drawing.Size(1860, 361);
            this.Estate_Land_Certificate.TabIndex = 1;
            this.Estate_Land_Certificate.TabStop = false;
            this.Estate_Land_Certificate.Text = "謄本資料";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(794, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 25);
            this.button1.TabIndex = 9;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Remove_Single_Row
            // 
            this.Remove_Single_Row.Location = new System.Drawing.Point(9, 18);
            this.Remove_Single_Row.Name = "Remove_Single_Row";
            this.Remove_Single_Row.Size = new System.Drawing.Size(98, 25);
            this.Remove_Single_Row.TabIndex = 8;
            this.Remove_Single_Row.Text = "刪除該行資料";
            this.Remove_Single_Row.UseVisualStyleBackColor = true;
            this.Remove_Single_Row.Click += new System.EventHandler(this.Remove_Single_Row_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1584, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "15";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1091, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "新建完資【公設】資料後，請先點擊一下【類型】，進行排序。使【類型】排序為 xxxx_b、xxxx_p、xxxx_t";
            // 
            // New_Public_Facility
            // 
            this.New_Public_Facility.Location = new System.Drawing.Point(132, 18);
            this.New_Public_Facility.Name = "New_Public_Facility";
            this.New_Public_Facility.Size = new System.Drawing.Size(66, 25);
            this.New_Public_Facility.TabIndex = 3;
            this.New_Public_Facility.Text = "新增公設";
            this.New_Public_Facility.UseVisualStyleBackColor = true;
            this.New_Public_Facility.Click += new System.EventHandler(this.New_Public_Facility_Click);
            // 
            // real_estate_land_datagridview
            // 
            this.real_estate_land_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.real_estate_land_datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.real_estate_certificate_no,
            this.real_estate_district,
            this.real_estate_section,
            this.real_estate_no,
            this.property_range_molecular,
            this.property_range_denominator,
            this.main_building_feet,
            this.main_building_meters,
            this.attached_building_feet,
            this.attached_building_meters,
            this.right_range_denominator,
            this.right_range_molecular,
            this.public_facility_feet,
            this.public_facility_meters,
            this.holder_area_feet,
            this.holder_area_meters,
            this.Total_holder_area_feet,
            this.Total_holder_area_meters,
            this.remark});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.real_estate_land_datagridview.DefaultCellStyle = dataGridViewCellStyle1;
            this.real_estate_land_datagridview.Location = new System.Drawing.Point(6, 70);
            this.real_estate_land_datagridview.Name = "real_estate_land_datagridview";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.real_estate_land_datagridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.real_estate_land_datagridview.RowTemplate.Height = 24;
            this.real_estate_land_datagridview.Size = new System.Drawing.Size(1848, 282);
            this.real_estate_land_datagridview.TabIndex = 0;
            this.real_estate_land_datagridview.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.real_certificate_datagridview_CellValueChanged);
            // 
            // Type
            // 
            this.Type.HeaderText = "類型";
            this.Type.Name = "Type";
            // 
            // real_estate_certificate_no
            // 
            this.real_estate_certificate_no.HeaderText = "建物謄本編號";
            this.real_estate_certificate_no.Name = "real_estate_certificate_no";
            // 
            // real_estate_district
            // 
            this.real_estate_district.HeaderText = "地區/鄉鎮地區";
            this.real_estate_district.Name = "real_estate_district";
            // 
            // real_estate_section
            // 
            this.real_estate_section.HeaderText = "段號";
            this.real_estate_section.Name = "real_estate_section";
            // 
            // real_estate_no
            // 
            this.real_estate_no.HeaderText = "建號";
            this.real_estate_no.Name = "real_estate_no";
            // 
            // property_range_molecular
            // 
            this.property_range_molecular.HeaderText = "產權範圍-分子";
            this.property_range_molecular.Name = "property_range_molecular";
            // 
            // property_range_denominator
            // 
            this.property_range_denominator.HeaderText = "產權範圍-分母";
            this.property_range_denominator.Name = "property_range_denominator";
            // 
            // main_building_feet
            // 
            this.main_building_feet.HeaderText = "主建物-平方公尺";
            this.main_building_feet.Name = "main_building_feet";
            // 
            // main_building_meters
            // 
            this.main_building_meters.HeaderText = "主建物-坪數";
            this.main_building_meters.Name = "main_building_meters";
            // 
            // attached_building_feet
            // 
            this.attached_building_feet.HeaderText = "附屬建物-平方公尺";
            this.attached_building_feet.Name = "attached_building_feet";
            // 
            // attached_building_meters
            // 
            this.attached_building_meters.HeaderText = "附屬建物-坪數";
            this.attached_building_meters.Name = "attached_building_meters";
            // 
            // right_range_denominator
            // 
            this.right_range_denominator.HeaderText = "權力範圍-分子";
            this.right_range_denominator.Name = "right_range_denominator";
            // 
            // right_range_molecular
            // 
            this.right_range_molecular.HeaderText = "權力範圍-分母";
            this.right_range_molecular.Name = "right_range_molecular";
            // 
            // public_facility_feet
            // 
            this.public_facility_feet.HeaderText = "公設-平方公尺";
            this.public_facility_feet.Name = "public_facility_feet";
            // 
            // public_facility_meters
            // 
            this.public_facility_meters.HeaderText = "公設-坪數";
            this.public_facility_meters.Name = "public_facility_meters";
            // 
            // holder_area_feet
            // 
            this.holder_area_feet.HeaderText = "持分面積-平方公尺";
            this.holder_area_feet.Name = "holder_area_feet";
            // 
            // holder_area_meters
            // 
            this.holder_area_meters.HeaderText = "持分面積-坪數";
            this.holder_area_meters.Name = "holder_area_meters";
            // 
            // Total_holder_area_feet
            // 
            this.Total_holder_area_feet.HeaderText = "持分面積-平方公尺(總)";
            this.Total_holder_area_feet.Name = "Total_holder_area_feet";
            // 
            // Total_holder_area_meters
            // 
            this.Total_holder_area_meters.HeaderText = "持分面積-坪數(總)";
            this.Total_holder_area_meters.Name = "Total_holder_area_meters";
            // 
            // remark
            // 
            this.remark.HeaderText = "備註";
            this.remark.Name = "remark";
            // 
            // New_Estate
            // 
            this.New_Estate.Location = new System.Drawing.Point(107, 12);
            this.New_Estate.Name = "New_Estate";
            this.New_Estate.Size = new System.Drawing.Size(103, 21);
            this.New_Estate.TabIndex = 2;
            this.New_Estate.Text = "資料轉換至表格";
            this.New_Estate.UseVisualStyleBackColor = true;
            this.New_Estate.Click += new System.EventHandler(this.New_Estate_Click);
            // 
            // House_Object_Panel
            // 
            this.House_Object_Panel.AutoScroll = true;
            this.House_Object_Panel.Location = new System.Drawing.Point(12, 41);
            this.House_Object_Panel.Name = "House_Object_Panel";
            this.House_Object_Panel.Size = new System.Drawing.Size(972, 249);
            this.House_Object_Panel.TabIndex = 113;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Log_Textbox);
            this.groupBox1.Location = new System.Drawing.Point(990, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 257);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Log_Textbox
            // 
            this.Log_Textbox.Location = new System.Drawing.Point(6, 21);
            this.Log_Textbox.Multiline = true;
            this.Log_Textbox.Name = "Log_Textbox";
            this.Log_Textbox.Size = new System.Drawing.Size(448, 230);
            this.Log_Textbox.TabIndex = 0;
            // 
            // New_House_Object
            // 
            this.New_House_Object.Location = new System.Drawing.Point(12, 12);
            this.New_House_Object.Name = "New_House_Object";
            this.New_House_Object.Size = new System.Drawing.Size(75, 23);
            this.New_House_Object.TabIndex = 115;
            this.New_House_Object.Text = "新增房屋物件";
            this.New_House_Object.UseVisualStyleBackColor = true;
            this.New_House_Object.Click += new System.EventHandler(this.New_House_Object_Click);
            // 
            // Saving
            // 
            this.Saving.Location = new System.Drawing.Point(232, 12);
            this.Saving.Name = "Saving";
            this.Saving.Size = new System.Drawing.Size(81, 21);
            this.Saving.TabIndex = 116;
            this.Saving.Text = "儲存";
            this.Saving.UseVisualStyleBackColor = true;
            this.Saving.Click += new System.EventHandler(this.Saving_Click);
            // 
            // Real_Estate_Land_Certificate_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Saving);
            this.Controls.Add(this.New_House_Object);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.House_Object_Panel);
            this.Controls.Add(this.Estate_Land_Certificate);
            this.Controls.Add(this.New_Estate);
            this.Name = "Real_Estate_Land_Certificate_Form";
            this.Text = "real_estate_land_certificate";
            this.Load += new System.EventHandler(this.Real_Estate_Land_Certificate_Form_Load);
            this.Estate_Land_Certificate.ResumeLayout(false);
            this.Estate_Land_Certificate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_land_datagridview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Estate_Land_Certificate;
        private Button New_Public_Facility;
        private Button New_Estate;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        public Panel House_Object_Panel;
        private GroupBox groupBox1;
        private TextBox Log_Textbox;
        private Button New_House_Object;
        private DataGridView real_estate_land_datagridview;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn real_estate_certificate_no;
        private DataGridViewTextBoxColumn real_estate_district;
        private DataGridViewTextBoxColumn real_estate_section;
        private DataGridViewTextBoxColumn real_estate_no;
        private DataGridViewTextBoxColumn property_range_molecular;
        private DataGridViewTextBoxColumn property_range_denominator;
        private DataGridViewTextBoxColumn main_building_feet;
        private DataGridViewTextBoxColumn main_building_meters;
        private DataGridViewTextBoxColumn attached_building_feet;
        private DataGridViewTextBoxColumn attached_building_meters;
        private DataGridViewTextBoxColumn right_range_denominator;
        private DataGridViewTextBoxColumn right_range_molecular;
        private DataGridViewTextBoxColumn public_facility_feet;
        private DataGridViewTextBoxColumn public_facility_meters;
        private DataGridViewTextBoxColumn holder_area_feet;
        private DataGridViewTextBoxColumn holder_area_meters;
        private DataGridViewTextBoxColumn Total_holder_area_feet;
        private DataGridViewTextBoxColumn Total_holder_area_meters;
        private DataGridViewTextBoxColumn remark;
        private Button Saving;
        private Button Remove_Single_Row;
        private Button button1;
    }
}