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

    public class ItemFactory
    {
        public Item GetItemById(int id)
        {
            Item item = null;
            using (Database db = new Database())
            {
                db.OpenConnection();

                db.CreateCommand("SELECT * FROM Item WHERE Item_ID = " + id.ToString());
                //db.AddParameter("itemid", id);

                MySqlDataReader dr = db.Command.ExecuteReader();

                //MySqlDataReader dr = db.DataReader;
                while (dr.Read())
                {
                    item = new Item();
                    item.Name = dr["name"].ToString();
                    item.Level = dr["level"].ToString();

                }
            }

            return item;
        }

        public Item GetItemByName(string name)
        {
            Item item = null;
            using (Database db = new Database())
            {
                db.OpenConnection();

                //db.CreateCommand("SELECT * FROM Item WHERE Name = @name");
                //db.AddParameter("@name", name);
                db.CreateCommand("SELECT * FROM Item WHERE Name LIKE @name");
                db.AddParameter("@name", "%" + name + "%"); // Part of the string
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

        public Item ItemGridview(string name)
        {
            Item item = null;
            using (Database db = new Database())
            {
                db.OpenConnection();

                db.CreateCommand("SELECT * FROM Item");
                DataTable datatableitems = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.Fill(datatableitems);
            }

            return item;
        }
    }
}
