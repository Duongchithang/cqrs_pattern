using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace cqrs_parttern.Application.Product.Queries
{
    // khi controller gọi đến ProductByIdQuery thì sẽ gọi đến ProductByIdHandler
    // IRequest<Domain.Product> là kiểu trả về của handler ProductByIdHandler
    public class ProductByIdQuery : IRequest<Domain.Product>
    {
        public string productId {set; get;}
        public ProductByIdQuery(string productId){
            this.productId = productId;
        }
    }
}