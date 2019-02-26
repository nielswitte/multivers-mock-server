using Microsoft.AspNetCore.Mvc;
using Multivers.Api.Requests;
using Multivers.Api.Responses;
using System;
using System.Collections.Generic;

namespace Multivers.Api.Controllers
{
    [Route("OAuth")]
    [ApiController]
    public class OAuthController : ControllerBase
    {        
        [HttpPost, Route("Token")]
        [Consumes("application/x-www-form-urlencoded")]
        public ActionResult<TokenResponse> PostToken([FromForm] TokenRequest request)
        {
            return Ok(new TokenResponse
            {
                Messages = new List<ResponseMessage>(),
                access_token = "mocked_token_here",
                date = DateTime.Now,
                expires_in = 3600,
                refresh_token = "mocked_refresh_token_here",
                scope = "api mock",
                token_type = "bearer"
            });
        }
    }
}
