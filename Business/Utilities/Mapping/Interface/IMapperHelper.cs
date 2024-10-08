namespace Business.Utilities.Mapping.Interface;

    public interface IMapperHelper
    {
        TDestination Map<TSource, TDestination>(TSource source);
        IEnumerable<TDestination> MapList<TSource, TDestination>(IEnumerable<TSource> source);
    }
