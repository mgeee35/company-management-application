using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class Role : BaseEntity
{
    public string Name { get; set; } = default!;
    public bool IsAdmin { get; set; } = false;
    
    // Navigation property
    public virtual ICollection<EmployeeRole> EmployeeRoles { get; set; } = default!;
}
