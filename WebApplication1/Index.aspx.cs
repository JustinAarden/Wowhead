using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;


namespace Wowhead
{
    public partial class WebForm1 : System.Web.UI.Page
     
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btSearch_Click(object sender, EventArgs e)
        {
            BusinessLayer.Item item = new BusinessLayer.Item();
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                int EnteredIntValue = 0;
                bool IsIntOrNot = false;
                IsIntOrNot = int.TryParse(txtSearch.Text, out EnteredIntValue);
                    if (IsIntOrNot)
                        {
                          txtSearch.Text = item.GetItemById(Convert.ToInt32(txtSearch.Text)).Name + " , " + item.GetItemById(Convert.ToInt32(txtSearch.Text)).Level;
                        }
                        else
                        {
                          txtSearch.Text = item.GetItemByName(txtSearch.Text).Level + " , " + item.GetItemByName(txtSearch.Text).Name;
                        }
            }
            else
            {
                txtSearch.Text = "Please enter a search string";
            }
        }


    }









}