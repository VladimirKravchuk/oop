using System;
using System.Drawing;
using System.IO;
using System.Globalization;
using System.Reflection;
using System.Data.SQLite;
using System.Configuration;
using System.Windows.Forms;

namespace hrdApp
{
    public partial class MainForm : Form
    {
        ////////////////////////////////////////////////////////////////////////////////////
        //
        public static string db_folder_name = ConfigurationManager.AppSettings["db_folder_name"];
        public static string db_file_name = ConfigurationManager.AppSettings["db_file_name"];
        public static string db_file_name_def = ConfigurationManager.AppSettings["db_file_name_def"];
        public static string db_file_name_empty = ConfigurationManager.AppSettings["db_file_name_empty"];
        //
        public static string img_photo_path_def = ConfigurationManager.AppSettings["img_photo_path_def"];
        public static string img_photo_path_usr = ConfigurationManager.AppSettings["img_photo_path_usr"];
        public static string img_path_photo_def = ConfigurationManager.AppSettings["img_path_photo_def"];
        //
        public const int MaxEmployees = 100;
        //
        public const string dateFormat = "dd.MM.yyyy";
        //
        public static int MaxNewEmployeesInDB = -1;
        ////////////////////////////////////////////////////////////////////////////////////

        #region variables

        static SQL.SQLClass sql = new SQL.SQLClass();
        static SQL.EmployeeItems ei = new SQL.EmployeeItems();
        static SQL.FurloughItems fi = new SQL.FurloughItems();
        static SQL.PostItems pi = new SQL.PostItems();
        static SQLiteDataReader getSQL;

        NewEmployeeForm nef;
        SettingsForm sf;
        EmployeesManager em;
        FurloughsForm ff;
        PostForm pf;

        public static int N_Employees;
        public static int N_FiredEmployees;
        public static int N_EmployeesInPost;

        public static string[] Employee_RegNumber = new string[MaxEmployees];
        public static string[] Employee_LastName = new string[MaxEmployees];
        public static string[] Employee_FirstName = new string[MaxEmployees];
        public static string[] Employee_Surname = new string[MaxEmployees];
        // для таблиці employees
        public static string LastName;
        public static string FirstName;
        public static string Surname;
        public static string PassportSeries;
        public static string PassportNumber;
        public static string AboutPassport;
        public static string ITN;
        public static string BirthDay;
        public static string Residence;
        public static string ActualResidence;
        public static string Phone;
        public static string Education;
        public static string Conviction;
        public static string photo_path;
        // для таблиці family
        public static string AboutManWoman;
        public static string AboutParents;
        public static string AboutChildren;
        // для таблиці furlough
        public static string StartDate;
        public static string CountDays;
        public static string MainSlave;
        // для таблиці post
        public static string Post;
        public static string Qualification;
        public static string Salary;
        public static string WorkExperience;
        //
        public static string FindPost_0;
        public static string FindPost_1;
        public static string FindPost_2;

        #endregion


        private void FindData_in_DB()
        {
            rtb_ResultOfFind.Text = null;

            if (tb_Find.Text != "")
            {
                sql.conn_db_Update();

                if (!sql.OpenDB())
                    MessageBox.Show("Помилка відкривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    getSQL = sql.FindSelectData(tb_Find.Text);
                    int n = 1;
                    while (getSQL.Read())
                    {
                        int iRegNumber = Convert.ToInt32(getSQL["RegNumber"].ToString());
                        string RegNumber = iRegNumber.ToString("000");
                        rtb_ResultOfFind.Text = rtb_ResultOfFind.Text +
                                                n.ToString() + ". " +
                                                "----------------------------------------------" + "\r\n" +
                                                getSQL["LastName"].ToString() + " " +
                                                getSQL["FirstName"].ToString() + " " +
                                                getSQL["Surname"].ToString() + "\r\n" +
                                                "* Табельний номер: " + RegNumber + "\r\n" +
                                                "* Номер телефону: \r\n" + "  " +
                                                getSQL["Phone"].ToString() + "\r\n" +
                                                "* Посада: \r\n" + "  " +
                                                getSQL["JobTitle"].ToString() + "\r\n" +
                                                "* День народження: \r\n" + "  " +
                                                getSQL["BirthDay"].ToString() + "\r\n" +
                                                "* Серія та номер паспорта: \r\n" + "  " +
                                                getSQL["PassportSeries"].ToString() + " " +
                                                getSQL["PassportNumber"].ToString() + "\r\n" +
                                                "* Ким та коли виданий паспорт: \r\n" + "  " +
                                                getSQL["AboutPassport"].ToString() + "\r\n" +
                                                "* Місце проживання за паспортом: \r\n" + "  " +
                                                getSQL["Residence"].ToString() + "\r\n" +
                                                "* Фактичне місце проживання: \r\n" + "  " +
                                                getSQL["ActualResidence"].ToString() + "\r\n" +
                                                "* Освіта: \r\n" + "  " +
                                                getSQL["Education"].ToString() + "\r\n" +
                                                "* Відомості про чоловіка/дружину: \r\n" + "  " +
                                                getSQL["AboutManWoman"].ToString() + "\r\n" +
                                                "* Відомості про батьків: \r\n" + "  " +
                                                getSQL["AboutParents"].ToString() + "\r\n" +
                                                "* Відомості про дітей: \r\n" + "  " +
                                                getSQL["AboutChildren"].ToString() + "\r\n" +
                                                "* Відомості про судимості: \r\n" + "  " +
                                                getSQL["Conviction"].ToString() + "\r\n" +
                                                "---------------------------------------------------" + "\r\n" +
                                                "\r\n";
                        n++;
                    }

                    if (!sql.CloseDB())
                        MessageBox.Show("Помилка закривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void UpdateCountEmployee_from_DB()
        {
            sql.conn_db_Update();

            if (!sql.OpenDB())
                MessageBox.Show("Помилка відкривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                getSQL = sql.SelectData();
                int n = 0;
                while (getSQL.Read())
                {
                    Employee_RegNumber[n] = Convert.ToInt32(getSQL["RegNumber"].ToString()).ToString("000");
                    Employee_LastName[n] = getSQL["LastName"].ToString();
                    Employee_FirstName[n] = getSQL["FirstName"].ToString();
                    Employee_Surname[n] = getSQL["Surname"].ToString();
                    n++;
                }
                N_Employees = n;

                getSQL.Close();

                N_EmployeesInPost = sql.GetCountEmployeeInPost();
                N_FiredEmployees = N_Employees - N_EmployeesInPost;

                if (!sql.CloseDB())
                    MessageBox.Show("Помилка закривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCountEmployeeInFurloughs_from_DB()
        {
            if (N_Employees > 0)
            {
                rtb_Furloughs.Text = null;
                int furlough_cnt = 1;

                for (int i = 0; i < N_Employees; i++)
                {
                    UpdateFurloughs_from_DB(Employee_RegNumber[i]);
                    if (StartDate != "")
                    {
                        rtb_Furloughs.Text = rtb_Furloughs.Text +
                                             furlough_cnt.ToString() + ". " +
                                             Employee_LastName[i] + " " +
                                             Employee_FirstName[i] + " " +
                                             Employee_Surname[i] + "\r\n";
                        furlough_cnt++;
                    }
                }
            }
            else
                rtb_Furloughs.Text = null;
        }

        public static void UpdateEmployeeData_from_DB(string RegNumber_value)
        {
            sql.conn_db_Update();

            if (!sql.OpenDB())
                MessageBox.Show("Помилка відкривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                getSQL = sql.SelectData_from_RegNumber(RegNumber_value);
                getSQL.Read();
                //
                LastName = getSQL["LastName"].ToString();
                FirstName = getSQL["FirstName"].ToString();
                Surname = getSQL["Surname"].ToString();
                PassportSeries = getSQL["PassportSeries"].ToString();
                PassportNumber = getSQL["PassportNumber"].ToString();
                AboutPassport = getSQL["AboutPassport"].ToString();
                ITN = getSQL["ITN"].ToString();
                BirthDay = getSQL["BirthDay"].ToString();
                Residence = getSQL["Residence"].ToString();
                ActualResidence = getSQL["ActualResidence"].ToString();
                Phone = getSQL["Phone"].ToString();
                Education = getSQL["Education"].ToString();
                AboutManWoman = getSQL["AboutManWoman"].ToString();
                AboutParents = getSQL["AboutParents"].ToString();
                AboutChildren = getSQL["AboutChildren"].ToString();
                Conviction = getSQL["Conviction"].ToString();
                photo_path = getSQL["PhotoPath"].ToString();
                //
                getSQL.Close();

                if (!sql.CloseDB())
                    MessageBox.Show("Помилка закривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void UpdateDataAboutEmployee_from_DB(string RegNumber_value)
        {
            sql.conn_db_Update();

            if (!sql.OpenDB())
                MessageBox.Show("Помилка відкривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                getSQL = sql.SelectData_from_RegNumber(RegNumber_value);
                getSQL.Read();
                //
                LastName = getSQL["LastName"].ToString();
                FirstName = getSQL["FirstName"].ToString();
                Surname = getSQL["Surname"].ToString();
                //
                getSQL.Close();
                ///
                getSQL = sql.SelectPost_from_RegNumber(RegNumber_value);
                getSQL.Read();
                //
                Qualification = getSQL["Qualification"].ToString();
                Salary = getSQL["Salary"].ToString();
                //
                getSQL.Close();

                if (!sql.CloseDB())
                    MessageBox.Show("Помилка закривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void UpdateFurloughs_from_DB(string RegNumber_value)
        {
            sql.conn_db_Update();

            if (!sql.OpenDB())
                MessageBox.Show("Помилка відкривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                getSQL = sql.SelectFurlough_from_RegNumber(RegNumber_value);
                getSQL.Read();
                //
                StartDate = getSQL["StartDate"].ToString();
                CountDays = getSQL["CountDays"].ToString();
                MainSlave = getSQL["MainSlave"].ToString();
                //
                getSQL.Close();

                if (!sql.CloseDB())
                    MessageBox.Show("Помилка закривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void UpdatePost_from_DB(string RegNumber_value)
        {
            sql.conn_db_Update();

            if (!sql.OpenDB())
                MessageBox.Show("Помилка відкривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                getSQL = sql.SelectPost_from_RegNumber(RegNumber_value);
                getSQL.Read();
                //
                Post = getSQL["JobTitle"].ToString();
                Qualification = getSQL["Qualification"].ToString();
                Salary = getSQL["Salary"].ToString();
                WorkExperience = getSQL["WorkExperience"].ToString();
                //
                getSQL.Close();

                if (!sql.CloseDB())
                    MessageBox.Show("Помилка закривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static string ExtractDateTime_from_DB(string dateTime_value)
        {
            if (dateTime_value != "")
                return DateTime.ParseExact(MainForm.BirthDay, MainForm.dateFormat, CultureInfo.InvariantCulture).ToShortDateString();
            else
                return null;
        }

        public static string GetAgeYears(string birthday_value)
        {
            DateTime date1 = Convert.ToDateTime(birthday_value);
            DateTime date2 = DateTime.Now;
            if (date1.DayOfYear <= date2.DayOfYear)
            {
                return (date2.Year - date1.Year).ToString();
            }
            else
                return (date2.Year - date1.Year - 1).ToString();
        }

        private static DateTime ConvertDT(string str)
        {
            if (str != null)
                return DateTime.Parse(str);
            else
                return DateTime.Now;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void вийтиЗПрограмиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox abox = new AboutBox();
            abox.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!sql.CloseDB())
                MessageBox.Show("Помилка закривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public static void CreateNewFurlough()
        {
            if (FurloughsForm.isNewData)
            {
                fi.RegNumber = FurloughsForm.RegNumber_DB;
                fi.StartDate = FurloughsForm.StartDate_DB;
                fi.CountDays = FurloughsForm.CountDays_DB;
                fi.MainSlave = FurloughsForm.MainSlave_DB;

                Add_Furlough_to_DB();
            }
        }

        public static void CreateNewPost()
        {
            if (PostForm.isNewData)
            {
                pi.RegNumber = PostForm.RegNumber_DB;
                pi.Post = PostForm.Post_DB;
                pi.Qualification = PostForm.Qualification_DB;
                pi.Salary = PostForm.Salary_DB;
                pi.WorkExperience = PostForm.WorkExperience_DB;

                Add_Post_to_DB();
            }
        }

        public static void Add_Post_to_DB()
        {
            sql.conn_db_Update();

            if (!sql.OpenDB())
                MessageBox.Show("Помилка відкривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!sql.UpdateDataNewPost(pi))
                    MessageBox.Show("Помилка призначення посади для нового працівника");
                else
                {
                    if (!sql.CloseDB())
                        MessageBox.Show("Помилка закривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Операція завершена успішно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static void Add_Furlough_to_DB()
        {
            sql.conn_db_Update();

            if (!sql.OpenDB())
                MessageBox.Show("Помилка відкривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!sql.UpdateDataNewFurlough(fi))
                    MessageBox.Show("Помилка додавання відпустки для нового працівника");
                else
                {
                    if (!sql.CloseDB())
                        MessageBox.Show("Помилка закривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Операція завершена успішно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static void CreateNewEmployee()
        {
            if (NewEmployeeForm.isNewData)
            {
                ei.RegNumber = NewEmployeeForm.RegNumber_DB;
                ei.LastName = NewEmployeeForm.LastName_DB;
                ei.FirstName = NewEmployeeForm.FirstName_DB;
                ei.Surname = NewEmployeeForm.Surname_DB;
                ei.PassportSeries = NewEmployeeForm.PassportSeries_DB;
                ei.PassportNumber = NewEmployeeForm.PassportNumber_DB;
                ei.AboutPassport = NewEmployeeForm.AboutPassport_DB;
                ei.ITN = NewEmployeeForm.ITN_DB;
                ei.BirthDay = NewEmployeeForm.BirthDay_DB;
                ei.Residence = NewEmployeeForm.Residence_DB;
                ei.ActualResidence = NewEmployeeForm.ActualResidence_DB;
                ei.Phone = NewEmployeeForm.Phone_DB;
                ei.Education = NewEmployeeForm.Education_DB;
                ei.Conviction = NewEmployeeForm.Conviction_DB;
                ei.photo_path = NewEmployeeForm.photo_path_DB;
                ei.AboutParents = NewEmployeeForm.AboutParents_DB;
                ei.AboutManWoman = NewEmployeeForm.AboutManWoman_DB;
                ei.AboutChildren = NewEmployeeForm.AboutChildren_DB;

                Add_Employee_to_DB();

                MaxNewEmployeesInDB = NewEmployeeForm.MaxNewEmployeesInDB;
                MaxNewEmployeesInDB++;

                if (!sql.OpenDB())
                    MessageBox.Show("Помилка відкривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (!sql.SetMaxRegNumber(MaxNewEmployeesInDB))
                        MessageBox.Show("Помилка встановлення нового MaxRegNumber!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (!sql.CloseDB())
                        MessageBox.Show("Помилка закривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public static void UpdateEmployeeData()
        {
            if (EmployeesManager.isNewData)
            {
                ei.RegNumber = EmployeesManager.RegNumber_DB;
                ei.PassportSeries = EmployeesManager.PassportSeries_DB;
                ei.PassportNumber = EmployeesManager.PassportNumber_DB;
                ei.AboutPassport = EmployeesManager.AboutPassport_DB;
                ei.ITN = EmployeesManager.ITN_DB;
                ei.BirthDay = EmployeesManager.BirthDay_DB;
                ei.Residence = EmployeesManager.Residence_DB;
                ei.ActualResidence = EmployeesManager.ActualResidence_DB;
                ei.Phone = EmployeesManager.Phone_DB;
                ei.Education = EmployeesManager.Education_DB;
                ei.Conviction = EmployeesManager.Conviction_DB;
                ei.photo_path = EmployeesManager.photo_path_DB;
                ei.AboutParents = EmployeesManager.AboutParents_DB;
                ei.AboutManWoman = EmployeesManager.AboutManWoman_DB;
                ei.AboutChildren = EmployeesManager.AboutChildren_DB;

                UpdateEmployee_in_DB();
            }
        }

        public static void Add_Employee_to_DB()
        {
            sql.conn_db_Update();

            if (!sql.OpenDB())
                MessageBox.Show("Помилка відкривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!sql.InsertDataNewEmployee(ei))
                    MessageBox.Show("Помилка додавання даних нового працівника");
                else
                {
                    if (!sql.CloseDB())
                        MessageBox.Show("Помилка закривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Операція завершена успішно", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        public static void UpdateEmployee_in_DB()
        {
            sql.conn_db_Update();

            if (!sql.OpenDB())
                MessageBox.Show("Помилка відкривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!sql.UpdateEmployeeData(ei))
                    MessageBox.Show("Помилка оновлення даних працівника!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (!sql.CloseDB())
                    MessageBox.Show("Помилка закривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static void UpdatePIB_in_DB(string RegNumber_value)
        {
            sql.conn_db_Update();

            if (!sql.OpenDB())
                MessageBox.Show("Помилка відкривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ei.RegNumber = RegNumber_value;
                ei.LastName = ChangePIB.LastName_DB;
                ei.FirstName = ChangePIB.FirstName_DB;
                ei.Surname = ChangePIB.Surname_DB;

                if (!sql.EditPIB(ei))
                    MessageBox.Show("Помилка оновлення ПІБ працівника!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (!sql.CloseDB())
                    MessageBox.Show("Помилка закривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteEmployee_from_DB(string RegNumber_value)
        {
            sql.conn_db_Update();

            if (!sql.OpenDB())
                MessageBox.Show("Помилка відкривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!sql.DeleteEmployee(RegNumber_value))
                    MessageBox.Show("Помилка видалення працівника!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (!sql.CloseDB())
                    MessageBox.Show("Помилка закривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void DeleteFurlough_from_DB(string RegNumber_value)
        {
            sql.conn_db_Update();

            if (!sql.OpenDB())
                MessageBox.Show("Помилка відкривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!sql.DeleteFurlough(RegNumber_value))
                    MessageBox.Show("Помилка видалення відпустки працівника!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (!sql.CloseDB())
                    MessageBox.Show("Помилка закривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeletePost_from_DB(string RegNumber_value)
        {
            sql.conn_db_Update();

            if (!sql.OpenDB())
                MessageBox.Show("Помилка відкривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!sql.DeletePost(RegNumber_value))
                    MessageBox.Show("Помилка звільнення працівника!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (!sql.CloseDB())
                    MessageBox.Show("Помилка закривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadData()
        {
            if (MainForm.N_Employees > 0)
            {
                FindEmployeeByPost_from_DB("Директор");
                l_dir_0.Text = FindPost_0;
                l_dir_1.Text = FindPost_1;
                l_dir_2.Text = FindPost_2;
                //
                FindEmployeeByPost_from_DB("Технічний директор");
                l_tech_dir_0.Text = FindPost_0;
                l_tech_dir_1.Text = FindPost_1;
                l_tech_dir_2.Text = FindPost_2;
                //
                FindEmployeeByPost_from_DB("Головний бухгалтер");
                l_main0_0.Text = FindPost_0;
                l_main0_1.Text = FindPost_1;
                l_main0_2.Text = FindPost_2;
                //
                FindEmployeeByPost_from_DB("Головний інженер");
                l_main1_0.Text = FindPost_0;
                l_main1_1.Text = FindPost_1;
                l_main1_2.Text = FindPost_2;
                //
                FindEmployeeByPost_from_DB("Економіст");
                l_echon_0.Text = FindPost_0;
                l_echon_1.Text = FindPost_1;
                l_echon_2.Text = FindPost_2;
                //
                FindEmployeeByPost_from_DB("Інженер");
                l_eng_0.Text = FindPost_0;
                l_eng_1.Text = FindPost_1;
                l_eng_2.Text = FindPost_2;
                //
                FindEmployeeByPost_from_DB("Фахівець");
                l_spec_0.Text = FindPost_0;
                l_spec_1.Text = FindPost_1;
                l_spec_2.Text = FindPost_2;
                //
                FindEmployeeByPost_from_DB("Підсобний робітник");
                l_other_0.Text = FindPost_0;
                l_other_1.Text = FindPost_1;
                l_other_2.Text = FindPost_2;
                ////
                l_AllEmployee.Text = N_Employees.ToString();
                l_AllEmployeeInPost.Text = N_EmployeesInPost.ToString();
                l_AllFiredEmployee.Text = N_FiredEmployees.ToString();
                ///
                UpdateCountEmployeeInFurloughs_from_DB();
            }
            else
            {
                l_dir_0.Text = "-";
                l_dir_1.Text = "-";
                l_dir_2.Text = "-";
                l_tech_dir_0.Text = "-";
                l_tech_dir_1.Text = "-";
                l_tech_dir_2.Text = "-";
                l_main0_0.Text = "-";
                l_main0_1.Text = "-";
                l_main0_2.Text = "-";
                l_main1_0.Text = "-";
                l_main1_1.Text = "-";
                l_main1_2.Text = "-";
                l_echon_0.Text = "-";
                l_echon_1.Text = "-";
                l_echon_2.Text = "-";
                l_eng_0.Text = "-";
                l_eng_1.Text = "-";
                l_eng_2.Text = "-";
                l_spec_0.Text = "-";
                l_spec_1.Text = "-";
                l_spec_2.Text = "-";
                l_other_0.Text = "-";
                l_other_1.Text = "-";
                l_other_2.Text = "-";
                //
                l_AllEmployee.Text = "0";
                l_AllEmployeeInPost.Text = "0";
                l_AllFiredEmployee.Text = "0";
                //
                rtb_Furloughs.Text = null;
            }
        }

        public static void FindEmployeeByPost_from_DB(string Post_value)
        {
            sql.conn_db_Update();

            if (!sql.OpenDB())
                MessageBox.Show("Помилка відкривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string RegNumber = sql.FindEmpoyee_from_Post(Post_value);
                if (RegNumber != null)
                {
                    UpdateDataAboutEmployee_from_DB(RegNumber);
                    FindPost_0 = LastName + " " + FirstName + " " + Surname;
                    FindPost_1 = Qualification;
                    FindPost_2 = "Оклад: " + Salary + " грн";
                }
                else
                {
                    FindPost_0 = "-";
                    FindPost_1 = "-";
                    FindPost_2 = "-";
                }

                if (!sql.CloseDB())
                    MessageBox.Show("Помилка закривання бази даних!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddEmployee()
        {
            nef = new NewEmployeeForm();
            nef.ShowDialog();
            UpdateCountEmployee_from_DB();
            ReloadData();
        }

        private void OpenOptions()
        {
            sf = new SettingsForm();
            sf.ShowDialog();
            UpdateCountEmployee_from_DB();
            ReloadData();
        }

        private void OpenPostManager()
        {
            pf = new PostForm();
            pf.ShowDialog();
            UpdateCountEmployee_from_DB();
            ReloadData();
        }

        private void OpenEmployeesManager()
        {
            em = new EmployeesManager();
            em.ShowDialog();
            UpdateCountEmployee_from_DB();
            ReloadData();
        }

        private void OpenFurloughManager()
        {
            ff = new FurloughsForm();
            ff.ShowDialog();
            UpdateCountEmployee_from_DB();
            ReloadData();
        }

        private void налаштуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenOptions();
        }

        private void новийПрацівникToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEmployee();
        }

        private void менеджерОбліковихЗаписівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenEmployeesManager();
        }

        private void посадиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenPostManager();
        }

        private void відпусткиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFurloughManager();
        }

        private void pButton_Furlough_MouseLeave(object sender, EventArgs e)
        {
            pButton_Furlough.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "furlough_normal.png"));
        }

        private void pButton_Furlough_MouseDown(object sender, MouseEventArgs e)
        {
            pButton_Furlough.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "furlough_down.png"));
        }

        private void pButton_Furlough_MouseUp(object sender, MouseEventArgs e)
        {
            pButton_Furlough.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "furlough_hover.png"));

            OpenFurloughManager();
        }

        private void pButton_Furlough_MouseEnter(object sender, EventArgs e)
        {
            pButton_Furlough.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "furlough_hover.png"));
        }

        private void pButton_Employee_MouseEnter(object sender, EventArgs e)
        {
            pButton_Employee.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "employee_hover.png"));
        }

        private void pButton_Employee_MouseLeave(object sender, EventArgs e)
        {
            pButton_Employee.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "employee_normal.png"));
        }

        private void pButton_Employee_MouseUp(object sender, MouseEventArgs e)
        {
            pButton_Employee.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "employee_hover.png"));

            OpenEmployeesManager();
        }

        private void pButton_Employee_MouseDown(object sender, MouseEventArgs e)
        {
            pButton_Employee.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "employee_down.png"));
        }

        private void pButton_Post_MouseEnter(object sender, EventArgs e)
        {
            pButton_Post.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "post_hover.png"));
        }

        private void pButton_Post_MouseDown(object sender, MouseEventArgs e)
        {
            pButton_Post.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "post_down.png"));
        }

        private void pButton_Post_MouseUp(object sender, MouseEventArgs e)
        {
            pButton_Post.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "post_hover.png"));

            OpenPostManager();
        }

        private void pButton_Post_MouseLeave(object sender, EventArgs e)
        {
            pButton_Post.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "post_normal.png"));
        }


        private void pButton_Options_MouseDown(object sender, MouseEventArgs e)
        {
            pButton_Options.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "options_down.png"));

        }

        private void pButton_Options_MouseEnter(object sender, EventArgs e)
        {
            pButton_Options.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "options_hover.png"));

        }

        private void pButton_Options_MouseLeave(object sender, EventArgs e)
        {
            pButton_Options.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "options_normal.png"));
        }

        private void pButton_Options_MouseUp(object sender, MouseEventArgs e)
        {
            pButton_Options.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "options_hover.png"));

            OpenOptions();
        }

        private void pButton_AddEmployee_MouseDown(object sender, MouseEventArgs e)
        {
            pButton_AddEmployee.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "add_down.png"));
        }

        private void pButton_AddEmployee_MouseEnter(object sender, EventArgs e)
        {
            pButton_AddEmployee.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "add_hover.png"));
        }

        private void pButton_AddEmployee_MouseLeave(object sender, EventArgs e)
        {
            pButton_AddEmployee.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "add_normal.png"));
        }

        private void pButton_AddEmployee_MouseUp(object sender, MouseEventArgs e)
        {
            pButton_AddEmployee.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "add_hover.png"));

            AddEmployee();
        }

        private void pButton_About_MouseDown(object sender, MouseEventArgs e)
        {
            pButton_About.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "about_down.png"));
        }

        private void pButton_About_MouseEnter(object sender, EventArgs e)
        {
            pButton_About.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "about_hover.png"));
        }

        private void pButton_About_MouseUp(object sender, MouseEventArgs e)
        {
            pButton_About.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "about_hover.png"));

            AboutBox abox = new AboutBox();
            abox.ShowDialog();
        }

        private void pButton_About_MouseLeave(object sender, EventArgs e)
        {
            pButton_About.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "about_normal.png"));
        }


        private void pButton_Exit_MouseDown(object sender, MouseEventArgs e)
        {
            pButton_Exit.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "exit_down.png"));
        }

        private void pButton_Exit_MouseEnter(object sender, EventArgs e)
        {
            pButton_Exit.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "exit_hover.png"));
        }

        private void pButton_Exit_MouseLeave(object sender, EventArgs e)
        {
            pButton_Exit.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "exit_normal.png"));
        }

        private void pButton_Exit_MouseUp(object sender, MouseEventArgs e)
        {
            pButton_Exit.Image = Image.FromFile(Path.Combine(Directory.GetCurrentDirectory(), "images", "exit_hover.png"));
            Close();
        }

        private void pButton_About_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pButton_About, "Про програму");
        }

        private void pButton_AddEmployee_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pButton_AddEmployee, "Створити новий обліковий запис працівника");
        }

        private void pButton_Employee_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pButton_Employee, "Відкрити менеджер облікових записів працівників");
        }

        private void pButton_Furlough_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pButton_Furlough, "Відкрити засіб редагування відпусток");
        }

        private void pButton_Post_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pButton_Post, "Відкрити засіб редагування посад");
        }

        private void pButton_Options_MouseHover(object sender, EventArgs e)
        {

            toolTip.SetToolTip(pButton_Options, "Налаштування бази даних");
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.Text = this.Text + ",  " + String.Format("версія {0}", AssemblyVersion);
            UpdateCountEmployee_from_DB();
            ReloadData();
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        private void b_Find_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(b_Find, "Пошук по базі даних");
        }

        private void tb_Find_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(tb_Find, "Ключове слово для пошуку");
        }

        private void rtb_ResultOfFind_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(rtb_ResultOfFind, "Результати пошуку");
        }

        private void pButton_Exit_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pButton_Exit, "Вихід з програми");
        }

        private void b_Find_Click(object sender, EventArgs e)
        {
            FindData_in_DB();
        }

        private void tb_Find_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindData_in_DB();
            }
        }
    }
}
