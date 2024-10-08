namespace Infrastructure.Data.Postgres.Entities;

public class EmployeeRole
{
    public int EmployeeId { get; set; }
    public int RoleId { get; set; }
    
    // Navigation properties
    public virtual Employee Employee { get; set; } = default!;
    public virtual Role Role { get; set; } = default!;
}
