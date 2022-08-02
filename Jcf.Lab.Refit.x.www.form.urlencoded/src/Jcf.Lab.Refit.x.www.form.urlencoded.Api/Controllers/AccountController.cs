using Jcf.Lab.Refit.x.www.form.urlencoded.Domain.Apis;
using Jcf.Lab.Refit.x.www.form.urlencoded.Domain.ModelsApi;
using Microsoft.AspNetCore.Mvc;

namespace Jcf.Lab.Refit.x.www.form.urlencoded.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AccountController : ControllerBase
    {
        private readonly AccountApi _accountApi;

        public AccountController(AccountApi accountApi)
        {
            _accountApi = accountApi;
        }

        [HttpPost]
        public async Task<IActionResult> Login(string id, string secret)
        {
            try
            {               
                if(string.IsNullOrEmpty(id) || string.IsNullOrEmpty(secret)) return BadRequest(new { messege = "id or secret is null or Empty" });

                var auth = await _accountApi.Client.AuthenticateUser(new Auth.Request() { client_id = id, client_secret = secret });

                if (auth is null || auth.Content is null) return Unauthorized(new { client_id = id, client_secret = secret });

                return Ok(auth.Content);
            }
            catch (Exception ex)
            {
                return BadRequest(new { ex.Message });
            }
        }
    }
}
