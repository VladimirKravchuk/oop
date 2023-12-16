using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace hrdApp
{
    public partial class SettingsForm : Form
    {
        static string db_folder_name;
        static string db_file_name;
        static string db_file_name_def;
        static string db_file_name_empty;
        //
        public static string path_db_file = db_file_name;
        //
        static string db_file_name_old = db_file_name;

        private void ReloadSettings()
        {
            db_folder_name = MainForm.db_folder_name;
            db_file_name = MainForm.db_file_name;
            db_file_name_def = MainForm.db_file_name_def;
            db_file_name_empty = MainForm.db_file_name_empty;
            path_db_file = db_file_name;
            db_file_name_old = db_file_name;
    }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void b_Back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void b_Add_DB_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(b_Add_DB, "Створити нову пусту базу даних");
        }

        private void b_Open_DB_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(b_Open_DB, "Відкрити наявну базу даних");
        }

        private void b_Open_DB_Click(object sender, EventArgs e)
        {
            openFileDialog_DB.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), db_folder_name);
            openFileDialog_DB.FileName = null;
            if (openFileDialog_DB.ShowDialog() == DialogResult.OK)
            {
                path_db_file = openFileDialog_DB.FileName;
                tb_DB_fullpath.Text = path_db_file;
                int length_str = Directory.GetCurrentDirectory().Length;
                path_db_file = path_db_file.Substring(length_str+1, path_db_file.Length-length_str-1);
                tb_DB_path.Text = path_db_file;
                SetCursorEnd();
            }
        }

        private void b_Add_DB_Click(object sender, EventArgs e)
        {
            saveFileDialog_DB.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), db_folder_name);
            saveFileDialog_DB.FileName = Path.GetFileNameWithoutExtension(db_file_name_def) + "_" + DateTime.Now.ToShortDateString()
                                         + "_" + DateTime.Now.Hour + "-" + DateTime.Now.Minute + "-" + DateTime.Now.Second;
            if (saveFileDialog_DB.ShowDialog() == DialogResult.OK)
            {
                path_db_file = saveFileDialog_DB.FileName;
                // копіювання файлу
                File.Copy(Path.Combine(Directory.GetCurrentDirectory(), db_file_name_empty), path_db_file, true);
                //
                tb_DB_fullpath.Text = path_db_file;
                int length_str = Directory.GetCurrentDirectory().Length;
                path_db_file = path_db_file.Substring(length_str + 1, path_db_file.Length - length_str - 1);
                tb_DB_path.Text = path_db_file;
                SetCursorEnd();
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            ReloadSettings();
            tb_DB_path.Text = Path.Combine(db_folder_name, db_file_name);
            tb_DB_fullpath.Text = Path.Combine(Directory.GetCurrentDirectory(), db_folder_name, db_file_name);
            SetCursorEnd();
        }

        private void SetCursorEnd()
        {
            tb_DB_fullpath.Focus();
            tb_DB_fullpath.SelectionStart = tb_DB_fullpath.Text.Length;
            tb_DB_path.Focus();
            tb_DB_path.SelectionStart = tb_DB_path.Text.Length;
        }

        private void SaveNewPath()
        {
            string path_new = Path.GetFileName(path_db_file);
            if (db_file_name_old != path_new)
            {
                MainForm.db_file_name = path_new;
                Configuration currentConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                currentConfig.AppSettings.Settings["db_file_name"].Value = MainForm.db_file_name;
                currentConfig.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                MessageBox.Show("Налаштування збережені", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            SaveNewPath();
            Close();
        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            ReloadSettings();
        }

        private void b_Back_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
