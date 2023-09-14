using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Mart_V1.Authentication
{
    public class UserSession
    {
        public string UserName { get; set;}
        public string Role {  get; set;}
    }
}
