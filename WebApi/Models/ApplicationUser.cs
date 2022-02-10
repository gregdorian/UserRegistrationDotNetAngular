﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Column(TypeName="nvarchar(150)")]
        public String FullName { get; set; }
        public string doctoIdent { get; set; }
        public string company { get; set; }
    }
}
