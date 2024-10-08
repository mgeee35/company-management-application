using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class Employee : BaseEntity
{
    public string FullName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Phone { get; set; } = default!;
    
    public int DepartmentId { get; set; } = default!;
    
    // Navigation property
    public virtual Department Department { get; set; } = default!;
}
