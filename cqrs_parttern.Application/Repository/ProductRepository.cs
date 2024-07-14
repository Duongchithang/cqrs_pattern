using cqrs_parttern.Application.Abstractions;
using cqrs_parttern.Application.Product.Dtos;
using cqrs_parttern.Domain;
using Microsoft.EntityFrameworkCore;

namespace cqrs_parttern.Application.Repository;

public class ProductRepository  : IProductRepository
{
    private readonly myDataBaseContext _context;

    public ProductRepository(myDataBaseContext context)
    {
        _context = context;
    }


    public async Task<List<Domain.Product>> getAllProduct()
    {
       var products = await _context.Products.ToListAsync();
       return products;
    }

    public async Task<Domain.Product> getProductById(string productId)
    {
        var product = await  _context.Products.FindAsync(productId);
        _context.SaveChangesAsync();
        return product;
    }

    public async Task<Domain.Product> createProduct(Domain.Product product)
    {
        var createProduct = await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
        return createProduct.Entity;
    }

    public async Task<Domain.Product> updatePriceByProductId(string productId, string Price)
    {
        var getProductId = await _context.Products.FindAsync(productId);
        getProductId.Price = Price;
        _context.Products.Update(getProductId);
        _context.SaveChanges();
        return getProductId;
    }

    public async Task<Domain.Product> deleteByIdProduct(string productId)
    {
        var deleteProduct = await _context.Products.FindAsync(productId);
        _context.Products.Remove(deleteProduct);
        _context.SaveChangesAsync();
        return deleteProduct;
    }
}