using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessByCategory;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Category.Commands.CreateCategory;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Category.Commands.DeleteCategory;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Category.Commands.UpdateCategory;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Category.Queries.GetAllCategories;
using ProyectoWebApi.DesarrolloIntegral.Application.Features;

namespace ProyectoWebAPI.DesarrolloIntegral.Api.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create(
            [FromBody] CreateCategoryModel model,
            [FromServices] ICreateCategoryCommand createCategoryCommand
            )
        {
            var data = await createCategoryCommand.Execute(model);
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
        [HttpPost("update")]
        public async Task<IActionResult> Update(
           [FromBody] UpdateCategoryModel model,
           [FromServices] IUpdateCategoryCommand updateCategoryCommand
           )
        {
            var data = await updateCategoryCommand.Execute(model);
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
        [HttpPost("delete/{id}")]
        public async Task<IActionResult> Delete(
            int id,
           [FromServices] IDeleteCategoryCommand deleteCategoryCommand
           )
        {
            var data = await deleteCategoryCommand.Execute(id);
            //var validate = await validator.ValidateAsync(model);
            if (data == false)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
        [HttpPost("getAll")]
        public async Task<IActionResult> GetAll(
          [FromServices] IGetAllCategoriesQuery getCategoryQuery
          )
        {
            var data = await getCategoryQuery.Execute();
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
    }
}
