using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleForm.Models
{
    public class Comentario
    {
        [HiddenInput(DisplayValue=false)]
        public int Id { get; set; }

        public string Nome { get; set; }
        
        public string Destinatario { get; set; }

        [DataType(DataType.MultilineText)]
        public string Texto { get; set; }
    }
}