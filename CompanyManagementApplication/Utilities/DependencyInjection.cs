using Business.Services;
using Business.Services.Base;
using Business.Services.Interface;
using Business.Utilities.Mapping;
using Business.Utilities.Mapping.Interface;
using Infrastructure.Data.Postgres;


namespace CompanyManagementApplication.Utilities;
public static class DependencyInjection
{
    public static void AddMyScoped(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IDepartmentService, DepartmentService>();
        serviceCollection.AddScoped<IEmployeeRoleService, EmployeeRoleService>();
        serviceCollection.AddScoped<IEmployeeService, EmployeeService>();
        serviceCollection.AddScoped<IRoleService, RoleService>();
        serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
    }

    public static void AddMySingleton(this IServiceCollection serviceCollection) 
    {
        serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        serviceCollection.AddSingleton<IMapperHelper, MapperHelper>();
        /*
        serviceCollection.AddSingleton<IValidationHelper, ValidationHelper>();
        serviceCollection.AddSingleton<IJwtTokenHelper, JwtTokenHelper>();
        serviceCollection.AddSingleton<IHashingHelper, HashingHelper>();
        serviceCollection.AddSingleton<IMailHelper, MailHelper>();
        */
    }

    public static void AddMyTransient(this IServiceCollection serviceCollection)
    {
    }

}
