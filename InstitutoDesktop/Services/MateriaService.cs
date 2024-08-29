using InstitutoDesktop.Class;
using InstitutoDesktop.Interfaces.Commons;
using InstitutoDesktop.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InstitutoDesktop.Services
{
    public class MateriaService : GenericService<Materia>, IMateriaService
    {
        private readonly HttpClient client;
        private readonly JsonSerializerOptions options;
        private readonly string _endpoint;

        public MateriaService() 
        {
            this.client = new HttpClient();
            options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            var urlApi = Properties.Settings.Default.UrlApi;
            this._endpoint = urlApi + ApiEndpoints.GetEndpoint(nameof(Materia));
        }

        public async Task<List<Materia>?> GetByCarreraAndAnioAsync(int? idCarrera, int? idAnioCarrera)
        {
            var response = await client.GetAsync($"{_endpoint}?idCarrera={idCarrera}&idAnioCarrera={idAnioCarrera}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<Materia>>(content, options);
        }


        public async Task<List<Materia>?> GetByAnioCarreraAsync(int? idCarrera)
        {
            var response = await client.GetAsync($"{_endpoint}?idAnioCarrera={idCarrera}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<Materia>>(content, options); ;
        }
    }
}
