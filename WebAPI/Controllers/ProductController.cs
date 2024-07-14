using cqrs_parttern.Application.Product.Commands;
using cqrs_parttern.Application.Product.Queries;
using cqrs_parttern.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/getProduct")]
        public async Task<List<Product>> getAllProduct()
        {
            var product = await _mediator.Send(new ListProductsQuery());
            return product;
        }

        [HttpGet("/getProductById")]
        public async Task<IActionResult> getAllProduct(string ProductId)
        {
            var product = await _mediator.Send(new ProductByIdQuery(ProductId));
            System.Console.WriteLine("product >>>" , product);
            if(product == null){
                return BadRequest();
            }
            return Ok(new {
                message = "success",
                product
            });
        }


        [HttpPost("/createProduct")]
        public async Task<IActionResult> createProduct(Product product)
        {
            var createProduct = await _mediator.Send(new CreateProductCommand(product.Id, product.Price, product.Product1));
            return Ok(new
            {
                message = "create success",
                product = createProduct
            });
        }

        [HttpPost("/updateProductById")]
        public async Task<IActionResult> updateProductById(string Id, string Price)
        {
            var updateProduct = await _mediator.Send(new UpdateProductCommand(Id, Price));
            return Ok(new
            {
                message = "update successfully !",
                updateProduct
            });
        }
        [HttpPost("/deleteProductById")]
        public async Task<IActionResult> updateProductById(string productId)
        {
            var deleteProduct = await _mediator.Send(new DeleteProductCommand(productId));
            return Ok(new
            {
                message = "delete successfully !",
                deleteProduct
            });
        }

    }
}
