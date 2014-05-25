// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Search.aspx.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BusinessLayer;

using Entities;

namespace Wowhead
{
    using System.Security.Cryptography.X509Certificates;

    public partial class Search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SearchSession search = (SearchSession)Session["SearchParams"];
            if (search.checkboxItemChecked)
            {
                List<Item> itemList = BLItem.gridviewitem(search.SearchText);
                if (itemList.Count != 0)
                {
                    GridItem.DataSource = itemList;
                    GridItem.DataBind();
                    GridItem.Visible = true;
                }
                else
                {
                    
                    lbNotFound.Text = "No Item Found Matching Your Criteria";
                    lbNotFound.Visible = true;
                }

            }
            else if (search.checkboxClassChecked)
            {
                List<Classes> classlist = BlClass.gridviewclasses(search.SearchText);
                if (classlist.Count != 0)
                {
                    GridClass.DataSource = classlist;
                    GridClass.DataBind();
                    GridClass.Visible = true;
                }
                else
                {
                    lbNotFound.Text = "No Class Found Matching Your Criteria";
                    lbNotFound.Visible = true;
                }
            }
            else if (search.checkboxGuideChecked)
            {
                List<Guide> guidelist = BlGuides.gridviewguide(search.SearchText);
                if(guidelist.Count != 0)
                {
                    GridGuide.DataSource = guidelist;
                    GridGuide.DataBind();
                    GridGuide.Visible = true;
                }
                else
                {
                    lbNotFound.Text = "No Guide Found Matching Your Criteria";
                    lbNotFound.Visible = true;
                }
            }

        }

        protected void btNewSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}