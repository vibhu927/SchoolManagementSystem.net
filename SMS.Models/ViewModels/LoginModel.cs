﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Models.ViewModels
{
    public class LoginModel
    {
        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}
