using AutoMapper;
using LeaveManagement.Web.Constents;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using LeaveManagement.Web.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly UserManager<Employee> userManager;
        private readonly IMapper mapper;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;

        public EmployeesController(UserManager<Employee> userManager, IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.leaveAllocationRepository = leaveAllocationRepository;
        }
        // GET: EmployeesController
        [ActionName("IndexAsync")]
        public async Task<IActionResult> IndexAsync()
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var model = mapper.Map<List<EmployeeListVM>>(employees);
            return View(model);
        }

        // GET: EmployeesController/Details/5
        public async Task<IActionResult> Details(string id, string name)
        {
            EmployeeLeaveAllocationVM employeeLeaveAllocations = await leaveAllocationRepository.GetEmployeeLeaveAllocation(id);
            return View(employeeLeaveAllocations);
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // GET: EmployeesController/EditLeaveAllocation/5
        [ActionName("EditLeaveAllocation")]
        public async Task<ActionResult> EditLeaveAllocationAsync(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LeaveAllocation? leaveAllocation = await leaveAllocationRepository.GetAsync(id);
            
            if (leaveAllocation == null)
            {
                return NotFound();
            }

            LeaveAllocationVM leaveAllocationVM = mapper.Map<LeaveAllocationVM>(leaveAllocation);

            return View(leaveAllocationVM);
        }


        [HttpPost, ActionName("EditLeaveAllocation"), ValidateAntiForgeryToken]
        public async Task<IActionResult> EditLeaveAllocation(int id, LeaveAllocationVM leaveAllocationVM)
        {
            if (id != leaveAllocationVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                LeaveAllocation leaveAllocation = mapper.Map<LeaveAllocation>(leaveAllocationVM);
                try
                {
                    await leaveAllocationRepository.UpdateAsync(leaveAllocation);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await leaveAllocationRepository.Exists(leaveAllocationVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(actionName: nameof(IndexAsync));
            }
            return View(leaveAllocationVM);
        }


        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        
    }
}
