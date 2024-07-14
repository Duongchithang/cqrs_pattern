using MediatR;
namespace cqrs_parttern.Application.Product.Queries;

public record ListProductsQuery : IRequest<List<Domain.Product>>;