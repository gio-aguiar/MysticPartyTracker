using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MysticPartyTracker.Models;
using MysticPartyTracker.Utils;
using System.Text.Json;

namespace MysticPartyTracker.Services
{
    public class MagiaService
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _serializerOptions;
        private readonly string _apiUrl = Variable.ApiUrl;

        public MagiaService()
        {
            _httpClient = new HttpClient();
            _serializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        }

        public async Task<MagiaResponse> GetAllMagiasAsync()
        {
            var url = $"{_apiUrl}/skills";
            try
            {
                var response = await _httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<MagiaResponse>(content, _serializerOptions);
                }
                return new MagiaResponse();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception(ex.Message);
            }
        }
    }
}
