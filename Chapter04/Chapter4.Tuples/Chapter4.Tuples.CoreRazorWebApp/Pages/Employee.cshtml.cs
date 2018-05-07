using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Chapter4.Tuples.TupleLib;

namespace Chapter4.Tuples.CoreRazorWebApp.Pages
{
    public class EmployeeModel : PageModel
    {
        public void OnGet()
        {
            var employee = new Employee();
            (string FirstName, string LastName, int YearsOfExperience) newEmployee = employee.GetBasicDetails();

            ViewData["FirstName"] = newEmployee.FirstName;
            ViewData["LastName"] = newEmployee.LastName;
            ViewData["YearsOfExperience "] = newEmployee.YearsOfExperience;

        }
    }
}