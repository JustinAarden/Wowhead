using System;
using System.Web.UI;
using BusinessLayer;

namespace Wowhead
{
    public partial class WebForm1 : Page

    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btSearch_Click(object sender, EventArgs e)
        {
            var guide = new BlGuides();
            var item = new BLItem();
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                int EnteredIntValue = 0;
                bool IsIntOrNot = false;
                IsIntOrNot = int.TryParse(txtSearch.Text, out EnteredIntValue);
                if (IsIntOrNot)
                {
                    txtSearch.Text = item.GetItemById(Convert.ToInt32(txtSearch.Text)).Name + " , " +
                                     item.GetItemById(Convert.ToInt32(txtSearch.Text)).Level;
                }
                else
                {
                    txtSearch.Text = item.GetItemByName(txtSearch.Text).Level + " , " +
                                     item.GetItemByName(txtSearch.Text).Name;
                }
            }
            else
            {
                txtSearch.Text = "Please enter a search string";
            }
        }
    }
}