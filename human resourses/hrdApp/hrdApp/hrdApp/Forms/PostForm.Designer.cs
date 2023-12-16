namespace hrdApp
{
    partial class PostForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostForm));
            this.b_Close = new System.Windows.Forms.Button();
            this.gb_1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_RegNumber = new System.Windows.Forms.TextBox();
            this.cb_Employee = new System.Windows.Forms.ComboBox();
            this.gb_2 = new System.Windows.Forms.GroupBox();
            this.cb_Post = new System.Windows.Forms.ComboBox();
            this.cb_Qualification = new System.Windows.Forms.ComboBox();
            this.tb_WorkExperience = new System.Windows.Forms.TextBox();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.b_DeleteFurlough = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.b_AddPost = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gb_1.SuspendLayout();
            this.gb_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_Close
            // 
            this.b_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Close.Location = new System.Drawing.Point(238, 309);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(84, 25);
            this.b_Close.TabIndex = 1;
            this.b_Close.Text = "Закрити";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            this.b_Close.KeyDown += new System.Windows.Forms.KeyEventHandler(this.b_Close_KeyDown);
            // 
            // gb_1
            // 
            this.gb_1.BackColor = System.Drawing.Color.Linen;
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
            // gb_2
            // 
            this.gb_2.Controls.Add(this.cb_Post);
            this.gb_2.Controls.Add(this.cb_Qualification);
            this.gb_2.Controls.Add(this.tb_WorkExperience);
            this.gb_2.Controls.Add(this.tb_Salary);
            this.gb_2.Controls.Add(this.b_DeleteFurlough);
            this.gb_2.Controls.Add(this.label5);
            this.gb_2.Controls.Add(this.b_AddPost);
            this.gb_2.Controls.Add(this.label7);
            this.gb_2.Controls.Add(this.label6);
            this.gb_2.Controls.Add(this.label4);
            this.gb_2.Controls.Add(this.label3);
            this.gb_2.Controls.Add(this.label2);
            this.gb_2.Location = new System.Drawing.Point(12, 118);
            this.gb_2.Name = "gb_2";
            this.gb_2.Size = new System.Drawing.Size(310, 175);
            this.gb_2.TabIndex = 4;
            this.gb_2.TabStop = false;
            this.gb_2.Text = "Штатний розпис";
            // 
            // cb_Post
            // 
            this.cb_Post.FormattingEnabled = true;
            this.cb_Post.Items.AddRange(new object[] {
            "Директор",
            "Технічний директор",
            "Головний інженер",
            "Головний економіст",
            "Головний енергетик",
            "Головний бухгалтер",
            "Генеральний конструктор",
            "Бухгалтер",
            "Інженер",
            "Економіст",
            "Технолог ",
            "Технік-технолог",
            "Інженер-технолог",
            "Технік-конструктор",
            "Фахівець",
            "Механік",
            "Підсобний робітник"});
            this.cb_Post.Location = new System.Drawing.Point(93, 19);
            this.cb_Post.Name = "cb_Post";
            this.cb_Post.Size = new System.Drawing.Size(206, 21);
            this.cb_Post.TabIndex = 5;
            // 
            // cb_Qualification
            // 
            this.cb_Qualification.FormattingEnabled = true;
            this.cb_Qualification.Items.AddRange(new object[] {
            "Спеціаліст вищої кваліфікації",
            "Спеціаліст середньої кваліфікації",
            "Спеціаліст-практик",
            "Висококваліфікований робітник",
            "Кваліфікований робітник",
            "Малокваліфікований робітник ",
            "Некваліфікований робітник"});
            this.cb_Qualification.Location = new System.Drawing.Point(93, 46);
            this.cb_Qualification.Name = "cb_Qualification";
            this.cb_Qualification.Size = new System.Drawing.Size(206, 21);
            this.cb_Qualification.TabIndex = 6;
            // 
            // tb_WorkExperience
            // 
            this.tb_WorkExperience.Location = new System.Drawing.Point(93, 99);
            this.tb_WorkExperience.Name = "tb_WorkExperience";
            this.tb_WorkExperience.Size = new System.Drawing.Size(95, 20);
            this.tb_WorkExperience.TabIndex = 8;
            this.tb_WorkExperience.Enter += new System.EventHandler(this.tb_WorkExperience_Enter);
            // 
            // tb_Salary
            // 
            this.tb_Salary.Location = new System.Drawing.Point(93, 73);
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(95, 20);
            this.tb_Salary.TabIndex = 7;
            this.tb_Salary.Enter += new System.EventHandler(this.tb_Salary_Enter);
            // 
            // b_DeleteFurlough
            // 
            this.b_DeleteFurlough.BackColor = System.Drawing.SystemColors.Control;
            this.b_DeleteFurlough.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_DeleteFurlough.ForeColor = System.Drawing.Color.Red;
            this.b_DeleteFurlough.Location = new System.Drawing.Point(167, 140);
            this.b_DeleteFurlough.Name = "b_DeleteFurlough";
            this.b_DeleteFurlough.Size = new System.Drawing.Size(118, 22);
            this.b_DeleteFurlough.TabIndex = 10;
            this.b_DeleteFurlough.Text = "Звільнити";
            this.b_DeleteFurlough.UseVisualStyleBackColor = false;
            this.b_DeleteFurlough.Click += new System.EventHandler(this.b_DeleteFurlough_Click);
            this.b_DeleteFurlough.MouseHover += new System.EventHandler(this.b_DeleteFurlough_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Досвід роботи:";
            // 
            // b_AddPost
            // 
            this.b_AddPost.BackColor = System.Drawing.SystemColors.Control;
            this.b_AddPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_AddPost.ForeColor = System.Drawing.Color.Green;
            this.b_AddPost.Location = new System.Drawing.Point(25, 140);
            this.b_AddPost.Name = "b_AddPost";
            this.b_AddPost.Size = new System.Drawing.Size(118, 22);
            this.b_AddPost.TabIndex = 9;
            this.b_AddPost.Text = "Призначити";
            this.b_AddPost.UseVisualStyleBackColor = false;
            this.b_AddPost.Click += new System.EventHandler(this.b_AddPost_Click);
            this.b_AddPost.MouseHover += new System.EventHandler(this.b_AddPost_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "років";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "грн";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Оклад:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Кваліфікакція:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Назва посади:";
            // 
            // PostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 346);
            this.Controls.Add(this.gb_2);
            this.Controls.Add(this.gb_1);
            this.Controls.Add(this.b_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PostForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Посади";
            this.Shown += new System.EventHandler(this.PostForm_Shown);
            this.gb_1.ResumeLayout(false);
            this.gb_1.PerformLayout();
            this.gb_2.ResumeLayout(false);
            this.gb_2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.GroupBox gb_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_RegNumber;
        private System.Windows.Forms.ComboBox cb_Employee;
        private System.Windows.Forms.GroupBox gb_2;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.Button b_DeleteFurlough;
        private System.Windows.Forms.Button b_AddPost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Qualification;
        private System.Windows.Forms.ComboBox cb_Post;
        private System.Windows.Forms.TextBox tb_WorkExperience;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip;
    }
}