﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoStore.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public int DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte Unknown=0;
        public static readonly byte PayAsYouGo = 1;
    }
}