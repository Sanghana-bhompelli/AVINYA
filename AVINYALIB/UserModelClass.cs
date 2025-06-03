using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVINYALIB.Models;
using Microsoft.EntityFrameworkCore;

namespace AVINYALIB
{
    public class UserModelClass : UserInterface
    {
        private readonly AvinyaContext _avinyaContext;

        public UserModelClass(AvinyaContext avinyacontext)
        {
            _avinyaContext = avinyacontext;
        }
        public async Task<List<UserModel>> GetAllUsers()
        {
            //LINQ Language Integrated Query

            var Userresult = await _avinyaContext.Transactions.Select(
                s => new UserModel
                {
                    UserId = s.UserId,
                    Name=s.Name,
                    Email=s.Email,
                    Password=s.Password,
                    Role=s.Role,
                    

                }
                ).ToListAsync();
            return Userresult;

        }
    }
}
