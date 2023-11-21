using Microsoft.AspNetCore.Mvc;
using CodePulse.API.Models.DTO;
using CodePulse.API.Models.Domain;
using CodePulse.API.Data;
using CodePulse.API.Repositories.Interface;


namespace CodePulse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

  
    public class CategoriesController : ControllerBase
    {
        public readonly ICategoryRepository CategoryRepository;

        public CategoriesController(ICategoryRepository CategoriesController)
        {
            this.CategoryRepository = CategoriesController;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryRequestDto request)
        {
            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle
            };

            await CategoryRepository.CreateAsync(category);

            var response = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandle = category.UrlHandle
            };
            return Ok(response);
        }
    }
}
