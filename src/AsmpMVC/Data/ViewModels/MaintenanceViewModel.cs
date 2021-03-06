﻿using AsmpMVC.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsmpMVC.ViewModels
{
    public class MaintenanceViewModel
    {


        public string IssueCode { get; set; }
        public DateTime DateRaised { get; set; }
        public MaintenanceCategory Category { get; set; }
        public string Item { get; set; }
        public MaintenancePriority Priority { get; set; }
        public MaintenanceStatus Status { get; set; }
        public string Note { get; set; }

    }
}
