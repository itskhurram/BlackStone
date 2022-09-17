using BlackStone.Application.Interfaces;
using BlackStone.Core.Entities;
using BlackStone.Core.Models;
using BlackStone.Core.ViewModels;

namespace BlackStone.Application.Services {
	public class UserService : IUserService {
		public string GenerateRefreshTokenKey() {
			throw new NotImplementedException();
		}

		public JWToken GenerateToken(long userId, string userName) {
			throw new NotImplementedException();
		}

		public Task<IList<User>> GetAllUsers(bool? isActive = null) {
			throw new NotImplementedException();
		}

		public Task<User> GetById(long userId) {
			throw new NotImplementedException();
		}

		public Task<User> Login(LoginViewModel loginViewModel) {
			throw new NotImplementedException();
		}

		public Task<long> Signup(User user) {
			throw new NotImplementedException();
		}
	}
}
