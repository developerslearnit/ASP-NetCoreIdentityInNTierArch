using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityInNTierNetCore.Domain.Entities
{
    public class User:IdentityUser
    {
        //Add additional fields to the default ones

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
