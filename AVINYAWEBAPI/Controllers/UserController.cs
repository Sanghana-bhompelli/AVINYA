using AVINYALIB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVINYAWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("GetAllUsers")]
        public List<UserModel> GetAllUsers()
        {
            UserModelClass objUserModelClass = new UserModelClass();

            List<UserModel> lstUsers = objUserModelClass.GetAllUsers();

            return lstUsers;

        }
    }
}
