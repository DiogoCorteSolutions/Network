using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace Network.Presentation.Models
{
    public class BaseModels
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }

        public IEnumerable<SelectListItem> DdlListaPerfil { get; set; }
    }
}