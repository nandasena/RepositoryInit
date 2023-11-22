using Microsoft.AspNetCore.Mvc;
using RepositoryInit.Core.IConfiguration;
using RepositoryInit.Models;

namespace RepositoryInit.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;

        private readonly IUnitOfWork _unitOfWork;
        public UserController(ILogger<UserController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            if(ModelState.IsValid)
            {
                await _unitOfWork.Users.Add(user);
                await _unitOfWork.CompleteAsync();

                return CreatedAtAction("GetUser", new { user.Id }, user);
            }

            return StatusCode(500);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _unitOfWork.Users.GetById(id);
            if (User == null)
            {
                return NotFound();
            }

            return Ok(user);
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
              var Users =   await _unitOfWork.Users.All();
              await _unitOfWork.CompleteAsync();

            return Ok(Users);
        }



    }
}
