using cqrs_parttern.Application.Abstractions;
using cqrs_parttern.Application.Product.Queries;
using MediatR;

namespace cqrs_parttern.Application.Product.QueryHandlers;

public class ListProductsQueryHandler : IRequestHandler<ListProductsQuery, List<Domain.Product>>
{
    private readonly IProductRepository IProductRepository;

    public ListProductsQueryHandler(IProductRepository _IProductRepository)
    {
        IProductRepository = _IProductRepository;
    }

    public async Task<List<Domain.Product>> Handle(ListProductsQuery query, CancellationToken cancellationToken)
    {
        return await IProductRepository.getAllProduct();
    } 
}