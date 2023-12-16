namespace hrdApp
{
    partial class FurloughsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FurloughsForm));
            this.gb_1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_RegNumber = new System.Windows.Forms.TextBox();
            this.cb_Employee = new System.Windows.Forms.ComboBox();
            this.b_Close = new System.Windows.Forms.Button();
            this.gb_3 = new System.Windows.Forms.GroupBox();
            this.b_DeleteFurlough = new System.Windows.Forms.Button();
            this.b_AddFurlough = new System.Windows.Forms.Button();
            this.cb_MainSlave = new System.Windows.Forms.CheckBox();
            this.l_FurloughDays = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.l_PlanFurloughDays = new System.Windows.Forms.Label();
            this.gb_2 = new System.Windows.Forms.GroupBox();
            this.l_PlanFurloughStart = new System.Windows.Forms.Label();
            this.l_PlanFurloughType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gb_1.SuspendLayout();
            this.gb_3.SuspendLayout();
            this.gb_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_1
            // 
            this.gb_1.BackColor = System.Drawing.Color.Azure;
            this.gb_1.Controls.Add(this.label1);
            this.gb_1.Controls.Add(this.tb_RegNumber);
            this.gb_1.Controls.Add(this.cb_Employee);
            this.gb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_1.Location = new System.Drawing.Point(12, 12);
            this.gb_1.Name = "gb_1";
            this.gb_1.Size = new System.Drawing.Size(310, 100);
            this.gb_1.TabIndex = 2;
            this.gb_1.TabStop = false;
            this.gb_1.Text = "Працівник";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Табельний номер:";
            // 
            // tb_RegNumber
            // 
            this.tb_RegNumber.Enabled = false;
            this.tb_RegNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_RegNumber.ForeColor = System.Drawing.Color.Gray;
            this.tb_RegNumber.Location = new System.Drawing.Point(137, 62);
            this.tb_RegNumber.MaxLength = 50;
            this.tb_RegNumber.Name = "tb_RegNumber";
            this.tb_RegNumber.Size = new System.Drawing.Size(51, 22);
            this.tb_RegNumber.TabIndex = 24;
            this.tb_RegNumber.TabStop = false;
            this.tb_RegNumber.Text = "0";
            // 
            // cb_Employee
            // 
            this.cb_Employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Employee.Location = new System.Drawing.Point(13, 20);
            this.cb_Employee.Name = "cb_Employee";
            this.cb_Employee.Size = new System.Drawing.Size(286, 28);
            this.cb_Employee.TabIndex = 3;
            this.cb_Employee.SelectedIndexChanged += new System.EventHandler(this.cb_Employee_SelectedIndexChanged);
            this.cb_Employee.TextChanged += new System.EventHandler(this.cb_Employee_TextChanged);
            // 
            // b_Close
            // 
            this.b_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Close.Location = new System.Drawing.Point(238, 369);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(84, 25);
            this.b_Close.TabIndex = 1;
            this.b_Close.Text = "Закрити";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            this.b_Close.KeyDown += new System.Windows.Forms.KeyEventHandler(this.b_Close_KeyDown);
            // 
            // gb_3
            // 
            this.gb_3.Controls.Add(this.b_DeleteFurlough);
            this.gb_3.Controls.Add(this.b_AddFurlough);
            this.gb_3.Controls.Add(this.cb_MainSlave);
            this.gb_3.Controls.Add(this.l_FurloughDays);
            this.gb_3.Controls.Add(this.label4);
            this.gb_3.Controls.Add(this.label3);
            this.gb_3.Controls.Add(this.dtp_EndDate);
            this.gb_3.Controls.Add(this.label2);
            this.gb_3.Controls.Add(this.dtp_StartDate);
            this.gb_3.Location = new System.Drawing.Point(12, 213);
            this.gb_3.Name = "gb_3";
            this.gb_3.Size = new System.Drawing.Size(310, 140);
            this.gb_3.TabIndex = 4;
            this.gb_3.TabStop = false;
            this.gb_3.Text = "Планування відпустки";
            // 
            // b_DeleteFurlough
            // 
            this.b_DeleteFurlough.BackColor = System.Drawing.SystemColors.Control;
            this.b_DeleteFurlough.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_DeleteFurlough.ForeColor = System.Drawing.Color.Red;
            this.b_DeleteFurlough.Location = new System.Drawing.Point(167, 106);
            this.b_DeleteFurlough.Name = "b_DeleteFurlough";
            this.b_DeleteFurlough.Size = new System.Drawing.Size(118, 22);
            this.b_DeleteFurlough.TabIndex = 9;
            this.b_DeleteFurlough.Text = "Видалити відпустку";
            this.b_DeleteFurlough.UseVisualStyleBackColor = false;
            this.b_DeleteFurlough.Click += new System.EventHandler(this.b_DeleteFurlough_Click);
            this.b_DeleteFurlough.MouseHover += new System.EventHandler(this.b_DeleteFurlough_MouseHover);
            // 
            // b_AddFurlough
            // 
            this.b_AddFurlough.BackColor = System.Drawing.SystemColors.Control;
            this.b_AddFurlough.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_AddFurlough.ForeColor = System.Drawing.Color.Green;
            this.b_AddFurlough.Location = new System.Drawing.Point(25, 106);
            this.b_AddFurlough.Name = "b_AddFurlough";
            this.b_AddFurlough.Size = new System.Drawing.Size(118, 22);
            this.b_AddFurlough.TabIndex = 8;
            this.b_AddFurlough.Text = "Додати відпустку";
            this.b_AddFurlough.UseVisualStyleBackColor = false;
            this.b_AddFurlough.Click += new System.EventHandler(this.b_AddFurlough_Click);
            this.b_AddFurlough.MouseHover += new System.EventHandler(this.b_AddFurlough_MouseHover);
            // 
            // cb_MainSlave
            // 
            this.cb_MainSlave.AutoSize = true;
            this.cb_MainSlave.Checked = true;
            this.cb_MainSlave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_MainSlave.Location = new System.Drawing.Point(171, 71);
            this.cb_MainSlave.Name = "cb_MainSlave";
            this.cb_MainSlave.Size = new System.Drawing.Size(128, 17);
            this.cb_MainSlave.TabIndex = 7;
            this.cb_MainSlave.Text = "Основна/додаткова";
            this.cb_MainSlave.UseVisualStyleBackColor = true;
            // 
            // l_FurloughDays
            // 
            this.l_FurloughDays.AutoSize = true;
            this.l_FurloughDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_FurloughDays.Location = new System.Drawing.Point(137, 72);
            this.l_FurloughDays.Name = "l_FurloughDays";
            this.l_FurloughDays.Size = new System.Drawing.Size(11, 13);
            this.l_FurloughDays.TabIndex = 61;
            this.l_FurloughDays.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Кількість днів відпустки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Закінчення відпустки:";
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Location = new System.Drawing.Point(129, 43);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(170, 20);
            this.dtp_EndDate.TabIndex = 6;
            this.dtp_EndDate.ValueChanged += new System.EventHandler(this.dtp_EndDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Початок відпустки:";
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.CustomFormat = "";
            this.dtp_StartDate.Location = new System.Drawing.Point(129, 17);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(170, 20);
            this.dtp_StartDate.TabIndex = 5;
            this.dtp_StartDate.ValueChanged += new System.EventHandler(this.dtp_StartDate_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Початок відпустки:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Кількість днів відпустки:";
            // 
            // l_PlanFurloughDays
            // 
            this.l_PlanFurloughDays.AutoSize = true;
            this.l_PlanFurloughDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_PlanFurloughDays.Location = new System.Drawing.Point(137, 42);
            this.l_PlanFurloughDays.Name = "l_PlanFurloughDays";
            this.l_PlanFurloughDays.Size = new System.Drawing.Size(11, 13);
            this.l_PlanFurloughDays.TabIndex = 61;
            this.l_PlanFurloughDays.Text = "-";
            // 
            // gb_2
            // 
            this.gb_2.Controls.Add(this.l_PlanFurloughStart);
            this.gb_2.Controls.Add(this.l_PlanFurloughType);
            this.gb_2.Controls.Add(this.l_PlanFurloughDays);
            this.gb_2.Controls.Add(this.label5);
            this.gb_2.Controls.Add(this.label6);
            this.gb_2.Controls.Add(this.label8);
            this.gb_2.Location = new System.Drawing.Point(12, 118);
            this.gb_2.Name = "gb_2";
            this.gb_2.Size = new System.Drawing.Size(310, 89);
            this.gb_2.TabIndex = 56;
            this.gb_2.TabStop = false;
            this.gb_2.Text = "Заплановані відпустки";
            // 
            // l_PlanFurloughStart
            // 
            this.l_PlanFurloughStart.AutoSize = true;
            this.l_PlanFurloughStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_PlanFurloughStart.Location = new System.Drawing.Point(137, 20);
            this.l_PlanFurloughStart.Name = "l_PlanFurloughStart";
            this.l_PlanFurloughStart.Size = new System.Drawing.Size(11, 13);
            this.l_PlanFurloughStart.TabIndex = 62;
            this.l_PlanFurloughStart.Text = "-";
            // 
            // l_PlanFurloughType
            // 
            this.l_PlanFurloughType.AutoSize = true;
            this.l_PlanFurloughType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_PlanFurloughType.Location = new System.Drawing.Point(137, 64);
            this.l_PlanFurloughType.Name = "l_PlanFurloughType";
            this.l_PlanFurloughType.Size = new System.Drawing.Size(11, 13);
            this.l_PlanFurloughType.TabIndex = 61;
            this.l_PlanFurloughType.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Основна або додаткова:";
            // 
            // FurloughsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 408);
            this.Controls.Add(this.gb_2);
            this.Controls.Add(this.gb_3);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.gb_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FurloughsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Відпустки";
            this.Shown += new System.EventHandler(this.FurloughsForm_Shown);
            this.gb_1.ResumeLayout(false);
            this.gb_1.PerformLayout();
            this.gb_3.ResumeLayout(false);
            this.gb_3.PerformLayout();
            this.gb_2.ResumeLayout(false);
            this.gb_2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_RegNumber;
        private System.Windows.Forms.ComboBox cb_Employee;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.GroupBox gb_3;
        private System.Windows.Forms.CheckBox cb_MainSlave;
        private System.Windows.Forms.Label l_FurloughDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Button b_DeleteFurlough;
        private System.Windows.Forms.Button b_AddFurlough;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l_PlanFurloughDays;
        private System.Windows.Forms.GroupBox gb_2;
        private System.Windows.Forms.Label l_PlanFurloughStart;
        private System.Windows.Forms.Label l_PlanFurloughType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip;
    }
}