using BlackStone.Core.Entities;

namespace BlackStone.Application.Interfaces {
	public interface ICategoryService {
		public Task<IList<Category>> GetAllCategories(bool? isActive = null);
	}
}
