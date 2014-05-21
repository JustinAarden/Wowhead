using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Entities;

namespace BusinessLayer
{
     public class BLItem
    {

         public Entities.Item GetItemById(int id)
         {
             DataAccessLayer.DalItem itemFactory = new DataAccessLayer.DalItem();
             return itemFactory.GetItemById(id);
         }

         public Entities.Item GetItemByName(string name)
         {
             DataAccessLayer.DalItem itemFactory = new DataAccessLayer.DalItem();
             return itemFactory.GetItemByName(name);
          }

         public List<Entities.Item> gridviewitem(string name)
         {
             DataAccessLayer.DalItem itemfactory = new DataAccessLayer.DalItem();
             return itemfactory.ItemsGridview(name);
         }
         
    }
}
