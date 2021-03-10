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
    public static class DBHandler
    {
        //private
        private static SQLiteConnection DBConn;

        private static SQLiteCommand DBCmd;

        private static SQLiteDataAdapter DBDA;

        private static List<SQLiteParameter> Params = new List<SQLiteParameter>();


        //Public
        public static DataTable DBDT;
        public static int RecordCount;
        public static string Exception;
        public static EventHandler ConnectionChanged { get; set; }
        
        public static void SetConnection(string filePath)
        {
            DBConn = new SQLiteConnection();
            DBConn.ConnectionString = "Data Source =" + filePath + "; Version = 3; FailIfMissing=True";
            if (ConnectionChanged != null)
                ConnectionChanged.Invoke(new object(), new EventArgs());
        }
        public static bool Error()
        {
            return !string.IsNullOrEmpty(Exception) || DBDT == null;
        }
        public static bool TryOpen()
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
        public static void Close()
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

        public static int GetLastInsertId()
        {
            return (int)DBConn.LastInsertRowId;
        }

        public static void ExecQuery(string Query)
        {
            long x = DBConn.LastInsertRowId;
            RecordCount = 0;
            Exception = string.Empty;

            try
            {
                DBCmd = new SQLiteCommand(Query, DBConn);

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
        public static void AddParam(string Name, object Value)
        {
            SQLiteParameter NewParam = new SQLiteParameter(Name, Value);
            Params.Add(NewParam);
        }

        //private static string artiklarQuery = "CREATE TABLE IF NOT EXISTS \"artiklar\" (\"Id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, \"Besk\" TEXT, \"Stoldtag\", \"Datornamn\" TEXT, \"SerieNr\" TEXT, \"Mac\" TEXT, \"Os\" TEXT, \"Inkop\" TEXT, \"AndvandInkop\" INTEGER NOT NULL DEFAULT 0, \"Ovrigt\" TEXT, \"Status\" INTEGER NOT NULL DEFAULT 0, PersId INTEGER)";
        //private static string personerQuery = "CREATE TABLE IF NOT EXISTS \"personer\" (\"Id\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, \"Fornamn\" TEXT, \"Efternamn\", \"PersNr\" TEXT, \"Sign\" TEXT, \"Epost\" TEXT, \"Telefon\" TEXT, \"Tillhorighet\" TEXT, \"Ovrigt\" TEXT)";
        public static bool CreateFile(string filNamn)
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
                            cmd.CommandText = File.ReadAllText("tables.sql3");
                            cmd.ExecuteNonQuery();
                        }
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
        //public static DataTable GetDataTable(string sql, string fileName)
        //{
        //    try
        //    {
        //        DataTable dt = new DataTable();
        //        using (var c = new SQLiteConnection(fileName))
        //        {
        //            c.Open();
        //            using (SQLiteCommand cmd = new SQLiteCommand(sql, c))
        //            {
        //                using (SQLiteDataReader rdr = cmd.ExecuteReader())
        //                {
        //                    dt.Load(rdr);
        //                    return dt;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        return null;
        //    }
        //}
    }
}
