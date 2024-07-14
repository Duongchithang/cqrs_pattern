using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cqrs_parttern.Application.Abstractions;
using cqrs_parttern.Application.Product.Commands;
using MediatR;

namespace cqrs_parttern.Application.Product.CommandHandlers
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, Domain.Product>
    {
        private readonly IProductRepository _IProductRepository;
        public DeleteProductHandler(IProductRepository IProductRepository){
         this._IProductRepository = IProductRepository;
        }
        public async Task<Domain.Product> Handle(DeleteProductCommand command, CancellationToken cancellationToken)
        {
            System.Console.WriteLine("Delete active >>>>>");
            return await _IProductRepository.deleteByIdProduct(command._productId);
        }
    }
}