using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FastMeetingItem : ScheduleItem
    {
        private DateTime _reminderTime;

        public override void ShowInformation()
        {
            throw new NotImplementedException();
        }
        public DateTime ReminderTime
        {
            get { return _reminderTime; }
            set { _reminderTime = value; }
        }
    }
}

