namespace Business.Models.Request.Update
{
    public class EmployeeUpdateDto
    {
        public string FullName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public int DepartmentId { get; set; } = default!;
    }
}
