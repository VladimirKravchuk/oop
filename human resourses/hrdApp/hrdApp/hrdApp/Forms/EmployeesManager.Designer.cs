namespace hrdApp
{
    partial class EmployeesManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesManager));
            this.gb_1 = new System.Windows.Forms.GroupBox();
            this.b_Set_PIB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_RegNumber = new System.Windows.Forms.TextBox();
            this.cb_Employee = new System.Windows.Forms.ComboBox();
            this.gb_2 = new System.Windows.Forms.GroupBox();
            this.pB_user = new System.Windows.Forms.PictureBox();
            this.b_OK = new System.Windows.Forms.Button();
            this.b_Back = new System.Windows.Forms.Button();
            this.gb_4 = new System.Windows.Forms.GroupBox();
            this.rtb_AboutPassport = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rtb_ActualResidence = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rtb_Residence = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_PassportNumber = new System.Windows.Forms.TextBox();
            this.tb_PassportSeries = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_5 = new System.Windows.Forms.GroupBox();
            this.rtb_AboutManWoman = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rtb_AboutChildren = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.rtb_AboutParents = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gb_3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.l_Age = new System.Windows.Forms.Label();
            this.tb_BirthDay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ITN = new System.Windows.Forms.TextBox();
            this.rtb_Education = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.gb_6 = new System.Windows.Forms.GroupBox();
            this.rtb_Conviction = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.l_N_Employees = new System.Windows.Forms.Label();
            this.b_Delete = new System.Windows.Forms.Button();
            this.openFileDialog_photo = new System.Windows.Forms.OpenFileDialog();
            this.b_Accept = new System.Windows.Forms.Button();
            this.gb_1.SuspendLayout();
            this.gb_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_user)).BeginInit();
            this.gb_4.SuspendLayout();
            this.gb_5.SuspendLayout();
            this.gb_3.SuspendLayout();
            this.gb_6.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_1
            // 
            this.gb_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.gb_1.Controls.Add(this.b_Set_PIB);
            this.gb_1.Controls.Add(this.label1);
            this.gb_1.Controls.Add(this.tb_RegNumber);
            this.gb_1.Controls.Add(this.cb_Employee);
            this.gb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_1.Location = new System.Drawing.Point(12, 12);
            this.gb_1.Name = "gb_1";
            this.gb_1.Size = new System.Drawing.Size(339, 100);
            this.gb_1.TabIndex = 2;
            this.gb_1.TabStop = false;
            this.gb_1.Text = "Працівник";
            // 
            // b_Set_PIB
            // 
            this.b_Set_PIB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Set_PIB.Location = new System.Drawing.Point(248, 62);
            this.b_Set_PIB.Name = "b_Set_PIB";
            this.b_Set_PIB.Size = new System.Drawing.Size(76, 22);
            this.b_Set_PIB.TabIndex = 35;
            this.b_Set_PIB.TabStop = false;
            this.b_Set_PIB.Text = "Змінити ПІБ";
            this.b_Set_PIB.UseVisualStyleBackColor = true;
            this.b_Set_PIB.Click += new System.EventHandler(this.b_Set_PIB_Click);
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
            this.cb_Employee.Size = new System.Drawing.Size(311, 28);
            this.cb_Employee.TabIndex = 3;
            this.cb_Employee.SelectedIndexChanged += new System.EventHandler(this.cb_Employee_SelectedIndexChanged);
            // 
            // gb_2
            // 
            this.gb_2.BackColor = System.Drawing.SystemColors.Control;
            this.gb_2.Controls.Add(this.pB_user);
            this.gb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_2.Location = new System.Drawing.Point(12, 118);
            this.gb_2.Name = "gb_2";
            this.gb_2.Size = new System.Drawing.Size(169, 229);
            this.gb_2.TabIndex = 20;
            this.gb_2.TabStop = false;
            this.gb_2.Text = "Фото працівника:";
            // 
            // pB_user
            // 
            this.pB_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pB_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pB_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pB_user.InitialImage = null;
            this.pB_user.Location = new System.Drawing.Point(10, 20);
            this.pB_user.Name = "pB_user";
            this.pB_user.Size = new System.Drawing.Size(150, 200);
            this.pB_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB_user.TabIndex = 8;
            this.pB_user.TabStop = false;
            this.pB_user.Click += new System.EventHandler(this.pB_user_Click);
            // 
            // b_OK
            // 
            this.b_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_OK.Location = new System.Drawing.Point(457, 367);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(84, 25);
            this.b_OK.TabIndex = 34;
            this.b_OK.Text = "OK";
            this.b_OK.UseVisualStyleBackColor = true;
            this.b_OK.Click += new System.EventHandler(this.b_OK_Click);
            // 
            // b_Back
            // 
            this.b_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Back.Location = new System.Drawing.Point(547, 367);
            this.b_Back.Name = "b_Back";
            this.b_Back.Size = new System.Drawing.Size(84, 25);
            this.b_Back.TabIndex = 1;
            this.b_Back.Text = "Скасувати";
            this.b_Back.UseVisualStyleBackColor = true;
            this.b_Back.Click += new System.EventHandler(this.b_Back_Click);
            this.b_Back.KeyDown += new System.Windows.Forms.KeyEventHandler(this.b_Back_KeyDown);
            // 
            // gb_4
            // 
            this.gb_4.Controls.Add(this.rtb_AboutPassport);
            this.gb_4.Controls.Add(this.label10);
            this.gb_4.Controls.Add(this.rtb_ActualResidence);
            this.gb_4.Controls.Add(this.label9);
            this.gb_4.Controls.Add(this.rtb_Residence);
            this.gb_4.Controls.Add(this.label2);
            this.gb_4.Controls.Add(this.tb_PassportNumber);
            this.gb_4.Controls.Add(this.tb_PassportSeries);
            this.gb_4.Controls.Add(this.label5);
            this.gb_4.Location = new System.Drawing.Point(357, 12);
            this.gb_4.Name = "gb_4";
            this.gb_4.Size = new System.Drawing.Size(180, 335);
            this.gb_4.TabIndex = 9;
            this.gb_4.TabStop = false;
            this.gb_4.Text = "Паспортні дані";
            // 
            // rtb_AboutPassport
            // 
            this.rtb_AboutPassport.Location = new System.Drawing.Point(9, 71);
            this.rtb_AboutPassport.Name = "rtb_AboutPassport";
            this.rtb_AboutPassport.Size = new System.Drawing.Size(161, 72);
            this.rtb_AboutPassport.TabIndex = 12;
            this.rtb_AboutPassport.Text = "";
            this.rtb_AboutPassport.TextChanged += new System.EventHandler(this.rtb_AboutPassport_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Ким та коли виданий паспорт:";
            // 
            // rtb_ActualResidence
            // 
            this.rtb_ActualResidence.Location = new System.Drawing.Point(9, 253);
            this.rtb_ActualResidence.Name = "rtb_ActualResidence";
            this.rtb_ActualResidence.Size = new System.Drawing.Size(161, 72);
            this.rtb_ActualResidence.TabIndex = 14;
            this.rtb_ActualResidence.Text = "";
            this.rtb_ActualResidence.TextChanged += new System.EventHandler(this.rtb_ActualResidence_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Фактичне місце проживання:";
            // 
            // rtb_Residence
            // 
            this.rtb_Residence.Location = new System.Drawing.Point(9, 162);
            this.rtb_Residence.Name = "rtb_Residence";
            this.rtb_Residence.Size = new System.Drawing.Size(161, 72);
            this.rtb_Residence.TabIndex = 13;
            this.rtb_Residence.Text = "";
            this.rtb_Residence.TextChanged += new System.EventHandler(this.rtb_Residence_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Місце проживання:";
            // 
            // tb_PassportNumber
            // 
            this.tb_PassportNumber.Location = new System.Drawing.Point(45, 32);
            this.tb_PassportNumber.Name = "tb_PassportNumber";
            this.tb_PassportNumber.Size = new System.Drawing.Size(125, 20);
            this.tb_PassportNumber.TabIndex = 11;
            this.tb_PassportNumber.TextChanged += new System.EventHandler(this.tb_PassportNumber_TextChanged);
            // 
            // tb_PassportSeries
            // 
            this.tb_PassportSeries.Location = new System.Drawing.Point(9, 32);
            this.tb_PassportSeries.Name = "tb_PassportSeries";
            this.tb_PassportSeries.Size = new System.Drawing.Size(30, 20);
            this.tb_PassportSeries.TabIndex = 10;
            this.tb_PassportSeries.TextChanged += new System.EventHandler(this.tb_PassportSeries_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Серія та номер паспорта:";
            // 
            // gb_5
            // 
            this.gb_5.Controls.Add(this.rtb_AboutManWoman);
            this.gb_5.Controls.Add(this.label11);
            this.gb_5.Controls.Add(this.rtb_AboutChildren);
            this.gb_5.Controls.Add(this.label12);
            this.gb_5.Controls.Add(this.rtb_AboutParents);
            this.gb_5.Controls.Add(this.label13);
            this.gb_5.Location = new System.Drawing.Point(543, 12);
            this.gb_5.Name = "gb_5";
            this.gb_5.Size = new System.Drawing.Size(180, 262);
            this.gb_5.TabIndex = 15;
            this.gb_5.TabStop = false;
            this.gb_5.Text = "Відомості про сім\'ю";
            // 
            // rtb_AboutManWoman
            // 
            this.rtb_AboutManWoman.Location = new System.Drawing.Point(9, 36);
            this.rtb_AboutManWoman.Name = "rtb_AboutManWoman";
            this.rtb_AboutManWoman.Size = new System.Drawing.Size(161, 60);
            this.rtb_AboutManWoman.TabIndex = 16;
            this.rtb_AboutManWoman.Text = "";
            this.rtb_AboutManWoman.TextChanged += new System.EventHandler(this.rtb_AboutManWoman_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Відомості про чоловіка/дружину:";
            // 
            // rtb_AboutChildren
            // 
            this.rtb_AboutChildren.Location = new System.Drawing.Point(9, 193);
            this.rtb_AboutChildren.Name = "rtb_AboutChildren";
            this.rtb_AboutChildren.Size = new System.Drawing.Size(161, 60);
            this.rtb_AboutChildren.TabIndex = 18;
            this.rtb_AboutChildren.Text = "";
            this.rtb_AboutChildren.TextChanged += new System.EventHandler(this.rtb_AboutChildren_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Відомості про дітей:";
            // 
            // rtb_AboutParents
            // 
            this.rtb_AboutParents.Location = new System.Drawing.Point(9, 115);
            this.rtb_AboutParents.Name = "rtb_AboutParents";
            this.rtb_AboutParents.Size = new System.Drawing.Size(161, 60);
            this.rtb_AboutParents.TabIndex = 17;
            this.rtb_AboutParents.Text = "";
            this.rtb_AboutParents.TextChanged += new System.EventHandler(this.rtb_AboutParents_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Відомості про батьків:";
            // 
            // gb_3
            // 
            this.gb_3.Controls.Add(this.label3);
            this.gb_3.Controls.Add(this.l_Age);
            this.gb_3.Controls.Add(this.tb_BirthDay);
            this.gb_3.Controls.Add(this.label8);
            this.gb_3.Controls.Add(this.label4);
            this.gb_3.Controls.Add(this.tb_ITN);
            this.gb_3.Controls.Add(this.rtb_Education);
            this.gb_3.Controls.Add(this.label6);
            this.gb_3.Controls.Add(this.label7);
            this.gb_3.Controls.Add(this.tb_Phone);
            this.gb_3.Location = new System.Drawing.Point(187, 118);
            this.gb_3.Name = "gb_3";
            this.gb_3.Size = new System.Drawing.Size(164, 229);
            this.gb_3.TabIndex = 4;
            this.gb_3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Дата народження:";
            // 
            // l_Age
            // 
            this.l_Age.AutoSize = true;
            this.l_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Age.ForeColor = System.Drawing.SystemColors.ControlText;
            this.l_Age.Location = new System.Drawing.Point(87, 16);
            this.l_Age.Name = "l_Age";
            this.l_Age.Size = new System.Drawing.Size(13, 16);
            this.l_Age.TabIndex = 52;
            this.l_Age.Text = "-";
            // 
            // tb_BirthDay
            // 
            this.tb_BirthDay.Location = new System.Drawing.Point(6, 56);
            this.tb_BirthDay.Name = "tb_BirthDay";
            this.tb_BirthDay.Size = new System.Drawing.Size(152, 20);
            this.tb_BirthDay.TabIndex = 5;
            this.tb_BirthDay.TextChanged += new System.EventHandler(this.tb_BirthDay_TextChanged);
            this.tb_BirthDay.Enter += new System.EventHandler(this.tb_BirthDay_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 51;
            this.label8.Text = "Вік (років):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "ІПН:";
            // 
            // tb_ITN
            // 
            this.tb_ITN.Location = new System.Drawing.Point(6, 145);
            this.tb_ITN.Name = "tb_ITN";
            this.tb_ITN.Size = new System.Drawing.Size(152, 20);
            this.tb_ITN.TabIndex = 7;
            this.tb_ITN.TextChanged += new System.EventHandler(this.tb_ITN_TextChanged);
            // 
            // rtb_Education
            // 
            this.rtb_Education.Location = new System.Drawing.Point(6, 187);
            this.rtb_Education.Name = "rtb_Education";
            this.rtb_Education.Size = new System.Drawing.Size(152, 33);
            this.rtb_Education.TabIndex = 8;
            this.rtb_Education.Text = "";
            this.rtb_Education.TextChanged += new System.EventHandler(this.tb_Education_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Контактний номер телефону:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Відомості про освіту:";
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(6, 103);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(152, 20);
            this.tb_Phone.TabIndex = 6;
            this.tb_Phone.TextChanged += new System.EventHandler(this.tb_Phone_TextChanged);
            this.tb_Phone.Enter += new System.EventHandler(this.tb_Phone_Enter);
            // 
            // gb_6
            // 
            this.gb_6.Controls.Add(this.rtb_Conviction);
            this.gb_6.Location = new System.Drawing.Point(543, 280);
            this.gb_6.Name = "gb_6";
            this.gb_6.Size = new System.Drawing.Size(178, 67);
            this.gb_6.TabIndex = 19;
            this.gb_6.TabStop = false;
            this.gb_6.Text = "Відомості про судимості:";
            // 
            // rtb_Conviction
            // 
            this.rtb_Conviction.Location = new System.Drawing.Point(9, 19);
            this.rtb_Conviction.Name = "rtb_Conviction";
            this.rtb_Conviction.Size = new System.Drawing.Size(161, 39);
            this.rtb_Conviction.TabIndex = 20;
            this.rtb_Conviction.Text = "";
            this.rtb_Conviction.TextChanged += new System.EventHandler(this.rtb_Conviction_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 373);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(181, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Кількість працівників в базі даних:";
            // 
            // l_N_Employees
            // 
            this.l_N_Employees.AutoSize = true;
            this.l_N_Employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_N_Employees.Location = new System.Drawing.Point(193, 373);
            this.l_N_Employees.Name = "l_N_Employees";
            this.l_N_Employees.Size = new System.Drawing.Size(11, 13);
            this.l_N_Employees.TabIndex = 49;
            this.l_N_Employees.Text = "-";
            // 
            // b_Delete
            // 
            this.b_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Delete.Location = new System.Drawing.Point(226, 367);
            this.b_Delete.Name = "b_Delete";
            this.b_Delete.Size = new System.Drawing.Size(151, 25);
            this.b_Delete.TabIndex = 34;
            this.b_Delete.TabStop = false;
            this.b_Delete.Text = "Видалити обліковий запис";
            this.b_Delete.UseVisualStyleBackColor = true;
            this.b_Delete.Click += new System.EventHandler(this.b_Delete_Click);
            // 
            // openFileDialog_photo
            // 
            this.openFileDialog_photo.Filter = "Image Files (*.BMP; *.JPG; *.GIF; *.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            // 
            // b_Accept
            // 
            this.b_Accept.Enabled = false;
            this.b_Accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Accept.Location = new System.Drawing.Point(637, 367);
            this.b_Accept.Name = "b_Accept";
            this.b_Accept.Size = new System.Drawing.Size(84, 25);
            this.b_Accept.TabIndex = 50;
            this.b_Accept.TabStop = false;
            this.b_Accept.Text = "Прийняти";
            this.b_Accept.UseVisualStyleBackColor = true;
            this.b_Accept.Click += new System.EventHandler(this.b_Accept_Click);
            // 
            // EmployeesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 406);
            this.Controls.Add(this.b_Accept);
            this.Controls.Add(this.l_N_Employees);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.gb_6);
            this.Controls.Add(this.gb_3);
            this.Controls.Add(this.gb_5);
            this.Controls.Add(this.gb_4);
            this.Controls.Add(this.b_Delete);
            this.Controls.Add(this.b_OK);
            this.Controls.Add(this.b_Back);
            this.Controls.Add(this.gb_2);
            this.Controls.Add(this.gb_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeesManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Менеджер облікових записів працівників";
            this.Shown += new System.EventHandler(this.EmployeesManager_Shown);
            this.gb_1.ResumeLayout(false);
            this.gb_1.PerformLayout();
            this.gb_2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pB_user)).EndInit();
            this.gb_4.ResumeLayout(false);
            this.gb_4.PerformLayout();
            this.gb_5.ResumeLayout(false);
            this.gb_5.PerformLayout();
            this.gb_3.ResumeLayout(false);
            this.gb_3.PerformLayout();
            this.gb_6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_1;
        private System.Windows.Forms.ComboBox cb_Employee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_RegNumber;
        private System.Windows.Forms.GroupBox gb_2;
        private System.Windows.Forms.PictureBox pB_user;
        private System.Windows.Forms.Button b_OK;
        private System.Windows.Forms.Button b_Back;
        private System.Windows.Forms.GroupBox gb_4;
        private System.Windows.Forms.RichTextBox rtb_Residence;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_PassportNumber;
        private System.Windows.Forms.TextBox tb_PassportSeries;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtb_ActualResidence;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtb_AboutPassport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button b_Set_PIB;
        private System.Windows.Forms.GroupBox gb_5;
        private System.Windows.Forms.RichTextBox rtb_AboutManWoman;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtb_AboutParents;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rtb_AboutChildren;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gb_3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l_Age;
        private System.Windows.Forms.TextBox tb_BirthDay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ITN;
        private System.Windows.Forms.RichTextBox rtb_Education;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.GroupBox gb_6;
        private System.Windows.Forms.RichTextBox rtb_Conviction;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label l_N_Employees;
        private System.Windows.Forms.Button b_Delete;
        private System.Windows.Forms.OpenFileDialog openFileDialog_photo;
        private System.Windows.Forms.Button b_Accept;
    }
}