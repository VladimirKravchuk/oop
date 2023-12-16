using System;
using System.Drawing;
using System.IO;
using System.Globalization;
using System.Windows.Forms;

namespace hrdApp
{
    public partial class EmployeesManager : Form
    {
        public static int number_of_employee;
        public static string img_path_photo;

        public static Boolean isNewData;

        public static string RegNumber_DB;
        public static string LastName_DB;
        public static string FirstName_DB;
        public static string Surname_DB;
        public static string PassportSeries_DB;
        public static string PassportNumber_DB;
        public static string AboutPassport_DB;
        public static string ITN_DB;
        public static string BirthDay_DB;
        public static string Residence_DB;
        public static string ActualResidence_DB;
        public static string Phone_DB;
        public static string Education_DB;
        public static string AboutManWoman_DB;
        public static string AboutParents_DB;
        public static string AboutChildren_DB;
        public static string Conviction_DB;
        public static string photo_path_DB;

        public static string PassportSeries_old;
        public static string PassportNumber_old;
        public static string AboutPassport_old;
        public static string ITN_old;
        public static string BirthDay_old;
        public static string Residence_old;
        public static string ActualResidence_old;
        public static string Phone_old;
        public static string Education_old;
        public static string AboutManWoman_old;
        public static string AboutParents_old;
        public static string AboutChildren_old;
        public static string Conviction_old;
        public static string photo_path_old;

        public static int cnt_of_change;

        ChangePIB cpf;

        public EmployeesManager()
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

        private void EmployeesManager_Shown(object sender, EventArgs e)
        {
            MainForm.UpdateCountEmployee_from_DB();
            UpdateEmployees();
            ReloadData();

            cnt_of_change = 0;

            PassportSeries_old = tb_PassportSeries.Text;
            PassportNumber_old = tb_PassportNumber.Text;
            AboutPassport_old = rtb_AboutPassport.Text;
            ITN_old = tb_ITN.Text;
            BirthDay_old = tb_BirthDay.Text;
            Residence_old = rtb_Residence.Text;
            ActualResidence_old = rtb_ActualResidence.Text;
            Phone_old = tb_Phone.Text;
            Education_old = rtb_Education.Text;
            AboutManWoman_old = rtb_AboutManWoman.Text;
            AboutParents_old = rtb_AboutParents.Text;
            AboutChildren_old = rtb_AboutChildren.Text;
            Conviction_old = rtb_Conviction.Text;
            photo_path_old = img_path_photo;
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
            l_N_Employees.Text = MainForm.N_Employees.ToString();

            // відновлення обробників переривань для cb_Employee
            this.cb_Employee.TextChanged += new System.EventHandler(this.cb_Employee_TextChanged);
            this.cb_Employee.SelectedIndexChanged += new System.EventHandler(this.cb_Employee_SelectedIndexChanged);
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

        private void ReloadData()
        {
            // тимчасова зупинка обробників переривань
            this.cb_Employee.TextChanged -= new System.EventHandler(this.cb_Employee_TextChanged);
            this.tb_PassportSeries.TextChanged -= new System.EventHandler(this.tb_PassportSeries_TextChanged);
            this.tb_PassportNumber.TextChanged -= new System.EventHandler(this.tb_PassportNumber_TextChanged);
            this.rtb_AboutPassport.TextChanged -= new System.EventHandler(this.rtb_AboutPassport_TextChanged);
            this.tb_ITN.TextChanged -= new System.EventHandler(this.tb_ITN_TextChanged);
            this.tb_BirthDay.TextChanged -= new System.EventHandler(this.tb_BirthDay_TextChanged);
            this.rtb_Residence.TextChanged -= new System.EventHandler(this.rtb_Residence_TextChanged);
            this.rtb_ActualResidence.TextChanged -= new System.EventHandler(this.rtb_ActualResidence_TextChanged);
            this.tb_Phone.TextChanged -= new System.EventHandler(this.tb_Phone_TextChanged);
            this.rtb_Education.TextChanged -= new System.EventHandler(this.tb_Education_TextChanged);
            this.rtb_AboutManWoman.TextChanged -= new System.EventHandler(this.rtb_AboutManWoman_TextChanged);
            this.rtb_AboutParents.TextChanged -= new System.EventHandler(this.rtb_AboutParents_TextChanged);
            this.rtb_AboutChildren.TextChanged -= new System.EventHandler(this.rtb_AboutChildren_TextChanged);
            this.rtb_Conviction.TextChanged -= new System.EventHandler(this.rtb_Conviction_TextChanged);
            //////////////////////////////////////////////////////////////////////////////////////////////////

            if (MainForm.N_Employees > 0)
            {
                MainForm.UpdateEmployeeData_from_DB(tb_RegNumber.Text);
                //
                tb_PassportSeries.Text = MainForm.PassportSeries;
                tb_PassportNumber.Text = MainForm.PassportNumber;
                rtb_AboutPassport.Text = MainForm.AboutPassport;
                tb_ITN.Text = MainForm.ITN;
                tb_BirthDay.Text = MainForm.ExtractDateTime_from_DB(MainForm.BirthDay);
                rtb_Residence.Text = MainForm.Residence;
                rtb_ActualResidence.Text = MainForm.ActualResidence;
                tb_Phone.Text = MainForm.Phone;
                rtb_Education.Text = MainForm.Education;
                rtb_AboutManWoman.Text = MainForm.AboutManWoman;
                rtb_AboutParents.Text = MainForm.AboutParents;
                rtb_AboutChildren.Text = MainForm.AboutChildren;
                rtb_Conviction.Text = MainForm.Conviction;
                //
                img_path_photo = Path.Combine(Directory.GetCurrentDirectory(), MainForm.photo_path);
                pB_user.Image = Image.FromFile(img_path_photo);

                if (tb_BirthDay.Text != "")
                    l_Age.Text = MainForm.GetAgeYears(tb_BirthDay.Text);
                else
                    l_Age.Text = "-";
            }
            else
            {
                cb_Employee.Text = null;
                tb_RegNumber.Text = null;
                tb_PassportSeries.Text = null;
                tb_PassportNumber.Text = null;
                rtb_AboutPassport.Text = null;
                tb_ITN.Text = null;
                tb_BirthDay.Text = null;
                rtb_Residence.Text = null;
                rtb_ActualResidence.Text = null;
                tb_Phone.Text = null;
                rtb_Education.Text = null;
                rtb_AboutManWoman.Text = null;
                rtb_AboutParents.Text = null;
                rtb_AboutChildren.Text = null;
                rtb_Conviction.Text = null;
                l_Age.Text = "-";
                pB_user.Image = null;
            }

            // відновлення обробників переривань
            this.cb_Employee.TextChanged += new System.EventHandler(this.cb_Employee_TextChanged);
            this.tb_PassportSeries.TextChanged += new System.EventHandler(this.tb_PassportSeries_TextChanged);
            this.tb_PassportNumber.TextChanged += new System.EventHandler(this.tb_PassportNumber_TextChanged);
            this.rtb_AboutPassport.TextChanged += new System.EventHandler(this.rtb_AboutPassport_TextChanged);
            this.tb_ITN.TextChanged += new System.EventHandler(this.tb_ITN_TextChanged);
            this.tb_BirthDay.TextChanged += new System.EventHandler(this.tb_BirthDay_TextChanged);
            this.rtb_Residence.TextChanged += new System.EventHandler(this.rtb_Residence_TextChanged);
            this.rtb_ActualResidence.TextChanged += new System.EventHandler(this.rtb_ActualResidence_TextChanged);
            this.tb_Phone.TextChanged += new System.EventHandler(this.tb_Phone_TextChanged);
            this.rtb_Education.TextChanged += new System.EventHandler(this.tb_Education_TextChanged);
            this.rtb_AboutManWoman.TextChanged += new System.EventHandler(this.rtb_AboutManWoman_TextChanged);
            this.rtb_AboutParents.TextChanged += new System.EventHandler(this.rtb_AboutParents_TextChanged);
            this.rtb_AboutChildren.TextChanged += new System.EventHandler(this.rtb_AboutChildren_TextChanged);
            this.rtb_Conviction.TextChanged += new System.EventHandler(this.rtb_Conviction_TextChanged);
            ///////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void cb_Employee_TextChanged(object sender, EventArgs e)
        {
        }

        private void b_Set_PIB_Click(object sender, EventArgs e)
        {
            if (MainForm.N_Employees > 0)
            {
                cpf = new ChangePIB();
                cpf.ShowDialog();
                MainForm.UpdateCountEmployee_from_DB();
                UpdateEmployees();
            }
        }

        private void b_Delete_Click(object sender, EventArgs e)
        {
            if (MainForm.N_Employees > 0)
            {
                if (MessageBox.Show("Ви дійсно бажаєте видалити обліковий запис працівника? \r\n" +
                                    "Дану операцію скасувати буде неможливо.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    MainForm.DeleteEmployee_from_DB(MainForm.Employee_RegNumber[number_of_employee]);
                    MainForm.UpdateCountEmployee_from_DB();
                    UpdateEmployees();
                    ReloadData();
                }
            }
            else
            {
                MessageBox.Show("База даних пуста. Видалення неможливе.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tb_BirthDay_TextChanged(object sender, EventArgs e)
        {
            if (tb_BirthDay.Text != BirthDay_old)
            {
                cnt_of_change++;
                b_Accept.Enabled = true;
            }
        }

        private void tb_Phone_TextChanged(object sender, EventArgs e)
        {
            if (tb_Phone.Text != Phone_old)
            {
                cnt_of_change++;
                b_Accept.Enabled = true;
            }
        }

        private void tb_ITN_TextChanged(object sender, EventArgs e)
        {
            if (tb_ITN.Text != ITN_old)
            {
                cnt_of_change++;
                b_Accept.Enabled = true;
            }
        }

        private void tb_Education_TextChanged(object sender, EventArgs e)
        {
            if (rtb_Education.Text != Education_old)
            {
                cnt_of_change++;
                b_Accept.Enabled = true;
            }
        }

        private void tb_PassportSeries_TextChanged(object sender, EventArgs e)
        {
            if (tb_PassportSeries.Text != PassportSeries_old)
            {
                cnt_of_change++;
                b_Accept.Enabled = true;
            }
        }

        private void tb_PassportNumber_TextChanged(object sender, EventArgs e)
        {
            if (tb_PassportNumber.Text != PassportNumber_old)
            {
                cnt_of_change++;
                b_Accept.Enabled = true;
            }
        }

        private void rtb_AboutPassport_TextChanged(object sender, EventArgs e)
        {
            if (rtb_AboutPassport.Text != AboutPassport_old)
            {
                cnt_of_change++;
                b_Accept.Enabled = true;
            }
        }

        private void rtb_Residence_TextChanged(object sender, EventArgs e)
        {
            if (rtb_Residence.Text != Residence_old)
            {
                cnt_of_change++;
                b_Accept.Enabled = true;
            }
        }

        private void rtb_ActualResidence_TextChanged(object sender, EventArgs e)
        {
            if (rtb_ActualResidence.Text != ActualResidence_old)
            {
                cnt_of_change++;
                b_Accept.Enabled = true;
            }
        }

        private void rtb_AboutManWoman_TextChanged(object sender, EventArgs e)
        {
            if (rtb_AboutManWoman.Text != AboutManWoman_old)
            {
                cnt_of_change++;
                b_Accept.Enabled = true;
            }
        }

        private void rtb_AboutParents_TextChanged(object sender, EventArgs e)
        {
            if (rtb_AboutParents.Text != AboutParents_old)
            {
                cnt_of_change++;
                b_Accept.Enabled = true;
            }
        }

        private void rtb_AboutChildren_TextChanged(object sender, EventArgs e)
        {
            if (rtb_AboutChildren.Text != AboutChildren_old)
            {
                cnt_of_change++;
                b_Accept.Enabled = true;
            }
        }

        private void rtb_Conviction_TextChanged(object sender, EventArgs e)
        {
            if (rtb_Conviction.Text != Conviction_old)
            {
                cnt_of_change++;
                b_Accept.Enabled = true;
            }   
        }

        private void pB_user_Click(object sender, EventArgs e)
        {
            openFileDialog_photo.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), MainForm.img_photo_path_def);
            openFileDialog_photo.FileName = null;
            if (openFileDialog_photo.ShowDialog() == DialogResult.OK)
            {
                img_path_photo = openFileDialog_photo.FileName;
                pB_user.Image = Image.FromFile(img_path_photo);

                if (img_path_photo != photo_path_old)
                {
                    cnt_of_change++;
                    b_Accept.Enabled = true;
                }
            }
        }

        private void StartUpdateEmployeeData()
        {
            if (NewEmployeeForm.ConvertFilePath(img_path_photo, MainForm.img_photo_path_def) != "repeat" &&
                NewEmployeeForm.ConvertFilePath(img_path_photo, MainForm.img_photo_path_usr) != "repeat" &&
                img_path_photo != MainForm.img_path_photo_def)
            {
                if (NewEmployeeForm.ConvertFilePath(img_path_photo, MainForm.img_photo_path_def) != null)
                    img_path_photo = NewEmployeeForm.ConvertFilePath(img_path_photo, MainForm.img_photo_path_def);
                else if (NewEmployeeForm.ConvertFilePath(img_path_photo, MainForm.img_photo_path_usr) != null)
                    img_path_photo = NewEmployeeForm.ConvertFilePath(img_path_photo, MainForm.img_photo_path_usr);
                else
                    img_path_photo = NewEmployeeForm.CopyAndConvertFilePath(img_path_photo, MainForm.img_photo_path_usr);
            }

            RegNumber_DB = tb_RegNumber.Text;
            PassportSeries_DB = tb_PassportSeries.Text;
            PassportNumber_DB = tb_PassportNumber.Text;
            AboutPassport_DB = rtb_AboutPassport.Text;
            ITN_DB = tb_ITN.Text;
            Residence_DB = rtb_Residence.Text;
            ActualResidence_DB = rtb_ActualResidence.Text;
            Phone_DB = tb_Phone.Text;
            Education_DB = rtb_Education.Text;
            AboutManWoman_DB = rtb_AboutManWoman.Text;
            AboutParents_DB = rtb_AboutParents.Text;
            AboutChildren_DB = rtb_AboutChildren.Text;
            Conviction_DB = rtb_Conviction.Text;
            photo_path_DB = img_path_photo;
            if (tb_BirthDay.Text != "")
            {
                BirthDay_DB = DateTime.ParseExact(tb_BirthDay.Text, MainForm.dateFormat, CultureInfo.InvariantCulture).ToShortDateString();
                if (tb_BirthDay.Text != "")
                    l_Age.Text = MainForm.GetAgeYears(tb_BirthDay.Text);
                else
                    l_Age.Text = "-";
            }      
            else
                BirthDay_DB = null;

            if (LastName_DB != "" && FirstName_DB != "")
                isNewData = true;
            else
                MessageBox.Show("Не заповнені обов'язкові поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            if (cnt_of_change > 0 && MainForm.N_Employees > 0)
            {
                if (MessageBox.Show("Ви підтверджуєте внесення змін до облікового запису працівника?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    StartUpdateEmployeeData();
                    MainForm.UpdateEmployeeData();
                }
            }
            Close();
        }

        private void b_Accept_Click(object sender, EventArgs e)
        {
            if (cnt_of_change > 0 && MainForm.N_Employees > 0)
            {
                if (MessageBox.Show("Ви підтверджуєте внесення змін до облікового запису працівника?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    StartUpdateEmployeeData();
                    MainForm.UpdateEmployeeData();
                    cnt_of_change = 0;
                    b_Accept.Enabled = false;
                }
            }
        }

        private void tb_BirthDay_Enter(object sender, EventArgs e)
        {
            if (tb_BirthDay.Text == "")
                tb_BirthDay.Text = MainForm.dateFormat;
        }

        private void tb_Phone_Enter(object sender, EventArgs e)
        {
            if (tb_Phone.Text == "")
                tb_Phone.Text = "+380";
        }
    }
}
