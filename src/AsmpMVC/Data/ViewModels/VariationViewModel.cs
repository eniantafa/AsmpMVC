﻿using AsmpMVC.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsmpMVC.ViewModels
{
    public class VariationViewModel
    {

        public string VariationCode { get; set; }
        public DateTime DateReleased { get; set; }
        public VariationContract Contract { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public double Price { get; set; }
        public int EOT { get; set; }
        public VariationStatus Status { get; set; }
        public bool Claimed { get; set; }
        public bool Paid { get; set; }
        public DateTime PaymentDate { get; set; }

    }
}
