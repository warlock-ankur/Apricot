﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apricot.Data.Models
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 CmtID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Comment Subject")]
        public String Cmt_Subject { get; set; }

        [StringLength(1000)]
        [Required]
        [Display(Name = "Comment Body")]
        public String Cmt_Body { get; set; }

        [Display(Name = "Time Stamp")]
        [DataType(DataType.DateTime)]
        public DateTime TimeStamp { get; set; }

        [Required]
        public Int64 Bill_ID { get; set; }

        [ForeignKey("Bill_ID")]
        public virtual Bill Bill { get; private set; }

        [Required]
        public Int64 Emp_ID { get; set; }

        [ForeignKey("Emp_ID")]
        public virtual Employee Employee { get; set; }
    }
}
