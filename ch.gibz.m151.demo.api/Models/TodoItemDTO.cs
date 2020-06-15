﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ch.gibz.m151.demo.api.Models
{
    public class TodoItemDTO
    {
        [Required]
        public long Id { get; set; }
        public string Name { get; set; }
        [DefaultValue(false)]
        public bool IsComplete { get; set; }
    }
}
