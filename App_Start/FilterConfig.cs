using System.Web;
using System.Web.Mvc;

namespace LuongMinhPhat_kiemtraFe
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
