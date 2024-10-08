namespace Business.Models.Request.Delete
{
    public class RoleDeleteDto
    {
        public string Name { get; set; } = default!;
        public bool IsAdmin { get; set; } = false;
    }
}
