using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


class FastMeetingItem : ScheduleItem
{
    private DateTime _reminderTime;

    public override ScheduleItem showInformation()
    {
        throw new NotImplementedException();
    }
    public DateTime ReminderTime
    {
        get { return _reminderTime; }
        set { _reminderTime = value; }
    }
}

