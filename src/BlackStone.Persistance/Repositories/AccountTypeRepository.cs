using BlackStone.Core.Entities;
using BlackStone.Core.Interfaces;

namespace BlackStone.Persistance.Repositories {
	public class AccountTypeRepository : IAccountTypeRepository {
		public Task<IList<AccountType>> GetAllAccountTypes(bool? isActive = null) {
			throw new NotImplementedException();
		}
	}
}
