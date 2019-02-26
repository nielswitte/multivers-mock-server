using Multivers.Api.Contracts;
using System;

namespace Multivers.Api.Responses
{
    public class TokenResponse : MultiversResponse
    {
        public DateTime date { get; set; }
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string refresh_token { get; set; }
        public string scope { get; set; }
    }
}
