using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Commands.CreateBusinessModel;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Commands.DeleteBusiness;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Commands.UdateBusiness;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetAllBusiness;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessByCategory;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessById;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Business.Queries.GetBusinessByName;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Commands.CreateProduct;
using ProyectoWebApi.DesarrolloIntegral.Application.Features;

namespace ProyectoWebAPI.DesarrolloIntegral.Api.Controllers
{
    [Route("api/business")]
    [ApiController]
    public class BusinessController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create(
           [FromBody] CreateBusinessModel model,
           [FromServices] ICreateBusinessCommand createBusinessCommand
           )
        {
            var data = await createBusinessCommand.Execute(model);
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data));
        }
        [HttpPost("update")]
        public async Task<IActionResult> Update(
          [FromBody] UpdateBusinessModel model,
          [FromServices] IUpdateBusinessCommand updateBusinessCommand
          )
        {
            var data = await updateBusinessCommand.Execute(model);
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
        [HttpPost("delete/{id}")]
        public async Task<IActionResult> Delete(
            int id,
            [FromServices] IDeleteBusinessCommand deleteBusinessCommand
            )
        {
            var data = await deleteBusinessCommand.Execute(id);
            //var validate = await validator.ValidateAsync(model);
            if (data == false)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
        [HttpPost("getAll")]
        public async Task<IActionResult> GetAll(
            
            [FromServices] IGetAllBusinessQuery getAllBusinessQuery
            )
        {
            var data = await getAllBusinessQuery.Execute();
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
        [HttpPost("getByCategory/{category}")]
        public async Task<IActionResult> GetBusinessByCategory(
            int category,
            [FromServices] IGetBusinessByCategoryQuery getBusinessByCategoryQuery
            )
        {
            var data = await getBusinessByCategoryQuery.Execute(category);
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
        [HttpPost("getById/{id}")]
        public async Task<IActionResult> GetById(
            int id,
            [FromServices] IGetBusinessByIdQuery getBusinessByIdQuery
            )
        {
            var data = await getBusinessByIdQuery.Execute(id);
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
        [HttpPost("getByName/{name}")]
        public async Task<IActionResult> GetBusinessByName(
            string name,
            [FromServices] IGetBusinessByNameQuery getBusinessByNameQuery
            )
        {
            var data = await getBusinessByNameQuery.Execute(name);
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
    }
}
