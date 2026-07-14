using MultiTenant.Domain.Common;
namespace MultiTenant.Domain.Entities;

public class Tenant:BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public SubscriptionPlan SubscriptionPlan { get; set; } = SubscriptionPlan.Basic;

    public ICollection<User> Users { get; set; } = new List<User>();
}