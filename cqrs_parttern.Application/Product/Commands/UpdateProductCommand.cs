using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace cqrs_parttern.Application.Product.Commands
{
    
    public class UpdateProductCommand : IRequest<Domain.Product>
    {
        public string ProductId { set; get; }
        public string Price { get; set; }

        public UpdateProductCommand(string productId, string Price)
        {
            this.ProductId = productId;
            this.Price = Price;
        }
    }
}
