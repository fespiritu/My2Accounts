﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace My2AccountsInAGlance.Model
{
    public class DataPoint
    {
        [Key]
        public long Id { get; set; }

        public string Time { get; set; }
        public long JSTicks { get; set; }
        public decimal Value { get; set; }


    }
}
