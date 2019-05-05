using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseApp.Util
{
    class SqliteHelper
    {
        static string dbPath = "Data Source =" + Application.StartupPath + "/DataBase.db3";

        private static SQLiteConnection getConnection()
        {
            SQLiteConnection connection = new SQLiteConnection(dbPath);
            connection.Open();
            return connection;
        }

        private static SQLiteCommand prepareCommand(String sql, Dictionary<String, Object> parameters, SQLiteConnection connection)
        {

            SQLiteCommand command = new SQLiteCommand(sql, connection);

            command = prepareParameter(command, parameters);
            return command;
        }

        private static SQLiteCommand prepareParameter(SQLiteCommand command, Dictionary<String, Object> parameters = null)
        {
            if (parameters == null || parameters.Count == 0)
            {
                return command;
            }
            foreach (String key in parameters.Keys)
            {
                SQLiteParameter parameter = new SQLiteParameter(key, parameters[key]);
                command.Parameters.Add(parameter);
            }
            return command;
        }

        public static DataTable findList(String sql, Dictionary<String, Object> parameters = null, CommandBehavior behavior = CommandBehavior.Default)
        {
            SQLiteConnection connection = null;
            SQLiteDataReader reader = null;
            try
            {
                connection = getConnection();
                SQLiteCommand command = prepareCommand(sql, parameters, connection);
                reader = command.ExecuteReader(behavior);
                DataTable result = new DataTable();
                result.Load(reader);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        

        public static int excuteNoQuery(String sql, Dictionary<String, Object> parameters = null)
        {
            SQLiteConnection connection = null;
            try
            {
                connection = getConnection();
                SQLiteCommand command = prepareCommand(sql, parameters, connection);
                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public static Object executeScalar(String sql, Dictionary<String, Object> parameters = null)
        {
            SQLiteConnection connection = null;
            try
            {
                connection = getConnection();
                SQLiteCommand command = prepareCommand(sql, parameters, connection);
                Object value = command.ExecuteScalar();

                return value;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public static bool excuteBatch(String sql, List<Dictionary<String, Object>> parametersList = null)
        {
            SQLiteConnection connection = null;
            try
            {
                if (parametersList == null)
                {
                    return false;
                }
                int count = 0;
                connection = getConnection();

                foreach (Dictionary<String, Object> parameters in parametersList)
                {
                    SQLiteCommand command = prepareCommand(sql, parameters, connection);
                    command.ExecuteNonQuery();
                    count++;
                }

                return count > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
