using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hrdApp
{
    public partial class PostForm : Form
    {

        private Boolean fst_change_Salary;
        private Boolean fst_change_WorkExperience;

        public static int number_of_employee;

        public static Boolean isNewData;

        public static string RegNumber_DB;
        public static string Post_DB;
        public static string Qualification_DB;
        public static string Salary_DB;
        public static string WorkExperience_DB;

        public PostForm()
        {
            InitializeComponent();
        }

        private void b_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_Back_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void PostForm_Shown(object sender, EventArgs e)
        {
            MainForm.UpdateCountEmployee_from_DB();
            UpdateEmployees();
            ReloadData();

            isNewData = false;

            fst_change_Salary = true;
            fst_change_WorkExperience = true;
        }

        private void UpdateEmployees()
        {
            // тимчасова зупинка обробників переривань для cb_Employee
            this.cb_Employee.TextChanged -= new System.EventHandler(this.cb_Employee_TextChanged);
            this.cb_Employee.SelectedIndexChanged -= new System.EventHandler(this.cb_Employee_SelectedIndexChanged);
            ///////////////////////////////////////////////////////////////////////////////////////////////

            if (MainForm.N_Employees > 0)
            {
                cb_Employee.Items.Clear();
                for (int i = 0; i < MainForm.N_Employees; i++)
                {
                    string name = MainForm.Employee_LastName[i] + " "
                                + MainForm.Employee_FirstName[i] + " "
                                + MainForm.Employee_Surname[i];
                    if (name != null)
                        cb_Employee.Items.Add(name);
                }

                cb_Employee.SelectedIndex = 0;
                number_of_employee = cb_Employee.SelectedIndex;
                tb_RegNumber.Text = MainForm.Employee_RegNumber[number_of_employee];
            }

            // відновлення обробників переривань для cb_Employee
            this.cb_Employee.TextChanged += new System.EventHandler(this.cb_Employee_TextChanged);
            this.cb_Employee.SelectedIndexChanged += new System.EventHandler(this.cb_Employee_SelectedIndexChanged);
            ///////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void ReloadData()
        {
            // тимчасова зупинка обробників переривань
            this.cb_Employee.TextChanged -= new System.EventHandler(this.cb_Employee_TextChanged);
            //////////////////////////////////////////////////////////////////////////////////////////////////

            if (MainForm.N_Employees > 0)
            {
                MainForm.UpdatePost_from_DB(tb_RegNumber.Text);
                //
                cb_Post.Text = MainForm.Post;
                cb_Qualification.Text = MainForm.Qualification;
                tb_Salary.Text = MainForm.Salary;
                tb_WorkExperience.Text = MainForm.WorkExperience;
            }
            else
            {
                cb_Employee.Text = null;
                tb_RegNumber.Text = null;
            }

            // відновлення обробників переривань
            this.cb_Employee.TextChanged += new System.EventHandler(this.cb_Employee_TextChanged);
            ///////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void cb_Employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Employee.SelectedIndex >= 0)
            {
                number_of_employee = cb_Employee.SelectedIndex;
                tb_RegNumber.Text = MainForm.Employee_RegNumber[number_of_employee];

                ReloadData();
            }
        }

        private void cb_Employee_TextChanged(object sender, EventArgs e)
        {
        }

        public static bool IsNumeric(object Expression)
        {
            double retNum;
            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }

        private void StartRegNewPost()
        {
            RegNumber_DB = tb_RegNumber.Text;
            Post_DB = cb_Post.Text;
            Qualification_DB = cb_Qualification.Text;
            Salary_DB = tb_Salary.Text;
            WorkExperience_DB = tb_WorkExperience.Text;

            if (cb_Post.Text != "" && cb_Qualification.Text != "" && IsNumeric(tb_Salary.Text) && IsNumeric(tb_WorkExperience.Text))
                isNewData = true;
            else
                MessageBox.Show("Потрібно заповнити всі поля штатного розпису!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void b_AddPost_Click(object sender, EventArgs e)
        {
            StartRegNewPost();
            MainForm.CreateNewPost();
            ReloadData();
            fst_change_Salary = true;
            fst_change_WorkExperience = true;
        }

        private void b_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_Close_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void tb_Salary_Enter(object sender, EventArgs e)
        {
            if (fst_change_Salary && tb_Salary.Text == "")
            {
                fst_change_Salary = false;
                tb_Salary.Text = "1000";
            }
        }

        private void tb_WorkExperience_Enter(object sender, EventArgs e)
        {
            if (fst_change_WorkExperience && tb_WorkExperience.Text == "")
            {
                fst_change_WorkExperience = false;
                tb_WorkExperience.Text = "0";
            }
        }

        private void b_DeleteFurlough_Click(object sender, EventArgs e)
        {
            if (MainForm.N_Employees > 0)
            {
                if (MessageBox.Show("Ви дійсно бажаєте звільнити працівника? \r\n" +
                                    "Дану операцію скасувати буде неможливо.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    MainForm.DeletePost_from_DB(MainForm.Employee_RegNumber[number_of_employee]);
                    UpdateEmployees();
                    ReloadData();
                    fst_change_Salary = true;
                    fst_change_WorkExperience = true;
                }
            }
            else
            {
                MessageBox.Show("База даних пуста. Звільнення неможливе.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void b_AddPost_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(b_AddPost, "Призначити працівника на вказану посаду");
        }

        private void b_DeleteFurlough_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(b_DeleteFurlough, "Звільнити працівника із вказаної посади");
        }
    }
}
