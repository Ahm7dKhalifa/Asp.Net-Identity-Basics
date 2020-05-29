using System.Web;
using System.Web.Mvc;

namespace Email_Verification_Password_Reset
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
