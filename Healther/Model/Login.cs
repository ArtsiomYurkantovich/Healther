using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Healther.Model
{
    public class Login
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Password { get; set; }
        public string Email { get; set; }
    }
}
