using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;

namespace PrylanLibary
{
    class DBHandler
    {
        //private
        private SQLiteConnection dbConn;
        private SQLiteCommand dbCmd;
        private SQLiteDataAdapter dbda;
        private readonly List<SQLiteParameter> parameters = new List<SQLiteParameter>();


        //Public
        public DataTable DBDT { get; set; }
        public int RecordCount { get; set; }
        public string Exception { get; set; }
        
        public void SetConnection(string filePath, EventHandler connectionChanged)
        {
            dbConn = new SQLiteConnection
            {
                ConnectionString = "Data Source =" + filePath + "; Version = 3; FailIfMissing=True"
            };
            connectionChanged?.Invoke(dbConn.ConnectionString, new EventArgs());
        }
        public bool Error()
        {
            return !string.IsNullOrEmpty(Exception) || DBDT == null;
        }
        public bool TryOpen()
        {
            Console.WriteLine("Öppnar");
            try
            {
                dbConn.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return dbConn.State == ConnectionState.Open;
        }
        public void Close()
        {
            Console.WriteLine("Stänger");
            try
            {
                if(dbConn.State != ConnectionState.Closed)
                    dbConn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int GetLastInsertId()
        {
            try
            {
                return (int)dbConn.LastInsertRowId;
            }
            catch
            {
                return 0;
            }
        }

        public void ExecQuery(string query)
        {
            RecordCount = 0;
            Exception = string.Empty;

            try
            {
                dbCmd = new SQLiteCommand(query, dbConn);

                parameters.ForEach((SQLiteParameter p) => dbCmd.Parameters.Add(p));
                parameters.Clear();

                DBDT = new DataTable();
                dbda = new SQLiteDataAdapter(dbCmd);
                RecordCount = dbda.Fill(DBDT);
            }
            catch (Exception ex)
            {
                Exception = ex.Message;
                Console.WriteLine(Exception);
            }
        }

        public void AddParam(string name, object value)
        {
            SQLiteParameter newParam = new SQLiteParameter(name, value);
            parameters.Add(newParam);
        }

        public bool CreateFile(string filNamn)
        {
            if (!File.Exists(filNamn))
            {
                SQLiteConnection.CreateFile(filNamn);
                try
                {
                    using (var connection = new SQLiteConnection($"DataSource={filNamn}; Version=3"))
                    {
                        connection.Open();
                        using (SQLiteCommand cmd = new SQLiteCommand(connection))
                        {
                            cmd.CommandText = File.ReadAllText(Config.TABLE_QUERIES_FILENAME);
                            cmd.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                    return File.Exists(filNamn);
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
