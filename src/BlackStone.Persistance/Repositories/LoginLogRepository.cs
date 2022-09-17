using BlackStone.Core.Entities;
using BlackStone.Core.Interfaces;

namespace BlackStone.Persistance.Repositories {
	public class LoginLogRepository : ILoginLogRepository {
		public Task<bool> Insert(LoginLog loginLog) {
			throw new NotImplementedException();
		}

		public Task<bool> Update(LoginLog loginLog) {
			throw new NotImplementedException();
		}

		public Task<bool> UpdateBySessionTokenAndUserId(long userId, string sessionToken) {
			throw new NotImplementedException();
		}
	}
}
