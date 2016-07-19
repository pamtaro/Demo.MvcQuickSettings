using DotNetNuke.Web.Mvc.Routing;

namespace Demo.MvcQuickSettings
{
    public class RouteConfig : IMvcRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapRoute("MvcQuickSettings", "MvcQuickSettings", "{controller}/{action}",
                new[] {"Demo.MvcQuickSettings.Controllers"});
        }
    }
}