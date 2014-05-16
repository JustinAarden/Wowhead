using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Entities;

namespace BusinessLayer
{
     public class Item
    {

         public Entities.Item GetItemById(int id)
         {
             DataAccessLayer.ItemFactory itemFactory = new DataAccessLayer.ItemFactory();
             return itemFactory.GetItemById(id);
         }

         public Entities.Item GetItemByName(string name)
         {
             DataAccessLayer.ItemFactory itemFactory = new DataAccessLayer.ItemFactory();
             return itemFactory.GetItemByName(name);
          }
         

    }
}
