using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace BlackBoard
{
    /// <summary>
    /// Connector class to interact with the database.
    /// </summary>
    class SQLiteConnector
    {
        SQLiteConnection my_connect;
        SQLiteCommand my_cmd;
        SQLiteTransaction my_txn;
        SQLiteDataAdapter da;

        public bool isOpen = false;

        string chain = @"Data Source=db/bb.db ; Version=3;datetimeformat=CurrentCulture";

        /// <summary>
        /// Opens a new connection to the database.
        /// </summary>
        public void Open()
        {
            my_connect= new SQLiteConnection(chain);
            my_connect.Open();
            my_cmd = my_connect.CreateCommand();
            my_txn = my_connect.BeginTransaction();
            isOpen = true;
        }

        /// <summary>
        /// Queries the database and returns a DataSet containing the information the database returns.
        /// </summary>
        /// <param name="Query">SQL code sent to the database as as query.</param>
        /// <returns>DataSet containing the queried information.</returns>
        public DataSet SelectDataSet(string Query)
        {
            DataSet ds = new DataSet();
            my_cmd.Connection = my_connect;
            my_cmd.Transaction = my_txn;
            da = new SQLiteDataAdapter(Query, my_connect);
            da.SelectCommand.Transaction = my_txn;
            da.Fill(ds);
            return ds;
        }

        /// <summary>
        /// Queries the database and returns a DataTable containing the information the database returns.
        /// </summary>
        /// <param name="Query">SQL code sent to the database as as query.</param>
        /// <returns>DataTable containing the queried information.</returns>
        public DataTable SelectTable (string Query)
        {
            DataSet ds = new DataSet();
            my_cmd.Connection = my_connect;
            my_cmd.Transaction = my_txn;
            da = new SQLiteDataAdapter(Query, my_connect);
            da.SelectCommand.Transaction = my_txn;
            da.Fill(ds);
            return ds.Tables[0];
        }

        /// <summary>
        /// Queries the database and returns a single string for use in single-item queries.
        /// </summary>
        /// <param name="Query">SQL code sent to the database as as query.</param>
        /// <returns>A single requested string.</returns>
        public string SelectSingle(string Query)
        {
            DataSet ds = new DataSet();
            my_cmd.Connection = my_connect;
            my_cmd.Transaction = my_txn;
            da = new SQLiteDataAdapter(Query, my_connect);
            da.SelectCommand.Transaction = my_txn;
            da.Fill(ds);
            return ds.Tables[0].Rows[0].ItemArray[0].ToString();


        }
        
        /// <summary>
        /// Sends a non-query command to the database.
        /// </summary>
        /// <param name="Query">SQL code sent to the database as an instruction.</param>
        public void Command(string Query)
        {
            my_cmd.Transaction = my_txn;
            my_cmd.CommandText = Query;
            my_cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Closes the connection to the database.
        /// </summary>
        public void Close()
        {
           if(isOpen)
            {
                my_txn.Commit();
                my_connect.Close();
                isOpen = false;
            }
        }
    }

}
