using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace cqrs_parttern.Application.Product.Commands
{
    public class DeleteProductCommand : IRequest<Domain.Product>
    {
        public string _productId;
        public DeleteProductCommand(string productId){
           this._productId = productId;
        }
    }
}