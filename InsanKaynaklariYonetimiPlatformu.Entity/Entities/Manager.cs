﻿using InsanKaynaklariYonetimiPlatformu.Entity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariYonetimiPlatformu.Entity.Entities
{
    public class Manager
    {
        public Manager()
        {
            Employees = new HashSet<Employee>();
            Permissions = new HashSet<Permission>();
            Expenditures = new HashSet<Expenditure>();
            Debits = new HashSet<Debit>();
           
        }

        public int ManagerId { get; set; }
        public string FullName { get; set; }
        public string Photo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
       
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; }
      
        public virtual Admin Admin { get; set; }
        public virtual Comment Comment { get; set; }
       public virtual int CompanyId { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }
        public virtual ICollection<Expenditure> Expenditures { get; set; }
        public virtual ICollection<Debit> Debits { get; set; }
       

        public static bool AddComment(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
