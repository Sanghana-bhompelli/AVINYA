using AVINYALIB;
using AVINYALIB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AVINYAWEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly TransactionInterface _transactionInterface;

        public TransactionController(TransactionInterface transactionInterface)
        {
            _transactionInterface = transactionInterface;
        }

        [HttpGet("GetAllTransactions")]
        public async Task<List<TransactionModel>> GetAllTransactions()
        {
            List<TransactionModel> lstTransactionModel = await _transactionInterface.GetAllTransactions();
            return lstTransactionModel;

        }
    }
}
