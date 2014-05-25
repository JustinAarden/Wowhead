// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DALItem.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------



using System.Collections.Generic;
using System.Data;

using Entities;

using MySql.Data.MySqlClient;

namespace DataAccessLayer
{
    public class DalItem
    {
        public Item GetItemById(int id)
        {
            Item item = null;
            using (var db = new Database())
            {
                db.OpenConnection();

                db.CreateCommand("SELECT * FROM Item WHERE Item_ID = " + id);
                MySqlDataReader dr = db.Command.ExecuteReader();
                while (dr.Read())
                {
                    item = new Item();
                    item.Name = dr["name"].ToString();

                    //item.Level = dr["level"].ToString();
                }
            }

            return item;
        }

        /// <summary>
        ///     This method will search for the item by
        ///     name. It will work with the full name
        ///     or just a keyword
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Item GetItemByName(string name)
        {
            Item item = null;
            using (var db = new Database())
            {
                db.OpenConnection();
                db.CreateCommand("SELECT * FROM Item WHERE Name LIKE @name");
                db.AddParameter("@name", "%" + name + "%"); // Part of the string
                MySqlDataReader dr = db.Command.ExecuteReader();

                while (dr.Read())
                {
                    item = new Item();
                    item.Name = dr["name"].ToString();

                    //item.Level = dr["level"].ToString();
                }
            }

            return item;
        }

        public List<Item> ItemsGridview(string name)
        {
            var griditems = new List<Item>();
            Item item = null;
            using (var db = new Database())
            {
                db.OpenConnection();
                db.CreateCommand("SELECT Item.*, Quality.Name AS Quality FROM Item, Quality WHERE Item.Quality_ID=Quality.Quality_ID AND Item.Name LIKE @name");
                db.AddParameter("@name", "%" + name + "%");
                MySqlDataReader dr = db.Command.ExecuteReader();


                while (dr.Read())
                {
                    item = new Item();
                    item.Name = (string) dr["name"];
                    item.Level = (int) dr["level"];
                    item.ReqLevel = (int) dr["Reqlevel"];
                    item.Quality = (string) dr["Quality"];
                    griditems.Add(item);
                }
            }

            return griditems;
        }
    }
}