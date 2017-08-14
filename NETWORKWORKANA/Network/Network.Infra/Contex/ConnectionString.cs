using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network.Infra.Contex
{
    public class ConnectionString
    {
        public static string GetConnectionString
        {
            get
            {
                return System.Configuration.ConfigurationManager.ConnectionStrings["DbDefaultContext"].ConnectionString;
            }
        }
    }
}
