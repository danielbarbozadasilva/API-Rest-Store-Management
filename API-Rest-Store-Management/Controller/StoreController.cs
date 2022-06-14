using API_Rest_Store_Management.Core.DTOs;
using API_Rest_Store_Management.Core.IRepository;
using API_Rest_Store_Management.Core.Models;
using API_Rest_Store_Management.Data;
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


        [HttpGet("{id:int}", Name = "GetStore")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetStore(int id)
        {
            var store = await _unitOfWork.Stores.Get(q => q.Id == id);
            var result = _mapper.Map<StoreDTO>(store);
            return Ok(result);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateStore([FromBody] CreateStoreDTO storeDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateStore)}");
                return BadRequest(ModelState);
            }

            var store = _mapper.Map<Store>(storeDTO);
            await _unitOfWork.Stores.Insert(store);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetStore", new { id = store.Id }, store);
        }


        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateStore(int id, [FromBody] UpdateStoreDTO storeDTO)
        {
            if (!ModelState.IsValid || id < 1)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateStore)}");
                return BadRequest(ModelState);
            }

            var store = await _unitOfWork.Stores.Get(q => q.Id == id);
            if (store == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateStore)}");
                return BadRequest(ModelState);
            }

            _mapper.Map(storeDTO, store);
            _unitOfWork.Stores.Update(store);
            await _unitOfWork.Save();

            return NoContent();
        }

    }
}
