using System.Data;
using Entities;
using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
    public class DalGuide
    {
        public Guide GetGuideById(int id)
        {
            Guide guide = null;
            using (var db = new Database())
            {
                db.OpenConnection();

                db.CreateCommand("SELECT Guide.Name, Author.Name AS Author FROM Guide, Author WHERE Guide.Author_ID=Author.Author_ID And Guide_ID = @id");
                db.AddParameter("@id", id);
                MySqlDataReader dr = db.Command.ExecuteReader();
                while (dr.Read())
                {
                    guide = new Guide();
                    guide.Name = dr["name"].ToString();
                    guide.Author= dr["author"].ToString();
                }
            }

            return guide;
        }


        public Guide GetGuideByName(string name)
        {
            Guide guide = null;
            using (var db = new Database())
            {
                db.OpenConnection();
                db.CreateCommand("SELECT Guide.Name, Author.Name AS Author FROM Guide, Author WHERE Guide.Author_ID=Author.Author_ID And Guide.Name LIKE @name");
                db.AddParameter("@name", "%" + name + "%"); // Part of the string
                MySqlDataReader dr = db.Command.ExecuteReader();

                while (dr.Read())
                {
                    guide = new Guide();
                    guide.Name = dr["name"].ToString();
                    guide.Author = dr["author"].ToString();
                }
            }

            return guide;
        }
    }
}
