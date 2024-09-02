using InstitutoDesktop.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstitutoDesktop.Interfaces.Commons
{
    public interface IMateriaService : IGenericService<Materia>
    {
        public Task<List<Materia>?> GetByCarreraAndAnioAsync(int? idCarrera, int? idAnioCarrera);
    }
}
