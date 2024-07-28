using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Queries.GetProductsByBusiness;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.RolUser.Commands.DeleteRlUser;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.User.Commands.CreateCommand;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.User.Commands.UpdateCommand;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.User.Queries.GetUserLogin;
using ProyectoWebApi.DesarrolloIntegral.Application.Features;

namespace ProyectoWebAPI.DesarrolloIntegral.Api.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create(
        [FromBody] CreateUserModel model,
        [FromServices] ICreateUserCommand createUserCommand
        )
        {
            var data = await createUserCommand.Execute(model);
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
        [HttpPost("update")]
        public async Task<IActionResult> Update(
       [FromBody] UpdateUserModel model,
       [FromServices] IUpdateUserCommand updateUserCommand
       )
        {
            var data = await updateUserCommand.Execute(model);
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(
      [FromBody] GetUserLoginModel model,
      [FromServices] IGetUserLoginQuery getUserLoginQuery
      )
        {
            var data = await getUserLoginQuery.Execute(model);
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }



    }
}
