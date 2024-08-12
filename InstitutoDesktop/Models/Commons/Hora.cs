using System.ComponentModel.DataAnnotations;

namespace BlazorAppVSCode.Models.Commons
{
    public class Hora
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre debe cargarse obligatoriamente")]
        public string Nombre { get; set; } = string.Empty;
        [Required(ErrorMessage = "La sigla debe cargarse obligatoriamente")]
        public bool esRecreo { get; set; }


        public override string ToString()
        {
            return $"id:{Id} nombre:{Nombre}";
        }
    }
}
