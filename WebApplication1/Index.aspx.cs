using System;
using System.Web.UI;
using BusinessLayer;
using Entities;

namespace Wowhead
{
    public partial class WebForm1 : Page

    {
        private IdOrNameCheck check = new IdOrNameCheck();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void RadioButtonHandler()
        {
            if (cbItem.Checked == true)
            {
                txtSearch.Text = "item:";
            }
        }
        protected void btSearch_Click(object sender, EventArgs e)
        {

            if (cbItem.Checked == true)
            {
                txtSearch.Text = check.HandleItem((txtSearch.Text));

            }
            else if (cbClass.Checked == true)
            {
                txtSearch.Text = check.HandleClass((txtSearch.Text));
            }
            else if (cbGuide.Checked == true)
            {
                txtSearch.Text = check.HandleGuide((txtSearch.Text));
            }
            else
            {
                txtSearch.Text = "Please select an search checkbox";
            }


        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}