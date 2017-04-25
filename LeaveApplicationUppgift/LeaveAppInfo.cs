
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveApplicationUppgift
{
    class LeaveAppInfo
    {
        #region properties
        public int LeaveId { get; set; }
        public string LeaveTitle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string status { get; set; }
        public int PercentageCompletion { get; set; }
        public string Ansvarig { get; set; }
        #endregion
    }
}
