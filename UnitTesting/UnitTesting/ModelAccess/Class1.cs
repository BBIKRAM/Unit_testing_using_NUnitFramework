using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using UnitTesting.Models;

namespace UnitTesting.ModelAccess
{
    /// <summary>
    /// Interface for providing functnality for Department Data Access
    /// </summary>
    public interface IDepartmentAccess
    {
        List<Department> GetDepartments();
        Department GetDepartment(int id);
        void CreateDepartment(Department dept);
        bool CheckDeptExist(int id);

        void DeleteDepartment(int id);
        void UpdateDepartment(Department dept);
         Department get_Department_Details(int id);

    }

    /// <summary>
    /// The Department Data Access
    /// </summary>
    public class DepartmentAccess : IDepartmentAccess
    {
        CompanyEntities entities;
        public DepartmentAccess()
        {
            entities = new CompanyEntities();
        }
        /// <summary>
        /// Get All Departments
        /// </summary>
        /// <returns></returns>
        public List<Department> GetDepartments()
        {
            var depts = entities.Departments.ToList();
            return depts;
        }
        /// <summary>
        /// Get Department base on Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Department GetDepartment(int id)
        {
            var dept = entities.Departments.Find(id);
            return dept;
        }
        /// <summary>
        /// Create Department
        /// </summary>
        /// <param name="dept"></param>
        public void CreateDepartment(Department dept)
        {
            entities.Departments.Add(dept);
            entities.SaveChanges();
        }

        public bool CheckDeptExist(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteDepartment(int id)
        {
            var data = entities.Departments.Find(id);
            entities.Departments.Remove(data);
            entities.SaveChanges(); 
        }

        public Department get_Department_Details(int id)
        {
            var data = entities.Departments.Where(x=>x.DeptNo==id).First();
            return data;
        }

        public void UpdateDepartment(Department dept)
        {
            var data= entities.Departments.Find(dept.DeptNo);
            data.DeptNo = dept.DeptNo;
            data.Location =dept.Location;
            data.Dname =dept.Dname;
            entities.SaveChanges();
        }


    }
}