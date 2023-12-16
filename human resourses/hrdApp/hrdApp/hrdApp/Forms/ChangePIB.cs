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
    public partial class ChangePIB : Form
    {
        public static string LastName_DB;
        public static string FirstName_DB;
        public static string Surname_DB;

        static string LastName_old;
        static string FirstName_old;
        static string Surname_old;

        public static int cnt_of_change;

        public ChangePIB()
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

        private void ChangePIB_Shown(object sender, EventArgs e)
        {
            tb_LastName.Text = MainForm.Employee_LastName[EmployeesManager.number_of_employee];
            tb_FirstName.Text = MainForm.Employee_FirstName[EmployeesManager.number_of_employee];
            tb_Surname.Text = MainForm.Employee_Surname[EmployeesManager.number_of_employee];

            LastName_old = tb_LastName.Text;
            FirstName_old = tb_FirstName.Text;
            Surname_old = tb_Surname.Text;

            cnt_of_change = 0;
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            if (cnt_of_change > 0)
            {
                if (tb_LastName.Text != "" && tb_FirstName.Text != "")
                {
                    LastName_DB = tb_LastName.Text;
                    FirstName_DB = tb_FirstName.Text;
                    Surname_DB = tb_Surname.Text;

                    MainForm.UpdatePIB_in_DB(MainForm.Employee_RegNumber[EmployeesManager.number_of_employee]);

                    Close();
                }
                else
                {
                    MessageBox.Show("Не заповнені обов'язкові поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                Close();
       }

        private void ChangePIB_Load(object sender, EventArgs e)
        {
        }

        private void tb_LastName_TextChanged(object sender, EventArgs e)
        {
            if (tb_LastName.Text != LastName_old)
                cnt_of_change++;
        }

        private void tb_FirstName_TextChanged(object sender, EventArgs e)
        {
            if (tb_FirstName.Text != FirstName_old)
                cnt_of_change++;
        }

        private void tb_Surname_TextChanged(object sender, EventArgs e)
        {
            if (tb_Surname.Text != Surname_old)
                cnt_of_change++;
        }

        private void tb_LastName_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(tb_LastName, "Прізвище працівника (обов'язкове поле)");
        }

        private void tb_FirstName_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(tb_FirstName, "Ім'я працівника (обов'язкове поле)");
        }

        private void tb_Surname_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(tb_Surname, "По батькові працівника");
        }
    }
}
