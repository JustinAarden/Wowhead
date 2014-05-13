using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data;

namespace DataAccessLayer
{

    public class DalItem
    {
        public Item GetItemById(int id)
        {
            Item item = null;
            using (Database db = new Database())
            {
                db.OpenConnection();

                db.CreateCommand("SELECT * FROM Item WHERE Item_ID = " + id.ToString());
                MySqlDataReader dr = db.Command.ExecuteReader();
                while (dr.Read())
                {
                    item = new Item();
                    item.Name = dr["name"].ToString();
                    item.Level = dr["level"].ToString();
                }
            }

            return item;
        }
        }
    }