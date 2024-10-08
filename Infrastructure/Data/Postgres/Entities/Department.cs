using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class Department : BaseEntity
{
    public string Name { get; set; } = default!;
    
    // Navigation property
    public virtual ICollection<Employee> Employees { get; set; } = default!;
}
