using System;
using System.Data.SQLite;

/// <summary>
/// Клас SQLClass призначений для роботи із відкритою базою даних за допомогою SQL v.3
/// 
/// Модуль працює на основі SQL біблітек для .NET
/// Використовуються такі DLL:
/// 
/// SQLite.Interop.dll
/// System.Data.SQLite.dll
/// System.Data.SQLite.EF6.dll
/// System.Data.SQLite.Linq.dll
/// 
/// 
/// Розробник: Сергій Сабадаш
/// sabadashss@ukr.net
/// 22.07.2021
/// 
/// </summary>

namespace hrdApp.SQL
{
    class SQLClass
    {
        static string db_folder_name = MainForm.db_folder_name;
        static string db_file_name = MainForm.db_file_name;
        //
        SQLiteConnection conn_db = new SQLiteConnection("Data Source=" + db_folder_name + "\\" + db_file_name + "; Version=3");
        //
        private String sql;
        Boolean ret = false;
        SQLiteDataReader readSQL;

        public void conn_db_Update()
        {
            db_folder_name = MainForm.db_folder_name;
            db_file_name = MainForm.db_file_name;
            conn_db = new SQLiteConnection("Data Source=" + db_folder_name + "\\" + db_file_name + "; Version=3");
        }

        public Boolean OpenDB()
        {
            try
            {
                conn_db.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean CloseDB()
        {
            try
            {
                conn_db.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public SQLiteDataReader FindSelectData(string findKey)
        {
            sql = "SELECT * " +
                  "FROM employees, family, post " +
                  "WHERE (employees.RegNumber = '" + findKey + "' OR " +
                         "employees.LastName = '" + findKey + "' OR " +
                         "employees.FirstName = '" + findKey + "' OR " +
                         "employees.Surname = '" + findKey + "' OR " +
                         "employees.PassportSeries = '" + findKey + "' OR " +
                         "employees.PassportNumber = '" + findKey + "' OR " +
                         "employees.AboutPassport = '" + findKey + "' OR " +
                         "employees.ITN = '" + findKey + "' OR " +
                         "employees.BirthDay = '" + findKey + "' OR " +
                         "employees.Residence = '" + findKey + "' OR " +
                         "employees.ActualResidence = '" + findKey + "' OR " +
                         "employees.Phone = '" + findKey + "' OR " +
                         "employees.Education = '" + findKey + "' OR " +
                         "employees.Conviction = '" + findKey + "' OR " +
                         "family.AboutParents = '" + findKey + "' OR " +
                         "family.AboutManWoman = '" + findKey + "' OR " +
                         "family.AboutChildren = '" + findKey + "' OR " +
                         "post.JobTitle = '" + findKey + "' OR " +
                         "post.Qualification = '" + findKey + "' OR " +
                         "post.Salary = '" + findKey + "' OR " +
                         "post.WorkExperience = '" + findKey + "') AND " +
                         "employees.RegNumber = post.RegNumber AND " +
                         "employees.RegNumber = family.RegNumber";

            SQLiteCommand CMD = new SQLiteCommand(sql, conn_db);
            try
            {
                readSQL = CMD.ExecuteReader();
            }
            catch (SQLiteException ex)
            {
                throw new SQLiteException("Помилка вибору даних! : " + ex.Message);
            }

            return readSQL;
        }

        public Boolean UpdateDataNewFurlough(FurloughItems f)
        {
            sql = "UPDATE furlough " +
                  "SET StartDate = '" + f.StartDate + "', " +
                      "CountDays = '" + f.CountDays + "', " +
                      "MainSlave = '" + f.MainSlave + "' " +
                  "WHERE RegNumber = '" + f.RegNumber + "'";

            SQLiteCommand CMD = new SQLiteCommand(sql, conn_db);
            try
            {
                CMD.ExecuteNonQuery();
                ret = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Помилка додавання відпустки для нового працівника! : " + ex.Message);
            }
            return ret;
        }

        public Boolean UpdateDataNewPost(PostItems p)
        {
            sql = "UPDATE post " +
                  "SET JobTitle = '" + p.Post + "', " +
                      "Qualification = '" + p.Qualification + "', " +
                      "Salary = '" + p.Salary + "', " +
                      "WorkExperience = '" + p.WorkExperience + "' " +
                  "WHERE RegNumber = '" + p.RegNumber + "'";

            SQLiteCommand CMD = new SQLiteCommand(sql, conn_db);
            try
            {
                CMD.ExecuteNonQuery();
                ret = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Помилка призначення посади для нового працівника! : " + ex.Message);
            }
            return ret;
        }

        public Boolean InsertDataNewEmployee(EmployeeItems m)
        {
            sql = "INSERT INTO employees (RegNumber, " +
                                         "LastName, " +
                                         "FirstName, " +
                                         "Surname, " +
                                         "PassportSeries, " +
                                         "PassportNumber, " +
                                         "AboutPassport, " +
                                         "ITN, " +
                                         "BirthDay, " +
                                         "Residence, " +
                                         "ActualResidence, " +
                                         "Phone, " +
                                         "Education, " +
                                         "Conviction, " +
                                         "PhotoPath) " +
                  "VALUES ( " + "'" + m.RegNumber + "', " + "'"
                                    + m.LastName + "', " + "'"
                                    + m.FirstName + "', " + "'"
                                    + m.Surname + "', " + "'" 
                                    + m.PassportSeries + "', " + "'"
                                    + m.PassportNumber + "', " + "'"
                                    + m.AboutPassport + "', " + "'"
                                    + m.ITN + "', " + "'"
                                    + m.BirthDay + "', " + "'"
                                    + m.Residence + "', " + "'"
                                    + m.ActualResidence + "', " + "'"
                                    + m.Phone + "', " + "'"
                                    + m.Education + "', " + "'"
                                    + m.Conviction + "', " + "'"
                                    + m.photo_path + "');";

            sql = sql + "INSERT INTO family (RegNumber, " +
                                            "AboutParents, " +
                                            "AboutManWoman, " +
                                            "AboutChildren) " +
                        "VALUES (" +  "'" + m.RegNumber + "', " + "'"
                                          + m.AboutParents + "', " + "'"
                                          + m.AboutManWoman + "', " + "'"
                                          + m.AboutChildren + "');";

            sql = sql + "INSERT INTO furlough (RegNumber) " +
                        "VALUES (" + "'" + m.RegNumber + "');";

            sql = sql + "INSERT INTO post (RegNumber) " +
                        "VALUES (" + "'" + m.RegNumber + "')";

            SQLiteCommand CMD = new SQLiteCommand(sql, conn_db);
            try
            {
                CMD.ExecuteNonQuery();
                ret = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Помилка додавання даних для нового працівника! : " + ex.Message);
            }
            return ret;
        }


        public Boolean DeleteEmployee(string RegNumber)
        {
            sql = "DELETE " +
                  "FROM employees " +
                  "WHERE RegNumber = '" + RegNumber + "';";

            sql = sql + "DELETE " +
                        "FROM family " +
                        "WHERE RegNumber = '" + RegNumber + "';";

            sql = sql + "DELETE " +
                        "FROM furlough " +
                        "WHERE RegNumber = '" + RegNumber + "';";

            sql = sql + "DELETE " +
                        "FROM post " +
                        "WHERE RegNumber = '" + RegNumber + "'";

            SQLiteCommand CMD = new SQLiteCommand(sql, conn_db);
            try
            {
                CMD.ExecuteNonQuery();
                ret = true;
            }
            catch (SQLiteException ex)
            {
                throw new SQLiteException("Помилка видалення даних! : " + ex.Message);
            }
            return ret;
        }

        public SQLiteDataReader SelectData()
        {
            sql = "SELECT * " +
                  "FROM employees";

            SQLiteCommand CMD = new SQLiteCommand(sql, conn_db);
            try
            {
                readSQL = CMD.ExecuteReader();
            }
            catch (SQLiteException ex)
            {
                throw new SQLiteException("Помилка вибору даних! : " + ex.Message);
            }

            return readSQL;
        }

        public SQLiteDataReader SelectData_from_RegNumber(string RegNumber)
        {
            sql = "SELECT * " +
                  "FROM employees, family " +
                  "WHERE employees.RegNumber = '" + RegNumber + "' AND " +
                        "family.RegNumber = '" + RegNumber + "'";

            SQLiteCommand CMD = new SQLiteCommand(sql, conn_db);
            try
            {
                readSQL = CMD.ExecuteReader();
            }
            catch (SQLiteException ex)
            {
                throw new SQLiteException("Помилка вибору даних за табельним номером! : " + ex.Message);
            }

            return readSQL;
        }

        public SQLiteDataReader SelectFurlough_from_RegNumber(string RegNumber)
        {
            sql = "SELECT * " +
                  "FROM furlough " +
                  "WHERE RegNumber = '" + RegNumber + "'";

            SQLiteCommand CMD = new SQLiteCommand(sql, conn_db);
            try
            {
                readSQL = CMD.ExecuteReader();
            }
            catch (SQLiteException ex)
            {
                throw new SQLiteException("Помилка вибору даних за табельним номером! : " + ex.Message);
            }

            return readSQL;
        }

        public SQLiteDataReader SelectPost_from_RegNumber(string RegNumber)
        {
            sql = "SELECT * " +
                  "FROM post " +
                  "WHERE RegNumber = '" + RegNumber + "'";

            SQLiteCommand CMD = new SQLiteCommand(sql, conn_db);
            try
            {
                readSQL = CMD.ExecuteReader();
            }
            catch (SQLiteException ex)
            {
                throw new SQLiteException("Помилка вибору даних за табельним номером! : " + ex.Message);
            }

            return readSQL;
        }

        public string FindEmpoyee_from_Post(string Post)
        {
            sql = "SELECT * " +
                  "FROM post " +
                  "WHERE JobTitle = '" + Post + "'";

            SQLiteCommand CMD = new SQLiteCommand(sql, conn_db);
            try
            {
                readSQL = CMD.ExecuteReader();

                if (!readSQL.Read())
                {
                    return null;
                }

                if (readSQL["RegNumber"] != DBNull.Value)
                {
                    string data = readSQL["RegNumber"].ToString();
                    readSQL.Close();
                    return data;
                }
                else
                {
                    readSQL.Close();
                    return null;
                }  
            }
            catch (SQLiteException ex)
            {
                throw new SQLiteException("Помилка вибору даних за табельним номером! : " + ex.Message);
            }
        }

        public int GetMaxRegNumber()
        {
            int MaxValue = -1;

            sql = "SELECT service.MaxRegNumber " +
                  "FROM service";

            SQLiteCommand CMD = new SQLiteCommand(sql, conn_db);
            try
            {
                readSQL = CMD.ExecuteReader();
                
                if (!readSQL.Read())
                {
                    throw new SQLiteException("Відсутні дані після виконання readSQL.Read().");
                }     

                if (readSQL["MaxRegNumber"] != DBNull.Value)
                {
                    MaxValue = Convert.ToInt32(readSQL["MaxRegNumber"]);
                }
                else
                {
                    MaxValue = 0;
                }
   
                readSQL.Close();
            }
            catch (SQLiteException ex)
            {
                throw new SQLiteException("Помилка визначення MaxRegNumber! : " + ex.Message);
            }

            return MaxValue;
        }

        public int GetCountEmployeeInPost()
        {
            int CountValue = -1;

            sql = "SELECT COUNT(JobTitle) " +
                  "AS JobTitleCnt " +
                  "FROM post " +
                  "WHERE post.JobTitle IS NOT NULL";

            SQLiteCommand CMD = new SQLiteCommand(sql, conn_db);
            try
            {
                readSQL = CMD.ExecuteReader();

                if (!readSQL.Read())
                {
                    throw new SQLiteException("Відсутні дані після виконання readSQL.Read().");
                }

                if (readSQL["JobTitleCnt"] != DBNull.Value)
                {
                    CountValue = Convert.ToInt32(readSQL["JobTitleCnt"]);
                }
                else
                {
                    CountValue = 0;
                }

                readSQL.Close();
            }
            catch (SQLiteException ex)
            {
                throw new SQLiteException("Помилка визначення CountValue! : " + ex.Message);
            }

            return CountValue;
        }

        public Boolean SetMaxRegNumber(int MaxValue)
        {
            sql = "UPDATE service " +
                  "SET MaxRegNumber = '" + MaxValue + "'";

            SQLiteCommand CMD = new SQLiteCommand(sql, conn_db);
            try
            {
                CMD.ExecuteNonQuery();
                ret = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Помилка встановлення SetMaxRegNumber! : " + ex.Message);
            }
            return ret;
        }

        public Boolean EditPIB(EmployeeItems m)
        {
            sql = "UPDATE employees " +
                  "SET LastName = '" + m.LastName + "', " +
                      "FirstName = '" + m.FirstName + "', " +
                      "Surname = '" + m.Surname + "' " +
                  "WHERE RegNumber = '" + m.RegNumber + "'";

            SQLiteCommand CMD = new SQLiteCommand(sql, conn_db);
            try
            {
                CMD.ExecuteNonQuery();
                ret = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Помилка редагування даних! : " + ex.Message);
            }
            return ret;
        }

        public Boolean UpdateEmployeeData(EmployeeItems m)
        {
            sql = "UPDATE employees " +
                  "SET PassportSeries = '" + m.PassportSeries + "', " +
                      "PassportNumber = '" + m.PassportNumber + "', " +
                      "AboutPassport = '" + m.AboutPassport + "', " +
                      "ITN = '" + m.ITN + "', " +
                      "BirthDay = '" + m.BirthDay + "', " +
                      "Residence = '" + m.Residence + "', " +
                      "ActualResidence = '" + m.ActualResidence + "', " +
                      "Phone = '" + m.Phone + "', " +
                      "Education = '" + m.Education + "', " +
                      "Conviction = '" + m.Conviction + "', " +
                      "PhotoPath = '" + m.photo_path + "' " +
                  "WHERE RegNumber = '" + m.RegNumber + "';";

            sql = sql + "UPDATE family " +
                        "SET AboutParents = '" + m.AboutParents + "', " +
                            "AboutManWoman = '" + m.AboutManWoman + "', " +
                            "AboutChildren = '" + m.AboutChildren + "' " +
                        "WHERE RegNumber = '" + m.RegNumber + "'";

            SQLiteCommand CMD = new SQLiteCommand(sql, conn_db);
            try
            {
                CMD.ExecuteNonQuery();
                ret = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Помилка оновлення даних! : " + ex.Message);
            }
            return ret;
        }


        public Boolean DeleteFurlough(string RegNumber)
        {
            sql = "UPDATE furlough " +
                  "SET StartDate = null, " +
                      "CountDays = null, " +
                      "MainSlave = null " +
                  "WHERE RegNumber = '" + RegNumber + "'";

            SQLiteCommand CMD = new SQLiteCommand(sql, conn_db);
            try
            {
                CMD.ExecuteNonQuery();
                ret = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Помилка додавання відпустки для нового працівника! : " + ex.Message);
            }
            return ret;
        }

        public Boolean DeletePost(string RegNumber)
        {
            sql = "UPDATE post " +
                  "SET JobTitle = null, " +
                      "Qualification = null, " +
                      "Salary = null, " +
                      "WorkExperience = null " +
                  "WHERE RegNumber = '" + RegNumber + "'";

            SQLiteCommand CMD = new SQLiteCommand(sql, conn_db);
            try
            {
                CMD.ExecuteNonQuery();
                ret = true;
            }
            catch (Exception ex)
            {
                throw new Exception("Помилка додавання відпустки для нового працівника! : " + ex.Message);
            }
            return ret;
        }
    }
}