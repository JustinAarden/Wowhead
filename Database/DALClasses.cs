// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DALClasses.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System.Collections.Generic;

    using Entities;

    using MySql.Data.MySqlClient;

    public class DalClasses
    {
        #region Public Methods and Operators

        public List<Classes> ClassesGridview(string name)
        {
            var gridclasses = new List<Classes>();
            Classes classes = null;
            using (var db = new Database())
            {
                db.OpenConnection();
                db.CreateCommand(
                    "SELECT Class.*, Spec.Name AS Spec FROM Class, Spec WHERE Class.Class_ID=Spec.Class_ID AND Class.Name LIKE @name");
                db.AddParameter("@name", "%" + name + "%");
                MySqlDataReader dr = db.Command.ExecuteReader();

                while (dr.Read())
                {
                    classes = new Classes();
                    classes.Name = (string)dr["name"];
                    classes.Specs = (string)dr["spec"];
                    gridclasses.Add(classes);
                }
            }

            return gridclasses;
        }

        #endregion
    }
}