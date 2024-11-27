﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluxorRP.Shared.Data
{
    public class Character
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int health { get; set; }
        public int strength { get; set; }
    }
}