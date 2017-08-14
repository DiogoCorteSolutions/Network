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
        protected IEnumerable<SelectListItem> SegmentoListaFixo()
        {
            var retorno = new List<SelectListItem>();

            retorno.Add(new SelectListItem { Selected = true, Text = "Selecione", Value = "" });
            retorno.Add(new SelectListItem { Text = "Mercado", Value = "Mercado" });
            retorno.Add(new SelectListItem { Text = "Padaria", Value = "Padaria" });
            retorno.Add(new SelectListItem { Text = "Restaurante", Value = "Restaurante" });
            retorno.Add(new SelectListItem { Text = "Borracharia", Value = "Borracharia" });
            retorno.Add(new SelectListItem { Text = "Mecanica", Value = "Mecanica" });
            retorno.Add(new SelectListItem { Text = "OUTROS", Value = "OUTROS" });

            return retorno;
        }
        //protected IEnumerable<SelectListItem> PerfilLista(IEnumerable<sosportalperfil_Dommain> lista)
        //{
        //    var retorno = new List<SelectListItem>();
        //    retorno.Equals(new SelectListItem { Selected = true, Text = "Selecione", Value = "" });

        //    retorno.AddRange(lista.Where(x => x.DescricaoTipo.Contains("Perfil") && !x.Perfil.Contains("Cadastro")).Select(item => new SelectListItem
        //    {
        //        Text = item.Perfil,
        //        Value = item.IdPerfil.ToString()

        //    }).ToList());

        //    return retorno;

        //}

        //protected IEnumerable<SelectListItem> UfListaID(IEnumerable<sosportaluf_Dommain> lista)
        //{
        //    var retorno = new List<SelectListItem>();
        //    retorno.Equals(new SelectListItem { Selected = true, Text = "Selecione", Value = "" });

        //    retorno.AddRange(lista.Select(item => new SelectListItem
        //    {
        //        Text = item.UF,
        //        Value = item.IdUf.ToString()

        //    }).ToList());

        //    return retorno;
        //}
        protected IEnumerable<SelectListItem> UfListaID()
        {
            var retorno = new List<SelectListItem>();

            retorno.Add(new SelectListItem { Selected = true, Text = "Selecione", Value = "" });
            retorno.Add(new SelectListItem { Text = "SP", Value = "SP" });
            retorno.Add(new SelectListItem { Text = "RJ", Value = "RJ" });
            retorno.Add(new SelectListItem { Text = "PE", Value = "PE" });

            return retorno;
        }
        protected IEnumerable<SelectListItem> TipoPessoaLista()
        {
            var retorno = new List<SelectListItem>();

            retorno.Add(new SelectListItem { Selected = true, Text = "Selecione", Value = "" });
            retorno.Add(new SelectListItem { Text = "Pessoa Fisica", Value = "1" });
            retorno.Add(new SelectListItem { Text = "Pessoa Juridica", Value = "2" });

            return retorno;
        }
        protected IEnumerable<SelectListItem> OperadoraLista()
        {
            var retorno = new List<SelectListItem>();

            retorno.Add(new SelectListItem { Selected = true, Text = "Selecione", Value = "" });
            retorno.Add(new SelectListItem { Text = "TIM", Value = "TIM" });
            retorno.Add(new SelectListItem { Text = "OI", Value = "OI" });
            retorno.Add(new SelectListItem { Text = "VIVO", Value = "VIVO" });
            retorno.Add(new SelectListItem { Text = "CLARO", Value = "CLARO" });
            retorno.Add(new SelectListItem { Text = "NEXTEL", Value = "NEXTEL" });
            retorno.Add(new SelectListItem { Text = "OUTROS", Value = "OUTROS" });

            return retorno;
        }
        protected IEnumerable<SelectListItem> TipoEnderecoLista()
        {
            var retorno = new List<SelectListItem>();

            retorno.Add(new SelectListItem { Selected = true, Text = "Selecione", Value = "" });
            retorno.Add(new SelectListItem { Text = "Comercial", Value = "Comercial" });
            retorno.Add(new SelectListItem { Text = "Residencial", Value = "Residencial" });
            retorno.Add(new SelectListItem { Text = "OUTROS", Value = "OUTROS" });

            return retorno;
        }
        protected IEnumerable<SelectListItem> TipoTelefoneLista()
        {
            var retorno = new List<SelectListItem>();

            retorno.Add(new SelectListItem { Selected = true, Text = "Selecione", Value = "" });
            retorno.Add(new SelectListItem { Text = "Comercial", Value = "Comercial" });
            retorno.Add(new SelectListItem { Text = "Residencial", Value = "Residencial" });
            retorno.Add(new SelectListItem { Text = "OUTROS", Value = "OUTROS" });

            return retorno;
        }
        protected IEnumerable<SelectListItem> TipoPerfilLista()
        {
            var retorno = new List<SelectListItem>();

            retorno.Add(new SelectListItem { Selected = true, Text = "Selecione", Value = "" });
            retorno.Add(new SelectListItem { Text = "Perfil", Value = "1" });
            retorno.Add(new SelectListItem { Text = "Segmento", Value = "2" });

            return retorno;
        }
        protected IEnumerable<SelectListItem> SexoLista()
        {
            var retorno = new List<SelectListItem>();

            retorno.Add(new SelectListItem { Selected = true, Text = "Selecione", Value = "" });
            retorno.Add(new SelectListItem { Text = "Masculino", Value = "M" });
            retorno.Add(new SelectListItem { Text = "Feminio", Value = "F" });

            return retorno;
        }
    }

}