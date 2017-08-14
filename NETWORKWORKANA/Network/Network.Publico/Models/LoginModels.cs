using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace Network.Publico.Models
{
    public class LoginModels
    {
        public int IdUsuario { get; set; }
        public string NomeFuncionario { get; set; }
        public string CodigoFuncionario { get; set; }
        public string Setor { get; set; }
        public Nullable<System.DateTime> DataEmaissao { get; set; }
        public Nullable<decimal> Salario { get; set; }
        public string Carteiratrabalho { get; set; }
        public string CarteiraMotorista { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Ud { get; set; }
        public string Fone1 { get; set; }
        public string Fone2 { get; set; }
        public Nullable<bool> Status { get; set; }
        public string Senha { get; set; }
        public string Perfil { get; set; }

        private const string sessionUser = "sessionUser";

        private static HttpSessionState Session { get { return HttpContext.Current.Session; } }

        public static bool IsLogado() { return (Session[sessionUser] != null); }

        public static void LogOff()
        {
            Session.Clear();
            Session.Abandon();
            Session.RemoveAll();
        }

        public static LoginModels GetLoginModel()
        {
            return !IsLogado() ? null : (LoginModels)Session[sessionUser];
        }

        public static void SetLoginModel(LoginModels model)
        {
            Session[sessionUser] = model;
        }
    }
}