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
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, Domain.Product>
    {
        private readonly IProductRepository _IProductRepository;
        public UpdateProductHandler(IProductRepository IProductRepository)
        {
            _IProductRepository = IProductRepository;
        }

        public async Task<Domain.Product> Handle(UpdateProductCommand command, CancellationToken cancellationToken)
        {
            return await _IProductRepository.updatePriceByProductId(command.ProductId, command.Price);
        }
    }
}
