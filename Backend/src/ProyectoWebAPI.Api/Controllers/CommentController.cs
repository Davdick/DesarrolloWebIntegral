using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Commands.CreateComment;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Commands.DeleteComment;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Commands.UpdateComment;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Comment.Queries.GetCommentsByBusiness;
using ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Queries.GetProductsByBusiness;
using ProyectoWebApi.DesarrolloIntegral.Application.Features;

namespace ProyectoWebAPI.DesarrolloIntegral.Api.Controllers
{
    [Route("api/comment")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        [HttpPost("create")]
        public async Task<IActionResult> Create(
        [FromBody] CreateCommentModel model,
        [FromServices] ICreateCommentCommand createCommentCommand
        )
        {
            var data = await createCommentCommand.Execute(model);
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
        [HttpPost("update")]
        public async Task<IActionResult> Update(
        [FromBody] UpdateCommentModel model,
        [FromServices] IUpdateCommentCommand updateCommentCommand
        )
        {
            var data = await updateCommentCommand.Execute(model);
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
        [HttpPost("delete/{id}")]
        public async Task<IActionResult> Delete(
        int id,
        [FromServices] IDeleteComment deleteComment
        )
        {
            var data = await deleteComment.Execute(id);
            //var validate = await validator.ValidateAsync(model);
            if (data == false)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
        [HttpPost("getByBusiness/{id}")]
        public async Task<IActionResult> GetByBusiness(
        int id,
        [FromServices] IGetCommentsByBusinessQuery getCommentsByBusinessQuery
        )
        {
            var data = await getCommentsByBusinessQuery.Execute(id);
            //var validate = await validator.ValidateAsync(model);
            if (data == null)
                return StatusCode(StatusCodes.Status400BadRequest, ResponseApiService.Response(StatusCodes.Status400BadRequest));

            return StatusCode(StatusCodes.Status200OK, ResponseApiService.Response(StatusCodes.Status200OK, data));
        }
    }
}
