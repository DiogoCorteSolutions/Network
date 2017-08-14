using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Network.Publico.Models
{
    public class BaseModels
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }


        public IEnumerable<SelectListItem> DdlSexo { get; set; }

        //public IEnumerable<SelectListItem> DdlPeriodo { get; set; }
        //public IEnumerable<SelectListItem> DdlPerfil { get; set; }
        //public IEnumerable<SelectListItem> DdSexo { get; set; }
        //public IEnumerable<SelectListItem> DdQauntidade { get; set; }
    }
}