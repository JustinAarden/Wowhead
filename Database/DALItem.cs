﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DALItem.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System.Collections.Generic;

    using Entities;

    using MySql.Data.MySqlClient;

    public class DalItem
    {
        #region Public Methods and Operators

        public List<Item> ItemsGridview(string name)
        {
            var griditems = new List<Item>();
            Item item = null;
            using (var db = new Database())
            {
                db.OpenConnection();
                db.CreateCommand(
                    "SELECT Item.*, Quality.Name AS Quality FROM Item, Quality WHERE Item.Quality_ID=Quality.Quality_ID AND Item.Name LIKE @name");
                db.AddParameter("@name", "%" + name + "%");
                MySqlDataReader dr = db.Command.ExecuteReader();

                while (dr.Read())
                {
                    item = new Item();
                    item.Name = (string)dr["name"];
                    item.Level = (int)dr["level"];
                    item.ReqLevel = (int)dr["Reqlevel"];
                    item.Quality = (string)dr["Quality"];
                    griditems.Add(item);
                }
            }

            return griditems;
        }

        #endregion
    }
}