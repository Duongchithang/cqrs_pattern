using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace cqrs_parttern.Application.Product.Commands
{
    // IRequest<Domain.Product> là kiểu trả về của handler CreateProductHandler
    public class CreateProductCommand : IRequest<Domain.Product>
    {
        public string Id { set; get; }
        public string Price { set; get; }
        public string Product01 { set; get; }

        public CreateProductCommand(string Id, string Price, string Product01)
        {
            this.Id = Id;
            this.Price = Price;
            this.Product01 = Product01;
        }

    }
}
