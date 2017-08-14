using Network.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace Network.Presentation.Helpers
{
    public class CustomHelper
    {
        private const string sessionUser = "sessionUser";
        private static HttpSessionState Session { get { return HttpContext.Current.Session; } }

        public static bool IsLogado
        {
            get
            {
                return (Session[sessionUser] != null);
            }
        }

        public static ClienteModels UsuarioLogado
        {
            get
            {
                return GetLogin<ClienteModels>();
            }
        }

        public static void LogOff()
        {
            Session.Clear();
            Session.Abandon();
            Session.RemoveAll();
        }
        public static void SetId(int idloja)
        {
            Session[sessionUser] = idloja;
        }

        public static void SetLogin(object model)
        {
            Session[sessionUser] = model;
        }

        private static T GetLogin<T>() where T : class
        {
            return (T)Session[sessionUser];
        }

    }
}