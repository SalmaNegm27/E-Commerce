namespace ECommerce.Application
{
    using AutoMapper;
    using FluentValidation;
    using Microsoft.AspNetCore.Mvc;
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<TEntity, TViewModel> : ControllerBase where 
        TEntity : BaseEntity
        where TViewModel : BaseViewModel
    {
        protected readonly IBaseUnitOfWork<TEntity> _baseUnitOfWork;
        protected readonly IMapper _mapper;
        private readonly IValidator<BaseViewModel> _validator;

        public BaseController(IBaseUnitOfWork<TEntity> baseUnitOfWork, IMapper mapper, IValidator<BaseViewModel> validator)
        {
            _baseUnitOfWork = baseUnitOfWork;
            _mapper = mapper;
            _validator = validator;
        }
        // GET: api/<ProductsController>
        [HttpGet]

        public async Task<IActionResult> GetAll()
        {
            var entities = await _baseUnitOfWork.ReadAsync();

            var entitiesResult = _mapper.Map<IEnumerable<TViewModel>>(entities);

            return Ok(entitiesResult);
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            TEntity  entity = await _baseUnitOfWork.ReadByIdAsync(id);
            BaseViewModel baseViewModel = _mapper.Map<BaseViewModel>(entity);

            var validationResult = await _validator.ValidateAsync(baseViewModel);

            if (!validationResult.IsValid)
                return BadRequest(new { errors = validationResult.Errors });

            return Ok(baseViewModel);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<BaseViewModel> Post([FromBody] TEntity entity)
        {
            entity = await _baseUnitOfWork.CreateAsync(entity);
            return _mapper.Map<BaseViewModel>(entity);
        }

        // PUT api/<ProductsController>/5
        [HttpPut]
        public async Task<BaseViewModel> Put([FromBody] TEntity entity)
        {
            entity = await _baseUnitOfWork.UpdateAsync(entity);
            return _mapper.Map<BaseViewModel>(entity);
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _baseUnitOfWork.DeleteAsync(id);
        }
    }
}
    

