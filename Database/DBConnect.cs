// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DBConnect.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Configuration;
    using System.Data;
    using System.Diagnostics;

    using MySql.Data.MySqlClient;

    /// <summary>
    ///     Class used for the database interaction in the application.
    /// </summary>
    public class Database : IDisposable
    {
        #region Constructors and Destructors

        public Database()
        {
            this.Connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["WowheadDB"].ConnectionString);
        }

        #endregion

        #region Public Properties

        public MySqlCommand Command { get; private set; }

        public MySqlConnection Connection { get; private set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Binds a parameter to the command with the given value.
        /// </summary>
        public void AddParameter(string parameterName, object value)
        {
            this.AddParameter(parameterName, value, default(MySqlDbType));
        }

        /// <summary>
        ///     Binds a parameter to the command with the given value and type.
        /// </summary>
        public void AddParameter(string parameterName, object value, MySqlDbType type)
        {
            var parameter = new MySqlParameter();
            parameter.ParameterName = parameterName;
            parameter.Value = value;
            this.Command.Parameters.Add(parameter);
        }

        /// <summary>
        ///     Closes the database connection.
        /// </summary>
        public void CloseConnection()
        {
            if (this.Connection.State != ConnectionState.Closed)
            {
                this.Connection.Close();
            }
        }

        /// <summary>
        ///     Creates an command and binds it to the connection.
        /// </summary>
        public void CreateCommand(string commandText)
        {
            Debug.WriteLine(commandText);

            this.Command = this.Connection.CreateCommand();
            this.Command.CommandText = commandText;
        }

        public void Dispose()
        {
            this.CloseConnection();
        }

        /// <summary>
        ///     Opens the database connection.
        /// </summary>
        public void OpenConnection()
        {
            if (this.Connection.State != ConnectionState.Open)
            {
                this.Connection.Open();
            }
        }

        #endregion
    }
}