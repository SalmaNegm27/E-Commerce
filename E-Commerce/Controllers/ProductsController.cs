// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECommerce
{
    using AutoMapper;
    using FluentValidation;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using System.ComponentModel.DataAnnotations;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductUnitOfWork _productUnitOfWork;

       private readonly IMapper _mapper;
        private readonly IValidator<ProductViewModel> _validator;

        public ProductsController(IProductUnitOfWork productUnitOfWork, IMapper mapper, IValidator<ProductViewModel> validator)
        {
            _productUnitOfWork = productUnitOfWork;
            _mapper = mapper;   
            _validator = validator;
        }

        // GET: api/<ProductsController>
        [HttpGet]

        public async  Task<IActionResult> GetAll()
        {
            var entities = await _productUnitOfWork.ReadAsync();
           
            var entitiesResult = _mapper.Map<IEnumerable<ProductViewModel>>(entities);
           
            return Ok(entitiesResult);


        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            Product product = await _productUnitOfWork.ReadByIdAsync(id);
            ProductViewModel productViewModel = _mapper.Map<ProductViewModel>(product);

            var validationResult = await _validator.ValidateAsync(productViewModel);

            if (!validationResult.IsValid)
                return BadRequest(new { errors = validationResult.Errors });

            return Ok(productViewModel);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<ProductViewModel> Post([FromBody] Product product)
        {
            product = await _productUnitOfWork.CreateAsync(product);
            return _mapper.Map<ProductViewModel>(product);
        }

        // PUT api/<ProductsController>/5
        [HttpPut]
        public async Task<ProductViewModel> Put([FromBody] Product product)
        {
            product = await _productUnitOfWork.UpdateAsync(product);
            return _mapper.Map<ProductViewModel>(product);
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _productUnitOfWork.DeleteAsync(id);
        }
    }
}