
using Microsoft.Extensions.Configuration;
using Refit;

namespace Jcf.Lab.Refit.x.www.form.urlencoded.Domain.Apis
{
    public class AccountApi
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        
        public IAccountApi Client { get; private set; }

        public AccountApi(IConfiguration configuration, HttpClient httpClient)
        {
            _configuration = configuration;

            _httpClient = httpClient;          

            _httpClient = httpClient;
            _httpClient.Timeout = TimeSpan.FromMinutes(2);
            _httpClient.BaseAddress = new Uri(_configuration["Api:Account:BaseUrl"].TrimEnd('/'));

            Client = RestService.For<IAccountApi>(_httpClient);
        }
    }
}
