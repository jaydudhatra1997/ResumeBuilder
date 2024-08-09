namespace RB.Web.Extensions;

public static class ServiceRegistry
{
  public static IServiceCollection RegisterServices(this IServiceCollection services)
  {
    RegisterSingletonServices(ref services);
    return services;
  }

  /// <summary>
  /// Registers singleton services
  /// </summary>
  /// <param name="services"></param>
  /// <returns></returns>
  public static void RegisterSingletonServices(ref IServiceCollection services)
  {
    
  }

  /// <summary>
  /// Registers scoped services
  /// </summary>
  /// <param name="services"></param>
  /// <returns></returns>
  public static void RegisterScopedServices(IServiceCollection services)
  {

  }
}
