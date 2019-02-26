using Multivers.Api.Contracts;

namespace Multivers.Api.Shared
{
    public class AdministrationContext
    {
        public string AdministrationId { get; set; }
        public int FiscalYear { get; set; }
        public ApiIdentity User { get; set; }        
        public ICompanyDetailsInfo Company { get; set; }
    }
}
