using Jcf.Lab.Refit.x.www.form.urlencoded.Domain.ModelsApi;
using Refit;

namespace Jcf.Lab.Refit.x.www.form.urlencoded.Domain.Apis
{
    public interface IAccountApi
    {
        [Headers("Content-Type: application/x-www-form-urlencoded")]
        [Post("/api/oauth/token")]
        public Task<ApiResponse<Auth.Response>> AuthenticateUser([Body(BodySerializationMethod.UrlEncoded)] Auth.Request request);
    }
}
