using ProyectoWebApi.DesarrolloIntegral.Domain.Models;

namespace ProyectoWebApi.DesarrolloIntegral.Application.Features
{
    public class ResponseApiService
    {
        public static BaseResponseModel Response(int statuscode, object data = null, string message = null)
        {
            bool success = false;
            if (statuscode >= 200 && statuscode < 300)
                success = true;
            var result = new BaseResponseModel
            {
                StatusCode = statuscode,
                Success = success,
                Message = message,
                Data = data
            };
            return result;
        }
    }
}
