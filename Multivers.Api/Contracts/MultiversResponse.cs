using Multivers.Api.Responses;
using System.Collections.Generic;

namespace Multivers.Api.Contracts
{
    public class MultiversResponse : IMultiversObject
    {
        protected MultiversResponse()
        {
            Messages = new List<ResponseMessage>();
        }

        public IEnumerable<ResponseMessage> Messages { get; set; }
    }
}