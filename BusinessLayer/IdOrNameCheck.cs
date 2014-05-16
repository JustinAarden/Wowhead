using System;
using System.Security.Cryptography.X509Certificates;
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
                txtGuide = guide.GetGuideById(Convert.ToInt32(txtSearch)).Name + " , " +
                                   guide.GetGuideById(Convert.ToInt32(txtSearch)).Author;
            }
            else
            {
                txtGuide = guide.GetGuideByName(txtSearch).Author + " , " +
                                   guide.GetGuideByName(txtSearch).Name;
            }
        }
        else
        {
            txtGuide = "guide: Please enter a Name or ID";
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
                    txtItem = item.GetItemById(Convert.ToInt32(txtSearch)).Name + " , " +
                              item.GetItemById(Convert.ToInt32(txtSearch)).Level;
                }
                else
                {
                    txtItem = item.GetItemByName(txtSearch).Level + " , " +
                                       item.GetItemByName(txtSearch).Name;
                }
            }
            else
            {
                txtItem = "item: Please enter a Name or ID";
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
                    txtClass = classes.GetClassById(Convert.ToInt32(txtSearch)).Name;
                }
                else
                {
                    txtClass = classes.GetClassByName(txtSearch).Name;
                }
            }
            else
            {
                txtClass = "class: Please enter a Name or ID";
            }
            return txtClass;

        }
    }
}