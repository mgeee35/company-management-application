using Infrastructure.Data.Postgres.Entities.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities;

namespace Infrastructure.Data.Postgres.Entities.Base.Interface
{
    public interface IBaseEntity
    {
        int Id { get; set; }
    }

}
