using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Results;

namespace Business.Services.Base.Interface
{
    public interface IBaseService<TResponseDto, TId>
    {
        Task<DataResult<TResponseDto>> GetByIdAsync(TId id);
        Task<DataResult<IList<TResponseDto>>> GetAllAsync();
        Task<Result> AddAsync(TResponseDto dto);
        Task<Result> UpdateAsync(TId id, TResponseDto dto);
        Task<Result> DeleteAsync(TId id);
    }
}
