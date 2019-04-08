using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrpzMvc.Helpers
{
    public static class BackgroundChangeHelper
    {
        public static MvcHtmlString ChangeBackground(this HtmlHelper html, int index)
        {
            switch (index)
            {
                case 1:
                    return new MvcHtmlString("<div class=\"content info_body\">");
                case 2:
                    return new MvcHtmlString("<div class=\"content contact_body\">");
                default:
                    return new MvcHtmlString("<div class=\"content\">");
            }

        }
    }
}