namespace Business.Models.Request.Create
{
    public class RoleCreateDto
    {
        public string Name { get; set; } = default!;
        public bool IsAdmin { get; set; } = false;
    }
}
