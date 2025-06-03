using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVINYALIB.Models;
using Microsoft.EntityFrameworkCore;

namespace AVINYALIB
{
    public class AccountModelClass : AccountInterface
    {
        private readonly AvinyaContext _avinyaContext;

        public AccountModelClass(AvinyaContext avinyacontext)
        {
            _avinyaContext = avinyacontext;
        }
        public async Task<List<AccountModel>> GetAllAccounts()
        {
            //LINQ Language Integrated Query

            var Accountresult = await _avinyaContext.Accounts.Select(
                s => new AccountModel
                {
                    AccountId = s.AccountId,
                    UserId = (int?)s.UserId,
                    AccountNumber = s.AccountNumber,
                    Balance = s.Balance,
                }
                ).ToListAsync();
            return Accountresult;

        }
    }
}
