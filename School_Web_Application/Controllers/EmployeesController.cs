using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using School_Web_Application.Helpers;
using School_Web_Application.Models;

namespace School_Web_Application.Controllers
{
    public class EmployeesController : Controller
    {
        SchoolHelper _api = new SchoolHelper();
        public async Task<IActionResult> Index()
        {
            List<Employee> employees = new List<Employee>();

            HttpClient client = _api.Initial();
            HttpResponseMessage response = await client.GetAsync("api/Employees");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                employees = JsonConvert.DeserializeObject<List<Employee>>(result);

            }
            return View(employees);
        }


    }
}