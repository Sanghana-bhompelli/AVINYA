using AVINYALIB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVINYAWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        [HttpGet("GetAllTransactions")]
        public List<TransactionModel> GetAllTransactions()
        {
            TransactionModelClass objTransactionModelClass = new TransactionModelClass();

            List<TransactionModel> lstTransaction = objTransactionModelClass.GetAllTransactions();

            return lstTransaction;

        }
    }
}
