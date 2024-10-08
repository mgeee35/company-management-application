namespace Business.Models.Response
{
    public class EmployeeResponseDto
    {
        public int Id { get; set; } = default!;
        
        public string FullName { get; set; } = default!;
        
        public string Email { get; set; } = default!;
        
        public string Phone { get; set; } = default!;
        
        public int DepartmentId { get; set; } = default!;
        
        public string Department { get; set; } = default!;
    }
}
