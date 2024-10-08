namespace Business.Models.Request.Delete
{
    public class EmployeeDeleteDto
    {
        public string FullName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public int DepartmentId { get; set; } = default!;
    }
}
