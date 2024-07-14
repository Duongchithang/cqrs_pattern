using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cqrs_parttern.Application.Abstractions;
using cqrs_parttern.Application.Product.Commands;
using MediatR;
namespace cqrs_parttern.Application.Product.CommandHandlers
{
    /// <summary>
    /// IRequestHandler là kiểu trả về của handler CreateProductHandler
    /// CreateProductCommand là kiểu truyền vào của handler CreateProductHandler
    /// </summary>
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, Domain.Product>
    {
        public readonly IProductRepository _IProductRepository;

        public CreateProductHandler(IProductRepository _IProductRepository)
        {
            this._IProductRepository = _IProductRepository;
        }
        public async Task<Domain.Product> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var createProduct = new Domain.Product()
            {
                Id = command.Id,
                Price = command.Price,
                Product1 = command.Product01
            };
            // sau đó truyền vào hàm CreateProduct của IProductRepository để xử lí
            return await _IProductRepository.createProduct(createProduct);
        }
    }
   
}
