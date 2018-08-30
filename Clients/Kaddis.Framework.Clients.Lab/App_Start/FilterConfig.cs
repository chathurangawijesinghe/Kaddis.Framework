using System.Web;
using System.Web.Mvc;

namespace Kaddis.Framework.Clients.Lab
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
