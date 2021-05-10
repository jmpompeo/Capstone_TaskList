using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone_TaskList.Data
{
    public class ApplicationUser : IdentityUser
    {
        public int Age { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
