﻿using InsanKaynaklariYonetimiPlatformu.Entity.Entities;
using InsanKaynaklariYonetimiPlatformu.ViewModels.ManagerVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariYonetimiPlatformu.DAL.Repositories.Abstract
{
    public interface IManagerRepository
    {

        bool AnyMailExtension(string mailextension);


        int InsertCompany(Company company);


        bool AnyMail(string managerMail);


        int InsertManager(Manager manager);


        bool managerApproval(int id);


        Manager CheckLogin(string email, string password);


        int InsertMemberShip(Membership membershipp);


        Company FindComapny(int companyId);


        Manager FindManager(int managerId);
        Company FindCompany(int id);
        List<Debit> GetListDebit(int id);
        int AddEmployeePermission(Permission permission);
        Permission GetPermissionById(int permissionId);
        int UpdatePermission(Permission permission);
        int DeletedPermission(Permission permission);
        List<Employee> GetEmployeesByManagerId(int managerID);
        
        List<Respite> GetRespitebyShiftId(int shiftId);
        List<Permission> GetPermissionByManagerId(int id);
        int AddPermissionManager(Permission permission);
        int UpdatePermissionManager(Permission permission);
        
        Debit GetDebitById(int Id);
        int DeletedDebit(Debit debit);
        int AddEmployeeDebit(Debit debit);
        bool addShiftDetails(Shift shift);
        int GetShiftOrderyBydescending();
      
        bool addRespitebyShiftID(Respite respite);
        List<Debit> GetListManagersDebit(int id);
        int AddDebitManager(Debit debit);
        int DeletedDocument(int id);
<<<<<<< HEAD
        int ChangePassword(Manager manager);
        int ChangeAccount(Manager manager);
        int ChangeSettings(Company company);
=======
        List<Shift> GetShiftbyEmployeeId(int employeeID);
        bool DeleteShiftDetails(int shiftId);
        Shift GetShiftDetailsByShiftId(int shiftId);
        Respite GetRespitebyRespiteID(int respiteID);
        bool UpdateShiftDetails(Shift shift, Respite respite);
        Shift GetShiftbyRespiteid(int id);
       
>>>>>>> a3b6ca62d4e8e1f315736b2c76e598603e52ee63
    }
}
