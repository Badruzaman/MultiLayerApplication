using MultiLayerApplication.Domain.Abstractions;
using MultiLayerApplication.Domain.DTOs;
using MultiLayerApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayerApplication.Service.Sevices
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }
        public async Task<bool> Create(DTOCategory category)
        {
            await this._categoryRepository.Create(category);
            return true;
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
            var result = await this._categoryRepository.Get(id);
            return result;
        }

        public Task<bool> Update(int id, Category category)
        {
            throw new NotImplementedException();
        }
    }
}
