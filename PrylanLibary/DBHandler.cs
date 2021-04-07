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
        private SQLiteConnection DBConn;

        private SQLiteCommand DBCmd;

        private SQLiteDataAdapter DBDA;

        private List<SQLiteParameter> Params = new List<SQLiteParameter>();


        //Public
        public DataTable DBDT;
        public int RecordCount;
        public string Exception;
        
        public void SetConnection(string filePath, EventHandler connectionChanged)
        {
            DBConn = new SQLiteConnection();
            DBConn.ConnectionString = "Data Source =" + filePath + "; Version = 3; FailIfMissing=True";
            if (connectionChanged != null)
                connectionChanged.Invoke(DBConn.ConnectionString, new EventArgs());
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
                DBConn.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return DBConn.State == ConnectionState.Open;
        }
        public void Close()
        {
            Console.WriteLine("Stänger");
            try
            {
                if(DBConn.State != ConnectionState.Closed)
                    DBConn.Close();
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
                return (int)DBConn.LastInsertRowId;
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
                DBCmd = new SQLiteCommand(query, DBConn);

                Params.ForEach((SQLiteParameter p) => DBCmd.Parameters.Add(p));
                Params.Clear();

                DBDT = new DataTable();
                DBDA = new SQLiteDataAdapter(DBCmd);
                RecordCount = DBDA.Fill(DBDT);
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
            Params.Add(newParam);
        }

        //private static string artiklarQuery = "CREATE TABLE IF NOT EXISTS \"artiklar\" (\"Id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, \"Besk\" TEXT, \"Stoldtag\", \"Datornamn\" TEXT, \"SerieNr\" TEXT, \"Mac\" TEXT, \"Os\" TEXT, \"Inkop\" TEXT, \"AndvandInkop\" INTEGER NOT NULL DEFAULT 0, \"Ovrigt\" TEXT, \"Status\" INTEGER NOT NULL DEFAULT 0, PersId INTEGER)";
        //private static string personerQuery = "CREATE TABLE IF NOT EXISTS \"personer\" (\"Id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, \"Fornamn\" TEXT, \"Efternamn\", \"PersNr\" TEXT, \"Sign\" TEXT, \"Epost\" TEXT, \"Telefon\" TEXT, \"Tillhorighet\" TEXT, \"Ovrigt\" TEXT)";
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
