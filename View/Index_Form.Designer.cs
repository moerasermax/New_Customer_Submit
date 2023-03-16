using System.Windows.Forms;

namespace New_Customer_Submit.View
{
    partial class index_form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Form_ID_Combobox = new System.Windows.Forms.ComboBox();
            this.Special_Mark = new System.Windows.Forms.CheckBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Current_Time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.New_Form = new System.Windows.Forms.Button();
            this.Get_Form_Data = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.New_Customer = new System.Windows.Forms.Button();
            this.Get_Personal_Form = new System.Windows.Forms.Button();
            this.Personal_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConsoleBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Modify_FormData = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Test_Connection = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Form_ID_Combobox);
            this.groupBox1.Controls.Add(this.Special_Mark);
            this.groupBox1.Controls.Add(this.label57);
            this.groupBox1.Controls.Add(this.label56);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Current_Time);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.New_Form);
            this.groupBox1.Controls.Add(this.Get_Form_Data);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.New_Customer);
            this.groupBox1.Controls.Add(this.Get_Personal_Form);
            this.groupBox1.Controls.Add(this.Personal_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(19, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(348, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "客戶資料加載";
            // 
            // Form_ID_Combobox
            // 
            this.Form_ID_Combobox.FormattingEnabled = true;
            this.Form_ID_Combobox.Location = new System.Drawing.Point(55, 59);
            this.Form_ID_Combobox.Name = "Form_ID_Combobox";
            this.Form_ID_Combobox.Size = new System.Drawing.Size(114, 20);
            this.Form_ID_Combobox.TabIndex = 21;
            // 
            // Special_Mark
            // 
            this.Special_Mark.AutoSize = true;
            this.Special_Mark.BackColor = System.Drawing.Color.Transparent;
            this.Special_Mark.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Special_Mark.Location = new System.Drawing.Point(145, 96);
            this.Special_Mark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Special_Mark.Name = "Special_Mark";
            this.Special_Mark.Size = new System.Drawing.Size(72, 16);
            this.Special_Mark.TabIndex = 20;
            this.Special_Mark.Text = "特別註記";
            this.Special_Mark.UseVisualStyleBackColor = false;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.BackColor = System.Drawing.Color.Transparent;
            this.label57.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label57.Location = new System.Drawing.Point(298, 92);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(45, 12);
            this.label57.TabIndex = 19;
            this.label57.Text = "Date_Str";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.BackColor = System.Drawing.Color.Transparent;
            this.label56.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label56.Location = new System.Drawing.Point(243, 92);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(65, 12);
            this.label56.TabIndex = 18;
            this.label56.Text = "填表日期：";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(55, 92);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(77, 20);
            this.comboBox2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(9, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "狀態：";
            // 
            // Current_Time
            // 
            this.Current_Time.AutoSize = true;
            this.Current_Time.BackColor = System.Drawing.Color.Transparent;
            this.Current_Time.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Current_Time.Location = new System.Drawing.Point(277, 110);
            this.Current_Time.Name = "Current_Time";
            this.Current_Time.Size = new System.Drawing.Size(71, 12);
            this.Current_Time.TabIndex = 10;
            this.Current_Time.Text = "Current_Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(243, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "日期：";
            // 
            // New_Form
            // 
            this.New_Form.ForeColor = System.Drawing.SystemColors.ControlText;
            this.New_Form.Location = new System.Drawing.Point(248, 56);
            this.New_Form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.New_Form.Name = "New_Form";
            this.New_Form.Size = new System.Drawing.Size(100, 24);
            this.New_Form.TabIndex = 8;
            this.New_Form.Text = "新申請表";
            this.New_Form.UseVisualStyleBackColor = true;
            this.New_Form.Click += new System.EventHandler(this.New_Form_Click);
            // 
            // Get_Form_Data
            // 
            this.Get_Form_Data.BackColor = System.Drawing.Color.Transparent;
            this.Get_Form_Data.Enabled = false;
            this.Get_Form_Data.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Get_Form_Data.Location = new System.Drawing.Point(175, 56);
            this.Get_Form_Data.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Get_Form_Data.Name = "Get_Form_Data";
            this.Get_Form_Data.Size = new System.Drawing.Size(67, 24);
            this.Get_Form_Data.TabIndex = 7;
            this.Get_Form_Data.Text = "查詢";
            this.Get_Form_Data.UseVisualStyleBackColor = false;
            this.Get_Form_Data.Click += new System.EventHandler(this.Get_Form_Data_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "單號：";
            // 
            // New_Customer
            // 
            this.New_Customer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.New_Customer.Location = new System.Drawing.Point(248, 19);
            this.New_Customer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.New_Customer.Name = "New_Customer";
            this.New_Customer.Size = new System.Drawing.Size(100, 24);
            this.New_Customer.TabIndex = 4;
            this.New_Customer.Text = "建立新顧客";
            this.New_Customer.UseVisualStyleBackColor = true;
            this.New_Customer.Click += new System.EventHandler(this.New_Customer_Click);
            // 
            // Get_Personal_Form
            // 
            this.Get_Personal_Form.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Get_Personal_Form.Location = new System.Drawing.Point(175, 19);
            this.Get_Personal_Form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Get_Personal_Form.Name = "Get_Personal_Form";
            this.Get_Personal_Form.Size = new System.Drawing.Size(67, 24);
            this.Get_Personal_Form.TabIndex = 2;
            this.Get_Personal_Form.Text = "查詢";
            this.Get_Personal_Form.UseVisualStyleBackColor = true;
            this.Get_Personal_Form.Click += new System.EventHandler(this.Get_Personal_Form_Click);
            // 
            // Personal_id
            // 
            this.Personal_id.Location = new System.Drawing.Point(55, 19);
            this.Personal_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Personal_id.Name = "Personal_id";
            this.Personal_id.Size = new System.Drawing.Size(114, 22);
            this.Personal_id.TabIndex = 1;
            this.Personal_id.Text = "A123456789";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "客戶ID";
            // 
            // ConsoleBox
            // 
            this.ConsoleBox.Location = new System.Drawing.Point(5, 19);
            this.ConsoleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsoleBox.Multiline = true;
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ConsoleBox.Size = new System.Drawing.Size(273, 265);
            this.ConsoleBox.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.ConsoleBox);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(385, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(284, 300);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "運算結果";
            // 
            // Modify_FormData
            // 
            this.Modify_FormData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Modify_FormData.Location = new System.Drawing.Point(20, 57);
            this.Modify_FormData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Modify_FormData.Name = "Modify_FormData";
            this.Modify_FormData.Size = new System.Drawing.Size(302, 33);
            this.Modify_FormData.TabIndex = 4;
            this.Modify_FormData.Text = "進件系統(未)";
            this.Modify_FormData.UseVisualStyleBackColor = true;
            this.Modify_FormData.Click += new System.EventHandler(this.Modify_FormData_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.Test_Connection);
            this.groupBox3.Controls.Add(this.Modify_FormData);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(24, 154);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(338, 157);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "功能選項";
            // 
            // Test_Connection
            // 
            this.Test_Connection.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Test_Connection.Location = new System.Drawing.Point(20, 19);
            this.Test_Connection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Test_Connection.Name = "Test_Connection";
            this.Test_Connection.Size = new System.Drawing.Size(302, 33);
            this.Test_Connection.TabIndex = 5;
            this.Test_Connection.Text = "測試連線功能";
            this.Test_Connection.UseVisualStyleBackColor = true;
            this.Test_Connection.Click += new System.EventHandler(this.Test_Connection_Click);
            // 
            // index_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::New_Customer_Submit.Properties.Resources.我的專案;
            this.ClientSize = new System.Drawing.Size(677, 314);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "index_form";
            this.Text = "index";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox Special_Mark;
        private Label label57;
        private Label label56;
        private ComboBox comboBox2;
        private Label label5;
        private Label Current_Time;
        private Label label3;
        private Button New_Form;
        private Button Get_Form_Data;
        private Label label2;
        private Button New_Customer;
        private Button Get_Personal_Form;
        private TextBox Personal_id;
        private Label label1;
        private TextBox ConsoleBox;
        private GroupBox groupBox2;
        private Button Modify_FormData;
        private GroupBox groupBox3;
        private Button Test_Connection;
        private ComboBox Form_ID_Combobox;
    }
}