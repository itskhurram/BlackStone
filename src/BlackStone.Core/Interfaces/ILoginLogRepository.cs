using BlackStone.Core.Entities;

namespace BlackStone.Core.Interfaces {
	public interface ILoginLogRepository {
		public Task<bool> Insert(LoginLog loginLog);
		public Task<bool> Update(LoginLog loginLog);
		public Task<bool> UpdateBySessionTokenAndUserId(long userId, string sessionToken);
	}
}
