<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Mvc;
using CodePulse.API.Models.DTO;
using CodePulse.API.Models.Domain;
using CodePulse.API.Data;
using CodePulse.API.Repositories.Interface;

=======
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
>>>>>>> 6297efd776b649db9cbcfcd4397c6e7526fdcb7b

namespace CodePulse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
<<<<<<< HEAD

  
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
=======
    public class CategoriesController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateCategory()
        {

>>>>>>> 6297efd776b649db9cbcfcd4397c6e7526fdcb7b
        }
    }
}
