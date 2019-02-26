namespace Multivers.Api.Shared
{
    public class ApiIdentity
    {
        public AdministrationContext Context { get; set; }
        public bool IsSystemUser { get; set; }
        public string Password { get; set; }
        public string UserRightGroup { get; set; }
    }
}