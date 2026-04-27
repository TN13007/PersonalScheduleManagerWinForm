using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


class EventItem : ScheduleItem
{
    private string _location;
    private string _description;

    public override ScheduleItem showInformation()
    {
        throw new NotImplementedException();
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }
    public string Location
    {
        get { return _location; }
        set { _location = value; }
    }
}