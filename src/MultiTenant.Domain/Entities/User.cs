using MultiTenant.Domain.Common;
namespace MultiTenant.Domain.Entities;

public class User:BaseEntity
{
    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public string Role { get; set; } = "User";

    public Guid TenantId { get; set; }

    public Tenant Tenant { get; set; }
}