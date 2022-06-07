using API_Rest_Store_Management.Core.DTOs;
using API_Rest_Store_Management.Core.IRepository;
using API_Rest_Store_Management.Core.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API_Rest_Store_Management.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ProductController> _logger;
        private readonly IMapper _mapper;

        public ProductController(IUnitOfWork unitOfWork, ILogger<ProductController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetProducts([FromQuery] RequestParams requestParams)
        {
            var products = await _unitOfWork.Products.GetPagedList(requestParams);
            var result = _mapper.Map<IList<ProductDTO>>(products);
            return Ok(result);
        }
    }
}
