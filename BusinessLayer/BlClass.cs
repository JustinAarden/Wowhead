using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace BusinessLayer
{
    class BlClass
    {
        public Entities.Classes GetClassById(int id)
        {
            DataAccessLayer.DalClasses dalclass = new DataAccessLayer.DalClasses();
            return dalclass.GetClassById(id);
        }

        public Entities.Classes GetClassByName(string name)
        {
            DataAccessLayer.DalClasses dalclass = new DataAccessLayer.DalClasses();
            return dalclass.GetClassByName(name);
        }
    }
}
