using BlackStone.Core.Entities;
using BlackStone.Core.Models;
using BlackStone.Core.ViewModels;

namespace BlackStone.Application.Interfaces {
	public interface IUserService {
		Task<IList<User>> GetAllUsers(bool? isActive = null);
		Task<User> GetById(long userId);
		Task<User> Login(LoginViewModel loginViewModel);
		Task<long> Signup(User user);
		JWToken GenerateToken(Int64 userId, string userName);
		string GenerateRefreshTokenKey();
	}
}
