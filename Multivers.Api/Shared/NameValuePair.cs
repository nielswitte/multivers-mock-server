using Multivers.Api.Contracts;

namespace Multivers.Api.Shared
{
    public class NameValuePair : MultiversResponse
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
