using LeaveManagement.Web.Data;

namespace LeaveManagement.Web.Models
{
    public class EmployeeLeaveAllocationVM : EmployeeListVM
    {
        public List<LeaveAllocationVM> LeaveAllocations { get; set; }
    }
}
