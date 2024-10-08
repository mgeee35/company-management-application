using Infrastructure.Data.Postgres.Entities.Base.Interface;

namespace Infrastructure.Data.Postgres.Entities.Base
{ 
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; } = default!;
    }
}
