using AutoMapper;
using Business.Utilities.Mapping.Interface;

namespace Business.Utilities.Mapping
{
    public class MapperHelper : IMapperHelper
    {
        private readonly IMapper _mapper;

        public MapperHelper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return _mapper.Map<TDestination>(source);
        }

        public IEnumerable<TDestination> MapList<TSource, TDestination>(IEnumerable<TSource> source)
        {
            return _mapper.Map<IEnumerable<TDestination>>(source);
        }
    }
}
