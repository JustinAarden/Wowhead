using System;
using System.Web.UI;
using BusinessLayer;
using Entities;

namespace Wowhead
{
    using System.Web.SessionState;

    public partial class WebForm1 : Page

    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["error"] == "itemnotfound")
            {
                txtSearch.Text = "No Item Found Matching Your Criteria";
            }
            else if (Request.Params["error"] == "classnotfound")
            {
                txtSearch.Text = "No Class Found Matching Your Criteria";
            }
            else if (Request.Params["error"] == "guidenotfound")
            {
                txtSearch.Text = "No Guide Found Matching Your Criteria";
            }
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
              
                //txtSearch.Text = check.HandleItem((txtSearch.Text));
                SearchSession search = new SearchSession();
                search.SearchText = txtSearch.Text;
                search.checkboxItemChecked = cbItem.Checked;
                Session["SearchParams"] = search;
                Response.Redirect("Search.aspx");

            }
            else if (cbClass.Checked == true)
            {
                SearchSession search = new SearchSession();
                search.SearchText = txtSearch.Text;
                search.checkboxClassChecked = cbClass.Checked;
                Session["SearchParams"] = search;
                Response.Redirect("Search.aspx");
            }
            else if (cbGuide.Checked == true)
            {
                SearchSession search = new SearchSession();
                search.SearchText = txtSearch.Text;
                search.checkboxGuideChecked = cbGuide.Checked;
                Session["SearchParams"] = search;
                Response.Redirect("Search.aspx");
            }
            else if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "Please enter a search criteria";
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