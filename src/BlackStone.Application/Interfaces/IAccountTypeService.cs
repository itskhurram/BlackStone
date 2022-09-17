using BlackStone.Core.Entities;

namespace BlackStone.Application.Interfaces {
	public interface IAccountTypeService {
		public Task<IList<AccountType>> GetAllAccountTypes(bool? isActive = null);
	}
}
