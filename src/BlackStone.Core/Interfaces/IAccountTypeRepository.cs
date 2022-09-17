using BlackStone.Core.Entities;

namespace BlackStone.Core.Interfaces {
	public interface IAccountTypeRepository {
		Task<IList<AccountType>> GetAllAccountTypes(bool? isActive = null);
	}
}
