﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apricot.Data.Models
{
    public class Bill_M
    {
        [Key]
        [Column(Order=1)]
        public Int64 Emp_ID { get; set; }

        [ForeignKey("Emp_ID")]
        public virtual Employee Manager { get; set; }

        [Key]
        [Column(Order=2)]
        public Int64 Bill_ID { get; set; }

        [ForeignKey("Bill_ID")]
        public virtual Bill Bill { get; set; }
    }
}
