﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Index.aspx.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Wowhead
{
    using System;
    using System.Web.UI;

    /// <summary>
    ///     The web form 1.
    /// </summary>
    public partial class WebForm1 : Page
    {
        #region Methods

        /// <summary>
        ///     BtSearchClick.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        protected void BtSearchClick(object sender, EventArgs e)
        {
            if (this.cbItem.Checked)
            {
                // txtSearch.Text = check.HandleItem((txtSearch.Text));
                var search = new SearchSession();
                search.SearchText = this.txtSearch.Text;
                search.checkboxItemChecked = this.cbItem.Checked;
                this.Session["SearchParams"] = search;
                this.Response.Redirect("Search.aspx");
            }
            else if (this.cbClass.Checked)
            {
                var search = new SearchSession();
                search.SearchText = this.txtSearch.Text;
                search.checkboxClassChecked = this.cbClass.Checked;
                this.Session["SearchParams"] = search;
                this.Response.Redirect("Search.aspx");
            }
            else if (this.cbGuide.Checked)
            {
                var search = new SearchSession();
                search.SearchText = this.txtSearch.Text;
                search.checkboxGuideChecked = this.cbGuide.Checked;
                this.Session["SearchParams"] = search;
                this.Response.Redirect("Search.aspx");
            }
            else if (this.txtSearch.Text == "Search")
            {
                this.txtSearch.Text = "Please enter a search criteria";
            }
            else
            {
                this.txtSearch.Text = "Please select an search checkbox";
            }
        }

        /// <summary>
        ///     The page_ load.
        /// </summary>
        /// <param name="sender">
        ///     The sender.
        /// </param>
        /// <param name="e">
        ///     The e.
        /// </param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Request.Params["error"] == "itemnotfound")
            {
                this.lbAlert.Visible = true;
                this.lbAlert.Text = "No Item Found Matching Your Criteria";
            }
            else if (this.Request.Params["error"] == "classnotfound")
            {
                this.lbAlert.Visible = true;
                this.lbAlert.Text = "No Class Found Matching Your Criteria";
            }
            else if (this.Request.Params["error"] == "guidenotfound")
            {
                this.lbAlert.Visible = true;
                this.lbAlert.Text = "No Guide Found Matching Your Criteria";
            }
        }

        #endregion
    }
}