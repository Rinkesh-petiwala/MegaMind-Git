using MegaMindsPractical.Models;
using MegaMindsPractical.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace MegaMindsPractical.Controllers
{
    //[Route("[controller]")]
    //[ApiController]
    public class StudentController : Controller
    {
       
        private readonly IStudentService _studentService;

        public StudentController(IStudentService StudentService)
        {
            _studentService = StudentService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult<StudentDataTable>> StudentList()
        {
            try
            {
                var data = await _studentService.GetStudentListAsync();

                var jsonOptions = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.Preserve,
                    // You can also customize other JsonSerializerOptions properties if needed.
                };

                // Serialize the data using the custom JsonSerializerOptions
                return new StudentDataTable { data = data };

    
            }
            catch
            {
                throw;
            }
        }


        [HttpGet]
        public async Task<IEnumerable<Student>> GetStudentById(int Id)
        {
            try
            {
                var result = await _studentService.GetStudentByIdAsync(Id);

                if (result == null)
                {
                    return result;
                }

                return result;
            }
            catch
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddEditStudent(Student Student)
        {
            string status = "";
            try
            {
                if (!ModelState.IsValid)
                {
                    return Json(new { status = status });
                }

                bool IsCenterDublicate = _studentService.CheckDublication(Student.Name, Student.Id);
                if (IsCenterDublicate)
                {
                    status = "Dublicate";
                    return Json(new { status = status });
                }
                if (Student.Id > 0)
                {
                    await _studentService.UpdateStudentAsync(Student);
                    status = "Update";
                }
                else
                {
                    await _studentService.AddStudentAsync(Student);
                    status = "success";
                }
                return Json(new { status = status });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return Json(new { status = status });

        }


        [HttpDelete]
        public async Task<int> DeleteStudent(int Id)
        {
            try
            {
                var result = await _studentService.DeleteStudentAsync(Id);
                return result;
            }
            catch
            {
                throw;
            }
        }

        [HttpGet]
        public List<State> BindStateDetails()
        {
            var stateDetail = _studentService.BindState();
            return stateDetail;
        }

        [HttpGet]
        public List<City> BindCityDetails(int StateId)
        {
            var cityDetail = _studentService.BindCity(StateId);
            return cityDetail;
        }

        //public async JsonResult BindState()
        //{
        //    var stateDetail = await _studentService.BindState();
        //    return new JsonResult(stateDetail);
        //}

    }
}
