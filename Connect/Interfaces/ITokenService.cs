using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Connect.Entities;

namespace Connect.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}