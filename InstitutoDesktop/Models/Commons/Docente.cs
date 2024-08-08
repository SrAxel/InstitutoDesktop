using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InstitutoDesktop.Models.Commons
{
    public class Docente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre debe cargarse obligatoriamente")]
        public string Nombre { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"id:{Id} nombre:{Nombre}";
        }
    }

   
}
