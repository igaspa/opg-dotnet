﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPG.Models
{
    public class StoreUser :IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<OrderForm> OrderForms { get; set; }
    }
}
