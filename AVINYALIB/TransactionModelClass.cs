using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVINYALIB.Models;
using Microsoft.EntityFrameworkCore;

namespace AVINYALIB
{
    public class TransactionModelClass:TransactionInterface
    {
        private readonly AvinyaContext _avinyaContext;

        public TransactionModelClass(AvinyaContext avinyacontext)
        {
            _avinyaContext = avinyacontext;
        }
        public async Task<List<TransactionModel>> GetAllTransactions()
        {
            //LINQ Language Integrated Query

            var Transactionresult = await _avinyaContext.Transactions.Select(
                s => new TransactionModel
                {
                    TransactionId = s.TransactionId,
                    FromAccountId = (int?)s.FromAccountId,
                    ToAccountId = (int?)s.ToAccountId,
                    Amount = s.Amount,
                    Date=s.Date,
                    Status = s.Status,
                    
                }
                ).ToListAsync();
            return Transactionresult;

        }
    }
}
