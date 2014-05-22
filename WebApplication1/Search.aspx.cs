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
    public partial class Search : System.Web.UI.Page
    {
        private IdOrNameCheck check = new IdOrNameCheck();
        protected void Page_Load(object sender, EventArgs e)
        {
            SearchSession search = (SearchSession)Session["SearchParams"];
            if (search.checkboxItemChecked)
            {
                List<Entities.Item> itemList = BLItem.gridviewitem(search.SearchText);
                GridView1.DataSource = itemList;
                GridView1.DataBind();
            }
            else if (search.checkboxClassChecked)
            {
              //txtSearch2.Text = check.HandleItem((search.SearchText));
            }

        }
    }
}