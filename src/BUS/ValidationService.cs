using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    internal class ValidationService
    {
        public bool CheckTask(ScheduleItem task)
        {
            if (task == null)
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(task.Title))
            {
                return false;
            }
            if (task.StartDate >= task.EndDate)
            {
                return false;
            }
            if(task.EndDate < DateTime.Now.Date)
            {
                return false;
            }
            return true;
        }
        public bool CheckTime(DateTime start, DateTime end)
        {
            return start < end;
        }
        public bool CheckTitle(string title)
        {
            return !string.IsNullOrWhiteSpace(title);
        }
    }
}
