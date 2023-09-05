using System.Web;
using System.Web.Mvc;

namespace ASPSec9_UPI_customization
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
