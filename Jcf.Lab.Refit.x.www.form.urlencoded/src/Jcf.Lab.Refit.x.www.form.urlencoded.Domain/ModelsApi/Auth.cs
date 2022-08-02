namespace Jcf.Lab.Refit.x.www.form.urlencoded.Domain.ModelsApi
{
    public class Auth
    {
        public class Response
        {
            public string access_token { get; set; }
            public string token_type { get; set; }
            public int expires_in { get; set; }
        }

        public class Request
        {
            public string client_id { get; set; }
            public string client_secret { get; set; }

        }
    }
}
