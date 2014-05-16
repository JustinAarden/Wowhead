using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using Entities;


namespace BusinessLayer
{
    public class BlGuides
    {
        public Entities.Guide GetGuideById(int id)
        {
            DataAccessLayer.DalGuide dalguide = new DataAccessLayer.DalGuide();
            return dalguide.GetGuideById(id);
        }

        public Entities.Guide GetGuideByName(string name)
        {
            DataAccessLayer.DalGuide dalguide = new DataAccessLayer.DalGuide();
            return dalguide.GetGuideByName(name);
        }


        
    }
}
