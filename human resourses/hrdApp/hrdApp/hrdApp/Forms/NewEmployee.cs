using System;
using System.Drawing;
using System.IO;
using System.Globalization;
using System.Windows.Forms;

namespace hrdApp
{
    public partial class NewEmployeeForm : Form
    {
        private Boolean fst_change_RegNumber;
        private Boolean fst_change_LastName;
        private Boolean fst_change_FirstName;
        private Boolean fst_change_Surname;
        private Boolean fst_change_PassportSeries;
        private Boolean fst_change_PassportNumber;
        private Boolean fst_change_AboutPassport;
        private Boolean fst_change_ITN;
        private Boolean fst_change_BirthDay;
        private Boolean fst_change_Residence;
        private Boolean fst_change_ActualResidence;
        private Boolean fst_change_Phone;
        private Boolean fst_change_Education;
        private Boolean fst_change_AboutManWoman;
        private Boolean fst_change_AboutParents;
        private Boolean fst_change_AboutChildren;
        private Boolean fst_change_Conviction;

        public static string img_path_photo = MainForm.img_photo_path_def;
        public static string img_no_photo = "no_photo";

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

        static SQL.SQLClass sql_ne = new SQL.SQLClass();

        public static int MaxNewEmployeesInDB = -1;


        public NewEmployeeForm()
        {
            InitializeComponent();
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            StartRegNewEmployee();
            MainForm.CreateNewEmployee();
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_Cancel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void tb_RegName_Enter(object sender, EventArgs e)
        {
            if (fst_change_RegNumber)
            {
                fst_change_RegNumber = false;
                tb_RegNumber.Text = null;
                tb_RegNumber.ForeColor = Color.Black;
            }
        }

        private void tb_LastName_Enter(object sender, EventArgs e)
        {
            if (fst_change_LastName)
            {
                fst_change_LastName = false;
                tb_LastName.Text = null;
                tb_LastName.ForeColor = Color.Black;
            }
        }

        private void tb_FirstName_Enter(object sender, EventArgs e)
        {
            if (fst_change_FirstName)
            {
                fst_change_FirstName = false;
                tb_FirstName.Text = null;
                tb_FirstName.ForeColor = Color.Black;
            }
        }

        private void tb_Surname_Enter(object sender, EventArgs e)
        {
            if (fst_change_Surname)
            {
                fst_change_Surname = false;
                tb_Surname.Text = null;
                tb_Surname.ForeColor = Color.Black;
            }
        }

        private void tb_PassportSeries_Enter(object sender, EventArgs e)
        {
            if (fst_change_PassportSeries)
            {
                fst_change_PassportSeries = false;
                tb_PassportSeries.Text = null;
                tb_PassportSeries.ForeColor = Color.Black;
            }
        }

        private void tb_PassportNumber_Enter(object sender, EventArgs e)
        {
            if (fst_change_PassportNumber)
            {
                fst_change_PassportNumber = false;
                tb_PassportNumber.Text = null;
                tb_PassportNumber.ForeColor = Color.Black;
            }
        }

        private void tb_ITN_Enter(object sender, EventArgs e)
        {
            if (fst_change_ITN)
            {
                fst_change_ITN = false;
                tb_ITN.Text = null;
                tb_ITN.ForeColor = Color.Black;
            }
        }

        private void tb_BirthDay_Enter(object sender, EventArgs e)
        {
            if (fst_change_BirthDay)
            {
                fst_change_BirthDay = false;
                tb_BirthDay.Text = MainForm.dateFormat;
                tb_BirthDay.ForeColor = Color.Black;
            }
        }

        private void rtb_Residence_Enter(object sender, EventArgs e)
        {
            if (fst_change_Residence)
            {
                fst_change_Residence = false;
                rtb_Residence.Text = null;
                rtb_Residence.ForeColor = Color.Black;
            }
        }

        private void tb_Phone_Enter(object sender, EventArgs e)
        {
            if (fst_change_Phone)
            {
                fst_change_Phone = false;
                tb_Phone.Text = "+380";
                tb_Phone.ForeColor = Color.Black;
            }
        }

        private void cb_Education_Enter(object sender, EventArgs e)
        {
            if (fst_change_Education)
            {
                fst_change_Education = false;
                cb_Education.Text = null;
                cb_Education.ForeColor = Color.Black;
            }
        }

        private void rtb_ActualResidence_Enter(object sender, EventArgs e)
        {
            if (fst_change_ActualResidence)
            {
                fst_change_ActualResidence = false;
                rtb_ActualResidence.Text = null;
                rtb_ActualResidence.ForeColor = Color.Black;
            }
        }


        private void rtb_AboutManWoman_Enter(object sender, EventArgs e)
        {
            if (fst_change_AboutManWoman)
            {
                fst_change_AboutManWoman = false;
                rtb_AboutManWoman.Text = "";
                rtb_AboutManWoman.ForeColor = Color.Black;
            }
        }

        private void rtb_AboutParents_Enter(object sender, EventArgs e)
        {
            if (fst_change_AboutParents)
            {
                fst_change_AboutParents = false;
                rtb_AboutParents.Text = "";
                rtb_AboutParents.ForeColor = Color.Black;
            }
        }

        private void rtb_AboutChildren_Enter(object sender, EventArgs e)
        {
            if (fst_change_AboutChildren)
            {
                fst_change_AboutChildren = false;
                rtb_AboutChildren.Text = "";
                rtb_AboutChildren.ForeColor = Color.Black;
            }
        }

        private void rtb_Conviction_Enter(object sender, EventArgs e)
        {
            if (fst_change_Conviction)
            {
                fst_change_Conviction = false;
                rtb_Conviction.Text = "";
                rtb_Conviction.ForeColor = Color.Black;
            }
        }

        private void rtb_AboutPassport_Enter(object sender, EventArgs e)
        {
            if (fst_change_AboutPassport)
            {
                fst_change_AboutPassport = false;
                rtb_AboutPassport.Text = null;
                rtb_AboutPassport.ForeColor = Color.Black;
            }
        }

        private void rtb_Residence_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(rtb_Residence, "Місце проживання за паспортом");
        }

        private void tb_RegName_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(tb_RegNumber, "Табельний номер працівника");
        }

        private void tb_LastName_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(tb_LastName, "Прізвище працівника");
        }

        private void tb_FirstName_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(tb_FirstName, "Ім'я працівника");
        }

        private void tb_Surname_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(tb_Surname, "По батькові працівника");
        }

        private void tb_PassportSeries_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(tb_PassportSeries, "Серія паспорта");
        }

        private void tb_PassportNumber_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(tb_PassportNumber, "Номер паспорта");
        }
   
        private void rtb_AboutPassport_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(rtb_AboutPassport, "Ким та коли виданий паспорт");
        }

        private void tb_ITN_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(tb_ITN, "Індивідуальний Податковий Номер");
        }

        private void tb_BirthDay_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(tb_BirthDay, "Дата народження");
        }

        private void tb_Phone_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(tb_Phone, "Номер телефону");
        }

        private void pB_user_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pB_user, "Додати фото працівника");
        }

        private void rtb_ActualResidence_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(rtb_ActualResidence, "Фактичне місце проживання");
        }

        private void cb_Education_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(cb_Education, "Дані про освіту працівника");
        }

        private void rtb_AboutManWoman_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(rtb_AboutManWoman, "Відомості про чоловіка/дружину");
        }

        private void rtb_AboutParents_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(rtb_AboutParents, "Відомості про батьків");
        }

        private void rtb_AboutChildren_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(rtb_AboutChildren, "Відомості про дітей");
        }

        private void rtb_Conviction_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(rtb_Conviction, "Відомості про наявність судимостей, відкритих кримінальних проваджень.");
        }

        private void pB_user_Click(object sender, EventArgs e)
        {
            openFileDialog_photo.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), MainForm.img_photo_path_def);
            openFileDialog_photo.FileName = null;
            if (openFileDialog_photo.ShowDialog() == DialogResult.OK)
            {
                img_path_photo = openFileDialog_photo.FileName;
                pB_user.Image = Image.FromFile(img_path_photo);
            }
        }

        public static string ConvertFilePath(string orig_path, string dir_name)
        {
            int seek_IndexOf = orig_path.IndexOf(dir_name);
            if (seek_IndexOf > 0)
                return orig_path.Substring(seek_IndexOf).Replace("\\", "/");
            else if (seek_IndexOf == 0)
                return "repeat";
            else
                return null;
        }

        public static string CopyAndConvertFilePath(string orig_path, string dir_name)
        {
            string new_path = Path.Combine(dir_name, Path.GetFileName(orig_path));
            try
            {
                File.Copy(orig_path, new_path, true);
            }
            catch
            {
                MessageBox.Show("Сталася помилка під час копіювання графічного файлу до папки з програмою.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new_path;
        }

        private void StartRegNewEmployee()
        {
            if (ConvertFilePath(img_path_photo, MainForm.img_photo_path_def) != "repeat" &&
                ConvertFilePath(img_path_photo, MainForm.img_photo_path_usr) != "repeat" &&
                img_path_photo != MainForm.img_path_photo_def)
            {
                if (ConvertFilePath(img_path_photo, MainForm.img_photo_path_def) != null)
                    img_path_photo = ConvertFilePath(img_path_photo, MainForm.img_photo_path_def);
                else if (ConvertFilePath(img_path_photo, MainForm.img_photo_path_usr) != null)
                    img_path_photo = ConvertFilePath(img_path_photo, MainForm.img_photo_path_usr);
                else
                    img_path_photo = CopyAndConvertFilePath(img_path_photo, MainForm.img_photo_path_usr);
            }

            RegNumber_DB = tb_RegNumber.Text;

            if (!fst_change_LastName) LastName_DB = tb_LastName.Text; else LastName_DB = null;
            if (!fst_change_FirstName) FirstName_DB = tb_FirstName.Text; else FirstName_DB = null;
            if (!fst_change_Surname) Surname_DB = tb_Surname.Text; else Surname_DB = null;
            if (!fst_change_PassportSeries) PassportSeries_DB = tb_PassportSeries.Text; else PassportSeries_DB = null;
            if (!fst_change_PassportNumber) PassportNumber_DB = tb_PassportNumber.Text; else PassportNumber_DB = null;
            if (!fst_change_AboutPassport) AboutPassport_DB = rtb_AboutPassport.Text; else AboutPassport_DB = null;
            if (!fst_change_ITN) ITN_DB = tb_ITN.Text; else ITN_DB = null;
            if (!fst_change_Residence) Residence_DB = rtb_Residence.Text; else Residence_DB = null;
            if (!fst_change_ActualResidence) ActualResidence_DB = rtb_ActualResidence.Text;  else ActualResidence_DB = null;
            if (!fst_change_Phone) Phone_DB = tb_Phone.Text; else Phone_DB = null;
            if (!fst_change_Education) Education_DB = cb_Education.Text; else  Education_DB = null;
            if (!fst_change_AboutManWoman) AboutManWoman_DB = rtb_AboutManWoman.Text; else AboutManWoman_DB = null;
            if (!fst_change_AboutParents) AboutParents_DB = rtb_AboutParents.Text; else AboutParents_DB = null;
            if (!fst_change_AboutChildren) AboutChildren_DB = rtb_AboutChildren.Text; else AboutChildren_DB = null;
            if (!fst_change_Conviction) Conviction_DB = rtb_Conviction.Text; else Conviction_DB = null;
            if (img_path_photo != MainForm.img_photo_path_def) photo_path_DB = img_path_photo; else  photo_path_DB = img_no_photo;
            if (!fst_change_BirthDay && tb_BirthDay.Text != "")
            {
                BirthDay_DB = DateTime.ParseExact(tb_BirthDay.Text, MainForm.dateFormat, CultureInfo.InvariantCulture).ToShortDateString();
            }
            else
                BirthDay_DB = null;

            if ( (!fst_change_LastName && LastName_DB != "") && (!fst_change_FirstName && FirstName_DB != "") )
            {
                isNewData = true;
                Close();
            }
            else
            {
                MessageBox.Show("Не заповнені обов'язкові поля!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NewEmployeeForm_Shown(object sender, EventArgs e)
        {
            fst_change_RegNumber = true;
            fst_change_LastName = true;
            fst_change_FirstName = true;
            fst_change_Surname = true;
            fst_change_PassportSeries = true;
            fst_change_PassportNumber = true;
            fst_change_AboutPassport = true;
            fst_change_ITN = true;
            fst_change_BirthDay = true;
            fst_change_Residence = true;
            fst_change_ActualResidence = true;
            fst_change_Phone = true;
            fst_change_Education = true;
            fst_change_AboutManWoman = true;
            fst_change_AboutParents = true;
            fst_change_AboutChildren = true;
            fst_change_Conviction = true;

            isNewData = false;

            img_path_photo = MainForm.img_path_photo_def;
            pB_user.Image = Image.FromFile(img_path_photo);

            sql_ne.conn_db_Update();

            if (!sql_ne.OpenDB())
                MessageBox.Show("Помилка відкривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MaxNewEmployeesInDB = sql_ne.GetMaxRegNumber();

                if (!sql_ne.CloseDB())
                    MessageBox.Show("Помилка закривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tb_RegNumber.Text = (MaxNewEmployeesInDB + 1).ToString("000");
        }
    }
}
