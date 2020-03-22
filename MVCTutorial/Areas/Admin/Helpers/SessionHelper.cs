using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorial.Areas.Admin.Helpers
{
    public class SessionHelper
    {
        public static void SetSession(UserSession sessionName)
        {
            HttpContext.Current.Session["loginSession"] = sessionName;
        }

        public static UserSession GetSession()
        {
            var sesion = HttpContext.Current.Session["loginSession"];
            if (sesion ==null)
            {
                return null;
            }

            return sesion as  UserSession;
        }
    }
}