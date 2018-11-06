using System.Web;
using System.Web.Mvc;

namespace Coffee_Shop_Web_App_Lab_21
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
