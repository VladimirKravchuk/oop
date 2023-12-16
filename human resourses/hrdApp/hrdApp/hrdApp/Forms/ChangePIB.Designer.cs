namespace hrdApp
{
    partial class ChangePIB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePIB));
            this.gB_2 = new System.Windows.Forms.GroupBox();
            this.tb_Surname = new System.Windows.Forms.TextBox();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.b_OK = new System.Windows.Forms.Button();
            this.b_Back = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gB_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gB_2
            // 
            this.gB_2.Controls.Add(this.tb_Surname);
            this.gB_2.Controls.Add(this.tb_LastName);
            this.gB_2.Controls.Add(this.tb_FirstName);
            this.gB_2.Location = new System.Drawing.Point(12, 12);
            this.gB_2.Name = "gB_2";
            this.gB_2.Size = new System.Drawing.Size(221, 109);
            this.gB_2.TabIndex = 2;
            this.gB_2.TabStop = false;
            this.gB_2.Text = "Прізвище, Ім\'я, По батькові";
            // 
            // tb_Surname
            // 
            this.tb_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_Surname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_Surname.Location = new System.Drawing.Point(6, 75);
            this.tb_Surname.MaxLength = 50;
            this.tb_Surname.Name = "tb_Surname";
            this.tb_Surname.Size = new System.Drawing.Size(207, 22);
            this.tb_Surname.TabIndex = 5;
            this.tb_Surname.TextChanged += new System.EventHandler(this.tb_Surname_TextChanged);
            this.tb_Surname.MouseHover += new System.EventHandler(this.tb_Surname_MouseHover);
            // 
            // tb_LastName
            // 
            this.tb_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_LastName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_LastName.Location = new System.Drawing.Point(6, 19);
            this.tb_LastName.MaxLength = 50;
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(207, 22);
            this.tb_LastName.TabIndex = 3;
            this.tb_LastName.TextChanged += new System.EventHandler(this.tb_LastName_TextChanged);
            this.tb_LastName.MouseHover += new System.EventHandler(this.tb_LastName_MouseHover);
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_FirstName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_FirstName.Location = new System.Drawing.Point(6, 47);
            this.tb_FirstName.MaxLength = 50;
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(207, 22);
            this.tb_FirstName.TabIndex = 4;
            this.tb_FirstName.TextChanged += new System.EventHandler(this.tb_FirstName_TextChanged);
            this.tb_FirstName.MouseHover += new System.EventHandler(this.tb_FirstName_MouseHover);
            // 
            // b_OK
            // 
            this.b_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_OK.Location = new System.Drawing.Point(59, 141);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(84, 25);
            this.b_OK.TabIndex = 6;
            this.b_OK.Text = "OK";
            this.b_OK.UseVisualStyleBackColor = true;
            this.b_OK.Click += new System.EventHandler(this.b_OK_Click);
            // 
            // b_Back
            // 
            this.b_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Back.Location = new System.Drawing.Point(149, 141);
            this.b_Back.Name = "b_Back";
            this.b_Back.Size = new System.Drawing.Size(84, 25);
            this.b_Back.TabIndex = 1;
            this.b_Back.Text = "Скасувати";
            this.b_Back.UseVisualStyleBackColor = true;
            this.b_Back.Click += new System.EventHandler(this.b_Back_Click);
            this.b_Back.KeyDown += new System.Windows.Forms.KeyEventHandler(this.b_Back_KeyDown);
            // 
            // ChangePIB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 178);
            this.Controls.Add(this.b_OK);
            this.Controls.Add(this.b_Back);
            this.Controls.Add(this.gB_2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePIB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Змінити ПІБ працівника";
            this.Shown += new System.EventHandler(this.ChangePIB_Shown);
            this.gB_2.ResumeLayout(false);
            this.gB_2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gB_2;
        private System.Windows.Forms.TextBox tb_Surname;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.Button b_OK;
        private System.Windows.Forms.Button b_Back;
        private System.Windows.Forms.ToolTip toolTip;
    }
}