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

        // GET: api/<CategoryController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
       
        [HttpPost("Create")]

        public async Task<ActionResult<bool>> Create(DTOCategory model)
        {
            await _categoryService.Create(model);
            return true;
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<DTOCategory> Get(int id)
        {
           var result = await _categoryService.Get(id);
            return result;
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            //_categoryService.Create(category);
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
