// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LiveSearch.ashx.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Wowhead
{
    using System.Collections.Generic;
    using System.Web;

    using BusinessLayer;

    using Entities;

    /// <summary>
    ///     Summary description for LiveSearch
    /// </summary>
    public class LiveSearch : IHttpHandler
    {
        #region Public Properties

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        #endregion

        #region Public Methods and Operators

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string searchstring = context.Request.Params["searchstring"];
            string cbItem = context.Request.Params["cbItem"];
            string cbClass = context.Request.Params["cbClass"];
            string cbGuide = context.Request.Params["cbGuide"];

            if (cbItem == "true")
            {
                string html = string.Empty;

                // Doe database query met LIKE
                List<Item> itemList = BLItem.Gridviewitem(searchstring);
                foreach (Item item in itemList)
                {
                    html += item.Name + "<br>";
                }

                context.Response.Write(html);
            }
            else if (cbClass == "true")
            {
                string html = string.Empty;
                List<Classes> classList = BlClass.Gridviewclasses(searchstring);
                foreach (Classes classes in classList)
                {
                    html += classes.Name + " - " + classes.Specs + "<br>";
                }
                context.Response.Write(html);
            }
            else if (cbGuide == "true")
            {
                string html = string.Empty;
                List<Guide> guideList = BlGuides.Gridviewguide(searchstring);
                foreach (Guide guide in guideList)
                {
                    html += guide.Name + " - " + guide.Author + "<br>";
                }
                context.Response.Write(html);
            }
        }

        #endregion
    }
}