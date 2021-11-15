using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace SQL
{
    public class DataBase
    {
        private static SQLiteConnection sqliteConnection;
        public DataBase()
        { }
        private static SQLiteConnection DbConnection()
        {
            string path = Directory.GetCurrentDirectory();
            sqliteConnection = new SQLiteConnection($"Data Source={path}/db.sqlite; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }
        public void CriarBancoSQLite()
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                SQLiteConnection.CreateFile(path + "/db.sqlite");
            }
            catch
            {
                throw;
            }
        }
        public void CriarTabelaSQlite()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Estoque (id int, produto Varchar(50), quantidade int, valor float)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetClientes()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Estoque";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetCliente(string name)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Estoque Where produto=" + name;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

