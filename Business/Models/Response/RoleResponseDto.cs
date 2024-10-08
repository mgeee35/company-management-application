namespace Business.Models.Response
{
    public class RoleResponseDto
    {
        public int Id { get; set; } = default!;
        
        public string Name { get; set; } = default!;
        
        public bool IsAdmin { get; set; } = false;
    }
}
