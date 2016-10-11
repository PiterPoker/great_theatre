using System.Web.Mvc;
using System.Web.Routing;

namespace great_theatre.Helpers
{
    public static class HtmlExtensions
    {
        public static MvcHtmlString MyActonLink(
            this HtmlHelper html,
            string linkText,
            string action,
            string controller,
            object htmlAttributes
            )
        {
            var urlHelper = new UrlHelper(html.ViewContext.RequestContext);
            var url = urlHelper.Action(action, controller);
            var anchor = new TagBuilder("a")
            {
                InnerHtml = linkText
            };
            anchor.Attributes["href"] = url;
            anchor.MergeAttributes(new RouteValueDictionary(htmlAttributes));
            return MvcHtmlString.Create(anchor.ToString());
        }

        public static MvcHtmlString UserActonLink(
            this HtmlHelper html,
            string linkText,
            string action,
            string controller,
            object routeValues,
            object htmlAttributes
            )
        {
            var urlHelper = new UrlHelper(html.ViewContext.RequestContext);
            var url = urlHelper.Action(action, controller, routeValues);
            var anchor = new TagBuilder("a")
            {
                InnerHtml = linkText
            };
            anchor.Attributes["href"] = url;
            anchor.MergeAttributes(new RouteValueDictionary(htmlAttributes));
            return MvcHtmlString.Create(anchor.ToString());
        }
    }
}