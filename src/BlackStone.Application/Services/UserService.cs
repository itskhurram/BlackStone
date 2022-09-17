using BlackStone.Application.Interfaces;
using BlackStone.Core.Entities;
using BlackStone.Core.Models;

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

		public Task<User> Login(string loginName, string loginPassword) {
			throw new NotImplementedException();
		}

		public Task<long> Signup(User user) {
			throw new NotImplementedException();
		}
	}
}
