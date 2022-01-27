﻿using InsanKaynaklariYonetimiPlatformu.DAL.Repositories.Abstract;
using InsanKaynaklariYonetimiPlatformu.Entity.Entities;
using InsanKaynaklariYonetimiPlatformu.ViewModels.ManagerVM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariYonetimiPlatformu.DAL.Repositories.Concrete
{
    public class ManagerRepository : IManagerRepository
    {
        HRDataBaseContext dbContext;
        IEmployeeRepository employeeRepository;
        public ManagerRepository(HRDataBaseContext dataBaseContext,IEmployeeRepository _employeeRepository)
        {
            dbContext = dataBaseContext;
            employeeRepository = _employeeRepository;

        }
        public bool AnyMailExtension(string mailextension)
        {
            return dbContext.Companies.Any(a => a.MailExtension == mailextension);
        }

        public int InsertCompany(Company company)
        {
            dbContext.Companies.Add(company);
            return dbContext.SaveChanges();
        }

        public bool AnyMail(string managerMail)
        {
            return dbContext.Managers.Any(a => a.Email == managerMail);
        }

        public int InsertManager(Manager manager)
        {
            dbContext.Managers.Add(manager);
            return dbContext.SaveChanges();
        }

        public bool managerApproval(int id)
        {
            Manager manager = dbContext.Managers.SingleOrDefault(a => a.CompanyId == id);
            manager.IsApproved = true;
            return dbContext.SaveChanges() > 0;
        }

        public Manager CheckLogin(string email, string password)
        {


            return dbContext.Managers.SingleOrDefault(a => a.Email == email && a.Password == password);

        }

        public int InsertMemberShip(Membership membershipp)
        {
            dbContext.Memberships.Add(membershipp);
            return dbContext.SaveChanges();
        }

        public Company FindComapny(int companyId)
        {
            Company company = dbContext.Companies.Where(a => a.CompanyId == companyId).SingleOrDefault();
            return company;
        }

        public Manager FindManager(int managerId)
        {
            Manager manager = dbContext.Managers.Where(a => a.ManagerId == managerId).SingleOrDefault();
            return manager;
        }

        public Company FindCompany(int id)
        {
            Company company = dbContext.Companies.Where(a => a.Manager.ManagerId == id).SingleOrDefault();
            return company;
        }

        public List<Debit> GetListDebit(int id)
        {
            //Listelerken include ile employee de yanında getirecek.
            return dbContext.Debits.Include("Employee").Where(a => a.ManagerID == id && a.EmployeeID != null).ToList();
        }

        public int AddEmployeePermission(Permission permission)
        {
            //Db için kayıt işlemi gerçekleştirilir
            dbContext.Permissions.Add(permission);
            return dbContext.SaveChanges();
        }

        public Permission GetPermissionById(int permissionId)
        {
            return dbContext.Permissions.Include("Employee").Where(a => a.PermissionId == permissionId).SingleOrDefault();
        }

        public int UpdatePermission(Permission permission)
        {
            return dbContext.SaveChanges();
        }

        public int DeletedPermission(Permission permission)
        {
            dbContext.Permissions.Remove(permission);
            return dbContext.SaveChanges();
        }

        public List<Employee> GetEmployeesByManagerId(int managerID)
        {
            return dbContext.Employees.Where(a => a.ManagerId == managerID).ToList();
        }

        public List<Shift> GetShiftbyEmployeeId(int employeeId)
        {
            return dbContext.Shifts.Where(a => a.EmployeeID == employeeId).ToList();


        }

        public List<Respite> GetRespitebyShiftId(int shiftId)
        {
            return dbContext.Respites.Where(a => a.ShiftId == shiftId).ToList();
        }



        public List<Permission> GetPermissionByManagerId(int id)
        {
            return dbContext.Permissions.Where(a => a.EmployeeId == null && a.ManagerId == id).ToList();
        }

        public int AddPermissionManager(Permission permission)
        {
            dbContext.Permissions.Add(permission);
            return dbContext.SaveChanges();
        }

        public int UpdatePermissionManager(Permission permission)
        {
            return dbContext.SaveChanges();
        }

        public Debit GetDebitById(int Id)
        {
            return dbContext.Debits.Where(a => a.ID == Id).SingleOrDefault();
        }

        public int DeletedDebit(Debit debit)
        {
            dbContext.Debits.Remove(debit);
            return dbContext.SaveChanges();
        }

        public int AddEmployeeDebit(Debit debit)
        {
            dbContext.Debits.Add(debit);
            return dbContext.SaveChanges();
        }


        public bool addShiftDetails(Shift shift)
        {
            dbContext.Shifts.Add(shift);


            return dbContext.SaveChanges() > 0 ? true : false;
        }

        public int GetShiftOrderyBydescending()
        {
            Shift shift = dbContext.Shifts.OrderByDescending(a => a.ShiftId).First();
            return shift.ShiftId;
        }

        public bool addRespitebyShiftID(Respite respite)
        {
            dbContext.Respites.Add(respite);

            return dbContext.SaveChanges() > 0 ? true : false;
        }

        public List<Debit> GetListManagersDebit(int id)
        {
            return dbContext.Debits.Where(a => a.EmployeeID == null && a.ManagerID == id).ToList();
        }

        public int AddDebitManager(Debit debit)
        {
            dbContext.Debits.Add(debit);
            return dbContext.SaveChanges();
        }

        public int DeletedDocument(int id)
        {
            Document document = dbContext.Documents.Where(a => a.DocumentID == id).SingleOrDefault();
            if (document == null)
            {
                return 1;
            }
            dbContext.Documents.Remove(document);
            return dbContext.SaveChanges();
        }

        public bool DeleteShiftDetails(int shiftId)
        {
            List<Shift> shifts = dbContext.Shifts.Include(a => a.Respites).Where(a => a.ShiftId == shiftId).ToList();
            foreach (Shift item in shifts)
            {
                dbContext.Shifts.Remove(item);

            }


            return dbContext.SaveChanges() > 0;
        }

        public Shift GetShiftDetailsByShiftId(int shiftId)
        {
            return dbContext.Shifts.Find(shiftId); // list döndüğünü kontrol et
        }

        public Respite GetRespitebyRespiteID(int respiteID)
        {
            return dbContext.Respites.Find(respiteID);
        }

        public bool UpdateShiftDetails(Shift shift, Respite respite)
        {
            dbContext.Shifts.Update(shift);
            dbContext.Respites.Update(respite);
            return dbContext.SaveChanges() > 0;
        }

        public Shift GetShiftbyRespiteid(int id)
        {
            Respite respite = dbContext.Respites.Include(a => a.Shift).Where(a => a.RespiteID == id).SingleOrDefault();
            Shift shift = respite.Shift;
            return shift;

        }

        
    }
}

