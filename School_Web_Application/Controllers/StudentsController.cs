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
    public class StudentsController : Controller
    {
        readonly SchoolHelper _helper = new SchoolHelper();
        public async Task<IActionResult> Index()
        {
           
            var students = new List<Student>();
            HttpClient client = _helper.Initial();
            HttpResponseMessage responseMessage = await client.GetAsync("api/Students");
            if (responseMessage.IsSuccessStatusCode)
            {
                var result = responseMessage.Content.ReadAsStringAsync().Result;
                students = JsonConvert.DeserializeObject<List<Student>>(result);

            }
           
            return View(students);
        }
    }
}