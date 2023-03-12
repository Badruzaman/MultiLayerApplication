using MultiLayerApplication.Domain.DTOs;
using MultiLayerApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLayerApplication.Domain.Abstractions
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> Get();
        Task<DTOCategory> Get(int id);
        Task<bool> Create(DTOCategory category);
        Task<bool> Update(int id,Category category);
        Task<bool> Delete(int id);
    }
}
