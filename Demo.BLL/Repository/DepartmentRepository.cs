using Demo.DAL.Context;
using Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repository
{
    public class DepartmentRepository
    {
        private readonly AppDbContext dbContext;

        //GetAll Department, GetById, Delete, Create, Update
        //Dependancy Injection
        //FirstWay
        //[FromService]
        //Prop
        //Second Way
        //Function([FromService]arg)
        //Third Way
        //Constructor

        public DepartmentRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public List<Department> GetAll()
        {
       
            var Departments=dbContext.Departments.ToList();
            return Departments;
        }

    }
}
