using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }

        
        public required LeaveType LeaveType { get; set; }

        public required Employee Employee { get; set; }

        public int Period { get; set; }

    }
}
