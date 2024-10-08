using System.Collections.Generic;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres;
using Business.Services.Base.Interface;

namespace Business.Services.Base
{
    public abstract class BaseService<TResponseDto, TEntity> : IBaseService<TResponseDto>
    {
        protected readonly IUnitOfWork _unitOfWork;

        protected BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<TResponseDto> GetByIdAsync(int id)
        {
            var entity = await _unitOfWork.GetRepository<TEntity>().GetByIdAsync(id);
            return MapToResponseDto(entity);
        }

        public async Task<IEnumerable<TResponseDto>> GetAllAsync()
        {
            var entities = await _unitOfWork.GetRepository<TEntity>().GetAllAsync();
            return MapToResponseDtoList(entities);
        }

        public async Task CreateAsync(TResponseDto responseDto)
        {
            var entity = MapToEntity(responseDto);
            await _unitOfWork.GetRepository<TEntity>().AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, TResponseDto responseDto)
        {
            var entity = await _unitOfWork.GetRepository<TEntity>().GetByIdAsync(id);
            if (entity == null) throw new NotFoundException("Entity not found");

            MapToEntity(responseDto, entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _unitOfWork.GetRepository<TEntity>().GetByIdAsync(id);
            if (entity == null) throw new NotFoundException("Entity not found");

            _unitOfWork.GetRepository<TEntity>().Remove(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        protected abstract TResponseDto MapToResponseDto(TEntity entity);
        protected abstract IEnumerable<TResponseDto> MapToResponseDtoList(IEnumerable<TEntity> entities);
        protected abstract TEntity MapToEntity(TResponseDto responseDto);
        protected abstract void MapToEntity(TResponseDto responseDto, TEntity entity);
    }
}
