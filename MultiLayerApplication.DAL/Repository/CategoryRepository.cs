using MultiLayerApplication.Domain.Abstractions;
using MultiLayerApplication.Domain.DTOs;
using MultiLayerApplication.Domain.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayerApplication.DAL.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly StoreContext _storeContext;
        public CategoryRepository(StoreContext storeContext)
        {
            this._storeContext = storeContext;
        }
        public async Task<bool> Create(DTOCategory  model)
        {
            try
            {
                var category = new Category { CategoryName = model.CategoryName, Description = model.Description };
                await this._storeContext.Categories.AddAsync(category);
                await this._storeContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<DTOCategory> Get(int id)
        {
            try
            {
                var result = await this._storeContext.Categories.FindAsync(id);
                var dtoCat = new DTOCategory { CategoryName = result.CategoryName, Description = result.Description };
                return dtoCat;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Task<bool> Update(int id, Category category)
        {
            throw new NotImplementedException();
        }
    }
}
