using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.RolUser.Commands.CreateRolUser;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.RolUser.Commands.DeleteRlUser;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.RolUser.Commands.UpdateRolUser;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.User.Commands.CreateCommand;
using ProyectoWebApi.DesarrolloIntegral.Application.Features;

namespace ProyectoWebAPI.DesarrolloIntegral.Api.Controllers
{
    [Route("api/roles")]
    [ApiController]
    public class RolUserController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create(
       [FromBody] CreateRolUserModel model,
       [FromServices] ICreateRolUserCommand createRolUserCommand
       )
        {
            var data = await createRolUserCommand.Execute(model);
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
        [HttpPost("update")]
        public async Task<IActionResult> Update(
          [FromBody] UpdateRolUserModel model,
          [FromServices] IUpdateRolUserCommand updateRolUserCommand
          )
        {
            var data = await updateRolUserCommand.Execute(model);
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
        [HttpPost("delete/{id}")]
        public async Task<IActionResult> delete(
        int id,
      [FromServices] IDeleteRolUserCommand deleteRolUserCommand
      )
        {
            var data = await deleteRolUserCommand.Execute(id);
            //var validate = await validator.ValidateAsync(model);
            if (data == false)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }


    }
}
