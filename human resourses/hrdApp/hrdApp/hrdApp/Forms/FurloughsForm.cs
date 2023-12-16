using System;
using System.Globalization;
using System.Windows.Forms;

namespace hrdApp
{
    public partial class FurloughsForm : Form
    {

        public static int number_of_employee;
        public static int FurloughsDays;

        public static Boolean isNewData;

        public static string RegNumber_DB;
        public static string StartDate_DB;
        public static string CountDays_DB;
        public static string MainSlave_DB;

        public FurloughsForm()
        {
            InitializeComponent();
        }

        private void FurloughsForm_Shown(object sender, EventArgs e)
        {
            MainForm.UpdateCountEmployee_from_DB();
            UpdateEmployees();
            ReloadData();
            CalcFurloughsDays();

            isNewData = false;
        }

        private void CalcFurloughsDays()
        {
            string FD_str = dtp_EndDate.Value.Subtract(dtp_StartDate.Value).Add(TimeSpan.FromSeconds(1)).Days.ToString();
            FurloughsDays = Convert.ToInt32(FD_str) + 1;
            l_FurloughDays.Text = FurloughsDays.ToString();
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
                MainForm.UpdateFurloughs_from_DB(tb_RegNumber.Text);
                //
                if (MainForm.StartDate != "")
                    l_PlanFurloughStart.Text = DateTime.ParseExact(MainForm.StartDate, MainForm.dateFormat, CultureInfo.InvariantCulture).ToLongDateString();
                else
                    l_PlanFurloughStart.Text = "-";

                if (MainForm.CountDays != "")
                    l_PlanFurloughDays.Text = MainForm.CountDays;
                else
                    l_PlanFurloughDays.Text = "-";

                if (MainForm.MainSlave != "")
                {
                    if (MainForm.MainSlave == "1")
                        l_PlanFurloughType.Text = "основна";
                    else
                        l_PlanFurloughType.Text = "додаткова";
                }
                else
                    l_PlanFurloughType.Text = "-";
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

        private void StartRegNewFurlough()
        {
            RegNumber_DB = tb_RegNumber.Text;
            StartDate_DB = dtp_StartDate.Value.ToShortDateString();
            CountDays_DB = FurloughsDays.ToString();
            MainSlave_DB = Convert.ToInt32(cb_MainSlave.Checked).ToString();

            if (FurloughsDays > 0)
                isNewData = true;
            else
                MessageBox.Show("Некоректна тривалість відпустки!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cb_Employee_TextChanged(object sender, EventArgs e)
        {

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

        private void dtp_StartDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_EndDate.Value.CompareTo(dtp_StartDate.Value) < 0)
                dtp_EndDate.Value = dtp_StartDate.Value;

            CalcFurloughsDays();
        }

        private void dtp_EndDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_EndDate.Value.CompareTo(dtp_StartDate.Value) < 0)
                dtp_StartDate.Value = dtp_EndDate.Value;

            CalcFurloughsDays();
        }

        private void b_AddFurlough_Click(object sender, EventArgs e)
        {
            StartRegNewFurlough();
            MainForm.CreateNewFurlough();
            ReloadData();
        }

        private void b_DeleteFurlough_Click(object sender, EventArgs e)
        {
            if (MainForm.N_Employees > 0)
            {
                if (MessageBox.Show("Ви дійсно бажаєте видалити відпустку працівника? \r\n" +
                                    "Дану операцію скасувати буде неможливо.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    MainForm.DeleteFurlough_from_DB(MainForm.Employee_RegNumber[number_of_employee]);
                    UpdateEmployees();
                    ReloadData();
                }
            }
            else
            {
                MessageBox.Show("База даних пуста. Видалення неможливе.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void b_AddFurlough_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(b_AddFurlough, "Додати відпустку");
        }

        private void b_DeleteFurlough_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(b_DeleteFurlough, "Видалити відпустку");
        }
    }
}
