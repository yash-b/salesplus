/*
Project created by:
      Yash Bhambhani
     yash-b.github.io
yash.bhambhani96@gmail.com
*/

using System.Web.Mvc;

namespace IdentitySample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
