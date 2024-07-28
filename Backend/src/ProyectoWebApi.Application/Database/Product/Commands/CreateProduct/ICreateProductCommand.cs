namespace ProyectoWebApi.DesarrolloIntegral.Application.Database.Product.Commands.CreateProduct
{
    public interface ICreateProductCommand
    {
        Task<CreateProductModel> Execute(CreateProductModel model);
    }
}
