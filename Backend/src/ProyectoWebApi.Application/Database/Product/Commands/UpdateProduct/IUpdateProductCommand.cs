namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Commands.UpdateProduct
{
    public interface IUpdateProductCommand
    {
        Task<UpdateProductModel> Execute(UpdateProductModel model);
    }
}
