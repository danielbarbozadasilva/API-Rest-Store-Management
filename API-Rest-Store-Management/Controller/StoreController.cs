using API_Rest_Store_Management.Core.DTOs;
using API_Rest_Store_Management.Core.IRepository;
using API_Rest_Store_Management.Core.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace API_Rest_Store_Management.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<StoreController> _logger;
        private readonly IMapper _mapper;

        public StoreController(IUnitOfWork unitOfWork, ILogger<StoreController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetStores([FromQuery] RequestParams requestParams)
        {
            var products = await _unitOfWork.Stores.GetPagedList(requestParams);
            var result = _mapper.Map<IList<StoreDTO>>(products);
            return Ok(result);
        }


    }
}
