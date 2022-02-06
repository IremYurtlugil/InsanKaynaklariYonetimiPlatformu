﻿using InsanKaynaklariYonetimiPlatformu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariYonetimiPlatformu.ViewModels.ManagerVM
{
    public class EditPremiumVm
    {
        public EditPremiumVm()
        {
            Employees = new List<Employee>();
        }
        public int EmployeeID { get; set; }
        public List<Employee> Employees { get; set; }
       
        [Display(Name = "Maaş")]
        public decimal Salary { get; set; }
        [Display(Name = "Prim Oranı")]
        public decimal PremiumRate { get; set; }
        private decimal _netSalary;

        [Display(Name = "Toplam Maaş")]
        public decimal NetSalary
        {
            get { return _netSalary; }
            set { _netSalary = Salary*(1+PremiumRate); }
        }

      

    }
}
