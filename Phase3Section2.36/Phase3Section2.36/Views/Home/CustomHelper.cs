using System;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Phase3Section3._36.Views.Home
{
    public class CustomHelper
    {
        public static IHtmlContent File(string id)
        {
            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("type", "file");
            tb.Attributes.Add("id", id);
            return new HtmlString(tb.ToString());
        }
    }
}
