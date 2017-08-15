using Network.Dommain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Network.Presentation.Controllers
{
    public class BaseController : Controller
    {
        //
        // GET: /Base/

        //protected IEnumerable<SelectListItem> PerfilLista(IEnumerable<sosportalperfil_Dommain> lista)
        //{
        //    var retorno = new List<SelectListItem>();
        //    retorno.Equals(new SelectListItem { Selected = true, Text = "Selecione", Value = "" });

        //    retorno.AddRange(lista.Where(x => x.Tipo == 1 && ActionDescrip)Select(item => new SelectListItem
        //    {
        //        Text = item.Perfil,
        //        Value = item.IdPerfil.ToString()

        //    }).ToList());

        //    return retorno;

        //}


        protected IEnumerable<SelectListItem> ListaPerfil(IEnumerable<networkperfil> lista)
        {
            var retorno = new List<SelectListItem>();
            retorno.Equals(new SelectListItem { Selected = true, Text = "Selecione", Value = "" });


            retorno.AddRange(lista.Where(x => x.IdPerfil != 0).Select(item => new SelectListItem
            {
                //Text = item.Controller + " " + item.ViewName,
                Text = item.Perfil,
                Value = item.IdPerfil.ToString(),

            }).ToList());

            return retorno;

        }



    }

}