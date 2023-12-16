namespace hrdApp
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_DB_fullpath = new System.Windows.Forms.TextBox();
            this.b_Open_DB = new System.Windows.Forms.Button();
            this.b_Add_DB = new System.Windows.Forms.Button();
            this.label_DB = new System.Windows.Forms.Label();
            this.tb_DB_path = new System.Windows.Forms.TextBox();
            this.b_OK = new System.Windows.Forms.Button();
            this.b_Back = new System.Windows.Forms.Button();
            this.openFileDialog_DB = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog_DB = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_DB_fullpath);
            this.groupBox1.Controls.Add(this.b_Open_DB);
            this.groupBox1.Controls.Add(this.b_Add_DB);
            this.groupBox1.Controls.Add(this.label_DB);
            this.groupBox1.Controls.Add(this.tb_DB_path);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "База даних";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Повний шлях до файлу бази даних:";
            // 
            // tb_DB_fullpath
            // 
            this.tb_DB_fullpath.Location = new System.Drawing.Point(6, 76);
            this.tb_DB_fullpath.Name = "tb_DB_fullpath";
            this.tb_DB_fullpath.Size = new System.Drawing.Size(234, 20);
            this.tb_DB_fullpath.TabIndex = 10;
            // 
            // b_Open_DB
            // 
            this.b_Open_DB.BackColor = System.Drawing.SystemColors.Control;
            this.b_Open_DB.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.b_Open_DB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Open_DB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_Open_DB.Image = ((System.Drawing.Image)(resources.GetObject("b_Open_DB.Image")));
            this.b_Open_DB.Location = new System.Drawing.Point(275, 36);
            this.b_Open_DB.Name = "b_Open_DB";
            this.b_Open_DB.Size = new System.Drawing.Size(23, 23);
            this.b_Open_DB.TabIndex = 5;
            this.b_Open_DB.UseVisualStyleBackColor = false;
            this.b_Open_DB.Click += new System.EventHandler(this.b_Open_DB_Click);
            this.b_Open_DB.MouseHover += new System.EventHandler(this.b_Open_DB_MouseHover);
            // 
            // b_Add_DB
            // 
            this.b_Add_DB.BackColor = System.Drawing.SystemColors.Control;
            this.b_Add_DB.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.b_Add_DB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Add_DB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_Add_DB.Image = ((System.Drawing.Image)(resources.GetObject("b_Add_DB.Image")));
            this.b_Add_DB.Location = new System.Drawing.Point(246, 36);
            this.b_Add_DB.Name = "b_Add_DB";
            this.b_Add_DB.Size = new System.Drawing.Size(23, 23);
            this.b_Add_DB.TabIndex = 4;
            this.b_Add_DB.UseVisualStyleBackColor = false;
            this.b_Add_DB.Click += new System.EventHandler(this.b_Add_DB_Click);
            this.b_Add_DB.MouseHover += new System.EventHandler(this.b_Add_DB_MouseHover);
            // 
            // label_DB
            // 
            this.label_DB.AutoSize = true;
            this.label_DB.Location = new System.Drawing.Point(6, 22);
            this.label_DB.Name = "label_DB";
            this.label_DB.Size = new System.Drawing.Size(197, 13);
            this.label_DB.TabIndex = 9;
            this.label_DB.Text = "Відносний шлях до файлу бази даних:";
            // 
            // tb_DB_path
            // 
            this.tb_DB_path.Location = new System.Drawing.Point(6, 38);
            this.tb_DB_path.Name = "tb_DB_path";
            this.tb_DB_path.Size = new System.Drawing.Size(234, 20);
            this.tb_DB_path.TabIndex = 3;
            // 
            // b_OK
            // 
            this.b_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_OK.Location = new System.Drawing.Point(143, 134);
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
            this.b_Back.Location = new System.Drawing.Point(233, 134);
            this.b_Back.Name = "b_Back";
            this.b_Back.Size = new System.Drawing.Size(84, 25);
            this.b_Back.TabIndex = 1;
            this.b_Back.Text = "Скасувати";
            this.b_Back.UseVisualStyleBackColor = true;
            this.b_Back.Click += new System.EventHandler(this.b_Back_Click);
            this.b_Back.KeyDown += new System.Windows.Forms.KeyEventHandler(this.b_Back_KeyDown);
            // 
            // openFileDialog_DB
            // 
            this.openFileDialog_DB.DefaultExt = "*.db";
            this.openFileDialog_DB.FileName = "openFileDialog_DB";
            this.openFileDialog_DB.Filter = "hrdApp database Files (*.db)|*.db";
            // 
            // saveFileDialog_DB
            // 
            this.saveFileDialog_DB.DefaultExt = "*.db";
            this.saveFileDialog_DB.Filter = "hrdApp database Files (*.db)|*.db";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(330, 171);
            this.Controls.Add(this.b_OK);
            this.Controls.Add(this.b_Back);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Налаштування";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.Shown += new System.EventHandler(this.SettingsForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_DB;
        private System.Windows.Forms.TextBox tb_DB_path;
        private System.Windows.Forms.Button b_OK;
        private System.Windows.Forms.Button b_Back;
        private System.Windows.Forms.Button b_Add_DB;
        private System.Windows.Forms.Button b_Open_DB;
        private System.Windows.Forms.OpenFileDialog openFileDialog_DB;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_DB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_DB_fullpath;
    }
}