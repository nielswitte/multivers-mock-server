using Multivers.Api.Contracts;

namespace Multivers.Api.Requests
{
    public class TokenRequest : MultiversRequest
    {
        public string client_id { get; set; }
        public string redirect_uri { get; set; }
        public string grant_type { get; set; }
        public string code { get; set; }
        public string client_secret { get; set; }
    }
}