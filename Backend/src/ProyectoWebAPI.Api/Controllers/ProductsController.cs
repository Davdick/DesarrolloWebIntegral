using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Commands.CreateProduct;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Commands.DeleteProduct;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Commands.UpdateProduct;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Queries.GetProductByName;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Queries.GetProductsByBusiness;
using ProyectoWebApi.DesarrolloIntegral.Application.Features;

namespace ProyectoWebAPI.DesarrolloIntegral.Api.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create(
           [FromBody] CreateProductModel model,
           [FromServices] ICreateProductCommand createProductCommand
           )
        {
            var data = await createProductCommand.Execute(model);
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));
            
            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data));
        }
        [HttpPost("update")]
        public async Task<IActionResult> Update(
          [FromBody] UpdateProductModel model,
          [FromServices] IUpdateProductCommand updateProductCommand
          )
        {
            var data = await updateProductCommand.Execute(model);
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
        [HttpPost("delete/{idProduct}")]
        public async Task<IActionResult> Delete(
         int idProduct,
         [FromServices] IDeleteProductCommand deleteProductCommand
         )
        {
            var data = await deleteProductCommand.Execute(idProduct);
            //var validate = await validator.ValidateAsync(model);
            if (data == false)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
        [HttpPost("getProductByName/{name}")]
        public async Task<IActionResult> GetProductByName(
         string name,
         [FromServices] IGetProductByNameQuery getProductByNameQuery
         )
        {
            var data = await getProductByNameQuery.Execute(name);
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status201Created, ResponseApiService.Response(StatusCodes.Status201Created, data));
        }
        [HttpPost("getProductByBusiness/{id}")]
        public async Task<IActionResult> GetProductByBusiness(
        int id,
        [FromServices] IGetProductsByBusinessQuery getProductByBusinessQuery
        )
        {
            var data = await getProductByBusinessQuery.Execute(id);
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }


    }
}
