using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoDesktop.Models.Commons
{
    public class Materia
    {

        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        [Display(Name = "Año Carrera")]
        public int AnioCarreraId { get; set; }
        [Display(Name = "Año Carrera")]

        public AnioCarrera? AnioCarrera { get; set; }
        public bool Eliminado { get; set; } = false;

        public override string ToString()
        {
            return Nombre;
        }
    }
}
