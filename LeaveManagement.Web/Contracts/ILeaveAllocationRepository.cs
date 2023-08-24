using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;

namespace LeaveManagement.Web.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task CreateLeaveAllocationForAllEmployees(int leaveTypeId);

        Task<bool> LeaveAllocationExists(string employeeId, int leaveTypeId, int period);

        Task<EmployeeLeaveAllocationVM> GetEmployeeLeaveAllocation(string employeeId);
    }
}
