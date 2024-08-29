using BlazorAppVSCode.Models.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoDesktop.Models.Commons
{
    public class AnioCarrera
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int? CarreraId { get; set; }
        public Carrera? Carrera { get; set; }
        [NotMapped]
        public string AñoYCarrera
        {
            get { return $"{Nombre} | {Carrera?.Nombre}" ?? string.Empty; }
        }
        public override string ToString()
        {
            return AñoYCarrera;
        }
    }
}
