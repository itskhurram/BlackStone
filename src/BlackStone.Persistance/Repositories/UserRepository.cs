using BlackStone.Core.Entities;
using BlackStone.Core.Interfaces;

namespace BlackStone.Persistance.Repositories {
	public class UserRepository : IUserRepository {
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
