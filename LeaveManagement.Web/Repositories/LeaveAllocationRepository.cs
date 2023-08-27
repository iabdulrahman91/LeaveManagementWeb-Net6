using AutoMapper;
using LeaveManagement.Web.Constents;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;

        public LeaveAllocationRepository(ApplicationDbContext context, UserManager<Employee> userManager, ILeaveTypeRepository leaveTypeRepository, IMapper mapper) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
        }

        public async Task CreateLeaveAllocationForAllEmployees(int leaveTypeId)
        {
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var allocation = new List<LeaveAllocation>();

            foreach (var employee in employees)
            {
                    if (!await LeaveAllocationExists(employee.Id, leaveType.Id, period))
                    {
                        allocation.Add(new LeaveAllocation
                        {
                            Employee = employee,
                            LeaveType = leaveType,
                            Period = period,
                            NumberOfDays = leaveType?.DefaultDays ?? default,
                        });
                    }
            }
            await AddRangeAsync( allocation );

        }

        public async Task<EmployeeLeaveAllocationVM> GetEmployeeLeaveAllocation(string employeeId)
        {
            var employee = await userManager.FindByIdAsync(employeeId);
            var leaveAllocations = await context.LeaveAllocations
                                                    .Include(q => q.LeaveType)
                                                    .Where(q => q.Employee.Id == employee.Id)
                                                    .ToListAsync();

            var employeeLeaveAllocationVM = mapper.Map<EmployeeLeaveAllocationVM>(employee);
            employeeLeaveAllocationVM.LeaveAllocations = mapper.Map<List<LeaveAllocationVM>>(leaveAllocations);

            return employeeLeaveAllocationVM;
        }

        public async Task<bool> LeaveAllocationExists(string employeeId, int leaveTypeId, int period)
        {
            return await context.LeaveAllocations.AnyAsync(q => q.Employee.Id == employeeId
                                                          && q.LeaveType.Id == leaveTypeId
                                                          && q.Period == period);
        }
    }
}
