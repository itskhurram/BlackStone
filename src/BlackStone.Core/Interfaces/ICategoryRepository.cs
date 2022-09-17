using BlackStone.Core.Entities;

namespace BlackStone.Core.Interfaces {
	public interface ICategoryRepository {
		Task<IList<Category>> GetAllCategories(bool? isActive = null);
	}
}
