﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Backend6.Models.ViewModels
{
    public class ForumCategoryCreateModel
    {
        [Required]
        public String Name { get; set; }
    }
}
