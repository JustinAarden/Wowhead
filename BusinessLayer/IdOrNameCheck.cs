//using System;

//namespace BusinessLayer
//{
//    public class IdOrNameCheck
//    {
//        public void HandleGuide(string txtSearch);
//    {
//        var guide = new BlGuides();

//        if (!txtSearch.IsNullOrEmpty())
//        {
//            int EnteredIntValue = 0;
//            bool IsIntOrNot = false;
//            IsIntOrNot = int.TryParse(txtSearch, out EnteredIntValue);
//            if (IsIntOrNot)
//            {
//                string txtSearch = guide.GetGuideById(Convert.ToInt32(txtSearch)).Name + " , " +
//                                   guide.GetGuideById(Convert.ToInt32(txtSearch)).Author;
//            }
//            else
//            {
//                string txtSearch = guide.GetGuideByName(txtSearch).Author + " , " +
//                                   guide.GetGuideByName(txtSearch).Name;
//            }
//        }
//        else
//        {
//            string guideerror = "Please enter a search string";
//        }
//    }
//    }
//}