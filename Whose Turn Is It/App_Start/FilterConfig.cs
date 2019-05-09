using System.Web;
using System.Web.Mvc;

namespace Whose_Turn_Is_It
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
