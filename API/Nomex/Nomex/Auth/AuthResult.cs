using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nomex.Dtos;

namespace Nomex.Auth
{
    public class AuthResult
    {
        public UserReadDto User { get; set; }
        public string Token { get; set; }
        public bool Success { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
