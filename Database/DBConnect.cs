using System;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
    /// <summary>
    ///     Class used for the database interaction in the application.
    /// </summary>
    public class Database : IDisposable
    {
        public Database()
        {
            Connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["WowheadDB"].ConnectionString);
        }

        public MySqlConnection Connection { get; private set; }
        public MySqlCommand Command { get; private set; }

        public void Dispose()
        {
            CloseConnection();
        }


        /// <summary>
        ///     Opens the database connection.
        /// </summary>
        public void OpenConnection()
        {
            if (Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }
        }

        /// <summary>
        ///     Closes the database connection.
        /// </summary>
        public void CloseConnection()
        {
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
        }

        /// <summary>
        ///     Creates an command and binds it to the connection.
        /// </summary>
        public void CreateCommand(string commandText)
        {
            Debug.WriteLine(commandText);

            Command = Connection.CreateCommand();
            Command.CommandText = commandText;
        }

        /// <summary>
        ///     Binds a parameter to the command with the given value.
        /// </summary>
        public void AddParameter(string parameterName, object value)
        {
            AddParameter(parameterName, value, default(MySqlDbType));
        }

        /// <summary>
        ///     Binds a parameter to the command with the given value and type.
        /// </summary>
        public void AddParameter(string parameterName, object value, MySqlDbType type)
        {
            var parameter = new MySqlParameter();
            parameter.ParameterName = parameterName;
            parameter.Value = value;
            Command.Parameters.Add(parameter);
        }


    }
}