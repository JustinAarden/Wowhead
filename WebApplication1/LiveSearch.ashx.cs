using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wowhead
{
    using BusinessLayer;

    using Entities;

    /// <summary>
    /// Summary description for LiveSearch
    /// </summary>
    public class LiveSearch : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string searchstring = context.Request.Params["searchstring"];
            string cbItem = context.Request.Params["cbItem"];
            string cbClass = context.Request.Params["cbClass"];
            string cbGuide = context.Request.Params["cbGuide"];

            if (cbItem == "true")
            {
                string html = "";

                // Doe database query met LIKE
                List<Item> itemList = BLItem.gridviewitem(searchstring);
                foreach (Item Item in itemList)
                {
                    html += Item.Name + "<br>";
                }

                context.Response.Write(html); 
            }
            else if (cbClass == "true")
            {
                string html = "";
                List<Classes> classList = BlClass.gridviewclasses(searchstring);
                foreach (Classes Class in classList)
                {
                    html += Class.Name + " - " + Class.Specs + "<br>";
                }
                context.Response.Write(html); 
            }
            else if (cbGuide == "true")
            {
                string html = "";
                List<Guide> guideList = BlGuides.gridviewguide(searchstring);
                foreach (Guide guide in guideList)
                {
                    html += guide.Name + " - " + guide.Author + "<br>";
                }
                context.Response.Write(html);
            }

        }
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}