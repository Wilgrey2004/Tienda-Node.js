using System.Web;
using System.Web.Mvc;

namespace Api_Tienda_Virtual
{
        public class FilterConfig
        {
                public static void RegisterGlobalFilters( GlobalFilterCollection filters ) {
                        filters.Add(new HandleErrorAttribute());
                }
        }
}
