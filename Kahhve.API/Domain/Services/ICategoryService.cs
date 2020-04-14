using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kahhve.API.Domain.Models;
using Kahhve.API.Domain.Services.Communication;

namespace Kahhve.API.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}
