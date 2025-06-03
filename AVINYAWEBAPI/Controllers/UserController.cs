using AVINYALIB.Models;
using AVINYALIB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVINYAWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserInterface _userInterface;

        public UserController(UserInterface userInterface)
        {
            _userInterface = userInterface;
        }

        [HttpGet("GetAllUsers")]
        public async Task<List<UserModel>> GetAllUsers()
        {
            List<UserModel> lstUserModel = await _userInterface.GetAllUsers();
            return lstUserModel;

        }
    }
}
