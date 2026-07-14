using MultiTenant.Domain.Common;
using MultiTenant.Domain.Enums;
namespace MultiTenant.Domain.Entities;

public class User:BaseEntity
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public UserRole Role { get; set; } = UserRole.User;

    public Guid TenantId { get; set; }

    public Tenant Tenant { get; set; } = null!;
}