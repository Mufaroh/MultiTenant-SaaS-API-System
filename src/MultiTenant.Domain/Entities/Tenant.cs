using MultiTenant.Domain.Common;
namespace MultiTenant.Domain.Entities;

public class Tenant:BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public string SubscriptionPlan { get; set; } = "Basic";

    public List<User> Users { get; set; } = new();
}