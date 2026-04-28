using System;
using System.Collections.Generic;
using System.Text;
using DTO;
namespace BUS
{
    internal class StatusService
    {
       public void MarkDone(ScheduleItem task)
        {
            if(task != null)
            {
                task.Status = TaskStatus.Done;
               
            }
        }
        public void CapNhatQuaHan(List<ScheduleItem> tasks)
        {
            DateTime now = DateTime.Now;

            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i].EndDate < now && tasks[i].Status != TaskStatus.Done)
                {
                    tasks[i].Status = TaskStatus.Overdue;
                }
            }
        }
    }
}
