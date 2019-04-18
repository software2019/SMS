using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMS.Web.Models;
using SMS.Data.Models;
using SMS.Data.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace SMS.Web.Controllers
{

    [Authorize]
    public class TicketController : Controller
    {

        private readonly StudentService svc;
        public TicketController()
        {
            svc = new StudentService();
        }

        // GET /ticket/index
        public IActionResult Index()
        {
            var tickets = svc.GetActiveTickets();
            return View(tickets);
        }

        [Authorize(Roles="Admin,Manager")]
        //  POST /ticket/close/{id}
        [HttpPost]
        public IActionResult Close(int id)
        {
            // close ticket via service
            var t = svc.CloseTicket(id);
            if (t == null)
            {
                return NotFound();
            }

            // redirect to the index view
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
        // GET /ticket/create
        public IActionResult Create()
        {
            var students = svc.GetStudents();
            var tvm = new TicketViewModel {
                Students = new SelectList(students,"Id","Name") 
            };
            
            // render blank form
            return View( tvm );
        }

        [Authorize(Roles = "Admin")]
        // POST /ticket/create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("StudentId,Issue")]TicketViewModel tvm)
        {
            if (ModelState.IsValid)
            {
                svc.CreateTicket(tvm.StudentId, tvm.Issue);

                return RedirectToAction(nameof(Index));
            }
            // redisplay the form for editing
            return View(tvm);
        }
    }
}
