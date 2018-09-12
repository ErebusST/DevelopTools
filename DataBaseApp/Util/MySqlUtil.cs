using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseApp.Util
{
    public class MySqlUtil
    {
        public static String getConnectionStr(String host, String port, String userName, String passWord)
        {
            MySql.Data.MySqlClient.MySqlConnectionStringBuilder builder = new MySql.Data.MySqlClient.MySqlConnectionStringBuilder();
            builder.Server = host;
            builder.Port = UInt32.Parse(port);
            //builder.Database = dataBaseName;
            builder.UserID = userName;
            builder.Password = passWord;

            return builder.GetConnectionString(true);
            //return String.Format("host={0};database={1};uid={2};pwd={3};charset=UTF-8", host, dataBaseName, userName, passWord);
        }

        public static String getConnectionStr(String host, String port, String userName, String passWord, String dataBase)
        {
            MySql.Data.MySqlClient.MySqlConnectionStringBuilder builder = new MySql.Data.MySqlClient.MySqlConnectionStringBuilder();
            builder.Server = host;
            builder.Port = UInt32.Parse(port);
            //builder.Database = dataBaseName;
            builder.UserID = userName;
            builder.Password = passWord;
            builder.Database = dataBase;
            return builder.GetConnectionString(true);
            //return String.Format("host={0};database={1};uid={2};pwd={3};charset=UTF-8", host, dataBaseName, userName, passWord);
        }

        public static DataTable getDateTable(String connStr, String sql)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    MySqlCommand command = new MySqlCommand(sql, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static MySqlConnection getConn(String connectionString)
        {
            return new MySqlConnection(connectionString);
        }

        public static DataTable getDateTable(MySqlConnection connection, String sql)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(sql, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static bool ExecuteNonQuery(MySqlTransaction transaction, String sql, Dictionary<String, Object> parameters)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(sql, transaction.Connection);
                foreach (String key in parameters.Keys)
                {
                    Object value = parameters[key];
                    command.Parameters.AddWithValue(key, value);
                }
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static DataTable getSchema(String connStr, String schemaName)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    return conn.GetSchema(schemaName);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }


}
