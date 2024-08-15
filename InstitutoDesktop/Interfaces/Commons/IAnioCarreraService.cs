using InstitutoDesktop.Interfaces;
using InstitutoDesktop.Models.Commons;

namespace InstitutoDesktop.Interfaces.Commons
{
    public interface IAnioCarreraService : IGenericService<AnioCarrera>
    {
        public Task<List<AnioCarrera>?> GetByCarreraAsync(int? id);
    }
}
