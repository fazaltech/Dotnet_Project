using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using Microsoft.Data.Sqlite;

namespace Dotnet_Project
{
    public class SqliteCommand
    {
        public string commandText;
        public SQLiteConnection con;
        public SqliteConnection con1;
        public string v;

        public SqliteCommand(SqliteConnection con1)
        {
            this.con1 = con1;
        }

        public SqliteCommand(string v)
        {
            this.v = v;
        }

        public SqliteCommand(string commandText, SQLiteConnection con)
        {
            this.commandText = commandText;
            this.con = con;
        }

        public static implicit operator SqlCommand(SqliteCommand v)
        {
            throw new NotImplementedException();
        }
    }
}