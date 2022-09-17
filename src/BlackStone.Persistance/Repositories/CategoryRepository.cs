using BlackStone.Core.Entities;
using BlackStone.Core.Interfaces;

namespace BlackStone.Persistance.Repositories {
	public class CategoryRepository : ICategoryRepository {
		public Task<IList<Category>> GetAllCategories(bool? isActive = null) {
			throw new NotImplementedException();
		}
	}
}
