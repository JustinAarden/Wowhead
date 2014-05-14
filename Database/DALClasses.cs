using System.Data;
using Entities;
using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
    class DalClasses
    {
        public Classes GetClassById(int id)
        {
            Classes classes = null;

            using (var db = new Database())
            {
                db.OpenConnection();

                db.CreateCommand("SELECT * FROM Guide WHERE Guide_ID = " + id);
                MySqlDataReader dr = db.Command.ExecuteReader();
                while (dr.Read())
                {
                    classes = new Classes();
                    classes.Name = dr["name"].ToString();
                }
            }

            return classes;
        }


        public Classes GetClassByName(string name)
        {
            Classes classes = null;
            using (var db = new Database())
            {
                db.OpenConnection();
                db.CreateCommand("SELECT * FROM Item WHERE Name LIKE @name");
                db.AddParameter("@name", "%" + name + "%"); // Part of the string
                MySqlDataReader dr = db.Command.ExecuteReader();

                while (dr.Read())
                {
                    classes = new Classes();
                    classes.Name = dr["name"].ToString();
                }
            }

            return classes;
        }
    }
}
