using System;
using System.Collections.Generic;
using System.Text;

namespace Expense_Tracker
{
    internal struct DateRange
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public DateRange(DateTime startTime ,DateTime endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public bool Contains(DateTime date)
        {
            return date.Date >= StartTime.Date && date.Date <= EndTime.Date;
        }
    }
}
