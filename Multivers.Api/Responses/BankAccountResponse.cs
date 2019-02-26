using Multivers.Api.Contracts;

namespace Multivers.Api.Responses
{
    public class BankAccountResponse : MultiversResponse
    {
        public string BankTypeId { get; set; }    
        public string AccountNumber { get; set; }
        public bool Preferred { get; set; }
        public bool Blocked { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string CountryId { get; set; }
        public string Bic { get; set; }
        public string GiroAccountNumberOfBank { get; set; }
        public int OrganizationId { get; set; }
        public string Iban { get; set; }
        public string AccountholderName { get; set; }
        public string AccountholderCity { get; set; }

    }
}
