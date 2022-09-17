using BlackStone.Application.Interfaces;
using BlackStone.Core.Entities;

namespace BlackStone.Application.Services {
	public class CategoryService : ICategoryService {
		public Task<IList<Category>> GetAllCategories(bool? isActive = null) {
			throw new NotImplementedException();
		}
	}
}
