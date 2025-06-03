using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVINYALIB.Models;

namespace AVINYALIB
{
    public interface UserInterface
    {
        public Task<List<UserModel>> GetAllUsers();

    }
}
