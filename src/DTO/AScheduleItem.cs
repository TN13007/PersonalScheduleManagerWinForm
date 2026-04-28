using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

abstract class AScheduleItem
    {
    private string _title;
    private DateTime _startDate;
    private DateTime _endDate;
    private TaskStatus _status;
    private Priority _priority;

    abstract public AScheduleItem showInformation();
    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public DateTime StartDate
    {
        get { return _startDate; }
        set { _startDate = value; }
    }

    public DateTime EndDate
    {
        get { return _endDate; }
        set { _endDate = value; }
    }

    public TaskStatus Status
    {
        get { return _status; }
        set { _status = value; }
    }

    public Priority Priority
    {
        get { return _priority; }
        set { _priority = value; }
    }
}

