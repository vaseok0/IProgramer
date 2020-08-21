﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IProgramer.Models
{
    public class User : IdentityUser
    {
        public override string UserName { get; set; }
    }
}
