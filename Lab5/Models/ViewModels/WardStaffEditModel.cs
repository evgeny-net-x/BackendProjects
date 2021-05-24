﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Backend5.Models.ViewModels
{
    public class WardStaffEditModel
    {
        [Required]
        [MaxLength(200)]
        public String Name { get; set; }

        public String Position { get; set; }
    }
}
