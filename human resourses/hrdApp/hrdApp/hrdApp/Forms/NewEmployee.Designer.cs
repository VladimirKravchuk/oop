namespace hrdApp
{
    partial class NewEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEmployeeForm));
            this.b_Cancel = new System.Windows.Forms.Button();
            this.b_OK = new System.Windows.Forms.Button();
            this.gB_1 = new System.Windows.Forms.GroupBox();
            this.pB_user = new System.Windows.Forms.PictureBox();
            this.tb_RegNumber = new System.Windows.Forms.TextBox();
            this.label_p0 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog_photo = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.gB_2 = new System.Windows.Forms.GroupBox();
            this.tb_Surname = new System.Windows.Forms.TextBox();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.gB_3 = new System.Windows.Forms.GroupBox();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.gB_4 = new System.Windows.Forms.GroupBox();
            this.rtb_AboutPassport = new System.Windows.Forms.RichTextBox();
            this.tb_BirthDay = new System.Windows.Forms.TextBox();
            this.tb_PassportNumber = new System.Windows.Forms.TextBox();
            this.tb_PassportSeries = new System.Windows.Forms.TextBox();
            this.rtb_ActualResidence = new System.Windows.Forms.RichTextBox();
            this.rtb_Residence = new System.Windows.Forms.RichTextBox();
            this.gB_5 = new System.Windows.Forms.GroupBox();
            this.cb_Education = new System.Windows.Forms.ComboBox();
            this.gB_6 = new System.Windows.Forms.GroupBox();
            this.rtb_AboutChildren = new System.Windows.Forms.RichTextBox();
            this.rtb_AboutParents = new System.Windows.Forms.RichTextBox();
            this.rtb_AboutManWoman = new System.Windows.Forms.RichTextBox();
            this.gB_7 = new System.Windows.Forms.GroupBox();
            this.tb_ITN = new System.Windows.Forms.TextBox();
            this.gB_8 = new System.Windows.Forms.GroupBox();
            this.rtb_Conviction = new System.Windows.Forms.RichTextBox();
            this.gB_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_user)).BeginInit();
            this.gB_2.SuspendLayout();
            this.gB_3.SuspendLayout();
            this.gB_4.SuspendLayout();
            this.gB_5.SuspendLayout();
            this.gB_6.SuspendLayout();
            this.gB_7.SuspendLayout();
            this.gB_8.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_Cancel
            // 
            this.b_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Cancel.Location = new System.Drawing.Point(648, 434);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(84, 25);
            this.b_Cancel.TabIndex = 1;
            this.b_Cancel.Text = "Скасувати";
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            this.b_Cancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.b_Cancel_KeyDown);
            // 
            // b_OK
            // 
            this.b_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_OK.Location = new System.Drawing.Point(452, 434);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(188, 25);
            this.b_OK.TabIndex = 25;
            this.b_OK.Text = "Зберегти дані нового працівника";
            this.b_OK.UseVisualStyleBackColor = true;
            this.b_OK.Click += new System.EventHandler(this.b_OK_Click);
            // 
            // gB_1
            // 
            this.gB_1.BackColor = System.Drawing.SystemColors.Control;
            this.gB_1.Controls.Add(this.pB_user);
            this.gB_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gB_1.Location = new System.Drawing.Point(12, 12);
            this.gB_1.Name = "gB_1";
            this.gB_1.Size = new System.Drawing.Size(169, 229);
            this.gB_1.TabIndex = 19;
            this.gB_1.TabStop = false;
            this.gB_1.Text = "Фото працівника:";
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
            this.pB_user.MouseHover += new System.EventHandler(this.pB_user_MouseHover);
            // 
            // tb_RegNumber
            // 
            this.tb_RegNumber.Enabled = false;
            this.tb_RegNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_RegNumber.ForeColor = System.Drawing.Color.Gray;
            this.tb_RegNumber.Location = new System.Drawing.Point(312, 40);
            this.tb_RegNumber.MaxLength = 50;
            this.tb_RegNumber.Name = "tb_RegNumber";
            this.tb_RegNumber.Size = new System.Drawing.Size(96, 22);
            this.tb_RegNumber.TabIndex = 20;
            this.tb_RegNumber.TabStop = false;
            this.tb_RegNumber.Text = "0";
            this.tb_RegNumber.Enter += new System.EventHandler(this.tb_RegName_Enter);
            this.tb_RegNumber.MouseHover += new System.EventHandler(this.tb_RegName_MouseHover);
            // 
            // label_p0
            // 
            this.label_p0.AutoSize = true;
            this.label_p0.Location = new System.Drawing.Point(184, 16);
            this.label_p0.Name = "label_p0";
            this.label_p0.Size = new System.Drawing.Size(130, 13);
            this.label_p0.TabIndex = 23;
            this.label_p0.Text = "Дані нового працівника:";
            // 
            // openFileDialog_photo
            // 
            this.openFileDialog_photo.Filter = "Image Files (*.BMP; *.JPG; *.GIF; *.PNG)|*.BMP;*.JPG;*.GIF;*.PNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(184, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Табельний номер:";
            // 
            // gB_2
            // 
            this.gB_2.Controls.Add(this.tb_Surname);
            this.gB_2.Controls.Add(this.tb_LastName);
            this.gB_2.Controls.Add(this.tb_FirstName);
            this.gB_2.Location = new System.Drawing.Point(187, 72);
            this.gB_2.Name = "gB_2";
            this.gB_2.Size = new System.Drawing.Size(221, 109);
            this.gB_2.TabIndex = 2;
            this.gB_2.TabStop = false;
            this.gB_2.Text = "Прізвище, Ім\'я, По батькові";
            // 
            // tb_Surname
            // 
            this.tb_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Surname.ForeColor = System.Drawing.Color.Gray;
            this.tb_Surname.Location = new System.Drawing.Point(6, 75);
            this.tb_Surname.MaxLength = 50;
            this.tb_Surname.Name = "tb_Surname";
            this.tb_Surname.Size = new System.Drawing.Size(207, 22);
            this.tb_Surname.TabIndex = 5;
            this.tb_Surname.Text = "По батькові";
            this.tb_Surname.Enter += new System.EventHandler(this.tb_Surname_Enter);
            this.tb_Surname.MouseHover += new System.EventHandler(this.tb_Surname_MouseHover);
            // 
            // tb_LastName
            // 
            this.tb_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_LastName.ForeColor = System.Drawing.Color.Gray;
            this.tb_LastName.Location = new System.Drawing.Point(6, 19);
            this.tb_LastName.MaxLength = 50;
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(207, 22);
            this.tb_LastName.TabIndex = 3;
            this.tb_LastName.Text = "Прізвище (обов\'язкове поле)";
            this.tb_LastName.Enter += new System.EventHandler(this.tb_LastName_Enter);
            this.tb_LastName.MouseHover += new System.EventHandler(this.tb_LastName_MouseHover);
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_FirstName.ForeColor = System.Drawing.Color.Gray;
            this.tb_FirstName.Location = new System.Drawing.Point(6, 47);
            this.tb_FirstName.MaxLength = 50;
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(207, 22);
            this.tb_FirstName.TabIndex = 4;
            this.tb_FirstName.Text = "Ім\'я (обов\'язкове поле)";
            this.tb_FirstName.Enter += new System.EventHandler(this.tb_FirstName_Enter);
            this.tb_FirstName.MouseHover += new System.EventHandler(this.tb_FirstName_MouseHover);
            // 
            // gB_3
            // 
            this.gB_3.Controls.Add(this.tb_Phone);
            this.gB_3.Location = new System.Drawing.Point(187, 187);
            this.gB_3.Name = "gB_3";
            this.gB_3.Size = new System.Drawing.Size(221, 54);
            this.gB_3.TabIndex = 6;
            this.gB_3.TabStop = false;
            this.gB_3.Text = "Контактні дані";
            // 
            // tb_Phone
            // 
            this.tb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Phone.ForeColor = System.Drawing.Color.Gray;
            this.tb_Phone.Location = new System.Drawing.Point(6, 19);
            this.tb_Phone.MaxLength = 50;
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(207, 22);
            this.tb_Phone.TabIndex = 7;
            this.tb_Phone.Text = "Номер телефону";
            this.tb_Phone.Enter += new System.EventHandler(this.tb_Phone_Enter);
            this.tb_Phone.MouseHover += new System.EventHandler(this.tb_Phone_MouseHover);
            // 
            // gB_4
            // 
            this.gB_4.Controls.Add(this.rtb_AboutPassport);
            this.gB_4.Controls.Add(this.tb_BirthDay);
            this.gB_4.Controls.Add(this.tb_PassportNumber);
            this.gB_4.Controls.Add(this.tb_PassportSeries);
            this.gB_4.Controls.Add(this.rtb_ActualResidence);
            this.gB_4.Controls.Add(this.rtb_Residence);
            this.gB_4.Location = new System.Drawing.Point(414, 37);
            this.gB_4.Name = "gB_4";
            this.gB_4.Size = new System.Drawing.Size(318, 184);
            this.gB_4.TabIndex = 8;
            this.gB_4.TabStop = false;
            this.gB_4.Text = "Паспортні дані працівника";
            // 
            // rtb_AboutPassport
            // 
            this.rtb_AboutPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_AboutPassport.ForeColor = System.Drawing.Color.Gray;
            this.rtb_AboutPassport.Location = new System.Drawing.Point(8, 47);
            this.rtb_AboutPassport.Name = "rtb_AboutPassport";
            this.rtb_AboutPassport.Size = new System.Drawing.Size(301, 40);
            this.rtb_AboutPassport.TabIndex = 12;
            this.rtb_AboutPassport.Text = "Ким та коли виданий паспорт";
            this.rtb_AboutPassport.Enter += new System.EventHandler(this.rtb_AboutPassport_Enter);
            this.rtb_AboutPassport.MouseHover += new System.EventHandler(this.rtb_AboutPassport_MouseHover);
            // 
            // tb_BirthDay
            // 
            this.tb_BirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_BirthDay.ForeColor = System.Drawing.Color.Gray;
            this.tb_BirthDay.Location = new System.Drawing.Point(181, 19);
            this.tb_BirthDay.MaxLength = 50;
            this.tb_BirthDay.Name = "tb_BirthDay";
            this.tb_BirthDay.Size = new System.Drawing.Size(128, 22);
            this.tb_BirthDay.TabIndex = 11;
            this.tb_BirthDay.Text = "Дата народження";
            this.tb_BirthDay.Enter += new System.EventHandler(this.tb_BirthDay_Enter);
            this.tb_BirthDay.MouseHover += new System.EventHandler(this.tb_BirthDay_MouseHover);
            // 
            // tb_PassportNumber
            // 
            this.tb_PassportNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_PassportNumber.ForeColor = System.Drawing.Color.Gray;
            this.tb_PassportNumber.Location = new System.Drawing.Point(56, 19);
            this.tb_PassportNumber.MaxLength = 50;
            this.tb_PassportNumber.Name = "tb_PassportNumber";
            this.tb_PassportNumber.Size = new System.Drawing.Size(119, 22);
            this.tb_PassportNumber.TabIndex = 10;
            this.tb_PassportNumber.Text = "Номер паспорта";
            this.tb_PassportNumber.Enter += new System.EventHandler(this.tb_PassportNumber_Enter);
            this.tb_PassportNumber.MouseHover += new System.EventHandler(this.tb_PassportNumber_MouseHover);
            // 
            // tb_PassportSeries
            // 
            this.tb_PassportSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_PassportSeries.ForeColor = System.Drawing.Color.Gray;
            this.tb_PassportSeries.Location = new System.Drawing.Point(8, 19);
            this.tb_PassportSeries.MaxLength = 50;
            this.tb_PassportSeries.Name = "tb_PassportSeries";
            this.tb_PassportSeries.Size = new System.Drawing.Size(42, 22);
            this.tb_PassportSeries.TabIndex = 9;
            this.tb_PassportSeries.Text = "Серія";
            this.tb_PassportSeries.Enter += new System.EventHandler(this.tb_PassportSeries_Enter);
            this.tb_PassportSeries.MouseHover += new System.EventHandler(this.tb_PassportSeries_MouseHover);
            // 
            // rtb_ActualResidence
            // 
            this.rtb_ActualResidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_ActualResidence.ForeColor = System.Drawing.Color.Gray;
            this.rtb_ActualResidence.Location = new System.Drawing.Point(8, 139);
            this.rtb_ActualResidence.Name = "rtb_ActualResidence";
            this.rtb_ActualResidence.Size = new System.Drawing.Size(301, 40);
            this.rtb_ActualResidence.TabIndex = 14;
            this.rtb_ActualResidence.Text = "Фактичне місце проживання";
            this.rtb_ActualResidence.Enter += new System.EventHandler(this.rtb_ActualResidence_Enter);
            this.rtb_ActualResidence.MouseHover += new System.EventHandler(this.rtb_ActualResidence_MouseHover);
            // 
            // rtb_Residence
            // 
            this.rtb_Residence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_Residence.ForeColor = System.Drawing.Color.Gray;
            this.rtb_Residence.Location = new System.Drawing.Point(8, 93);
            this.rtb_Residence.Name = "rtb_Residence";
            this.rtb_Residence.Size = new System.Drawing.Size(301, 40);
            this.rtb_Residence.TabIndex = 13;
            this.rtb_Residence.Text = "Місце проживання за паспортом";
            this.rtb_Residence.Enter += new System.EventHandler(this.rtb_Residence_Enter);
            this.rtb_Residence.MouseHover += new System.EventHandler(this.rtb_Residence_MouseHover);
            // 
            // gB_5
            // 
            this.gB_5.Controls.Add(this.cb_Education);
            this.gB_5.Location = new System.Drawing.Point(414, 227);
            this.gB_5.Name = "gB_5";
            this.gB_5.Size = new System.Drawing.Size(318, 54);
            this.gB_5.TabIndex = 19;
            this.gB_5.TabStop = false;
            this.gB_5.Text = "Відомості про освіту";
            // 
            // cb_Education
            // 
            this.cb_Education.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Education.ForeColor = System.Drawing.Color.Gray;
            this.cb_Education.FormattingEnabled = true;
            this.cb_Education.Items.AddRange(new object[] {
            "Повна загальна середня освіта",
            "Професійно-технічна освіта",
            "Базова вища освіта",
            "Повна вища освіта"});
            this.cb_Education.Location = new System.Drawing.Point(8, 19);
            this.cb_Education.Name = "cb_Education";
            this.cb_Education.Size = new System.Drawing.Size(301, 24);
            this.cb_Education.TabIndex = 20;
            this.cb_Education.Text = "Освіта";
            this.cb_Education.Enter += new System.EventHandler(this.cb_Education_Enter);
            this.cb_Education.MouseHover += new System.EventHandler(this.cb_Education_MouseHover);
            // 
            // gB_6
            // 
            this.gB_6.Controls.Add(this.rtb_AboutChildren);
            this.gB_6.Controls.Add(this.rtb_AboutParents);
            this.gB_6.Controls.Add(this.rtb_AboutManWoman);
            this.gB_6.Location = new System.Drawing.Point(12, 251);
            this.gB_6.Name = "gB_6";
            this.gB_6.Size = new System.Drawing.Size(396, 209);
            this.gB_6.TabIndex = 15;
            this.gB_6.TabStop = false;
            this.gB_6.Text = "Відомості про сім\'ю";
            // 
            // rtb_AboutChildren
            // 
            this.rtb_AboutChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_AboutChildren.ForeColor = System.Drawing.Color.Gray;
            this.rtb_AboutChildren.Location = new System.Drawing.Point(10, 143);
            this.rtb_AboutChildren.Name = "rtb_AboutChildren";
            this.rtb_AboutChildren.Size = new System.Drawing.Size(378, 56);
            this.rtb_AboutChildren.TabIndex = 18;
            this.rtb_AboutChildren.Text = "Відомості про дітей";
            this.rtb_AboutChildren.Enter += new System.EventHandler(this.rtb_AboutChildren_Enter);
            this.rtb_AboutChildren.MouseHover += new System.EventHandler(this.rtb_AboutChildren_MouseHover);
            // 
            // rtb_AboutParents
            // 
            this.rtb_AboutParents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_AboutParents.ForeColor = System.Drawing.Color.Gray;
            this.rtb_AboutParents.Location = new System.Drawing.Point(10, 81);
            this.rtb_AboutParents.Name = "rtb_AboutParents";
            this.rtb_AboutParents.Size = new System.Drawing.Size(378, 56);
            this.rtb_AboutParents.TabIndex = 17;
            this.rtb_AboutParents.Text = "Відомості про батьків";
            this.rtb_AboutParents.Enter += new System.EventHandler(this.rtb_AboutParents_Enter);
            this.rtb_AboutParents.MouseHover += new System.EventHandler(this.rtb_AboutParents_MouseHover);
            // 
            // rtb_AboutManWoman
            // 
            this.rtb_AboutManWoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_AboutManWoman.ForeColor = System.Drawing.Color.Gray;
            this.rtb_AboutManWoman.Location = new System.Drawing.Point(10, 19);
            this.rtb_AboutManWoman.Name = "rtb_AboutManWoman";
            this.rtb_AboutManWoman.Size = new System.Drawing.Size(378, 56);
            this.rtb_AboutManWoman.TabIndex = 16;
            this.rtb_AboutManWoman.Text = "Відомості про чоловіка/дружину";
            this.rtb_AboutManWoman.Enter += new System.EventHandler(this.rtb_AboutManWoman_Enter);
            this.rtb_AboutManWoman.MouseHover += new System.EventHandler(this.rtb_AboutManWoman_MouseHover);
            // 
            // gB_7
            // 
            this.gB_7.Controls.Add(this.tb_ITN);
            this.gB_7.Location = new System.Drawing.Point(414, 287);
            this.gB_7.Name = "gB_7";
            this.gB_7.Size = new System.Drawing.Size(318, 54);
            this.gB_7.TabIndex = 21;
            this.gB_7.TabStop = false;
            this.gB_7.Text = "Індивідуальний податковий номер";
            // 
            // tb_ITN
            // 
            this.tb_ITN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ITN.ForeColor = System.Drawing.Color.Gray;
            this.tb_ITN.Location = new System.Drawing.Point(8, 21);
            this.tb_ITN.MaxLength = 50;
            this.tb_ITN.Name = "tb_ITN";
            this.tb_ITN.Size = new System.Drawing.Size(301, 22);
            this.tb_ITN.TabIndex = 22;
            this.tb_ITN.Text = "ІПН";
            this.tb_ITN.Enter += new System.EventHandler(this.tb_ITN_Enter);
            this.tb_ITN.MouseHover += new System.EventHandler(this.tb_ITN_MouseHover);
            // 
            // gB_8
            // 
            this.gB_8.Controls.Add(this.rtb_Conviction);
            this.gB_8.Location = new System.Drawing.Point(414, 347);
            this.gB_8.Name = "gB_8";
            this.gB_8.Size = new System.Drawing.Size(318, 81);
            this.gB_8.TabIndex = 23;
            this.gB_8.TabStop = false;
            this.gB_8.Text = "Відомості про судимості";
            // 
            // rtb_Conviction
            // 
            this.rtb_Conviction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_Conviction.ForeColor = System.Drawing.Color.Gray;
            this.rtb_Conviction.Location = new System.Drawing.Point(8, 21);
            this.rtb_Conviction.Name = "rtb_Conviction";
            this.rtb_Conviction.Size = new System.Drawing.Size(301, 50);
            this.rtb_Conviction.TabIndex = 24;
            this.rtb_Conviction.Text = "Відомості про наявність судимостей, відкритих кримінальних проваджень.";
            this.rtb_Conviction.Enter += new System.EventHandler(this.rtb_Conviction_Enter);
            this.rtb_Conviction.MouseHover += new System.EventHandler(this.rtb_Conviction_MouseHover);
            // 
            // NewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 471);
            this.Controls.Add(this.gB_8);
            this.Controls.Add(this.gB_7);
            this.Controls.Add(this.gB_6);
            this.Controls.Add(this.gB_5);
            this.Controls.Add(this.gB_3);
            this.Controls.Add(this.gB_4);
            this.Controls.Add(this.gB_2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_p0);
            this.Controls.Add(this.tb_RegNumber);
            this.Controls.Add(this.gB_1);
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.b_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Додавання нового працівника";
            this.Shown += new System.EventHandler(this.NewEmployeeForm_Shown);
            this.gB_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pB_user)).EndInit();
            this.gB_2.ResumeLayout(false);
            this.gB_2.PerformLayout();
            this.gB_3.ResumeLayout(false);
            this.gB_3.PerformLayout();
            this.gB_4.ResumeLayout(false);
            this.gB_4.PerformLayout();
            this.gB_5.ResumeLayout(false);
            this.gB_6.ResumeLayout(false);
            this.gB_7.ResumeLayout(false);
            this.gB_7.PerformLayout();
            this.gB_8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Cancel;
        private System.Windows.Forms.Button b_OK;
        private System.Windows.Forms.GroupBox gB_1;
        private System.Windows.Forms.PictureBox pB_user;
        private System.Windows.Forms.TextBox tb_RegNumber;
        private System.Windows.Forms.Label label_p0;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.OpenFileDialog openFileDialog_photo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gB_2;
        private System.Windows.Forms.TextBox tb_Surname;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.GroupBox gB_3;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.GroupBox gB_4;
        private System.Windows.Forms.TextBox tb_BirthDay;
        private System.Windows.Forms.TextBox tb_PassportNumber;
        private System.Windows.Forms.TextBox tb_PassportSeries;
        private System.Windows.Forms.RichTextBox rtb_ActualResidence;
        private System.Windows.Forms.RichTextBox rtb_Residence;
        private System.Windows.Forms.GroupBox gB_5;
        private System.Windows.Forms.ComboBox cb_Education;
        private System.Windows.Forms.GroupBox gB_6;
        private System.Windows.Forms.RichTextBox rtb_AboutChildren;
        private System.Windows.Forms.RichTextBox rtb_AboutParents;
        private System.Windows.Forms.RichTextBox rtb_AboutManWoman;
        private System.Windows.Forms.GroupBox gB_7;
        private System.Windows.Forms.TextBox tb_ITN;
        private System.Windows.Forms.GroupBox gB_8;
        private System.Windows.Forms.RichTextBox rtb_Conviction;
        private System.Windows.Forms.RichTextBox rtb_AboutPassport;
    }
}