namespace cqrs_parttern.Application.Abstractions;

public interface IProductRepository
{
    public Task<List<Domain.Product>> getAllProduct();
    public  Task<Domain.Product> getProductById(string productId);
    public Task<Domain.Product> createProduct(Domain.Product product);
    public Task<Domain.Product> updatePriceByProductId(string productId, string Price);           
    public Task<Domain.Product> deleteByIdProduct(string productId);
}