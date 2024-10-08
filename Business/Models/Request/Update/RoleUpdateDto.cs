namespace Business.Models.Request.Update
{
    public class RoleUpdateDto
    {
        public string Name { get; set; } = default!;
        public bool IsAdmin { get; set; } = false;
    }
}