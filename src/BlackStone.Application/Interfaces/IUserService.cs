using BlackStone.Core.Entities;
using BlackStone.Core.Models;

namespace BlackStone.Application.Interfaces {
	public interface IUserService {
		Task<IList<User>> GetAllUsers(bool? isActive = null);
		Task<User> GetById(long userId);
		Task<User> Login(string loginName, string loginPassword);
		Task<long> Signup(User user);
		JWToken GenerateToken(Int64 userId, string userName);
		string GenerateRefreshTokenKey();

	}
}
