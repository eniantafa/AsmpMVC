﻿using AsmpMVC.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsmpMVC.ViewModels
{
    public class ProgressStageViewModel
    {

        public ProgressStageStage Stage { get; set; }
        public double Value { get; set; }
        public DateTime DateCompleted { get; set; }
        public string CompletedBy { get; set; }
        public DateTime DateApproved { get; set; }
        public string ApprovedBy { get; set; }
        public ProgressStagePaymentStatus PaymentStatus { get; set; }
        public DateTime DatePaid { get; set; }

    }
}
