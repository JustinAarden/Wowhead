// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Search.aspx.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Wowhead
{
    using System;
    using System.Collections.Generic;
    using System.Web.UI;

    using BusinessLayer;

    using Entities;

    public partial class Search : Page
    {
        #region Methods

        protected void BtNewSearchClick1(object sender, EventArgs e)
        {
            this.Response.Redirect("Index.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var search = (SearchSession)this.Session["SearchParams"];
            if (search.checkboxItemChecked)
            {
                List<Item> itemList = BLItem.Gridviewitem(search.SearchText);
                if (itemList.Count != 0)
                {
                    this.GridItem.DataSource = itemList;
                    this.GridItem.DataBind();
                    this.GridItem.Visible = true;
                }
                else
                {
                    this.Response.Redirect("Index.aspx?error=itemnotfound");
                }
            }
            else if (search.checkboxClassChecked)
            {
                List<Classes> classlist = BlClass.Gridviewclasses(search.SearchText);
                if (classlist.Count != 0)
                {
                    this.GridClass.DataSource = classlist;
                    this.GridClass.DataBind();
                    this.GridClass.Visible = true;
                }
                else
                {
                    this.Response.Redirect("Index.aspx?error=classnotfound");
                }
            }
            else if (search.checkboxGuideChecked)
            {
                List<Guide> guidelist = BlGuides.Gridviewguide(search.SearchText);
                if (guidelist.Count != 0)
                {
                    this.GridGuide.DataSource = guidelist;
                    this.GridGuide.DataBind();
                    this.GridGuide.Visible = true;
                }
                else
                {
                    this.Response.Redirect("Index.aspx?error=guidenotfound");
                }
            }
        }

        #endregion
    }
}