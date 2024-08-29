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
    public class AnioCarreraService : GenericService<AnioCarrera>, IAnioCarreraService
    {
        private readonly HttpClient client;
        private readonly JsonSerializerOptions options;
        private readonly string _endpoint;

        public AnioCarreraService()
        {
            this.client = new HttpClient();
            this.options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
            var urlApi = Properties.Settings.Default.UrlApi;
            this._endpoint = urlApi + ApiEndpoints.GetEndpoint(nameof(AnioCarrera));
        }

        public async Task<List<AnioCarrera>?> GetByCarreraAsync(int? idCarrera)
        {
            var response = await client.GetAsync($"{_endpoint}?idCarrera={idCarrera}");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content?.ToString());
            }
            return JsonSerializer.Deserialize<List<AnioCarrera>>(content, options); ;
        }
    }
}
