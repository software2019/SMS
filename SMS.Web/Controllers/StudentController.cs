using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMS.Web.Models;
using SMS.Data.Models;
using SMS.Data.Services;
using Microsoft.AspNetCore.Authorization;

namespace SMS.Web.Controllers
{
    [Authorize]
    public class StudentController : BaseController
    {
        private readonly StudentService svc;
        public StudentController()
        {
            svc = new StudentService();
        }

        // GET /student/index
        public IActionResult Index()
        {
            var students = svc.GetStudents();
            return View(students);
        }

        // GET /student/details/{id}
        public IActionResult Details(int id)
        {
            var student = svc.GetStudent(id);
            if (student == null)
            {
                Alert("Student Not Found", AlertType.warning);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        [Authorize(Roles = "Admin")]
        // GET /student/create
        public IActionResult Create()
        {
            // render blank form
            return View();
        }

       
        // POST /student/create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name,Course,Age,Email")]Student s)
        {
            if (ModelState.IsValid)
            {
                svc.AddStudent(s);

                // add alert confirming student created successfully
                Alert("Student created successfully", AlertType.success);

                // redirect to newly created student details view (not index)

                return RedirectToAction(nameof(Index));
            }

            // redisplay the form for editing
            return View(s);

        }

        // GET /student/edit/{id}
        public IActionResult Edit(int id)
        {
            // load student via service
            var s = svc.GetStudent(id);
            if (s == null)
            {
                // add an alert and redirect to Index

                return NotFound();
            }
            // pass student to view for editing
            return View( s );
        }


        // POST /student/edit/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id, Name, Course, Age, Email")] Student s)
        {
            if (ModelState.IsValid)
            {
                svc.UpdateStudent(s);

                // add alert and redirect to newly updated student details view (not index)

                return RedirectToAction(nameof(Index));
            }
            // redisplay the form for editing
            return View(s);
        }

        // GET / student/delete/{id}
        public IActionResult Delete(int id)
        {
            // load student via service 
            var s = svc.GetStudent(id);
            
            // pass student to view for deletion confirmation
            return View( s );
        }


        // POST /student/delete/{id}
        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            // delete student via service
            svc.DeleteStudent(id);

            Alert("Student deleted successfully", AlertType.success);

            // redirect to the index view
            return RedirectToAction(nameof(Index));
        }


        // GET /student/createticket/{id}
        public IActionResult CreateTicket(int id)
        {
            var s = svc.GetStudent(id);
            if (s == null)
            {
                // add an alert and redirect to Index
                Alert ("Student Not Found", AlertType.warning);
                return RedirectToAction(nameof(Index));
            }

            // create a ticket view model and set foreign key
            var tvm = new TicketViewModel { StudentId = id }; 
            // render blank form
            return View( tvm );
        }

        // POST /student/create
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult CreateTicket([Bind("StudentId,Issue")]TicketViewModel t)
        {         
            if (ModelState.IsValid)
            {                
                svc.CreateTicket(t.StudentId, t.Issue);

                return RedirectToAction(nameof(Details), new { Id = t.StudentId });
            }
            // redisplay the form for editing
            return View(t);
        }

    }
}
