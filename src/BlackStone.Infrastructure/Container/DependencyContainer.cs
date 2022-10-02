using BlackStone.Application.Interfaces;
using BlackStone.Application.Services;
using BlackStone.Core.Interfaces;
using BlackStone.Infrastructure.Logger;
using BlackStone.Infrastructure.MemoryCache;
using BlackStone.Persistance.Repositories;

using Microsoft.Extensions.DependencyInjection;

namespace BlackStone.Infrastructure.Container {
	public class DependencyContainer {
		public static void RegisterServices(IServiceCollection services) {
			ServicesRegistration(services);
			RepositoryRegistration(services);
			ApploggerRegistration(services);
		}
		private static void ServicesRegistration(IServiceCollection services) {
			services.AddTransient<IAccountTypeService, AccountTypeService>();
			services.AddTransient<ICategoryService, CategoryService>();
			services.AddTransient<IUserService, UserService>();
			services.AddTransient<IRefreshTokenService, RefreshTokenService>();
			services.AddTransient<ILoginLogService, LoginLogService>();
		}
		private static void RepositoryRegistration(IServiceCollection services) {
			//services.AddTransient<IBaseRepository, BaseRepository>();
			services.AddTransient<IAccountTypeRepository, AccountTypeRepository>();
			services.AddTransient<ICategoryRepository, CategoryRepository>();
			services.AddTransient<IUserRepository, UserRepository>();
			services.AddTransient<IRefreshTokenRepository, RefreshTokenRepository>();
			services.AddTransient<ILoginLogRepository, LoginLogRepository>();
			services.AddScoped<IMemoryCacheProvider, MemoryCacheProvider>();
		}

		private static void ApploggerRegistration(IServiceCollection services) {
			services.AddSingleton<IApplogger, Applogger>();
		}
	}
}
