using BlackStone.Application.Interfaces;
using BlackStone.Core.Entities;

namespace BlackStone.Application.Services {
	public class AccountTypeService : IAccountTypeService {
		public Task<IList<AccountType>> GetAllAccountTypes(bool? isActive = null) {
			throw new NotImplementedException();
		}
	}
}
