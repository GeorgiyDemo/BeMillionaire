using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace BeMillionaire
{
    class SQLiteClass
    {

        public static void SQLiteExecute(string sql)
        {

            SqliteConnection myConn = new SqliteConnection("DataSource=MillionDatabase.db;");
            SqliteCommand sqCommand = new SqliteCommand(sql);
            sqCommand.Connection = myConn;
            myConn.Open();
            try
            {
                sqCommand.ExecuteNonQuery();
            }
            finally
            {
                myConn.Close();
            }
        }

        public static string SQLiteGet(string sql)
        {
            string outstr = "";
            using (SqliteConnection con = new SqliteConnection("DataSource=../../database.db;"))
            {
                con.Open();

                using (SqliteCommand cmd = new SqliteCommand(sql, con))
                {
                    using (SqliteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                            outstr += rdr.GetString(0);
                    }
                }

                con.Close();
            }

            return outstr;
        }
    }
}
