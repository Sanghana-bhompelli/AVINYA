using AVINYALIB;
using AVINYALIB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVINYAWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AccountInterface _accountInterface;

        public AccountController(AccountInterface accountInterface)
        {
            _accountInterface = accountInterface;
        }

        [HttpGet("GetAllAccounts")]
        public async Task<List<AccountModel>> GetAllAccounts()
        {
            List<AccountModel> lstAccountModel = await _accountInterface.GetAllAccounts();
            return lstAccountModel;

        }

    }
}
