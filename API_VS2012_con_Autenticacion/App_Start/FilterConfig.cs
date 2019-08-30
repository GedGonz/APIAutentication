using System.Web;
using System.Web.Mvc;

namespace API_VS2012_con_Autenticacion
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}