using Microsoft.AspNetCore.Mvc;
using MultiLayerApplication.Domain.Abstractions;
using MultiLayerApplication.Domain.DTOs;
using MultiLayerApplication.Domain.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MultiLayerApplication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }


        [HttpGet("GetAll")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("GetById")]
        public async Task<DTOCategory> Get(int id)
        {
            var result = await _categoryService.Get(id);
            return result;
        }

        [HttpPost("Create")]
        public async Task<ActionResult<bool>> Create(DTOCategory model)
        {
            try
            {
                await _categoryService.Create(model);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPut("Update")]
        public void Put(int id, [FromBody] string value)
        {

        }

        [HttpDelete("Delete")]
        public void Delete(int id)
        {

        }
    }
}
