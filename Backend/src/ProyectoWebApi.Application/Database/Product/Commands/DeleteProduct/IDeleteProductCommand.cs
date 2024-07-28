namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Commands.DeleteProduct
{
    public interface IDeleteProductCommand
    {
        Task<bool> Execute(int productId);
    }
}
