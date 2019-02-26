using System;
using Multivers.Api.Contracts;
using Multivers.Api.Enums;

namespace Multivers.Api.Requests
{
    public class MandateRequest : MultiversRequest
    {
        // Only set when not using auto ids
        public string MandateId { get; set; }
        public string Description { get; set; }
        public string CustomerId { get; set; }
        public DateTime DateOfSignature { get; set; }
        public bool ExistingMandate { get; set; }
        public string ElectronicSignature { get; set; }        
        public bool Finished { get; set; }
        public bool FirstCollection { get; set; }
        public MandateKind Kind { get; set; }
        public bool ToPrint { get; set; }
        public MandateType MandateType { get; set; }
        public int BankAccountId { get; set; }
    }
}
