using System;
using Entities;

namespace BusinessLayer
{
    public class IdOrNameCheck
    {
        public string HandleGuide(string txtSearch)
        {
            string txtGuide;
            var guide = new BlGuides();

            if (!string.IsNullOrEmpty(txtSearch))
            {
                int EnteredIntValue = 0;
                bool IsIntOrNot = false;
                IsIntOrNot = int.TryParse(txtSearch, out EnteredIntValue);
                if (IsIntOrNot)
                {
                    Guide guid = guide.GetGuideById(Convert.ToInt32(txtSearch));
                    if (guid != null)
                    {
                        txtGuide = guid.Name + " by " + guid.Author;
                    }
                    else
                    {
                        txtGuide = "Sorry No Guide Found Matching Your Criteria";
                    }
                }
                else
                {
                    Guide guid = guide.GetGuideByName(txtSearch);
                         if (guid != null)
                    {
                        txtGuide = guid.Name + " by " + guid.Author;
                    }
                    else
                    {
                        txtGuide = "Sorry No Guide Found Matching Your Criteria";
                    }
                }
            }

            else
            {
                txtGuide = "Please enter a Guide Name or ID";
            }
            return txtGuide;
        }



        public string HandleItem(string txtSearch)
        {
            string txtItem;
            var item = new BLItem();

            if (!string.IsNullOrEmpty(txtSearch))
            {
                int EnteredIntValue = 0;
                bool IsIntOrNot = false;
                IsIntOrNot = int.TryParse(txtSearch, out EnteredIntValue);
                if (IsIntOrNot)
                {
                    Item itm = item.GetItemById(Convert.ToInt32(txtSearch));
                    if (itm != null)
                    {
                        txtItem = itm.Name + " , " + itm.Level;
                    }
                    else
                    {
                        txtItem = "Sorry No Items Found Matching Your Criteria";
                    }
                }
                else
                {
                    Item itm = item.GetItemByName(txtSearch);
                    if (itm != null)
                    {
                        txtItem = itm.Name + " , " + itm.Level;
                    }
                    else
                    {
                        txtItem = "Sorry No Items Found Matching Your Criteria";
                    }
                }
            }
            else
            {
                txtItem = "Please enter a Name or ID";
            }
            return txtItem;
        }

        public string HandleClass(string txtSearch)
        {
            string txtClass;
            var classes = new BlClass();

            if (!string.IsNullOrEmpty(txtSearch))
            {
                int EnteredIntValue = 0;
                bool IsIntOrNot = false;
                IsIntOrNot = int.TryParse(txtSearch, out EnteredIntValue);
                if (IsIntOrNot)
                {
                    Classes clsses = classes.GetClassById(Convert.ToInt32(txtSearch));
                    if(clsses != null)
                    {
                        txtClass = clsses.Name;
                    }
                    else
                    {
                        txtClass = "Sorry No Classes Found Matching Your Criteria";
                    }
                }
                else
                {
                    Classes clsses = classes.GetClassByName(txtSearch);
                    if (clsses != null)
                    {
                        txtClass = clsses.Name;
                    }
                    else
                    {
                        txtClass = "Sorry No Classes Found Matching Your Criteria";
                    }
                }
            }
            else
            {
                txtClass = "Please enter a Name or ID";
            }
            return txtClass;
        }
    }
}