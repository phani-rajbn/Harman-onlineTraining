using SampleWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleWebApi.Controllers
{
    public class EmployeeController : ApiController
    {
        public IHttpActionResult GetAllEmployees()
        {
            var context = new MyDBEntities();
            var data = context.Employees;
            return Ok(data);
        }

        public IHttpActionResult GetEmployee(string id)
        {
            //id to be passed as Querystring thro the URL..
            var empid = int.Parse(id);
            var context = new MyDBEntities();
            var data = context.Employees.FirstOrDefault((e) => e.EmpID == empid);
            if (data != null)
                return Ok(data);
            else
                return NotFound();
        } 

        public IHttpActionResult PostNewEmployee(Employee emp)
        {
            var context = new MyDBEntities();
            context.Employees.Add(emp);
            context.SaveChanges();//commit the operation....
            return Ok("Added Successfully");
        }
    }
}
