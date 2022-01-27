﻿using InsanKaynaklariYonetimiPlatformu.Entity.Entities;
using InsanKaynaklariYonetimiPlatformu.ViewModels.EmployeeVM;
using InsanKaynaklariYonetimiPlatformu.ViewModels.ManagerVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsanKaynaklariYonetimiPlatformu.BLL.Services.Absract
{
    public interface IEmployeeService
    {
        Employee CheckLogin(LoginVM login);
        List<Employee> GetListEmployees(int id);
        Employee AddEmployee(AddEmployeeVM employeeVM, int id, string mailextension);
        Employee GetEmployeeById(int id);
        int ChangesPassword(Employee employee, string password);
        int UpdateEmployees(int id, Employee employee);
        int DeleteEmployee(int id);
        List<DocumentVM> GetDocument(int id);
        List<Permission> GetPermissionListEmployees(int id);
        List<EmployeePermissionVM> GetPermissionListEmployeeByID(int id);
        bool AnyEmployeesPermission(AddEmployeesPermissionVM permissionVM);
        int AddPermissionEmployee(int id, EmployeePermissionVM permissionVM);
        bool AnyFilePath(string filepath);
        int AddDocumentByEmployeID(int id, string filePath, string fileName);
       
    }
}
